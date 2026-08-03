using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record SweepConfigurationV2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category")]
    public Category? Category { get; init; }

    [JsonPropertyName("counterparty")]
    public required SweepCounterparty Counterparty { get; init; }

    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see> in uppercase. For example, <b>EUR</b>.
    /// <para>
    /// The sweep currency must match any of the <see href="https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__resParam_balances">balances currencies</see>.
    /// </para>
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

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
    [JsonPropertyName("id")]
    public required string Id { get; init; }

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
    public IReadOnlyList<Priority>? Priorities { get; init; }

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

    [JsonPropertyName("schedule")]
    public required SweepSchedule Schedule { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status51? Status { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sweepAmount")]
    public SweepAmount? SweepAmount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("targetAmount")]
    public TargetAmount? TargetAmount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerAmount")]
    public TriggerAmount? TriggerAmount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type7? Type { get; init; }
}
