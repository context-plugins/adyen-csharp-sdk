using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Mandate1
{
    /// <summary>
    /// The billing amount (in minor units) of the recurring transactions.
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amountRule")]
    public AmountRule? AmountRule { get; init; }

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

    [JsonPropertyName("frequency")]
    public required Frequency1 Frequency { get; init; }

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
