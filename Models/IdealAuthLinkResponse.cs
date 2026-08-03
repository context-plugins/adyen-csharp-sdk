using System.Text.Json.Serialization;

namespace Adyen.Models;

public record IdealAuthLinkResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirectUrl")]
    public Href? RedirectUrl { get; init; }
}
