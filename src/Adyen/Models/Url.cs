using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Url
{
    /// <summary>
    /// Indicates if the message sent to this URL should be encrypted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; init; }

    /// <summary>
    /// The password for authentication of the notifications.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("password")]
    public string? Password { get; init; }

    /// <summary>
    /// The URL in the format: http(s)://domain.com.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? UrlValue { get; init; }

    /// <summary>
    /// The username for authentication of the notifications.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("username")]
    public string? Username { get; init; }
}
