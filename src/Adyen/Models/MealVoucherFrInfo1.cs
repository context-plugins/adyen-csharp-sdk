using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>mealVoucher_FR</b>.
/// </summary>
public record MealVoucherFrInfo1
{
    /// <summary>
    /// Meal Voucher conecsId. Format: digits only
    /// </summary>
    [JsonPropertyName("conecsId")]
    public required string ConecsId { get; init; }

    /// <summary>
    /// Meal Voucher siret. Format: 14 digits.
    /// </summary>
    [JsonPropertyName("siret")]
    [StringLength(14, MinimumLength = 14)]
    public required string Siret { get; init; }

    /// <summary>
    /// The list of additional payment methods. Allowed values: <b>mealVoucher_FR_endenred</b>, <b>mealVoucher_FR_groupeup</b>, <b>mealVoucher_FR_natixis</b>, <b>mealVoucher_FR_sodexo</b>.
    /// </summary>
    [JsonPropertyName("subTypes")]
    public required IReadOnlyList<string> SubTypes { get; init; }
}
