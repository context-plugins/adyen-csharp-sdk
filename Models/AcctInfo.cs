using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Additional information about the cardholder’s account provided by the 3DS Requestor.
/// </summary>
public record AcctInfo
{
    /// <summary>
    /// Length of time that the cardholder has had the account with the 3DS Requestor.
    /// Allowed values:
    /// * <b>01</b> — No account
    /// * <b>02</b> — Created during this transaction
    /// * <b>03</b> — Less than 30 days
    /// * <b>04</b> — 30–60 days
    /// * <b>05</b> — More than 60 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chAccAgeInd")]
    public ChAccAgeInd? ChAccAgeInd { get; init; }

    /// <summary>
    /// Date that the cardholder’s account with the 3DS Requestor was last changed, including Billing or Shipping address, new payment account, or new user(s) added.
    /// Format: <b>YYYYMMDD</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chAccChange")]
    public string? ChAccChange { get; init; }

    /// <summary>
    /// Length of time since the cardholder’s account information with the 3DS Requestor was last changed, including Billing or Shipping address, new payment account, or new user(s) added.
    /// Allowed values:
    /// * <b>01</b> — Changed during this transaction
    /// * <b>02</b> — Less than 30 days
    /// * <b>03</b> — 30–60 days
    /// * <b>04</b> — More than 60 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chAccChangeInd")]
    public ChAccChangeInd? ChAccChangeInd { get; init; }

    /// <summary>
    /// Date that cardholder’s account with the 3DS Requestor had a password change or account reset.
    /// Format: <b>YYYYMMDD</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chAccPwChange")]
    public string? ChAccPwChange { get; init; }

    /// <summary>
    /// Indicates the length of time since the cardholder’s account with the 3DS Requestor had a password change or account reset.
    /// Allowed values:
    /// * <b>01</b> — No change
    /// * <b>02</b> — Changed during this transaction
    /// * <b>03</b> — Less than 30 days
    /// * <b>04</b> — 30–60 days
    /// * <b>05</b> — More than 60 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chAccPwChangeInd")]
    public ChAccPwChangeInd? ChAccPwChangeInd { get; init; }

    /// <summary>
    /// Date that the cardholder opened the account with the 3DS Requestor.
    /// Format: <b>YYYYMMDD</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chAccString")]
    public string? ChAccString { get; init; }

    /// <summary>
    /// Number of purchases with this cardholder account during the previous six months. Max length: 4 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nbPurchaseAccount")]
    public string? NbPurchaseAccount { get; init; }

    /// <summary>
    /// String that the payment account was enrolled in the cardholder’s account with the 3DS Requestor.
    /// Format: <b>YYYYMMDD</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentAccAge")]
    public string? PaymentAccAge { get; init; }

    /// <summary>
    /// Indicates the length of time that the payment account was enrolled in the cardholder’s account with the 3DS Requestor.
    /// Allowed values:
    /// * <b>01</b> — No account (guest checkout)
    /// * <b>02</b> — During this transaction
    /// * <b>03</b> — Less than 30 days
    /// * <b>04</b> — 30–60 days
    /// * <b>05</b> — More than 60 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentAccInd")]
    public PaymentAccInd? PaymentAccInd { get; init; }

    /// <summary>
    /// Number of Add Card attempts in the last 24 hours. Max length: 3 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("provisionAttemptsDay")]
    public string? ProvisionAttemptsDay { get; init; }

    /// <summary>
    /// String when the shipping address used for this transaction was first used with the 3DS Requestor.
    /// Format: <b>YYYYMMDD</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipAddressUsage")]
    public string? ShipAddressUsage { get; init; }

    /// <summary>
    /// Indicates when the shipping address used for this transaction was first used with the 3DS Requestor.
    /// Allowed values:
    /// * <b>01</b> — This transaction
    /// * <b>02</b> — Less than 30 days
    /// * <b>03</b> — 30–60 days
    /// * <b>04</b> — More than 60 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipAddressUsageInd")]
    public ShipAddressUsageInd? ShipAddressUsageInd { get; init; }

    /// <summary>
    /// Indicates if the Cardholder Name on the account is identical to the shipping Name used for this transaction.
    /// Allowed values:
    /// * <b>01</b> — Account Name identical to shipping Name
    /// * <b>02</b> — Account Name different to shipping Name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipNameIndicator")]
    public ShipNameIndicator? ShipNameIndicator { get; init; }

    /// <summary>
    /// Indicates whether the 3DS Requestor has experienced suspicious activity (including previous fraud) on the cardholder account.
    /// Allowed values:
    /// * <b>01</b> — No suspicious activity has been observed
    /// * <b>02</b> — Suspicious activity has been observed
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("suspiciousAccActivity")]
    public SuspiciousAccActivity? SuspiciousAccActivity { get; init; }

    /// <summary>
    /// Number of transactions (successful and abandoned) for this cardholder account with the 3DS Requestor across all payment accounts in the previous 24 hours. Max length: 3 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("txnActivityDay")]
    [MaxLength(3)]
    public string? TxnActivityDay { get; init; }

    /// <summary>
    /// Number of transactions (successful and abandoned) for this cardholder account with the 3DS Requestor across all payment accounts in the previous year. Max length: 3 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("txnActivityYear")]
    [MaxLength(3)]
    public string? TxnActivityYear { get; init; }
}
