using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Empty.
/// Content of the Custom Admin Request message.
/// </summary>
public record AdminRequest
{
    /// <summary>
    /// Identification of the administrative service to process.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ServiceIdentification")]
    [RegularExpression("^.+$")]
    public string? ServiceIdentification { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
