using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// It conveys Information related to the payment and loyalty cards to read and analyse. This message pair is usually followed by a message pair (e.g. payment or loyalty) which refers to this Card Acquisition message pair.
/// Content of the Card Acquisition Request message.
/// </summary>
public record CardAcquisitionRequest
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
