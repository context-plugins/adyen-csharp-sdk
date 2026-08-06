using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record IbanAccountIdentificationProperties
{
    /// <summary>
    /// The IBAN of the bank account.
    /// </summary>
    [JsonPropertyName("iban")]
    [MinLength(1)]
    public required string Iban { get; init; }
}
