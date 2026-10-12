namespace Adyen.Requests.AccountMerchantLevel;

/// <summary>
/// The inputs of the GetMerchants operation.
/// </summary>
public sealed record GetMerchantsRequest
{
    /// <summary>
    /// The number of the page to fetch.
    /// </summary>
    public int? PageNumber { get; init; }

    /// <summary>
    /// The number of items to have on a page, maximum 100. The default is 10 items on a page.
    /// </summary>
    public int? PageSize { get; init; }
}
