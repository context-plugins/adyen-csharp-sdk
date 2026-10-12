using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CheckoutForwardResponseFromUrl
{
    /// <summary>
    /// The body of the response Adyen received from the third party, in string format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("body")]
    public string? Body { get; init; }

    /// <summary>
    /// The HTTP headers of the response Adyen received from the third party.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("headers")]
    public IReadOnlyDictionary<string, string>? Headers { get; init; }

    /// <summary>
    /// The HTTP status of the response Adyen received from the third party.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public int? Status { get; init; }
}
