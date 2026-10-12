namespace Adyen.Requests.ApiCredentialsMerchantLevel;

/// <summary>
/// The inputs of the GetMerchantsMerchantIdApiCredentialsApiCredentialId operation.
/// </summary>
public sealed record GetMerchantsMerchantIdApiCredentialsApiCredentialIdRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// Unique identifier of the API credential.
    /// </summary>
    public required string ApiCredentialId { get; init; }
}
