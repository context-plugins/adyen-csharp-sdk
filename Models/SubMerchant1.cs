using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SubMerchant1
{
    /// <summary>
    /// The city of the sub-merchant's address.
    /// * Format: Alphanumeric
    /// * Maximum length: 13 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    public string? City { get; init; }

    /// <summary>
    /// The three-letter country code of the sub-merchant's address. For example, <b>BRA</b> for Brazil.
    /// * Format: <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3">ISO 3166-1 alpha-3</see>
    /// * Fixed length: 3 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public string? Country { get; init; }

    /// <summary>
    /// The sub-merchant's 4-digit Merchant Category Code (MCC).
    /// * Format: Numeric
    /// * Fixed length: 4 digits
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mcc")]
    public string? Mcc { get; init; }

    /// <summary>
    /// The name of the sub-merchant. Based on scheme specifications, this value will overwrite the shopper statement  that will appear in the card statement.
    /// * Format: Alphanumeric
    /// * Maximum length: 22 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The tax ID of the sub-merchant.
    /// * Format: Numeric
    /// * Fixed length: 11 digits for the CPF or 14 digits for the CNPJ
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxId")]
    public string? TaxId { get; init; }
}
