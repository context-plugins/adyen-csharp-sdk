using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CertificateLoadingRequest
{
    /// <summary>
    /// The unique identifier of your merchant account.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// The setup token provided by the SDK in a Mobile solution for in-person payments.
    /// - When using the Android SDK, obtain the token through the <c>MerchantAuthenticationService.authenticate(setupToken)</c> callback of <c>AuthenticationService</c>.
    /// - When using the iOS SDK, obtain the token through the <c>PaymentServiceDelegate.register(with:)</c> callback of <c>PaymentServiceDelegate</c>.
    /// </summary>
    [JsonPropertyName("setupToken")]
    public required string SetupToken { get; init; }

    /// <summary>
    /// The reference of the store that you want to process transactions for. Do not include this parameter if your account structure uses merchant accounts as stores, or if you are a registered payment facilitator.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("store")]
    public string? Store { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchantData")]
    public SubMerchantData2? SubMerchantData { get; init; }
}
