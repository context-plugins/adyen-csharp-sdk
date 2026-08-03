using System.Text.Json.Serialization;

namespace Adyen.Models;

public record LocalShopperStatement
{
    /// <summary>
    /// The character set of the local shopper statement.
    /// <para>
    /// Possible values: <b>ja-Hani</b>, <b>ja-Kana</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("script")]
    public required string Script { get; init; }

    /// <summary>
    /// The text of the local shopper statement in the specified character set.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; init; }
}
