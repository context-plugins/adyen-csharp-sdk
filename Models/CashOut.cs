using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record CashOut
{
    /// <summary>
    /// Contains the amount of the cashout, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }

    /// <summary>
    /// Contains information about the counterparty of the cashout transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("counterparty")]
    public CashOutInfoCounterparty1? Counterparty { get; init; }

    /// <summary>
    /// Allowed and returned only when you provide the <c>counterparty.transferInstrumentId</c> field.
    /// <para>
    /// Your description of the cashout transfer. This description is used by most banks as the transfer description. We recommend sending a maximum of 140 characters, otherwise the description may be truncated.
    /// </para>
    /// <para>
    /// If you do not provide a description, Adyen generates a description automatically. This generated description is not returned in the response.
    /// </para>
    /// <para>
    /// Supported characters: <b>[a-z] [A-Z] [0-9] / - ? : ( ) . , ' + Space</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Contains the currency and value of the cashout fee, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fee")]
    public Fee21? Fee { get; init; }

    /// <summary>
    /// The unique identifier of the cashout reference.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The unique identifier of the balance account that initiates the cashout request.
    /// </summary>
    [JsonPropertyName("instructingBalanceAccountId")]
    public required string InstructingBalanceAccountId { get; init; }

    /// <summary>
    /// Allowed and returned only when you provide the <c>counterparty.transferInstrumentId</c> field.
    /// <para>
    /// The reference that is sent to the recipient of a cashout transfer. This reference is also sent in all webhooks related to the cashout transfer, so you can use it to track the status of the transfer.
    /// </para>
    /// <para>
    /// If you do not provide a reference for the beneficiary, Adyen generates one automatically. This generated reference for the beneficiary is not returned in the response.
    /// </para>
    /// <para>
    /// Supported characters: <b>a-z</b>, <b>A-Z</b>, <b>0-9</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenceForBeneficiary")]
    public string? ReferenceForBeneficiary { get; init; }

    /// <summary>
    /// <b>Use <c>counterparty.transferInstrumentId</c> instead.</b>
    /// <para>
    /// The unique identifier of the counterparty transfer instrument.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transferInstrumentId")]
    public string? TransferInstrumentId { get; init; }

    /// <summary>
    /// The list of transfers related to cashout.
    /// </summary>
    [JsonPropertyName("transfers")]
    public required IReadOnlyList<CashOutTransfer> Transfers { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
