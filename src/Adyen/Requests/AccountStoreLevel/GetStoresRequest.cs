namespace Adyen.Requests.AccountStoreLevel;

/// <summary>
/// The inputs of the GetStores operation.
/// </summary>
public sealed record GetStoresRequest
{
    /// <summary>
    /// The number of the page to fetch.
    /// </summary>
    public int? PageNumber { get; init; }

    /// <summary>
    /// The number of items to have on a page, maximum 100. The default is 10 items on a page.
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// The reference of the store.
    /// </summary>
    public string? Reference { get; init; }

    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public string? MerchantId { get; init; }
}
