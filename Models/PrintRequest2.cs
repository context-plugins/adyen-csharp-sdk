using System.Text.Json.Serialization;
using Adyen.Core.Models;

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
