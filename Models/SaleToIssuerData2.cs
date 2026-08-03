using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SaleToIssuerData2
{
    /// <summary>
    /// Label to print on the bank statement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("StatementReference")]
    [RegularExpression("^.+$")]
    public string? StatementReference { get; init; }
}
