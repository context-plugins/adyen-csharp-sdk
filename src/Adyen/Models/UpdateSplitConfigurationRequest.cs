using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UpdateSplitConfigurationRequest
{
    /// <summary>
    /// Your description for the split configuration.
    /// </summary>
    [JsonPropertyName("description")]
    [MaxLength(300)]
    public required string Description { get; init; }
}
