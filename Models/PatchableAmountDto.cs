using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Required if <c>type</c> is <b>business</b>, <b>assetSale</b>, <b>gamblingWinnings</b> or <b>inheritance</b>.
/// <para>
/// For <c>type</c> <b>business</b>, provide the annual turn over of the business. For <c>type</c> <b>assetSale</b>, <b>gamblingWinnings</b> or <b>inheritance</b>, provide the amount of the funds., The amount of the funds the financier provided., The maximum amount a card holder can withdraw per day.
/// </para>
/// </summary>
public record PatchableAmountDto
{
    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public string? Currency { get; init; }

    /// <summary>
    /// The amount of the transaction, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public long? Value { get; init; }
}
