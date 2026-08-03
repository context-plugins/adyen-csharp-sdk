using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PinChangeResponse
{
    [JsonPropertyName("status")]
    public required Status13 Status { get; init; }
}
