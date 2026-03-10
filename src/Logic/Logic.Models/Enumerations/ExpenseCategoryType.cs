using System.Text.Json.Serialization;
using devdeer.CoffeeCupApiAccess.Logic.Models.JsonConverters;

namespace devdeer.CoffeeCupApiAccess.Logic.Models.Enumerations
{

    /// <summary>
    /// Defines possible values for expense categories.
    /// </summary>
    [JsonConverter(typeof(ExpenseCategoryTypeConverter))]
    public enum ExpenseCategoryType
    {
        Undefined = 0,
        Amount = 1,
        Percent = 2
    }
}