using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The transaction rule.
/// </summary>
public record TransactionRule1
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

    /// <summary>
    /// The type and unique identifier of the resource to which the rule applies.
    /// </summary>
    [JsonPropertyName("entityKey")]
    public required TransactionRuleEntityKey2 EntityKey { get; init; }

    /// <summary>
    /// The unique identifier of the transaction rule.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The <see href="https://docs.adyen.com/issuing/transaction-rules#time-intervals">time interval</see> when the rule conditions apply.
    /// </summary>
    [JsonPropertyName("interval")]
    public required TransactionRuleInterval1 Interval { get; init; }

    /// <summary>
    /// The <see href="https://docs.adyen.com/issuing/transaction-rules#outcome">outcome</see> that will be applied when a transaction meets the conditions of the rule.
    /// <para>
    /// Possible values:
    /// * <b>hardBlock</b> (default): the transaction is declined.
    /// * <b>scoreBased</b>: the transaction is assigned the <c>score</c> you specified. Adyen calculates the total score and if it exceeds 100, the transaction is declined. This value is not allowed when <c>requestType</c> is <b>bankTransfer</b>.
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>enforceSCA</b>: your user is prompted to verify their identity using <see href="https://docs.adyen.com/issuing/3d-secure/">3D Secure authentication</see>. If the authentication fails or times out, the transaction is declined. This value is only allowed when <c>requestType</c> is <b>authentication</b>.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("outcomeType")]
    public OutcomeType? OutcomeType { get; init; }

    /// <summary>
    /// The <c>id</c> of the transaction rule you want to override or skip for the specified <c>entityKey</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("overridesRule")]
    public string? OverridesRule { get; init; }

    /// <summary>
    /// Specifies the reason for creating the rule.
    /// <para>
    /// Possible values:
    /// * <b>fraud</b>: the rule is created to regulate fraudulent activity.
    /// * <b>policy</b>: the rule is created to ensure that the transaction adheres to your business' policies. For example, if your business has policies about the Merchant Category Codes (MCCs) allowed on a transaction, you can create a rule to block transactions that have specific MCCs.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purpose")]
    public Purpose? Purpose { get; init; }

    /// <summary>
    /// Your reference for the transaction rule.
    /// </summary>
    [JsonPropertyName("reference")]
    [MaxLength(150)]
    public required string Reference { get; init; }

    /// <summary>
    /// Indicates the type of request to which the rule applies. If not provided, by default, this is set to <b>authorization</b>.
    /// <para>
    /// Possible values: <b>authorization</b>, <b>authentication</b>, <b>tokenization</b>, <b>bankTransfer</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestType")]
    public RequestType? RequestType { get; init; }

    /// <summary>
    /// Contains one or more objects that define the <see href="https://docs.adyen.com/issuing/transaction-rules#conditions">rule conditions</see>. Each object must have a value and an operation which determines how the values must be evaluated.
    /// <para>
    /// For example, a <c>countries</c> object can have a list of country codes <b>["US", "CA"]</b> in the <c>value</c> field and <b>anyMatch</b> in the <c>operation</c> field.
    /// </para>
    /// </summary>
    [JsonPropertyName("ruleRestrictions")]
    public required TransactionRuleRestrictions1 RuleRestrictions { get; init; }

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

    /// <summary>
    /// The status of the transaction rule. If you provide a <c>startDate</c> in the request, the rule is automatically created
    /// with an <b>active</b> status.
    /// <para>
    /// Possible values: <b>active</b>, <b>inactive</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status6? Status { get; init; }

    /// <summary>
    /// The <see href="https://docs.adyen.com/issuing/transaction-rules#rule-types">type of rule</see>, which defines if a rule blocks transactions based on individual characteristics or accumulates data.
    /// <para>
    /// Possible values:
    ///  * <b>blockList</b>: decline a transaction when the conditions are met.
    ///  * <b>maxUsage</b>: add the amount or number of transactions for the lifetime of a payment instrument, and then decline a transaction when the specified limits are met.
    ///  * <b>velocity</b>: add the amount or number of transactions based on a specified time interval, and then decline a transaction when the specified limits are met.
    ///  * <b>bypass</b>: bypass or skip a rule for the specified <c>entityKey</c>. Transactions processed to that entity are no longer evaluated by the bypassed rule.  You must provide the <c>id</c> of the rule to bypass in <c>overridesRule</c> and leave the <c>ruleRestrictions</c> object empty.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type141 Type { get; init; }
}
