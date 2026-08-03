using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record TransactionRuleInfo
{
    /// <summary>
    /// The level at which data must be accumulated, used in rules with <c>type</c> <b>velocity</b> or <b>maxUsage</b>. The level must be the <see href="https://docs.adyen.com/issuing/transaction-rules#accumulate-data">same or lower in hierarchy</see> than the <c>entityKey</c>.
    /// <para>
    /// If not provided, by default, the rule will accumulate data at the <b>paymentInstrument</b> level.
    /// </para>
    /// <para>
    /// Possible values: <b>paymentInstrument</b>, <b>paymentInstrumentGroup</b>, <b>balanceAccount</b>, <b>accountHolder</b>, <b>balancePlatform</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aggregationLevel")]
    public string? AggregationLevel { get; init; }

    /// <summary>
    /// Your description for the transaction rule.
    /// </summary>
    [JsonPropertyName("description")]
    [MaxLength(300)]
    public required string Description { get; init; }

    /// <summary>
    /// The date when the rule will stop being evaluated, in ISO 8601 extended offset date-time format. For example, <b>2025-03-19T10:15:30+01:00</b>.
    /// <para>
    /// If not provided, the rule will be evaluated until the rule status is set to <b>inactive</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endDate")]
    public string? EndDate { get; init; }

    [JsonPropertyName("entityKey")]
    public required TransactionRuleEntityKey EntityKey { get; init; }

    [JsonPropertyName("interval")]
    public required TransactionRuleInterval Interval { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("outcomeType")]
    public OutcomeType? OutcomeType { get; init; }

    /// <summary>
    /// The <c>id</c> of the transaction rule you want to override or skip for the specified <c>entityKey</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("overridesRule")]
    public string? OverridesRule { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purpose")]
    public Purpose? Purpose { get; init; }

    /// <summary>
    /// Your reference for the transaction rule.
    /// </summary>
    [JsonPropertyName("reference")]
    [MaxLength(150)]
    public required string Reference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestType")]
    public RequestType? RequestType { get; init; }

    [JsonPropertyName("ruleRestrictions")]
    public required TransactionRuleRestrictions RuleRestrictions { get; init; }

    /// <summary>
    /// A positive or negative score applied to the transaction if it meets the conditions of the rule. Required when <c>outcomeType</c> is <b>scoreBased</b>.  The value must be between <b>-100</b> and <b>100</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("score")]
    public int? Score { get; init; }

    /// <summary>
    /// The date when the rule will start to be evaluated, in ISO 8601 extended offset date-time format. For example, <b>2025-03-19T10:15:30+01:00</b>.
    /// <para>
    /// If not provided when creating a transaction rule, the <c>startDate</c> is set to the date when the rule status is set to <b>active</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startDate")]
    public string? StartDate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status14? Status { get; init; }

    [JsonPropertyName("type")]
    public required Type14 Type { get; init; }
}
