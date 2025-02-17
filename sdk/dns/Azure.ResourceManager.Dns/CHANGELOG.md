# Release History

## 1.0.0-beta.2 (Unreleased)

### Features Added

### Breaking Changes

### Bugs Fixed

### Other Changes

## 1.0.0-beta.1 (2022-07-12)

### Breaking Changes

New design of track 2 initial commit.

### Package Name

The package name has been changed from `Microsoft.Azure.Management.Dns` to `Azure.ResourceManager.Dns`

### Features Added

- Added ArmClient extension methods to support [start from the middle scenario](https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/resourcemanager/Azure.ResourceManager#managing-existing-resources-by-id).

### General New Features

* Support MSAL.NET, Azure.Identity is out of box for supporting MSAL.NET
* Support [OpenTelemetry](https://opentelemetry.io/) for distributed tracing
* HTTP pipeline with custom policies
* Better error-handling
* Support uniform telemetry across all languages
> NOTE: For more information about unified authentication, please refer to [Azure Identity documentation for .NET](https://docs.microsoft.com/dotnet/api/overview/azure/identity-readme?view=azure-dotnet)

### Management Client Changes

Before upgrade:

``` c#
using Microsoft.Rest;
using Microsoft.Azure.Management.Dns;
using Microsoft.Azure.Management.Dns.Models;
```

``` c#
var tokenCredentials = new TokenCredentials("YOUR ACCESS TOKEN");
DnsManagementClient dnsManagementClient = new DnsManagementClient(credentials);
var dnsZone = await dnsManagementClient.Zones.CreateOrUpdateAsync(resourceGroupName, dnsZoneName, zone);
```

After upgrade:

```C# Snippet:Manage_DnsZones_Namespaces
using System;
using System.Threading.Tasks;
using Azure.Identity;
using Azure.ResourceManager.Dns;
using Azure.ResourceManager.Resources;
using NUnit.Framework;
```

```C# Snippet:Managing_DnsZones_CreateADnsZones
ArmClient armClient = new ArmClient(new DefaultAzureCredential());
SubscriptionResource subscription = await armClient.GetDefaultSubscriptionAsync();
// first we need to get the resource group
string rgName = "myRgName";
ResourceGroupResource resourceGroup = await subscription.GetResourceGroups().GetAsync(rgName);
// Now we get the DnsZone collection from the resource group
DnsZoneCollection dnsZoneCollection = resourceGroup.GetDnsZones();
// Use the same location as the resource group
string dnsZoneName = "sample.com";
DnsZoneData data = new DnsZoneData("Global")
{
};
ArmOperation<DnsZoneResource> lro = await dnsZoneCollection.CreateOrUpdateAsync(WaitUntil.Completed, dnsZoneName, data);
DnsZoneResource dnsZone = lro.Value;
```
