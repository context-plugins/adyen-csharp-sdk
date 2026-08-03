using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The response payload of the Adyen Terminal API.
/// </summary>
public record TerminalApiresponse
{
    [JsonPropertyName("SaleToPOIResponse")]
    public required SaleToPoiresponse2 SaleToPoiresponse { get; init; }
}
