using System;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Shopper account information for 3D Secure 2.
/// &gt; For 3D Secure 2 transactions, we recommend that you include this object to increase the chances of achieving a frictionless flow.
/// </summary>
public record AccountInfo
{
    /// <summary>
    /// Indicator for the length of time since this shopper account was created in the merchant's environment.
    /// Allowed values:
    /// * notApplicable
    /// * thisTransaction
    /// * lessThan30Days
    /// * from30To60Days
    /// * moreThan60Days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountAgeIndicator")]
    public AccountAgeIndicator? AccountAgeIndicator { get; init; }

    /// <summary>
    /// Date when the shopper's account was last changed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountChangeDate")]
    public DateTimeOffset? AccountChangeDate { get; init; }

    /// <summary>
    /// Indicator for the length of time since the shopper's account was last updated.
    /// Allowed values:
    /// * thisTransaction
    /// * lessThan30Days
    /// * from30To60Days
    /// * moreThan60Days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountChangeIndicator")]
    public AccountChangeIndicator? AccountChangeIndicator { get; init; }

    /// <summary>
    /// Date when the shopper's account was created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountCreationDate")]
    public DateTimeOffset? AccountCreationDate { get; init; }

    /// <summary>
    /// Indicates the type of account. For example, for a multi-account card product.
    /// Allowed values:
    /// * notApplicable
    /// * credit
    /// * debit
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountType")]
    public AccountType? AccountType { get; init; }

    /// <summary>
    /// Number of attempts the shopper tried to add a card to their account in the last day.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("addCardAttemptsDay")]
    public int? AddCardAttemptsDay { get; init; }

    /// <summary>
    /// Date the selected delivery address was first used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliveryAddressUsageDate")]
    public DateTimeOffset? DeliveryAddressUsageDate { get; init; }

    /// <summary>
    /// Indicator for the length of time since this delivery address was first used.
    /// Allowed values:
    /// * thisTransaction
    /// * lessThan30Days
    /// * from30To60Days
    /// * moreThan60Days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliveryAddressUsageIndicator")]
    public DeliveryAddressUsageIndicator? DeliveryAddressUsageIndicator { get; init; }

    /// <summary>
    /// Shopper's home phone number (including the country code).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("homePhone")]
    public string? HomePhone { get; init; }

    /// <summary>
    /// Shopper's mobile phone number (including the country code).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mobilePhone")]
    public string? MobilePhone { get; init; }

    /// <summary>
    /// Date when the shopper last changed their password.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("passwordChangeDate")]
    public DateTimeOffset? PasswordChangeDate { get; init; }

    /// <summary>
    /// Indicator when the shopper has changed their password.
    /// Allowed values:
    /// * notApplicable
    /// * thisTransaction
    /// * lessThan30Days
    /// * from30To60Days
    /// * moreThan60Days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("passwordChangeIndicator")]
    public PasswordChangeIndicator? PasswordChangeIndicator { get; init; }

    /// <summary>
    /// Number of all transactions (successful and abandoned) from this shopper in the past 24 hours.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pastTransactionsDay")]
    public int? PastTransactionsDay { get; init; }

    /// <summary>
    /// Number of all transactions (successful and abandoned) from this shopper in the past year.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pastTransactionsYear")]
    public int? PastTransactionsYear { get; init; }

    /// <summary>
    /// Date this payment method was added to the shopper's account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentAccountAge")]
    public DateTimeOffset? PaymentAccountAge { get; init; }

    /// <summary>
    /// Indicator for the length of time since this payment method was added to this shopper's account.
    /// Allowed values:
    /// * notApplicable
    /// * thisTransaction
    /// * lessThan30Days
    /// * from30To60Days
    /// * moreThan60Days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentAccountIndicator")]
    public PaymentAccountIndicator? PaymentAccountIndicator { get; init; }

    /// <summary>
    /// Number of successful purchases in the last six months.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purchasesLast6Months")]
    public int? PurchasesLast6Months { get; init; }

    /// <summary>
    /// Whether suspicious activity was recorded on this account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("suspiciousActivity")]
    public bool? SuspiciousActivity { get; init; }

    /// <summary>
    /// Shopper's work phone number (including the country code).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("workPhone")]
    public string? WorkPhone { get; init; }
}
