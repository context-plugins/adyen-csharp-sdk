using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains the account number to which the payment funds are sent.
/// </summary>
public record AccountIdentification1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
