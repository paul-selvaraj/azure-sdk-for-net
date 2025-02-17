// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> The RP custom operation error info. </summary>
    public partial class MoverAffectedMoveResourceInfo
    {
        /// <summary> Initializes a new instance of MoverAffectedMoveResourceInfo. </summary>
        internal MoverAffectedMoveResourceInfo()
        {
            MoveResources = new ChangeTrackingList<MoverAffectedMoveResourceInfo>();
        }

        /// <summary> Initializes a new instance of MoverAffectedMoveResourceInfo. </summary>
        /// <param name="id"> The affected move resource id. </param>
        /// <param name="sourceId"> The affected move resource source id. </param>
        /// <param name="moveResources"> The affected move resources. </param>
        internal MoverAffectedMoveResourceInfo(ResourceIdentifier id, ResourceIdentifier sourceId, IReadOnlyList<MoverAffectedMoveResourceInfo> moveResources)
        {
            Id = id;
            SourceId = sourceId;
            MoveResources = moveResources;
        }

        /// <summary> The affected move resource id. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> The affected move resource source id. </summary>
        public ResourceIdentifier SourceId { get; }
        /// <summary> The affected move resources. </summary>
        public IReadOnlyList<MoverAffectedMoveResourceInfo> MoveResources { get; }
    }
}
