using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Phone
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

    [JsonPropertyName("type")]
    public required Type4 Type { get; init; }
}
