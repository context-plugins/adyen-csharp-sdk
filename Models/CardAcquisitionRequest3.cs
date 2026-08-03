using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CardAcquisitionRequest3
{
    [JsonPropertyName("SaleData")]
    public required SaleData2 SaleData { get; init; }

    [JsonPropertyName("CardAcquisitionTransaction")]
    public required CardAcquisitionTransaction CardAcquisitionTransaction { get; init; }
}
