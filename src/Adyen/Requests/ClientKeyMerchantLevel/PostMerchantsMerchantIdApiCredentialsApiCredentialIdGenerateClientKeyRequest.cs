namespace Adyen.Requests.ClientKeyMerchantLevel;

/// <summary>
/// The inputs of the PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKey operation.
/// </summary>
public sealed record PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKeyRequest
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
