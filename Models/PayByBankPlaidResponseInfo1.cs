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

    /// <summary>
    /// Information regarding the transaction description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionResponseInfo1? TransactionDescription { get; init; }
}
