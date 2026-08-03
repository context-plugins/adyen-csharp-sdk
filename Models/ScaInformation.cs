using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ScaInformation
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exemption")]
    public ScaExemption? Exemption { get; init; }

    [JsonPropertyName("status")]
    public required ScaStatus Status { get; init; }
}
