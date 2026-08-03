using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The international bank account number as defined in the ISO-13616 standard.
/// </summary>
public record IbanaccountIdentifier2
{
    /// <summary>
    /// The Basic Bank Account Number (BBAN) component of the IBAN.
    /// </summary>
    [JsonPropertyName("bban")]
    public required string Bban { get; init; }

    /// <summary>
    /// BIC of a bank account.
    /// </summary>
    [JsonPropertyName("bic")]
    public required string Bic { get; init; }

    /// <summary>
    /// The international bank account number as defined in the <see href="https://www.iso.org/standard/81090.html">ISO-13616</see> standard. This is the national identifier for the bank account, following the country-specific format, and is part of the full IBAN.
    /// </summary>
    [JsonPropertyName("iban")]
    public required string Iban { get; init; }
}
