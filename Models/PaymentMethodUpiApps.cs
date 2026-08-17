using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentMethodUpiApps
{
    /// <summary>
    /// The app identifier information containing iOS scheme and Android package ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("appIdentifierInfo")]
    public AppIdentifierInfo1? AppIdentifierInfo { get; init; }

    /// <summary>
    /// The unique identifier of this app, to submit in requests to /payments.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// A localized name of the app.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}
