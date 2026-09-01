using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Sale information intended for the Issuer.
/// Send to the Acquirer if present.
/// </summary>
public record SaleToIssuerData1
{
    /// <summary>
    /// Label to print on the bank statement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("StatementReference")]
    [RegularExpression("^.+$")]
    public string? StatementReference { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
