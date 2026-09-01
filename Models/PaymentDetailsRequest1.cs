using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record PaymentDetailsRequest1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("method")]
    public string? Method { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
