using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentDetailsRequest1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("method")]
    public string? Method { get; init; }
}
