using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Content of the Card Acquisition Response message.
/// </summary>
public record CardAcquisitionResponse2
{
    /// <summary>
    /// Result of a message request processing.
    /// </summary>
    [JsonPropertyName("Response")]
    public required Response11 Response { get; init; }

    /// <summary>
    /// Data related to the Sale System.
    /// </summary>
    [JsonPropertyName("SaleData")]
    public required SaleData1 SaleData { get; init; }

    /// <summary>
    /// Data related to the POI System.
    /// </summary>
    [JsonPropertyName("POIData")]
    public required PoiData1 PoiData { get; init; }

    /// <summary>
    /// Type of payment card.
    /// Brands available for payment by the card and not chosen by the Customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentBrand")]
    public IReadOnlyList<string>? PaymentBrand { get; init; }

    /// <summary>
    /// Data related to the instrument of payment for the transaction.
    /// If this type of payment card is configured to send information if the CardAcquisition response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentInstrumentData")]
    public PaymentInstrumentData1? PaymentInstrumentData { get; init; }

    /// <summary>
    /// Data related to the loyalty System.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyAccount")]
    public IReadOnlyList<LoyaltyAccount>? LoyaltyAccount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
