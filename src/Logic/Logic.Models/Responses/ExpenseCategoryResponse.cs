namespace devdeer.CoffeeCupApiAccess.Logic.Models.Responses
{
    using System.Text.Json.Serialization;
    using devdeer.CoffeeCupApiAccess.Logic.Models.DataModels;

    /// <summary>
    /// Represents the response of the CoffeeCup API when the expense categories endpoint is called.
    /// </summary>
    public class ExpenseCategoryResponseModel : BaseResponse
    {
        #region properties

        /// <summary>
        /// The list of expense category information.
        /// </summary>
        [JsonPropertyName("expenseCategories")]
        public ExpenseCategory[] ExpenseCategories { get; set; } = default!;

        #endregion
    }
}