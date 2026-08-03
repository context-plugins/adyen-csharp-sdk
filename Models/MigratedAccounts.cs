using System.Text.Json.Serialization;

namespace Adyen.Models;

public record MigratedAccounts
{
    /// <summary>
    /// The unique identifier of the account of the migrated account holder in the classic integration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountCode")]
    public string? AccountCode { get; init; }

    /// <summary>
    /// The unique identifier of the account of the migrated account holder in the balance platform.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balanceAccountId")]
    public string? BalanceAccountId { get; init; }
}
