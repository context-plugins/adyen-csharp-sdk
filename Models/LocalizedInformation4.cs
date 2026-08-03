using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The localized information of the store.
/// </summary>
public record LocalizedInformation4
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
