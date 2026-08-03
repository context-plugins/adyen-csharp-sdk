using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record GetTaxFormResponse1
{
    /// <summary>
    /// The content of the tax form in Base64 format.
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contentType")]
    public ContentType? ContentType { get; init; }
}
