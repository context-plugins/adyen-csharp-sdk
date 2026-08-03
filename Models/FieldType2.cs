using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record FieldType2
{
    /// <summary>
    /// The full name of the property.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field")]
    public string? Field { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fieldName")]
    public FieldName? FieldName { get; init; }

    /// <summary>
    /// The code of the shareholder that the field belongs to. If empty, the field belongs to an account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shareholderCode")]
    public string? ShareholderCode { get; init; }
}
