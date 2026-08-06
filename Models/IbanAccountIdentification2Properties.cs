using System.Text.Json.Serialization;

namespace Adyen.Models;

public record IbanAccountIdentification2Properties
{
    /// <summary>
    /// The bank's 8- or 11-character BIC or SWIFT code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bic")]
    public string? Bic { get; init; }

    /// <summary>
    /// The international bank account number as defined in the <see href="https://www.iso.org/standard/81090.html">ISO-13616</see> standard.
    /// </summary>
    [JsonPropertyName("iban")]
    public required string Iban { get; init; }

    /// <summary>
    /// <b>iban</b>
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }
}
