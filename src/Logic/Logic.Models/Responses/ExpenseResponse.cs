namespace devdeer.CoffeeCupApiAccess.Logic.Models.Responses
{
    using System.Text.Json.Serialization;
    using devdeer.CoffeeCupApiAccess.Logic.Models.DataModels;

    /// <summary>
    /// Represents the response of the CoffeeCup API when the expense endpoint is called.
    /// </summary>
    public class ExpenseResponseModel : BaseResponse
    {
        #region properties

        /// <summary>
        /// The list of expense information.
        /// </summary>
        [JsonPropertyName("expenses")]
        public Expense[] Expenses { get; set; } = default!;

        #endregion
    }
}