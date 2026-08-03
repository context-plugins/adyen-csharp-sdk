using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Provider
{
    /// <summary>
    /// The URL of the organization's or brand's logo. This URL typically points to an image file (e.g., .png, .jpg, .svg) that can be displayed to visually represent the entity.
    /// </summary>
    [JsonPropertyName("logoURL")]
    [MinLength(1)]
    public required string LogoUrl { get; init; }

    /// <summary>
    /// The official or commonly used name of the organization, brand, or entity.
    /// </summary>
    [JsonPropertyName("name")]
    [MinLength(1)]
    public required string Name { get; init; }
}
