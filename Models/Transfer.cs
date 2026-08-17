using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;
using Adyen.Models.OneOf;

namespace Adyen.Models;

public record Transfer
{
    /// <summary>
    /// The account holder associated with the balance account involved in the transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolder")]
    public ResourceReference5? AccountHolder { get; init; }

    /// <summary>
    /// The amount of the transfer.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }

    /// <summary>
    /// Contains information about the balance account involved in the transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balanceAccount")]
    public ResourceReference1? BalanceAccount { get; init; }

    /// <summary>
    /// The category of the transfer.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>bank</b>: A transfer involving a <see href="https://docs.adyen.com/api-explorer/legalentity/latest/post/transferInstruments#responses-200-id">transfer instrument</see> or a bank account.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>card</b>: A transfer involving a third-party card.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>internal</b>: A transfer between <see href="https://docs.adyen.com/api-explorer/balanceplatform/latest/post/balanceAccounts#responses-200-id">balance accounts</see> within your platform.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>issuedCard</b>: A transfer initiated by an Adyen-issued card.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>platformPayment</b>: Funds movements related to payments that are acquired for your users.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>topUp</b>: An incoming transfer initiated by your user to top up their balance account.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("category")]
    public required Category3 Category { get; init; }

    /// <summary>
    /// The relevant data according to the transfer category.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("categoryData")]
    public CategoryData? CategoryData { get; init; }

    /// <summary>
    /// The other party in the transfer.
    /// </summary>
    [JsonPropertyName("counterparty")]
    public required CounterpartyV31 Counterparty { get; init; }

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

    /// <summary>
    /// The details of the direct debit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("directDebitInformation")]
    public DirectDebitInformation1? DirectDebitInformation { get; init; }

    /// <summary>
    /// The direction of the transfer.
    /// <para>
    /// Possible values: <b>incoming</b>, <b>outgoing</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("direction")]
    public Direction? Direction { get; init; }

    /// <summary>
    /// Contains information about the date when the transfer will be processed. The execution date must be within 30 days of the current date.
    /// <para>
    /// Until the execution date:
    /// - The <c>status</c> of the transfer remains as <b>received</b>.
    /// - The <c>reason</c> of the transfer remains as <b>pending</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("executionDate")]
    public ExecutionDate1? ExecutionDate { get; init; }

    /// <summary>
    /// The ID of the resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Contains information about the payment instrument used in the transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentInstrument")]
    public PaymentInstrument3? PaymentInstrument { get; init; }

    /// <summary>
    /// Additional information about the status of the transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public Reason2? Reason { get; init; }

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

    /// <summary>
    /// Contains status updates related to additional reviews.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("review")]
    public TransferReview1? Review { get; init; }

    /// <summary>
    /// The result of the transfer.
    /// <para>
    /// For example:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>received</b>: an outgoing transfer request is created.</description></item>
    ///   <item><description><b>refused</b>: the transfer request is rejected by Adyen for one of the following reasons:
    ///     <list type="bullet">
    ///       <item><description>Transfer limit exceeded.</description></item>
    ///       <item><description>Transaction rule requirements violated.</description></item>
    ///     </list>
    ///   </description></item>
    ///   <item><description><b>authorised</b>: the transfer request is authorized and the funds are reserved.</description></item>
    ///   <item><description><b>booked</b>: the funds are deducted from your user's balance account.
    ///     <list type="bullet">
    ///       <item><description><b>failed</b>: the transfer is rejected by the counterparty's bank.</description></item>
    ///     </list>
    ///   </description></item>
    ///   <item><description><b>returned</b>: the transfer is returned by the counterparty's bank.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status51 Status { get; init; }

    /// <summary>
    /// The type of transfer or transaction. For example, <b>refund</b>, <b>payment</b>, <b>internalTransfer</b>, <b>bankTransfer</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type83? Type { get; init; }

    /// <summary>
    /// The ultimate sender of the funds of the transfer (ultimate debtor).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ultimateParty")]
    public UltimatePartyIdentification1? UltimateParty { get; init; }
}
