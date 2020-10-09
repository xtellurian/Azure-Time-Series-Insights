using System;
using Microsoft.Azure.TimeSeriesInsights.Models;
using Newtonsoft.Json.Linq;
using NJsonSchema.Converters;

namespace AmphoraData.TSI
{
    public class VariableJsonInheritanceConverter : JsonInheritanceConverter
    {
        public VariableJsonInheritanceConverter(string name) : base(name)
        {
        }

        public override string GetDiscriminatorValue(Type type)
        {
            if(type == typeof(NumericVariable))
            {
                return "numeric";
            }
            else if(type == typeof(AggregateVariable))
            {
                return "aggregate";
            }
            else if(type == typeof(CategoricalVariable))
            {
                return "categorical";
            }
            else
            {
                return type.Name;
            }
        }

        protected override Type GetDiscriminatorType(JObject jObject, Type objectType, string discriminatorValue)
        {
            if(discriminatorValue == "numeric") return typeof(NumericVariable);
            if(discriminatorValue == "aggregate") return typeof(AggregateVariable);
            if(discriminatorValue == "categorical") return typeof(CategoricalVariable);
            else return base.GetDiscriminatorType(jObject, objectType, discriminatorValue + "Dto");
        }
    }
}