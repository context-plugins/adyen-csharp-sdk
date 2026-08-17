using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains the card user's password and mobile phone number. This is required when you issue cards that can be used to make online payments within the EEA and the UK, or can be added to digital wallets. Refer to <see href="https://docs.adyen.com/issuing/3d-secure-and-wallets">3D Secure and digital wallets</see> for more information.
/// </summary>
public record Authentication1
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

    /// <summary>
    /// The phone number where the one-time password (OTP) is sent.
    /// <para>
    /// This object must have:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>A <c>type</c> set to <b>mobile</b>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>A <c>number</c> with a valid country code.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>A <c>number</c> with more than 4 digits, excluding the country code.</description></item>
    /// </list>
    /// <para>
    /// &gt;Make sure to verify that the card user owns the phone number.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public Phone11? Phone { get; init; }
}
