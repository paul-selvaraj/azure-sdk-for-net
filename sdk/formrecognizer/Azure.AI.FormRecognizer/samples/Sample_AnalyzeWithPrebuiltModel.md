# Analyze a document with a prebuilt model

This sample demonstrates how to analyze data from certain types of common documents with prebuilt models, using an invoice as an example. For more information about prebuilt models and which types of documents are supported, see the [service documentation][formreco_models].

To get started you'll need a Cognitive Services resource or a Form Recognizer resource.  See [README][README] for prerequisites and instructions.

## Creating a `DocumentAnalysisClient`

To create a new `DocumentAnalysisClient` you need the endpoint and credentials from your resource. In the sample below you'll use a Form Recognizer API key credential by creating an `AzureKeyCredential` object, that if needed, will allow you to update the API key without creating a new client.

You can set `endpoint` and `apiKey` based on an environment variable, a configuration setting, or any way that works for your application.

```C# Snippet:CreateDocumentAnalysisClient
string endpoint = "<endpoint>";
string apiKey = "<apiKey>";
var credential = new AzureKeyCredential(apiKey);
var client = new DocumentAnalysisClient(new Uri(endpoint), credential);
```

## Use a prebuilt model to analyze a document from a URI

To analyze a given file at a URI, use the `AnalyzeDocumentFromUri` method. The returned value is an `AnalyzeResult` object containing data about the submitted document. Since we're analyzing an invoice, we'll pass the model ID `prebuilt-invoice` to the method.

For simplicity, we are not showing all the fields that the service returns. To see the list of all the supported fields returned by service and its corresponding types, consult the [invoice model documentation][invoice_fields].

```C# Snippet:FormRecognizerAnalyzeWithPrebuiltModelFromUriAsync
Uri fileUri = new Uri("<fileUri>");

AnalyzeDocumentOperation operation = await client.AnalyzeDocumentFromUriAsync(WaitUntil.Completed, "prebuilt-invoice", fileUri);
AnalyzeResult result = operation.Value;

// To see the list of all the supported fields returned by service and its corresponding types for the
// prebuilt-invoice model, consult:
// https://aka.ms/azsdk/formrecognizer/invoicefieldschema

for (int i = 0; i < result.Documents.Count; i++)
{
    Console.WriteLine($"Document {i}:");

    AnalyzedDocument document = result.Documents[i];

    if (document.Fields.TryGetValue("VendorName", out DocumentField vendorNameField))
    {
        if (vendorNameField.ValueType == DocumentFieldType.String)
        {
            string vendorName = vendorNameField.AsString();
            Console.WriteLine($"Vendor Name: '{vendorName}', with confidence {vendorNameField.Confidence}");
        }
    }

    if (document.Fields.TryGetValue("CustomerName", out DocumentField customerNameField))
    {
        if (customerNameField.ValueType == DocumentFieldType.String)
        {
            string customerName = customerNameField.AsString();
            Console.WriteLine($"Customer Name: '{customerName}', with confidence {customerNameField.Confidence}");
        }
    }

    if (document.Fields.TryGetValue("Items", out DocumentField itemsField))
    {
        if (itemsField.ValueType == DocumentFieldType.List)
        {
            foreach (DocumentField itemField in itemsField.AsList())
            {
                Console.WriteLine("Item:");

                if (itemField.ValueType == DocumentFieldType.Dictionary)
                {
                    IReadOnlyDictionary<string, DocumentField> itemFields = itemField.AsDictionary();

                    if (itemFields.TryGetValue("Description", out DocumentField itemDescriptionField))
                    {
                        if (itemDescriptionField.ValueType == DocumentFieldType.String)
                        {
                            string itemDescription = itemDescriptionField.AsString();

                            Console.WriteLine($"  Description: '{itemDescription}', with confidence {itemDescriptionField.Confidence}");
                        }
                    }

                    if (itemFields.TryGetValue("Amount", out DocumentField itemAmountField))
                    {
                        if (itemAmountField.ValueType == DocumentFieldType.Currency)
                        {
                            CurrencyValue itemAmount = itemAmountField.AsCurrency();

                            Console.WriteLine($"  Amount: '{itemAmount.Symbol}{itemAmount.Amount}', with confidence {itemAmountField.Confidence}");
                        }
                    }
                }
            }
        }
    }

    if (document.Fields.TryGetValue("SubTotal", out DocumentField subTotalField))
    {
        if (subTotalField.ValueType == DocumentFieldType.Currency)
        {
            CurrencyValue subTotal = subTotalField.AsCurrency();
            Console.WriteLine($"Sub Total: '{subTotal.Symbol}{subTotal.Amount}', with confidence {subTotalField.Confidence}");
        }
    }

    if (document.Fields.TryGetValue("TotalTax", out DocumentField totalTaxField))
    {
        if (totalTaxField.ValueType == DocumentFieldType.Currency)
        {
            CurrencyValue totalTax = totalTaxField.AsCurrency();
            Console.WriteLine($"Total Tax: '{totalTax.Symbol}{totalTax.Amount}', with confidence {totalTaxField.Confidence}");
        }
    }

    if (document.Fields.TryGetValue("InvoiceTotal", out DocumentField invoiceTotalField))
    {
        if (invoiceTotalField.ValueType == DocumentFieldType.Currency)
        {
            CurrencyValue invoiceTotal = invoiceTotalField.AsCurrency();
            Console.WriteLine($"Invoice Total: '{invoiceTotal.Symbol}{invoiceTotal.Amount}', with confidence {invoiceTotalField.Confidence}");
        }
    }
}
```

## Use a prebuilt model to analyze a document from a file stream

To analyze a given file at a file stream, use the `AnalyzeDocument` method. The returned value is an `AnalyzeResult` object containing data about the submitted document. Since we're analyzing an invoice, we'll pass the model ID `prebuilt-invoice` to the method.

For simplicity, we are not showing all the fields that the service returns. To see the list of all the supported fields returned by service and its corresponding types, consult the [invoice model documentation][invoice_fields].

```C# Snippet:FormRecognizerAnalyzeWithPrebuiltModelFromFileAsync
string filePath = "<filePath>";

using var stream = new FileStream(filePath, FileMode.Open);

AnalyzeDocumentOperation operation = await client.AnalyzeDocumentAsync(WaitUntil.Completed, "prebuilt-invoice", stream);
AnalyzeResult result = operation.Value;

// To see the list of all the supported fields returned by service and its corresponding types for the
// prebuilt-invoice model, consult:
// https://aka.ms/azsdk/formrecognizer/invoicefieldschema

for (int i = 0; i < result.Documents.Count; i++)
{
    Console.WriteLine($"Document {i}:");

    AnalyzedDocument document = result.Documents[i];

    if (document.Fields.TryGetValue("VendorName", out DocumentField vendorNameField))
    {
        if (vendorNameField.ValueType == DocumentFieldType.String)
        {
            string vendorName = vendorNameField.AsString();
            Console.WriteLine($"Vendor Name: '{vendorName}', with confidence {vendorNameField.Confidence}");
        }
    }

    if (document.Fields.TryGetValue("CustomerName", out DocumentField customerNameField))
    {
        if (customerNameField.ValueType == DocumentFieldType.String)
        {
            string customerName = customerNameField.AsString();
            Console.WriteLine($"Customer Name: '{customerName}', with confidence {customerNameField.Confidence}");
        }
    }

    if (document.Fields.TryGetValue("Items", out DocumentField itemsField))
    {
        if (itemsField.ValueType == DocumentFieldType.List)
        {
            foreach (DocumentField itemField in itemsField.AsList())
            {
                Console.WriteLine("Item:");

                if (itemField.ValueType == DocumentFieldType.Dictionary)
                {
                    IReadOnlyDictionary<string, DocumentField> itemFields = itemField.AsDictionary();

                    if (itemFields.TryGetValue("Description", out DocumentField itemDescriptionField))
                    {
                        if (itemDescriptionField.ValueType == DocumentFieldType.String)
                        {
                            string itemDescription = itemDescriptionField.AsString();

                            Console.WriteLine($"  Description: '{itemDescription}', with confidence {itemDescriptionField.Confidence}");
                        }
                    }

                    if (itemFields.TryGetValue("Amount", out DocumentField itemAmountField))
                    {
                        if (itemAmountField.ValueType == DocumentFieldType.Currency)
                        {
                            CurrencyValue itemAmount = itemAmountField.AsCurrency();

                            Console.WriteLine($"  Amount: '{itemAmount.Symbol}{itemAmount.Amount}', with confidence {itemAmountField.Confidence}");
                        }
                    }
                }
            }
        }
    }

    if (document.Fields.TryGetValue("SubTotal", out DocumentField subTotalField))
    {
        if (subTotalField.ValueType == DocumentFieldType.Currency)
        {
            CurrencyValue subTotal = subTotalField.AsCurrency();
            Console.WriteLine($"Sub Total: '{subTotal.Symbol}{subTotal.Amount}', with confidence {subTotalField.Confidence}");
        }
    }

    if (document.Fields.TryGetValue("TotalTax", out DocumentField totalTaxField))
    {
        if (totalTaxField.ValueType == DocumentFieldType.Currency)
        {
            CurrencyValue totalTax = totalTaxField.AsCurrency();
            Console.WriteLine($"Total Tax: '{totalTax.Symbol}{totalTax.Amount}', with confidence {totalTaxField.Confidence}");
        }
    }

    if (document.Fields.TryGetValue("InvoiceTotal", out DocumentField invoiceTotalField))
    {
        if (invoiceTotalField.ValueType == DocumentFieldType.Currency)
        {
            CurrencyValue invoiceTotal = invoiceTotalField.AsCurrency();
            Console.WriteLine($"Invoice Total: '{invoiceTotal.Symbol}{invoiceTotal.Amount}', with confidence {invoiceTotalField.Confidence}");
        }
    }
}
```

To see the full example source files, see:

* [Analyze with prebuilt model from URI](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/formrecognizer/Azure.AI.FormRecognizer/tests/samples/Sample_AnalyzeWithPrebuiltModelFromUriAsync.cs)
* [Analyze with prebuilt model from file](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/formrecognizer/Azure.AI.FormRecognizer/tests/samples/Sample_AnalyzeWithPrebuiltModelFromFileAsync.cs)

[invoice_fields]: https://aka.ms/azsdk/formrecognizer/invoicefieldschema
[formreco_models]: https://aka.ms/azsdk/formrecognizer/models

[README]: https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/formrecognizer/Azure.AI.FormRecognizer#getting-started
