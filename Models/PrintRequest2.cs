using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Print Request message.
/// </summary>
public record PrintRequest2
{
    /// <summary>
    /// Information to print and how to process it.
    /// </summary>
    [JsonPropertyName("PrintOutput")]
    public required PrintOutput2 PrintOutput { get; init; }
}
