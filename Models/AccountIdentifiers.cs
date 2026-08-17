using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AccountIdentifiers
{
    /// <summary>
    /// Identifiers relevant for Automated Clearing House (ACH) payments, primarily used in the United States.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ach")]
    public AchAccountIdentifier1? Ach { get; init; }

    /// <summary>
    /// Identifiers relevant for Bankers' Automated Clearing Services (BACS) payments, primarily used in the United Kingdom.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bacs")]
    public BacsAccountIdentifier2? Bacs { get; init; }

    /// <summary>
    /// Identifiers relevant for Australian banking, specifically for BSB (Bank-State-Branch) numbers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bsb")]
    public BsbAccountIdentifier2? Bsb { get; init; }

    /// <summary>
    /// Identifiers relevant for Electronic Funds Transfer (EFT) payments, commonly used in Canada.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eft")]
    public EftAccountIdentifier2? Eft { get; init; }

    /// <summary>
    /// The international bank account number as defined in the ISO-13616 standard.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iban")]
    public IbanAccountIdentifier2? Iban { get; init; }

    /// <summary>
    /// Identifiers relevant for the Rix (Russian Interbank eXchange) system, used for interbank payments within Russia.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rix")]
    public RixAccountIdentifier2? Rix { get; init; }
}
