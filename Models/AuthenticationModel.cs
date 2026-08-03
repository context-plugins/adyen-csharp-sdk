using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AuthenticationModel
{
    /// <summary>
    /// The email address where the one-time password (OTP) is sent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    /// <summary>
    /// The password used for 3D Secure password-based authentication. The value must be between 1 to 30 characters and must only contain the following supported characters.
    /// <list type="bullet">
    ///   <item><description>Characters between <b>a-z</b>, <b>A-Z</b>, and <b>0-9</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Special characters: <b>äöüßÄÖÜ+-*/ç%()=?!~#'",;:$&amp;àùòâôûáúó</b></description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("password")]
    [StringLength(30, MinimumLength = 1)]
    public string? Password { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public Phone? Phone { get; init; }
}
