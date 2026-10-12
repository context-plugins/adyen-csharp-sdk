using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Data related to the payment and loyalty transaction.
/// </summary>
public record PaymentTransaction1
{
    /// <summary>
    /// Various amounts related to the payment request from the Sale System.
    /// </summary>
    [JsonPropertyName("AmountsReq")]
    public required AmountsReq AmountsReq { get; init; }

    /// <summary>
    /// Identification of a previous POI transaction.
    /// In the Payment Request message, it allows using the card of a previous CardAcquisition or Payment request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OriginalPOITransaction")]
    public OriginalPoiTransaction? OriginalPoiTransaction { get; init; }

    /// <summary>
    /// Conditions on which the transaction must be processed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TransactionConditions")]
    public TransactionConditions? TransactionConditions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
