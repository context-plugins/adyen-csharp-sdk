namespace Adyen.Requests.UsersMerchantLevel;

/// <summary>
/// The inputs of the GetMerchantsMerchantIdUsers operation.
/// </summary>
public sealed record GetMerchantsMerchantIdUsersRequest
{
    /// <summary>
    /// Unique identifier of the merchant.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The number of the page to fetch.
    /// </summary>
    public int? PageNumber { get; init; }

    /// <summary>
    /// The number of items to have on a page. Maximum value is <b>100</b>. The default is <b>10</b> items on a page.
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// The partial or complete username to select all users that match.
    /// </summary>
    public string? Username { get; init; }
}
