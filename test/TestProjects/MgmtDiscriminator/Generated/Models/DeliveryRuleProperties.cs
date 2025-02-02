// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace MgmtDiscriminator.Models
{
    /// <summary> The properties. </summary>
    public partial class DeliveryRuleProperties
    {
        /// <summary> Initializes a new instance of DeliveryRuleProperties. </summary>
        public DeliveryRuleProperties()
        {
            Actions = new ChangeTrackingList<DeliveryRuleAction>();
        }

        /// <summary> Initializes a new instance of DeliveryRuleProperties. </summary>
        /// <param name="order"> The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a lesser order will be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not require any condition and actions listed in it will always be applied. </param>
        /// <param name="actions"> A list of actions that are executed when all the conditions of a rule are satisfied. </param>
        internal DeliveryRuleProperties(int? order, IList<DeliveryRuleAction> actions)
        {
            Order = order;
            Actions = actions;
        }

        /// <summary> The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a lesser order will be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not require any condition and actions listed in it will always be applied. </summary>
        public int? Order { get; set; }
        /// <summary> A list of actions that are executed when all the conditions of a rule are satisfied. </summary>
        public IList<DeliveryRuleAction> Actions { get; }
    }
}
