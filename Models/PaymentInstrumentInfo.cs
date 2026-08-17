using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PaymentInstrumentInfo
{
    /// <summary>
    /// The unique identifier of the <see href="https://docs.adyen.com/api-explorer/#/balanceplatform/v1/post/balanceAccounts__resParam_id">balance account</see> associated with the payment instrument.
    /// </summary>
    [JsonPropertyName("balanceAccountId")]
    public required string BalanceAccountId { get; init; }

    /// <summary>
    /// Contains the business account details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccount")]
    public BankAccountModel1? BankAccount { get; init; }

    /// <summary>
    /// Contains information about the card. Required when you create a payment instrument of <c>type</c> <b>card</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public CardInfo1? Card { get; init; }

    /// <summary>
    /// Your description for the payment instrument, maximum 300 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(300)]
    public string? Description { get; init; }

    /// <summary>
    /// The two-character <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> country code where the payment instrument is issued. For example, <b>NL</b> or <b>US</b>.
    /// </summary>
    [JsonPropertyName("issuingCountryCode")]
    public required string IssuingCountryCode { get; init; }

    /// <summary>
    /// The unique identifier of the <see href="https://docs.adyen.com/api-explorer/#/balanceplatform/v1/post/paymentInstrumentGroups__resParam_id">payment instrument group</see> to which the payment instrument belongs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentInstrumentGroupId")]
    public string? PaymentInstrumentGroupId { get; init; }

    /// <summary>
    /// Your reference for the payment instrument, maximum 150 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    [MaxLength(150)]
    public string? Reference { get; init; }

    /// <summary>
    /// The status of the payment instrument. If a status is not specified when creating a payment instrument, it is set to <b>active</b> by default. However, there can be exceptions for cards based on the <c>card.formFactor</c> and the <c>issuingCountryCode</c>. For example, when issuing physical cards in the US, the default status is <b>inactive</b>.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>active</b>:  The payment instrument is active and can be used to make payments.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>inactive</b>: The payment instrument is inactive and cannot be used to make payments.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>suspended</b>: The payment instrument is suspended, either because it was stolen or lost.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>closed</b>: The payment instrument is permanently closed. This action cannot be undone.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status10? Status { get; init; }

    /// <summary>
    /// The status comment provides additional information for the statusReason of the payment instrument.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statusComment")]
    public string? StatusComment { get; init; }

    /// <summary>
    /// The reason for the status of the payment instrument.
    /// <para>
    /// Possible values: <b>accountClosure</b>, <b>damaged</b>, <b>endOfLife</b>, <b>expired</b>, <b>lost</b>, <b>stolen</b>, <b>suspectedFraud</b>, <b>transactionRule</b>, <b>other</b>.
    /// If the reason is <b>other</b>, you must also send the <c>statusComment</c> parameter describing the status change.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statusReason")]
    public StatusReason? StatusReason { get; init; }

    /// <summary>
    /// The type of payment instrument.
    /// <para>
    /// Possible values: <b>card</b>, <b>bankAccount</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type111 Type { get; init; }
}
