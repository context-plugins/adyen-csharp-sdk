using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentDetailsRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("method")]
    public string? Method { get; init; }
}
