using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record SubjectErasureResponse
{
    /// <summary>
    /// The result of this operation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("result")]
    public Result2? Result { get; init; }
}
