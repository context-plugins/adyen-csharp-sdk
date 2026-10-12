using System;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record BalancePlatformConfiguration
{
    /// <summary>
    /// Specifies whether this payout schedule is automatically applied to new balance accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("automaticApplication")]
    public bool? AutomaticApplication { get; init; }

    /// <summary>
    /// The balance platform to which the payout schedule applies.
    /// </summary>
    [JsonPropertyName("balancePlatformId")]
    public required string BalancePlatformId { get; init; }

    /// <summary>
    /// The two-letter <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> code of the country to which the payout schedule applies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; init; }

    /// <summary>
    /// The date when the payout schedule was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO code</see> of the currency used for the payout schedule.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public string? Currency { get; init; }

    /// <summary>
    /// The default description for payouts initiated by this payout schedule.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("defaultDescription")]
    public string? DefaultDescription { get; init; }

    /// <summary>
    /// The default frequency of payouts initiated by this payout schedule.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("defaultFrequency")]
    public string? DefaultFrequency { get; init; }

    /// <summary>
    /// The default value for date of the month or day of the week when payouts are initiated. Allowed only if <c>defaultFrequency</c> is <b>monthly</b> or <b>weekly</b>.
    /// <para>
    /// Possible values if <c>defaultFrequency</c> is <b>monthly</b>: <b>[1 - 31]</b>.
    /// * If your specified date happens on a weekend, the payout is initiated on the next business day.
    /// * If your specified date (<b>29</b>, <b>30</b>, or <b>31</b>) does not exist in a month, the payout is initiated  on the last day of that month.
    /// </para>
    /// <para>
    /// Possible values if <c>defaultFrequency</c> is <b>weekly</b>: <b>[1 - 5]</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("defaultFrequencyValue")]
    public int? DefaultFrequencyValue { get; init; }

    /// <summary>
    /// Your internal default reference for the payout schedule.When the payout schedule is applied to a balance account, this reference is also used for that payout schedule.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("defaultReference")]
    public string? DefaultReference { get; init; }

    /// <summary>
    /// The default reference for beneficiary for payouts initiated by this payout schedule.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("defaultReferenceForBeneficiary")]
    public string? DefaultReferenceForBeneficiary { get; init; }

    /// <summary>
    /// Specifies whether the payout schedule is enabled immediately after it is created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }

    /// <summary>
    /// The unique identifier of the payout schedule for your balance platform.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The maximum amount that can be paid out from balance accounts that use this payout schedule.
    /// <para>
    /// Default value: <b>0</b>, which means that there is no maximum limit.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxPayoutAmount")]
    public long? MaxPayoutAmount { get; init; }

    /// <summary>
    /// The minimum amount that can be paid out from balance accounts that use this payout schedule.
    /// <para>
    /// Default value: <b>0</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minPayoutAmount")]
    public long? MinPayoutAmount { get; init; }

    /// <summary>
    /// The type of payout schedule. This type indicates how fast funds are paid out to your user.
    /// <para>
    /// Possible values:
    /// - <b>Standard</b>: The funds arrive in your user's transfer instrument two days after the funds are settled.
    /// - <b>Accelerated</b>: The funds arrive to your user's transfer instrument the day after the funds are settled.
    /// </para>
    /// </summary>
    [JsonPropertyName("payoutScheduleDescription")]
    public required string PayoutScheduleDescription { get; init; }

    /// <summary>
    /// The amount of funds that must remain available in a balance account after an execution of the payout schedule. If the funds in the balance account are less than the retained amount, the execution is not initiated.
    /// <para>
    /// Default value: <b>0</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("retainedAmount")]
    public long? RetainedAmount { get; init; }

    /// <summary>
    /// The date when the payout schedule was updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? UpdatedAt { get; init; }

    /// <summary>
    /// The default <see href="https://docs.adyen.com/platforms/settle-funds/#settlement-delay">settlement delay</see> for this payout schedule.
    /// </summary>
    [JsonPropertyName("userSettlementDelay")]
    public required int UserSettlementDelay { get; init; }

    /// <summary>
    /// The time when the payout funds are settled in your user's transfer instrument.
    /// </summary>
    [JsonPropertyName("userSettlementTime")]
    public required LocalTime2 UserSettlementTime { get; init; }

    /// <summary>
    /// The timezone of the <c>userSettlementTime</c>.
    /// </summary>
    [JsonPropertyName("userSettlementTimeZone")]
    public required string UserSettlementTimeZone { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
