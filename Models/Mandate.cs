using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The mandate details to initiate recurring transaction.
/// </summary>
public record Mandate
{
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
    /// The message shown by UPI to the shopper on the approval screen.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("remarks")]
    public string? Remarks { get; init; }

    /// <summary>
    /// Start date of the billing plan, in YYYY-MM-DD format. By default, the transaction date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startsAt")]
    public string? StartsAt { get; init; }
}
