using System.Text.Json.Serialization;
using Adyen.Models.AnyOf;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PatchableDisputeRequest
{
    /// <summary>
    /// Additional information for raising a dispute of <c>type</c> <b>duplicate</b>. Required for disputes of <c>type</c> <b>duplicate</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("duplicateInfo")]
    public DuplicateInfo3? DuplicateInfo { get; init; }

    /// <summary>
    /// Additional information for raising a dispute of <c>type</c> <b>fraud</b>. Required for disputes of <c>type</c> <b>fraud</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudInfo")]
    public FraudInfo3? FraudInfo { get; init; }

    /// <summary>
    /// Additional information for raising a dispute of <c>type</c> <b>notDelivered</b>. Required for disputes of <c>type</c> <b>notDelivered</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notDeliveredInfo")]
    public NotDeliveredInfo3? NotDeliveredInfo { get; init; }

    /// <summary>
    /// Additional information for raising a dispute of <c>type</c> <b>other</b>. Required for disputes of <c>type</c> <b>other</b>.
    /// <para>
    /// <b>Note:</b> The <b>other</b> dispute <c>type</c> is currently in beta testing. Do not create or submit any disputes for this dispute <c>type</c> at this time.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("otherInfo")]
    public OtherInfo3? OtherInfo { get; init; }

    /// <summary>
    /// The current status of the dispute.
    /// <para>
    /// When you create a dispute, you can only set the <c>status</c> to <b>draft</b>. When you update a dispute, you can set the <c>status</c> to <b>submitted</b> or <b>closed</b>.
    /// </para>
    /// <para>
    /// Possible values: <b>draft</b>, <b>submitted</b>, <b>closed</b>, <b>won</b>, <b>chargeback</b>, <b>secondPresentment</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status? Status { get; init; }
}
