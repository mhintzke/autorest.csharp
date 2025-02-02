// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtExpandResourceTypes.Models
{
    /// <summary> An AAAA record. </summary>
    public partial class AaaaRecord
    {
        /// <summary> Initializes a new instance of AaaaRecord. </summary>
        public AaaaRecord()
        {
        }

        /// <summary> Initializes a new instance of AaaaRecord. </summary>
        /// <param name="ipv6Address"> The IPv6 address of this AAAA record. </param>
        internal AaaaRecord(string ipv6Address)
        {
            Ipv6Address = ipv6Address;
        }

        /// <summary> The IPv6 address of this AAAA record. </summary>
        public string Ipv6Address { get; set; }
    }
}
