using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ProfileRegistrationResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirectUrl")]
    public Href? RedirectUrl { get; init; }
}
