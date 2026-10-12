namespace Adyen.Requests.AccountHolders;

/// <summary>
/// The inputs of the GetAccountHoldersIdTaxFormSummary operation.
/// </summary>
public sealed record GetAccountHoldersIdTaxFormSummaryRequest
{
    /// <summary>
    /// The unique identifier of the account holder.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// The type of tax form you want a summary for. Accepted values are <b>US1099k</b> and <b>US1099nec</b>.
    /// </summary>
    public required string FormType { get; init; }
}
