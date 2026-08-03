using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Additional information about the cardholder’s account provided by the 3DS Requestor.
/// </summary>
public record AcctInfo
{
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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipAddressUsageInd")]
    public ShipAddressUsageInd? ShipAddressUsageInd { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipNameIndicator")]
    public ShipNameIndicator? ShipNameIndicator { get; init; }

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
