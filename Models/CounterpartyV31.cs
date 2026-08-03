using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The other party in the transfer.
/// </summary>
public record CounterpartyV31
{
    /// <summary>
    /// The unique identifier of the counterparty <see href="https://docs.adyen.com/api-explorer/balanceplatform/latest/post/balanceAccounts#responses-200-id">balance account</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balanceAccountId")]
    public string? BalanceAccountId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccount")]
    public BankAccountV3? BankAccount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public Card4? Card { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant")]
    public MerchantData? Merchant { get; init; }

    /// <summary>
    /// The unique identifier of the counterparty <see href="https://docs.adyen.com/api-explorer/legalentity/latest/post/transferInstruments#responses-200-id">transfer instrument</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transferInstrumentId")]
    public string? TransferInstrumentId { get; init; }
}
