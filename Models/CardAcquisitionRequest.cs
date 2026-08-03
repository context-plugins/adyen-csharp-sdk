using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// It conveys Information related to the payment and loyalty cards to read and analyse. This message pair is usually followed by a message pair (e.g. payment or loyalty) which refers to this Card Acquisition message pair.
/// Content of the Card Acquisition Request message.
/// </summary>
public record CardAcquisitionRequest
{
    [JsonPropertyName("SaleData")]
    public required SaleData2 SaleData { get; init; }

    [JsonPropertyName("CardAcquisitionTransaction")]
    public required CardAcquisitionTransaction CardAcquisitionTransaction { get; init; }
}
