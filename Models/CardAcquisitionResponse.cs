using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// It conveys Information related to the payment and loyalty cards read and processed by the POI System and entered by the Customer.
/// Content of the Card Acquisition Response message.
/// </summary>
public record CardAcquisitionResponse
{
    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }

    [JsonPropertyName("SaleData")]
    public required SaleData2 SaleData { get; init; }

    [JsonPropertyName("POIData")]
    public required Poidata2 Poidata { get; init; }

    /// <summary>
    /// Type of payment card.
    /// Brands available for payment by the card and not chosen by the Customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentBrand")]
    public IReadOnlyList<string>? PaymentBrand { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentInstrumentData")]
    public PaymentInstrumentData2? PaymentInstrumentData { get; init; }

    /// <summary>
    /// Data related to the loyalty System.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyAccount")]
    public IReadOnlyList<LoyaltyAccount>? LoyaltyAccount { get; init; }
}
