using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// The response payload of the Adyen Terminal API.
/// </summary>
public record TerminalApiResponse
{
    /// <summary>
    /// The SaleToPOIResponse message pair is a container for the response message content. It contains a MessageHeader and a message body.
    /// </summary>
    [JsonPropertyName("SaleToPOIResponse")]
    public required SaleToPoiResponse SaleToPoiResponse { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
