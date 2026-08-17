using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record UpdateSweepConfigurationV2
{
    /// <summary>
    /// The type of transfer that results from the sweep.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>bank</b>: Sweep to a <see href="https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id">transfer instrument</see>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>internal</b>: Transfer to another <see href="https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/balanceAccounts__resParam_id">balance account</see> within your platform.</description></item>
    /// </list>
    /// <para>
    /// Required when setting <c>priorities</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category")]
    public Category1? Category { get; init; }

    /// <summary>
    /// The destination or the source of the funds, depending on the sweep <c>type</c>.
    /// <para>
    /// Either a <c>balanceAccountId</c>, <c>transferInstrumentId</c>, or <c>merchantAccount</c> is required.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("counterparty")]
    public SweepCounterparty1? Counterparty { get; init; }

    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see> in uppercase. For example, <b>EUR</b>.
    /// <para>
    /// The sweep currency must match any of the <see href="https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__resParam_balances">balances currencies</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public string? Currency { get; init; }

    /// <summary>
    /// The message that will be used in the sweep transfer's description body with a maximum length of 140 characters.
    /// <para>
    /// If the message is longer after replacing placeholders, the message will be cut off at 140 characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The unique identifier of the sweep.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The list of priorities for the bank transfer. This sets the speed at which the transfer is sent and the fees that you have to pay. You can provide multiple priorities, ordered by your preference. Adyen will try to pay out using the priorities in the given order. If the first priority is not currently supported or enabled for your platform, the system will try the next one, and so on.
    /// <para>
    /// The request will be accepted as long as <b>at least one</b> of the provided priorities is valid (i.e., supported by Adyen and activated for your platform). For example, if you provide <c>["wire","regular"]</c>, and <c>wire</c> is not supported but <c>regular</c> is, the request will still be accepted and processed.
    /// </para>
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>regular</b>: For normal, low-value transactions.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>fast</b>: A faster way to transfer funds, but the fees are higher. Recommended for high-priority, low-value transactions.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>wire</b>: The fastest way to transfer funds, but this has the highest fees. Recommended for high-priority, high-value transactions.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>instant</b>: For instant funds transfers within the United States and in <see href="https://www.ecb.europa.eu/paym/integration/retail/sepa/html/index.en.html">SEPA locations</see>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>crossBorder</b>: For high-value transfers to a recipient in a different country.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>internal</b>: For transfers to an Adyen-issued business bank account (by bank account number/IBAN).</description></item>
    /// </list>
    /// <para>
    /// Set <c>category</c> to <b>bank</b>. For more details, see optional priorities setup for <see href="https://docs.adyen.com/marketplaces/payout-to-users/scheduled-payouts#optional-priorities-setup">marketplaces</see> or <see href="https://docs.adyen.com/platforms/payout-to-users/scheduled-payouts#optional-priorities-setup">platforms</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("priorities")]
    public IReadOnlyList<Priority1>? Priorities { get; init; }

    /// <summary>
    /// The reason for disabling the sweep.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public Reason? Reason { get; init; }

    /// <summary>
    /// The human readable reason for disabling the sweep.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reasonDetail")]
    public string? ReasonDetail { get; init; }

    /// <summary>
    /// Your reference for the sweep configuration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    [MaxLength(80)]
    public string? Reference { get; init; }

    /// <summary>
    /// The reference sent to or received from the counterparty. Only alphanumeric characters are allowed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenceForBeneficiary")]
    [MaxLength(80)]
    public string? ReferenceForBeneficiary { get; init; }

    /// <summary>
    /// The schedule when the <c>triggerAmount</c> is evaluated. If the balance meets the threshold, funds are pushed out of or pulled in to the balance account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schedule")]
    public SweepSchedule1? Schedule { get; init; }

    /// <summary>
    /// The status of the sweep. If not provided, by default, this is set to <b>active</b>.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>active</b>:  the sweep is enabled and funds will be pulled in or pushed out based on the defined configuration.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>inactive</b>: the sweep is disabled and cannot be triggered.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status6? Status { get; init; }

    /// <summary>
    /// The amount that must be pushed out or pulled in. You can configure either <c>sweepAmount</c> or <c>targetAmount</c>, not both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sweepAmount")]
    public Amount17? SweepAmount { get; init; }

    /// <summary>
    /// The amount that must be available in the balance account after the sweep. You can configure either <c>sweepAmount</c> or <c>targetAmount</c>, not both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("targetAmount")]
    public Amount17? TargetAmount { get; init; }

    /// <summary>
    /// The threshold amount that triggers the sweep. If not provided, by default, the amount is set to zero. The <c>triggerAmount</c> is evaluated according to the specified <c>schedule.type</c>.
    /// <list type="bullet">
    ///   <item><description>For <c>type</c> <b>pull</b>, if the balance is less than or equal to the <c>triggerAmount</c>, funds are pulled in to the balance account.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>For <c>type</c> <b>push</b>, if the balance is more than or equal to the <c>triggerAmount</c>, funds are pushed out of the balance account.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerAmount")]
    public Amount17? TriggerAmount { get; init; }

    /// <summary>
    /// The direction of sweep, whether pushing out or pulling in funds to the balance account. If not provided, by default, this is set to <b>push</b>.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>push</b>: _push out funds_ to a destination balance account or transfer instrument.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>pull</b>: _pull in funds_ from a source merchant account, transfer instrument, or balance account.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("type")]
    public Type72? Type { get; init; } = Type72.Push;
}
