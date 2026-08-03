using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Card Acquisition Request message.
/// </summary>
public record CardAcquisitionRequest2
{
    [JsonPropertyName("SaleData")]
    public required SaleData2 SaleData { get; init; }

    [JsonPropertyName("CardAcquisitionTransaction")]
    public required CardAcquisitionTransaction CardAcquisitionTransaction { get; init; }
}
