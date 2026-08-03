using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GetTaxFormRequest
{
    /// <summary>
    /// The account holder code you provided when you created the account holder.
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }

    /// <summary>
    /// Type of the requested tax form. For example, 1099-K.
    /// </summary>
    [JsonPropertyName("formType")]
    public required string FormType { get; init; }

    /// <summary>
    /// Applicable tax year in the YYYY format.
    /// </summary>
    [JsonPropertyName("year")]
    public required int Year { get; init; }
}
