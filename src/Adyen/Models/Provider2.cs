using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Metadata about the selected provider, including the name and company logo. You can use this information to inform the user about the provider they will be redirected to when they select the link.
/// </summary>
public record Provider2
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
