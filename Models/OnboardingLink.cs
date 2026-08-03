using System.Text.Json.Serialization;

namespace Adyen.Models;

public record OnboardingLink
{
    /// <summary>
    /// The URL of the hosted onboarding page where you need to redirect your user. This URL:
    /// <list type="bullet">
    ///   <item><description>Expires after 4 minutes.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Can only be used once.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Can only be clicked once by the user.</description></item>
    /// </list>
    /// <para>
    /// If the link expires, you need to create a new link.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }
}
