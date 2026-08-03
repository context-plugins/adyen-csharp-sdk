using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record UpdatePaymentInstrument
{
    /// <summary>
    /// Contains optional, additional business account details. Returned when you create a payment instrument with <c>type</c> <b>bankAccount</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalBankAccountIdentifications")]
    public IReadOnlyList<IbanAccountIdentification1>? AdditionalBankAccountIdentifications { get; init; }

    /// <summary>
    /// The unique identifier of the <see href="https://docs.adyen.com/api-explorer/#/balanceplatform/v1/post/balanceAccounts__resParam_id">balance account</see> associated with the payment instrument.
    /// </summary>
    [JsonPropertyName("balanceAccountId")]
    public required string BalanceAccountId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccount")]
    public BankAccountDetails? BankAccount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public Card? Card { get; init; }

    /// <summary>
    /// Your description for the payment instrument, maximum 300 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(300)]
    public string? Description { get; init; }

    /// <summary>
    /// The unique identifier of the payment instrument.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

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
    /// The unique identifier of the payment instrument that replaced this payment instrument.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("replacedById")]
    public string? ReplacedById { get; init; }

    /// <summary>
    /// The unique identifier of the payment instrument that is replaced by this payment instrument.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("replacementOfId")]
    public string? ReplacementOfId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status10? Status { get; init; }

    /// <summary>
    /// Comment for the status of the payment instrument.
    /// <para>
    /// Required if <c>statusReason</c> is <b>other</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statusComment")]
    public string? StatusComment { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statusReason")]
    public StatusReason? StatusReason { get; init; }

    [JsonPropertyName("type")]
    public required Type11 Type { get; init; }
}
