namespace Adyen.Requests.AccountMerchantLevel;

/// <summary>
/// The inputs of the GetMerchantsMerchantId operation.
/// </summary>
public sealed record GetMerchantsMerchantIdRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }
}
