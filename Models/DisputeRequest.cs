using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record DisputeRequest
{
    /// <summary>
    /// Your description for the dispute.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [StringLength(50, MinimumLength = 0)]
    public string? Description { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disputedAmount")]
    public DisputedAmount? DisputedAmount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("duplicateInfo")]
    public DuplicateInfo? DuplicateInfo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudInfo")]
    public FraudInfo? FraudInfo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notDeliveredInfo")]
    public NotDeliveredInfo? NotDeliveredInfo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("otherInfo")]
    public OtherInfo? OtherInfo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public DisputeStatus1? Status { get; init; }

    /// <summary>
    /// The unique reference of the transaction for which you are raising the dispute.
    /// </summary>
    [JsonPropertyName("transactionId")]
    [MinLength(1)]
    public required string TransactionId { get; init; }

    /// <summary>
    /// The type of the dispute.
    /// <para>
    /// Possible values: <b>duplicate</b>, <b>fraud</b>, <b>notDelivered</b>, <b>other</b>.
    /// </para>
    /// <para>
    /// <b>Note:</b> The <b>other</b> dispute <c>type</c> is currently in beta testing. Do not create or submit any disputes for this dispute <c>type</c> at this time.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }
}
