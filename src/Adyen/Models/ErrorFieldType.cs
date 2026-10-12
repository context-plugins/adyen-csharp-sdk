using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ErrorFieldType
{
    /// <summary>
    /// The validation error code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorCode")]
    public int? ErrorCode { get; init; }

    /// <summary>
    /// A description of the validation error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorDescription")]
    public string? ErrorDescription { get; init; }

    /// <summary>
    /// The type of error field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fieldType")]
    public FieldType? FieldType { get; init; }
}
