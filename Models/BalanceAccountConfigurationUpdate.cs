using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record BalanceAccountConfigurationUpdate
{
    /// <summary>
    /// The description used for all payouts initiated by this payout schedule.
    /// <para>
    /// Maximum length: 140 characters. If your description is longer, it may be truncated.
    /// </para>
    /// <para>
    /// Default value: The <c>defaultDescription</c> from the balance platform schedule that you are applying.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Specifies whether the payout schedule is enabled immediately after it is created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frequency")]
    public Frequency? Frequency { get; init; }

    /// <summary>
    /// The date of the month or day of the week when payouts are initiated. Allowed only if <c>frequency</c> is <b>monthly</b> or <b>weekly</b>.
    /// <para>
    /// Possible values if <c>frequency</c> is <b>monthly</b>: <b>[1 - 31]</b>.
    /// * If your specified date happens on a weekend, the payout is initiated on the next business day.
    /// * If your specified date (<b>29</b>, <b>30</b>, or <b>31</b>) does not exist in a month, the payout is initiated on the last day of that month.
    /// </para>
    /// <para>
    /// Possible values if <c>frequency</c> is <b>weekly</b>: <b>[1 - 5]</b>.
    /// </para>
    /// <para>
    /// Default value: The <c>defaultFrequencyValue</c> from the balance platform schedule that you are applying.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frequencyValue")]
    public int? FrequencyValue { get; init; }

    /// <summary>
    /// The maximum amount that can be paid out from balance accounts that use this payout schedule.
    /// <para>
    /// Default value: <b>0</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxPayoutAmount")]
    public long? MaxPayoutAmount { get; init; }

    /// <summary>
    /// The minimum amount that can be paid out from balance accounts that use this payout schedule.
    /// <para>
    /// Default value: <b>0</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minPayoutAmount")]
    public long? MinPayoutAmount { get; init; }

    /// <summary>
    /// The merchant reference that will be shown only in the schedule.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// The reference for beneficiary used for all payouts initiated by this payout schedule. This reference is sent to the recipient of the transfer and is included in all webhooks related to the payout.
    /// <para>
    /// Supported characters: <b>a-z</b>, <b>A-Z</b>, <b>0-9</b>, <b>-</b> and space. Spaces might be replaced with <b>-</b> if the recipient bank or payment infrastructure does not allow spaces.
    /// </para>
    /// <para>
    /// Default value: The <c>defaultReferenceForBeneficiary</c> from the balance platform schedule that you are applying.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenceForBeneficiary")]
    public string? ReferenceForBeneficiary { get; init; }

    /// <summary>
    /// The amount of funds that must remain available in the balance account after an execution of the payout schedule. If the funds in the balance account are less than the retained amount, the execution is not initiated.
    /// <para>
    /// Default value: <b>0</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("retainedAmount")]
    public long? RetainedAmount { get; init; }

    /// <summary>
    /// The time of day when the sales day is closed in balance account time zone. The sales day closing time can be between 00:00 to 07:00.
    /// <para>
    /// Format: <b>HH:mm:ss</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("salesDayClosingTime")]
    public string? SalesDayClosingTime { get; init; }

    /// <summary>
    /// The unique identifier of the transfer instrument to which the funds are paid out.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transferInstrumentId")]
    public string? TransferInstrumentId { get; init; }
}
