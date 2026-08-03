using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record WebDataExemption
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public Reason1? Reason { get; init; }
}
