using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Information for the Strong Customer Authentication (SCA)
/// </summary>
public record ScaInformation1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exemption")]
    public ScaExemption? Exemption { get; init; }

    [JsonPropertyName("status")]
    public required ScaStatus Status { get; init; }
}
