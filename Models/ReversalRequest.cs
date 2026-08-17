using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// It conveys Information related to the reversal of a previous payment or a loyalty transaction.
/// Content of the Reversal Request message.
/// </summary>
public record ReversalRequest
{
    /// <summary>
    /// Data associated with the Sale System, with a particular value during the processing of the payment by the POI, including the cards acquisition.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SaleData")]
    public SaleData? SaleData { get; init; }

    /// <summary>
    /// Identification of a previous POI transaction.
    /// </summary>
    [JsonPropertyName("OriginalPOITransaction")]
    public required OriginalPoiTransaction2 OriginalPoiTransaction { get; init; }

    /// <summary>
    /// Amount of the payment or loyalty to reverse.
    /// ReversedAmount is implicitly equal to the AuthorizedAmount if absent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ReversedAmount")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? ReversedAmount { get; init; }

    /// <summary>
    /// Reason of the payment or loyalty reversal.
    /// Possible values:
    /// * <b>CustCancel</b>
    /// * <b>Malfunction</b>
    /// * <b>MerchantCancel</b>
    /// * <b>Unable2Compl</b>
    /// </summary>
    [JsonPropertyName("ReversalReason")]
    public required ReversalReason1 ReversalReason { get; init; }
}
