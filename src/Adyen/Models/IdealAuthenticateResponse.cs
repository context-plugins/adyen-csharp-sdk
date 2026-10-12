using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record IdealAuthenticateResponse
{
    /// <summary>
    /// A short-lived URL that redirects the user to the iDEAL page that is required for authentication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirectUrl")]
    public Href4? RedirectUrl { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
