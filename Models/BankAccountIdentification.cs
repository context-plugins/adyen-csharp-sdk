using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BankAccountIdentification
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
