// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace MgmtParent
{
    /// <summary> A class representing the DedicatedHostGroup data model. </summary>
    public partial class DedicatedHostGroupData : TrackedResource
    {
        /// <summary> Initializes a new instance of DedicatedHostGroupData. </summary>
        /// <param name="location"> The location. </param>
        public DedicatedHostGroupData(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of DedicatedHostGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="foo"> specifies the foo. </param>
        internal DedicatedHostGroupData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, string foo) : base(id, name, type, tags, location)
        {
            Foo = foo;
        }

        /// <summary> specifies the foo. </summary>
        public string Foo { get; set; }
    }
}
