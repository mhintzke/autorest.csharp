// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace body_complex.Models.V20160229
{
    public partial class Sawshark : Shark
    {
        public Sawshark()
        {
            Fishtype = "sawshark";
        }
        public byte[]? Picture { get; set; }
    }
}
