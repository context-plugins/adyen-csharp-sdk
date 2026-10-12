using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record MealVoucherFrResponseInfo
{
    /// <summary>
    /// Meal Voucher conecsId.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("conecsId")]
    public string? ConecsId { get; init; }

    /// <summary>
    /// Meal Voucher siret.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("siret")]
    public string? Siret { get; init; }

    /// <summary>
    /// The list of additional payment methods.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subTypes")]
    public IReadOnlyList<string>? SubTypes { get; init; }
}
