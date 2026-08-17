using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Links4
{
    /// <summary>
    /// The URL to where the user must be redirected after a payment has been canceled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancel")]
    public Href6? Cancel { get; init; }

    /// <summary>
    /// The URL to where the user must be redirected after a successful payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("success")]
    public Href1? Success { get; init; }
}
