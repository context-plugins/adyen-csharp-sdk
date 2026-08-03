using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Content of the Reversal Request message.
/// </summary>
public record ReversalRequest2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SaleData")]
    public SaleData2? SaleData { get; init; }

    [JsonPropertyName("OriginalPOITransaction")]
    public required OriginalPoitransaction3 OriginalPoitransaction { get; init; }

    /// <summary>
    /// Amount of the payment or loyalty to reverse.
    /// ReversedAmount is implicitly equal to the AuthorizedAmount if absent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ReversedAmount")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? ReversedAmount { get; init; }

    [JsonPropertyName("ReversalReason")]
    public required ReversalReason1 ReversalReason { get; init; }
}
