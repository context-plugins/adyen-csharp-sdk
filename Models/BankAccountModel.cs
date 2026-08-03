using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BankAccountModel
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("formFactor")]
    public object? FormFactor { get; init; }
}
