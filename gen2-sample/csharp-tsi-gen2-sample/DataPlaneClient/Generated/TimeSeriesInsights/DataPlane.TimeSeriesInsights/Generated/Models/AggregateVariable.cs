// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.TimeSeriesInsights.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Aggregate variable represents any aggregation calculation. Aggregate
    /// Variables does not support interpolation.
    /// </summary>
    [Newtonsoft.Json.JsonObject("aggregate")]
    public partial class AggregateVariable : Variable
    {
        /// <summary>
        /// Initializes a new instance of the AggregateVariable class.
        /// </summary>
        public AggregateVariable()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AggregateVariable class.
        /// </summary>
        /// <param name="aggregation">Aggregation time series expression when
        /// kind is "aggregate" is used to represent the aggregation that needs
        /// to be performed directly using event properties like
        /// "$event.Temperature". For example, aggregation for calculating
        /// range of temperature changes can be written as:
        /// "max($event.Temperature)-min($event.Temperature)".</param>
        /// <param name="filter">Filter over the events that restricts the
        /// number of events being considered for computation. Example:
        /// "$event.Status.String='Good'". Optional.</param>
        public AggregateVariable(Tsx aggregation, Tsx filter = default(Tsx))
            : base(filter)
        {
            Aggregation = aggregation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets aggregation time series expression when kind is
        /// "aggregate" is used to represent the aggregation that needs to be
        /// performed directly using event properties like
        /// "$event.Temperature". For example, aggregation for calculating
        /// range of temperature changes can be written as:
        /// "max($event.Temperature)-min($event.Temperature)".
        /// </summary>
        [JsonProperty(PropertyName = "aggregation")]
        public Tsx Aggregation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Aggregation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Aggregation");
            }
            if (Aggregation != null)
            {
                Aggregation.Validate();
            }
        }
    }
}
