using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ForceRebootDetails
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type210? Type { get; init; }
}
