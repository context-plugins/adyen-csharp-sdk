using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PatchableCreateRecurringTopUp
{
    /// <summary>
    /// Your description for the recurring top-up.
    /// <para>
    /// Maximum length is 140 characters. If you set a longer description, it will be cut off at 140 characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [StringLength(140, MinimumLength = 0)]
    public string? Description { get; init; }

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
    public object? Status { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("topUpAmount")]
    public PatchableTopUpAmount? TopUpAmount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trigger")]
    public PatchableTrigger? Trigger { get; init; }
}
