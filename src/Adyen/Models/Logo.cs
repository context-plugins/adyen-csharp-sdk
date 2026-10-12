using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Logo
{
    /// <summary>
    /// The image file, converted to a Base64-encoded string, of the logo to be shown on the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    [MaxLength(350000)]
    public string? Data { get; init; }
}
