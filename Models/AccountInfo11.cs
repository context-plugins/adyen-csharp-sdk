using System;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Shopper account information for 3D Secure 2.
/// &gt; For 3D Secure 2 transactions, we recommend that you include this object to increase the chances of achieving a frictionless flow.
/// </summary>
public record AccountInfo11
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountAgeIndicator")]
    public AccountAgeIndicator? AccountAgeIndicator { get; init; }

    /// <summary>
    /// Date when the shopper's account was last changed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountChangeDate")]
    public DateTimeOffset? AccountChangeDate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountChangeIndicator")]
    public AccountChangeIndicator? AccountChangeIndicator { get; init; }

    /// <summary>
    /// Date when the shopper's account was created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountCreationDate")]
    public DateTimeOffset? AccountCreationDate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountType")]
    public AccountType1? AccountType { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliveryAddressUsageIndicator")]
    public AccountChangeIndicator? DeliveryAddressUsageIndicator { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("passwordChangeIndicator")]
    public AccountAgeIndicator? PasswordChangeIndicator { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentAccountIndicator")]
    public AccountAgeIndicator? PaymentAccountIndicator { get; init; }

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
