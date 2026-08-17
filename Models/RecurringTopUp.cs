using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record RecurringTopUp
{
    /// <summary>
    /// The details about the counterparty that is funding the top-up.
    /// </summary>
    [JsonPropertyName("counterparty")]
    public required TopUpCounterparty1 Counterparty { get; init; }

    /// <summary>
    /// Your description for the recurring top-up.
    /// <para>
    /// Maximum length is 140 characters. If you set a longer description, it will be cut off at 140 characters.
    /// </para>
    /// </summary>
    [JsonPropertyName("description")]
    [StringLength(140, MinimumLength = 0)]
    public required string Description { get; init; }

    /// <summary>
    /// The unique identifier of the top up.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// A reference that is sent to the recipient. This reference is also sent in all webhooks related to the transfer, so you can use it to track statuses for both parties involved in the funds movement.
    /// <para>
    ///  Supported characters: <b>a-z</b>, <b>A-Z</b>, <b>0-9</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenceForBeneficiary")]
    [StringLength(80, MinimumLength = 0)]
    public string? ReferenceForBeneficiary { get; init; }

    /// <summary>
    /// The status of the recurring top-up. If not provided, by default, this is set to <b>active</b>.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>active</b>:  the top up is enabled and funds will be pulled in.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>inactive</b>: the top up is disabled and cannot be triggered.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status6? Status { get; init; }

    /// <summary>
    /// The currency and value to be added to the balance account, specified in minor units. This can be a fixed amount or a target amount.
    /// </summary>
    [JsonPropertyName("topUpAmount")]
    public required TopUpAmount1 TopUpAmount { get; init; }

    /// <summary>
    /// The condition that triggers the top-up. This can be a recurring schedule or a minimum balance threshold.
    /// </summary>
    [JsonPropertyName("trigger")]
    public required Trigger1 Trigger { get; init; }
}
