using System.Text.Json.Serialization;

namespace Adyen.Models;

public record IdealAuthLinkResponse
{
    /// <summary>
    /// A short-lived URL that redirects the user to the iDEAL profile management page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirectUrl")]
    public Href3? RedirectUrl { get; init; }
}
