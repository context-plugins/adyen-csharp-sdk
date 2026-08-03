using System.Text.Json.Serialization;

namespace Adyen.Models;

public record MandateAccountIdentification
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
