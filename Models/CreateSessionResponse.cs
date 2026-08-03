using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CreateSessionResponse
{
    /// <summary>
    /// The unique identifier of the session.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The unique identifier of the SDK installation. If you create the <see href="https://docs.adyen.com/point-of-sale/design-your-integration/terminal-api/">Terminal API</see> transaction request on your backend, use this as the <c>POIID</c> in the <c>MessageHeader</c> of the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installationId")]
    public string? InstallationId { get; init; }

    /// <summary>
    /// The unique identifier of your merchant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantAccount")]
    public string? MerchantAccount { get; init; }

    /// <summary>
    /// The data that the SDK uses to authenticate responses from the Adyen payments platform. Pass this value to your POS app.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkData")]
    public string? SdkData { get; init; }

    /// <summary>
    /// The unique identifier of the store that you want to process transactions for.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("store")]
    public string? Store { get; init; }
}
