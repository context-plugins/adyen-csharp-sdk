using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record IbanAccountIdentification2Properties
{
    /// <summary>
    /// The IBAN of the bank account.
    /// </summary>
    [JsonPropertyName("iban")]
    [MinLength(1)]
    public required string Iban { get; init; }
}
