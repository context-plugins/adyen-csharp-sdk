using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains the business account details.
/// </summary>
public record BankAccountModel1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("formFactor")]
    public object? FormFactor { get; init; }
}
