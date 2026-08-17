using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PixRecurring
{
    /// <summary>
    /// The date on which the shopper's payment method will be charged, in YYYY-MM-DD format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingDate")]
    public string? BillingDate { get; init; }

    /// <summary>
    /// Flag used to define whether liquidation can happen only on business days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessDayOnly")]
    public bool? BusinessDayOnly { get; init; }

    /// <summary>
    /// End date of the billing plan, in YYYY-MM-DD format. The end date must align with the frequency and the start date of the billing plan. If left blank, the subscription will continue indefinitely unless it is cancelled by the shopper.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endsAt")]
    public string? EndsAt { get; init; }

    /// <summary>
    /// The frequency at which the shopper will be charged.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frequency")]
    public Frequency2? Frequency { get; init; }

    /// <summary>
    /// For a billing plan where the payment amounts are variable, the minimum amount to charge the shopper for each recurring payment. When a shopper approves the billing plan, they can also specify a maximum amount in their banking app.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minAmount")]
    public Amount42? MinAmount { get; init; }

    /// <summary>
    /// The pspReference for the failed recurring payment. Find this in AUTHORISATION webhook you received after the billing date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalPspReference")]
    public string? OriginalPspReference { get; init; }

    /// <summary>
    /// For a billing plan where the payment amount is fixed, the amount the shopper will be charged for each recurring payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringAmount")]
    public Amount43? RecurringAmount { get; init; }

    /// <summary>
    /// The text that that will be shown on the shopper's bank statement for the recurring payments. We recommend to add a descriptive text about the subscription to let your shoppers recognize your recurring payments.
    /// Maximum length: 35 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringStatement")]
    public string? RecurringStatement { get; init; }

    /// <summary>
    /// When set to true, you can retry for failed recurring payments. The default value is true.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("retryPolicy")]
    public bool? RetryPolicy { get; init; }

    /// <summary>
    /// Start date of the billing plan, in YYYY-MM-DD format. The default value is the transaction date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startsAt")]
    public string? StartsAt { get; init; }
}
