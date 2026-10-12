using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The other party involved in the funds transfer. A bank account, a balance account, a card, or a transfer instrument is required.
/// </summary>
public record CounterpartyInfoV31
{
    /// <summary>
    /// The unique identifier of the counterparty <see href="https://docs.adyen.com/api-explorer/balanceplatform/latest/post/balanceAccounts#responses-200-id">balance account</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balanceAccountId")]
    public string? BalanceAccountId { get; init; }

    /// <summary>
    /// Contains information about the counterparty bank account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccount")]
    public BankAccountV31? BankAccount { get; init; }

    /// <summary>
    /// Contains information about the counterparty card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public Card12? Card { get; init; }

    /// <summary>
    /// The unique identifier of the counterparty <see href="https://docs.adyen.com/api-explorer/legalentity/latest/post/transferInstruments#responses-200-id">transfer instrument</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transferInstrumentId")]
    public string? TransferInstrumentId { get; init; }
}
