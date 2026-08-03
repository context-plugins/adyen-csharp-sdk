using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Sale information intended for the Issuer.
/// The POI System receives this information and sends it to the Acquirer for the Issuer without any change.
/// </summary>
public record SaleToIssuerData
{
    /// <summary>
    /// Label to print on the bank statement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("StatementReference")]
    [RegularExpression("^.+$")]
    public string? StatementReference { get; init; }
}
