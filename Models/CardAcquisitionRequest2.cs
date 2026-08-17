using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Card Acquisition Request message.
/// </summary>
public record CardAcquisitionRequest2
{
    /// <summary>
    /// Data related to the Sale System.
    /// </summary>
    [JsonPropertyName("SaleData")]
    public required SaleData1 SaleData { get; init; }

    /// <summary>
    /// Data related to the payment and loyalty card acquisition.
    /// </summary>
    [JsonPropertyName("CardAcquisitionTransaction")]
    public required CardAcquisitionTransaction1 CardAcquisitionTransaction { get; init; }
}
