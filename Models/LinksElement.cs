using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The link to the first page of the list., The link to the last page of the list., The link to the next page of the list., The link to the previous page of the list., The link to the list page you are currently viewing., Contains a link to the previous page., Contains a link to the next page.
/// </summary>
public record LinksElement
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }
}
