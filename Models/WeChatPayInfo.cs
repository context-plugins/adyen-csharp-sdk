using System.Text.Json.Serialization;

namespace Adyen.Models;

public record WeChatPayInfo
{
    /// <summary>
    /// The name of the contact person from merchant support.
    /// </summary>
    [JsonPropertyName("contactPersonName")]
    public required string ContactPersonName { get; init; }

    /// <summary>
    /// The email address of merchant support.
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; init; }
}
