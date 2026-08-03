using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Result of a message request processing.
/// </summary>
public record Response11
{
    [JsonPropertyName("Result")]
    public required Result11 Result { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ErrorCondition")]
    public ErrorCondition1? ErrorCondition { get; init; }

    /// <summary>
    /// Additional information related to processing status of a message request.
    /// If present, the POI logs it for further examination.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AdditionalResponse")]
    [RegularExpression("^.+$")]
    public string? AdditionalResponse { get; init; }
}
