using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AmountAdjustment
{
    /// <summary>
    /// The adjustment amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount17? Amount { get; init; }

    /// <summary>
    /// The type of markup that is applied to an authorised payment.
    /// <para>
    /// Possible values: <b>exchange</b>, <b>forexMarkup</b>, <b>authHoldReserve</b>, <b>atmMarkup</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amountAdjustmentType")]
    public AmountAdjustmentType? AmountAdjustmentType { get; init; }

    /// <summary>
    /// The basepoints associated with the applied markup.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("basepoints")]
    public int? Basepoints { get; init; }
}
