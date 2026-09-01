using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record IdealAuthLinkResponse
{
    /// <summary>
    /// A short-lived URL that redirects the user to the iDEAL profile management page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirectUrl")]
    public Href3? RedirectUrl { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
