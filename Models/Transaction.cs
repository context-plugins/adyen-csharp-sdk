using System;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Transaction
{
    /// <summary>
    /// Contains information about the account holder associated with the <c>balanceAccount</c>.
    /// </summary>
    [JsonPropertyName("accountHolder")]
    public required ResourceReference3 AccountHolder { get; init; }

    /// <summary>
    /// Contains information about the amount of the transaction.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }

    /// <summary>
    /// Contains information about the balance account involved in the transaction.
    /// </summary>
    [JsonPropertyName("balanceAccount")]
    public required ResourceReference4 BalanceAccount { get; init; }

    /// <summary>
    /// The unique identifier of the balance platform.
    /// </summary>
    [JsonPropertyName("balancePlatform")]
    public required string BalancePlatform { get; init; }

    /// <summary>
    /// The date the transaction was booked into the balance account.
    /// </summary>
    [JsonPropertyName("bookingDate")]
    public required DateTimeOffset BookingDate { get; init; }

    /// <summary>
    /// The date and time when the event was triggered, in ISO 8601 extended format. For example, <b>2025-03-19T10:15:30+01:00</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creationDate")]
    public DateTimeOffset? CreationDate { get; init; }

    /// <summary>
    /// The <c>description</c> from the <c>/transfers</c> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The unique identifier of the transaction.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Contains information about the payment instrument that was used for the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentInstrument")]
    public PaymentInstrument21? PaymentInstrument { get; init; }

    /// <summary>
    /// The reference sent to or received from the counterparty.
    /// <list type="bullet">
    ///   <item><description>For outgoing funds, this is the <see href="https://docs.adyen.com/api-explorer/#/transfers/latest/post/transfers__resParam_referenceForBeneficiary"><c>referenceForBeneficiary</c></see> from the  <see href="https://docs.adyen.com/api-explorer/#/transfers/latest/post/transfers__reqParam_referenceForBeneficiary"><c>/transfers</c></see> request.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>For incoming funds, this is the reference from the sender.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenceForBeneficiary")]
    public string? ReferenceForBeneficiary { get; init; }

    /// <summary>
    /// The status of the transaction.
    /// <para>
    ///  Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>pending</b>: The transaction is still pending.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>booked</b>: The transaction has been booked to the balance account.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status72 Status { get; init; }

    /// <summary>
    /// Contains information about the transfer related to the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transfer")]
    public TransferView2? Transfer { get; init; }

    /// <summary>
    /// The date the transfer amount becomes available in the balance account.
    /// </summary>
    [JsonPropertyName("valueDate")]
    public required DateTimeOffset ValueDate { get; init; }
}
