using System.Text.Json.Serialization;
using devdeer.CoffeeCupApiAccess.Logic.Models.JsonConverters;

namespace devdeer.CoffeeCupApiAccess.Logic.Models.Enumerations
{

    /// <summary>
    /// Defines possible values for billing mappings.
    /// </summary>
    [JsonConverter(typeof(BillingMappingConverter))]
    public enum BillingMapping
    {
        Undefined = 0,
        Service = 1,
        Product = 2
    }
}