using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>paybybank_plaid</b>.
/// </summary>
public record PayByBankPlaidInfo1
{
    /// <summary>
    /// Merchant logo (max. size 150kB). Format: Base64-encoded string.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logo")]
    public string? Logo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
