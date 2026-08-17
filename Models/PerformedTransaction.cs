using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

public record PerformedTransaction
{
    /// <summary>
    /// Result of a message request processing.
    /// If Result is Success, <c>ErrorCondition</c> is absent or not used in the processing of the message. In the other cases, the <c>ErrorCondition</c> has to be present and can refine the processing of the message response. <c>AdditionalResponse</c> gives more information about the success or the failure of the message request processing, for logging without real time involvements.
    /// </summary>
    [JsonPropertyName("Response")]
    public required Response1 Response { get; init; }

    /// <summary>
    /// Data associated with the Sale System, with a particular value during the processing of the payment by the POI, including the cards acquisition.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SaleData")]
    public SaleData? SaleData { get; init; }

    /// <summary>
    /// Data related to the POI System.
    /// In the Message Response, identification of the POI transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("POIData")]
    public PoiData? PoiData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentResult")]
    public PaymentResult1? PaymentResult { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyResult")]
    public IReadOnlyList<LoyaltyResult>? LoyaltyResult { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ReversedAmount")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? ReversedAmount { get; init; }
}
