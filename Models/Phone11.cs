using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

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
public record Phone11
{
    /// <summary>
    /// The full phone number provided as a single string.
    /// For example, <b>"0031 6 11 22 33 44"</b>, <b>"+316/1122-3344"</b>,
    /// <para>
    ///  or <b>"(0031) 611223344"</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("number")]
    public required string Number { get; init; }

    /// <summary>
    /// Type of phone number.
    /// Possible values:
    /// <b>Landline</b>, <b>Mobile</b>.
    /// </summary>
    [JsonPropertyName("type")]
    public required Type410 Type { get; init; }
}
