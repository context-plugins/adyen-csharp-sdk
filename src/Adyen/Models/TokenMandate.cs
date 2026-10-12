using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record TokenMandate
{
    /// <summary>
    /// The type of account identifier for the masked account number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountIdType")]
    public string? AccountIdType { get; init; }

    /// <summary>
    /// The billing amount (in minor units) of the recurring transactions.
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// The limitation rule of the billing amount.
    /// <para>
    /// Possible values:
    ///  * <b>max</b>: The transaction amount can not exceed the <c>amount</c>.
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>exact</b>: The transaction amount should be the same as the <c>amount</c>.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amountRule")]
    public AmountRule? AmountRule { get; init; }

    /// <summary>
    /// The rule to specify the period, within which the recurring debit can happen, relative to the mandate recurring date.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>on</b>: On a specific date.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>before</b>:  Before and on a specific date.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>after</b>: On and after a specific date.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingAttemptsRule")]
    public BillingAttemptsRule? BillingAttemptsRule { get; init; }

    /// <summary>
    /// The number of the day, on which the recurring debit can happen. Should be within the same calendar month as the mandate recurring date.
    /// <para>
    /// Possible values: 1-31 based on the <c>frequency</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingDay")]
    public string? BillingDay { get; init; }

    /// <summary>
    /// The number of transactions that can be performed within the given frequency.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("count")]
    public string? Count { get; init; }

    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see>.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>
    /// End date of the billing plan, in YYYY-MM-DD format.
    /// </summary>
    [JsonPropertyName("endsAt")]
    public required string EndsAt { get; init; }

    /// <summary>
    /// The frequency with which a shopper should be charged.
    /// <para>
    /// Possible values: <b>adhoc</b>, <b>daily</b>, <b>weekly</b>, <b>biWeekly</b>, <b>monthly</b>, <b>quarterly</b>, <b>halfYearly</b>, <b>yearly</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("frequency")]
    public required Frequency Frequency { get; init; }

    /// <summary>
    /// The unique identifier of the mandate.
    /// </summary>
    [JsonPropertyName("mandateId")]
    public required string MandateId { get; init; }

    /// <summary>
    /// The masked account number associated with the mandate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maskedAccountId")]
    public string? MaskedAccountId { get; init; }

    /// <summary>
    /// For a billing plan where the payment amounts are variable, the minimum amount to charge the shopper for each recurring payment. When a shopper approves the billing plan, they can also specify a maximum amount in their banking app.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minAmount")]
    public string? MinAmount { get; init; }

    /// <summary>
    /// The provider-specific identifier for this mandate.
    /// </summary>
    [JsonPropertyName("providerId")]
    public required string ProviderId { get; init; }

    /// <summary>
    /// For a billing plan where the payment amount is fixed, the amount the shopper will be charged for each recurring payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringAmount")]
    public string? RecurringAmount { get; init; }

    /// <summary>
    /// The text that will be shown on the shopper's bank statement for the recurring payments. We recommend to add a descriptive text about the subscription to let your shoppers recognize your recurring payments.
    /// Maximum length: 35 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringStatement")]
    [MaxLength(35)]
    public string? RecurringStatement { get; init; }

    /// <summary>
    /// Additional remarks or notes about the mandate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("remarks")]
    public string? Remarks { get; init; }

    /// <summary>
    /// When set to true, you can retry for failed recurring payments. The default value is true.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("retryPolicy")]
    public RetryPolicy? RetryPolicy { get; init; }

    /// <summary>
    /// Start date of the billing plan, in YYYY-MM-DD format. By default, the transaction date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startsAt")]
    public string? StartsAt { get; init; }

    /// <summary>
    /// The status of the mandate. Examples : active, revoked, completed, expired
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    /// <summary>
    /// The transaction variant used for this mandate.
    /// </summary>
    [JsonPropertyName("txVariant")]
    public required string TxVariant { get; init; }
}
