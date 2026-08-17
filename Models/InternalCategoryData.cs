using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record InternalCategoryData
{
    /// <summary>
    /// The capture's merchant reference included in the transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modificationMerchantReference")]
    public string? ModificationMerchantReference { get; init; }

    /// <summary>
    /// The capture reference included in the transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modificationPspReference")]
    public string? ModificationPspReference { get; init; }

    /// <summary>
    /// <b>internal</b>
    /// </summary>
    [JsonPropertyName("type")]
    public Type411? Type { get; init; } = Type411.Internal;
}
