using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentMethodUpiapps
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("appIdentifierInfo")]
    public AppIdentifierInfo? AppIdentifierInfo { get; init; }

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
