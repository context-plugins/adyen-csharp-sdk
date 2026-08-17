using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ProfileRegistrationResponse
{
    /// <summary>
    /// A short-lived URL that redirects the user to the iDEAL profile registration page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirectUrl")]
    public Href5? RedirectUrl { get; init; }
}
