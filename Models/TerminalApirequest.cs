using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The request payload of the Adyen Terminal API.
/// </summary>
public record TerminalApirequest
{
    [JsonPropertyName("SaleToPOIRequest")]
    public required SaleToPoirequest2 SaleToPoirequest { get; init; }
}
