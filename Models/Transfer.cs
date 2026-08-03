using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.AnyOf;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Transfer
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolder")]
    public ResourceReference? AccountHolder { get; init; }

    [JsonPropertyName("amount")]
    public required Amount5 Amount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balanceAccount")]
    public ResourceReference? BalanceAccount { get; init; }

    [JsonPropertyName("category")]
    public required Category3 Category { get; init; }

    /// <summary>
    /// The relevant data according to the transfer category.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("categoryData")]
    public CategoryData? CategoryData { get; init; }

    [JsonPropertyName("counterparty")]
    public required CounterpartyV3 Counterparty { get; init; }

    /// <summary>
    /// The date and time when the transfer was created, in ISO 8601 extended format. For example, <b>2020-12-18T10:15:30+01:00</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? CreatedAt { get; init; }

    /// <summary>
    /// The date and time when the event was triggered, in ISO 8601 extended format. For example, <b>2020-12-18T10:15:30+01:00</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creationDate")]
    public DateTimeOffset? CreationDate { get; init; }

    /// <summary>
    /// Your description for the transfer. It is used by most banks as the transfer description. We recommend sending a maximum of 140 characters, otherwise the description may be truncated.
    /// <para>
    /// Supported characters: <b>[a-z] [A-Z] [0-9] / - ?</b> <b>: ( ) . , ' + Space</b>
    /// </para>
    /// <para>
    /// Supported characters for <b>regular</b> and <b>fast</b> transfers to a US counterparty: <b>[a-z] [A-Z] [0-9] &amp; $ % # @</b> <b>~ = + - _ ' " ! ?</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("directDebitInformation")]
    public DirectDebitInformation? DirectDebitInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("direction")]
    public Direction? Direction { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("executionDate")]
    public ExecutionDate? ExecutionDate { get; init; }

    /// <summary>
    /// The ID of the resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentInstrument")]
    public PaymentInstrument2? PaymentInstrument { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public Reason21? Reason { get; init; }

    /// <summary>
    /// Your reference for the transfer, used internally within your platform. If you don't provide this in the request, Adyen generates a unique reference.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    [MaxLength(80)]
    public string? Reference { get; init; }

    /// <summary>
    /// A reference that is sent to the recipient. This reference is also sent in all webhooks related to the transfer, so you can use it to track statuses for both the source and recipient of funds.
    /// <para>
    ///  Supported characters: <b>a-z</b>, <b>A-Z</b>, <b>0-9</b>.The maximum length depends on the <c>category</c>.
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>internal</b>: 80 characters</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>bank</b>: 35 characters when transferring to an IBAN, 15 characters for others.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenceForBeneficiary")]
    public string? ReferenceForBeneficiary { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("review")]
    public TransferReview? Review { get; init; }

    [JsonPropertyName("status")]
    public required Status53 Status { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type83? Type { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ultimateParty")]
    public UltimatePartyIdentification? UltimateParty { get; init; }
}
