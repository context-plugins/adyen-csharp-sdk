using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record SubjectErasureResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("result")]
    public Result2? Result { get; init; }
}
