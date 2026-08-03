using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains the identification information of the account to which you can transfer funds related to repayments.
/// </summary>
public record BankAccountIdentification1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
