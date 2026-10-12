using Adyen.Models;

namespace Adyen.Requests.ApiCredentialsMerchantLevel;

/// <summary>
/// The inputs of the PostMerchantsMerchantIdApiCredentials operation.
/// </summary>
public sealed record PostMerchantsMerchantIdApiCredentialsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    public CreateMerchantApiCredentialRequest? Body { get; init; }
}
