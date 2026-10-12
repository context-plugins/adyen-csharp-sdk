using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// The request payload of the Adyen Terminal API.
/// </summary>
public record TerminalApiRequest
{
    /// <summary>
    /// The SaleToPOIRequest message pair is a container for the request message content. It contains a MessageHeader and a message body.
    /// </summary>
    [JsonPropertyName("SaleToPOIRequest")]
    public required SaleToPoiRequest SaleToPoiRequest { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
