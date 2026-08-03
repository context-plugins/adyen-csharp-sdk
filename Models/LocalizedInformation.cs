using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record LocalizedInformation
{
    /// <summary>
    /// An array of local shopper statements. Card schemes use this in the bank statement.
    /// <para>
    /// For Japan local shopper statements in both ja-Hani and ja-Kana are required.
    /// </para>
    /// </summary>
    [JsonPropertyName("localShopperStatement")]
    public required IReadOnlyList<LocalShopperStatement> LocalShopperStatement { get; init; }
}
