using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The work phone number provided by the cardholder. The phone number must consist of a country code, followed by the number. If the value you provide does not follow the guidelines, we do not submit it for authentication.
/// &gt; Required for Visa and JCB transactions that require 3D Secure 2 authentication, if you did not include the <c>shopperEmail</c>, and did not send the shopper's phone number in <c>telephoneNumber</c>.
/// </summary>
public record Phone21
{
    /// <summary>
    /// Country code. Length: 1–3 digits.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cc")]
    [StringLength(3, MinimumLength = 1)]
    public string? Cc { get; init; }

    /// <summary>
    /// Subscriber number. Length: 4-15  digits.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscriber")]
    [MaxLength(15)]
    public string? Subscriber { get; init; }
}
