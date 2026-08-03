using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AuthenticationSessionRequest
{
    /// <summary>
    /// The URL where the component will appear. In your live environment, you must protect the URL with an SSL certificate and ensure that it starts with <c>https://</c>.
    /// </summary>
    [JsonPropertyName("allowOrigin")]
    public required string AllowOrigin { get; init; }

    [JsonPropertyName("policy")]
    public required Policy Policy { get; init; }

    [JsonPropertyName("product")]
    public required ProductType21 Product { get; init; }
}
