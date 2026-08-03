using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CreateRecurringTopUp
{
    [JsonPropertyName("counterparty")]
    public required TopUpCounterparty Counterparty { get; init; }

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
    /// A reference that is sent to the recipient. This reference is also sent in all webhooks related to the transfer, so you can use it to track statuses for both parties involved in the funds movement.
    /// <para>
    ///  Supported characters: <b>a-z</b>, <b>A-Z</b>, <b>0-9</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenceForBeneficiary")]
    [StringLength(80, MinimumLength = 0)]
    public string? ReferenceForBeneficiary { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status211? Status { get; init; }

    [JsonPropertyName("topUpAmount")]
    public required TopUpAmount TopUpAmount { get; init; }

    [JsonPropertyName("trigger")]
    public required Trigger Trigger { get; init; }
}
