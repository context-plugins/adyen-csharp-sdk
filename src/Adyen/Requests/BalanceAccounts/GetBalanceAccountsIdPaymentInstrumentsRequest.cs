namespace Adyen.Requests.BalanceAccounts;

/// <summary>
/// The inputs of the GetBalanceAccountsIdPaymentInstruments operation.
/// </summary>
public sealed record GetBalanceAccountsIdPaymentInstrumentsRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// The number of items that you want to skip.
    /// </summary>
    public int? Offset { get; init; }

    /// <summary>
    /// The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The status of the payment instruments that you want to get. By default, the response includes payment instruments with any status.
    /// </summary>
    public string? Status { get; init; }
}
