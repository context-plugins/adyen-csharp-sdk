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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccount")]
    public BankAccountModel? BankAccount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public CardInfo? Card { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status10? Status { get; init; }

    /// <summary>
    /// The status comment provides additional information for the statusReason of the payment instrument.
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
