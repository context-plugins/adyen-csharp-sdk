using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>paybybank_plaid</b> details
/// </summary>
public record PayByBankPlaidResponseInfo1
{
    /// <summary>
    /// Merchant logo
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logo")]
    public string? Logo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
