namespace Adyen.Requests.AccountMerchantLevel;

/// <summary>
/// The inputs of the PostMerchantsMerchantIdActivate operation.
/// </summary>
public sealed record PostMerchantsMerchantIdActivateRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }
}
