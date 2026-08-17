using System.Text.Json.Serialization;

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
}
