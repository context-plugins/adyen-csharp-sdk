namespace Adyen.Requests.AllowedOriginsMerchantLevel;

/// <summary>
/// The inputs of the GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginId operation.
/// </summary>
public sealed record GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// Unique identifier of the API credential.
    /// </summary>
    public required string ApiCredentialId { get; init; }

    /// <summary>
    /// Unique identifier of the allowed origin.
    /// </summary>
    public required string OriginId { get; init; }
}
