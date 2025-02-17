// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.JobRouter
{
    /// <summary> Contains the weight percentage and label selectors to be applied if selected for weighted distributions. </summary>
    public partial class QueueWeightedAllocation
    {
        /// <summary> Initializes a new instance of QueueWeightedAllocation. </summary>
        /// <param name="weight"> The percentage of this weight, expressed as a fraction of 1. </param>
        /// <param name="labelSelectors"> A collection of label selectors that will be applied if this allocation is selected. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="labelSelectors"/> is null. </exception>
        public QueueWeightedAllocation(double weight, IEnumerable<QueueSelector> labelSelectors)
        {
            if (labelSelectors == null)
            {
                throw new ArgumentNullException(nameof(labelSelectors));
            }

            Weight = weight;
            LabelSelectors = labelSelectors.ToList();
        }

        /// <summary> Initializes a new instance of QueueWeightedAllocation. </summary>
        /// <param name="weight"> The percentage of this weight, expressed as a fraction of 1. </param>
        /// <param name="labelSelectors"> A collection of label selectors that will be applied if this allocation is selected. </param>
        internal QueueWeightedAllocation(double weight, IList<QueueSelector> labelSelectors)
        {
            Weight = weight;
            LabelSelectors = labelSelectors;
        }

        /// <summary> The percentage of this weight, expressed as a fraction of 1. </summary>
        public double Weight { get; set; }
        /// <summary> A collection of label selectors that will be applied if this allocation is selected. </summary>
        public IList<QueueSelector> LabelSelectors { get; }
    }
}
