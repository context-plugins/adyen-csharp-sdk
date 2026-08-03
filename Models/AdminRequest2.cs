using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Admin Request message.
/// </summary>
public record AdminRequest2
{
    /// <summary>
    /// Identification of the administrative service to process.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ServiceIdentification")]
    [RegularExpression("^.+$")]
    public string? ServiceIdentification { get; init; }
}
