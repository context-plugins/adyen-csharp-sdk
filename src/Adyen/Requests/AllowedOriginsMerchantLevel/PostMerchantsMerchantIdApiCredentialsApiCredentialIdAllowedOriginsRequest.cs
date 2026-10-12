using Adyen.Models;

namespace Adyen.Requests.AllowedOriginsMerchantLevel;

/// <summary>
/// The inputs of the PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOrigins operation.
/// </summary>
public sealed record PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// Unique identifier of the API credential.
    /// </summary>
    public required string ApiCredentialId { get; init; }

    public AllowedOrigin? Body { get; init; }
}
