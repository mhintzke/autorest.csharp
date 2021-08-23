// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace MgmtOperations
{
    /// <summary> A class representing the AvailabilitySet data model. </summary>
    public partial class AvailabilitySetData : TrackedResource
    {
        /// <summary> Initializes a new instance of AvailabilitySetData. </summary>
        /// <param name="location"> The location. </param>
        public AvailabilitySetData(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of AvailabilitySetData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="bar"> specifies the bar. </param>
        internal AvailabilitySetData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, string bar) : base(id, name, type, tags, location)
        {
            Bar = bar;
        }

        /// <summary> specifies the bar. </summary>
        public string Bar { get; set; }
    }
}
