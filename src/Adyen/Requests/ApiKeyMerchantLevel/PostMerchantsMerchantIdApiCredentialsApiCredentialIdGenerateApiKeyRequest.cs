namespace Adyen.Requests.ApiKeyMerchantLevel;

/// <summary>
/// The inputs of the PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKey operation.
/// </summary>
public sealed record PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKeyRequest
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
