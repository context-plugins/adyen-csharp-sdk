using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AdminRequest3
{
    /// <summary>
    /// Identification of the administrative service to process.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ServiceIdentification")]
    [RegularExpression("^.+$")]
    public string? ServiceIdentification { get; init; }
}
