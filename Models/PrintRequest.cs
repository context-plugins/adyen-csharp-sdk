using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Print Request message.
/// It conveys the complete data to print and how to process the print.
/// </summary>
public record PrintRequest
{
    [JsonPropertyName("PrintOutput")]
    public required PrintOutput PrintOutput { get; init; }
}
