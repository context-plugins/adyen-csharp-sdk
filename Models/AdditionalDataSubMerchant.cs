using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AdditionalDataSubMerchant
{
    /// <summary>
    /// Required for transactions performed by registered payment facilitators. Indicates the number of sub-merchants contained in the request. For example, <b>3</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchant.numberOfSubSellers")]
    public string? SubMerchantNumberOfSubSellers { get; init; }

    /// <summary>
    /// Required for transactions performed by registered payment facilitators. The city of the sub-merchant's address.
    /// * Format: Alphanumeric
    /// * Maximum length: 13 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchant.subSeller[subSellerNr].city")]
    public string? SubMerchantSubSellerSubSellerNrCity { get; init; }

    /// <summary>
    /// Required for transactions performed by registered payment facilitators. The three-letter country code of the sub-merchant's address. For example, <b>BRA</b> for Brazil.
    /// * Format: <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3">ISO 3166-1 alpha-3</see>
    /// * Fixed length: 3 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchant.subSeller[subSellerNr].country")]
    public string? SubMerchantSubSellerSubSellerNrCountry { get; init; }

    /// <summary>
    /// Required for transactions performed by registered payment facilitators. The email address of the sub-merchant.
    /// * Format: Alphanumeric
    /// * Maximum length: 40 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchant.subSeller[subSellerNr].email")]
    public string? SubMerchantSubSellerSubSellerNrEmail { get; init; }

    /// <summary>
    /// Required for transactions performed by registered payment facilitators. A unique identifier that you create for the sub-merchant, used by schemes to identify the sub-merchant.
    /// * Format: Alphanumeric
    /// * Maximum length: 15 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchant.subSeller[subSellerNr].id")]
    public string? SubMerchantSubSellerSubSellerNrId { get; init; }

    /// <summary>
    /// Required for transactions performed by registered payment facilitators. The sub-merchant's 4-digit Merchant Category Code (MCC).
    /// * Format: Numeric
    /// * Fixed length: 4 digits
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchant.subSeller[subSellerNr].mcc")]
    public string? SubMerchantSubSellerSubSellerNrMcc { get; init; }

    /// <summary>
    /// Required for transactions performed by registered payment facilitators. The name of the sub-merchant. Based on scheme specifications, this value will overwrite the shopper statement  that will appear in the card statement.
    /// Exception: for acquirers in Brazil, this value does not overwrite the shopper statement.
    /// * Format: Alphanumeric
    /// * Maximum length: 22 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchant.subSeller[subSellerNr].name")]
    public string? SubMerchantSubSellerSubSellerNrName { get; init; }

    /// <summary>
    /// Required for transactions performed by registered payment facilitators. The phone number of the sub-merchant.
    /// * Format: Alphanumeric and special characters
    /// * Maximum length: 20 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchant.subSeller[subSellerNr].phoneNumber")]
    public string? SubMerchantSubSellerSubSellerNrPhoneNumber { get; init; }

    /// <summary>
    /// Required for transactions performed by registered payment facilitators. The postal code of the sub-merchant's address, without dashes.
    /// * Format: Numeric
    /// * Fixed length: 8 digits
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchant.subSeller[subSellerNr].postalCode")]
    public string? SubMerchantSubSellerSubSellerNrPostalCode { get; init; }

    /// <summary>
    /// Required for transactions performed by registered payment facilitators. The state code of the sub-merchant's address, if applicable to the country.
    /// * Format: Alphanumeric
    /// * Maximum length: 2 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchant.subSeller[subSellerNr].state")]
    public string? SubMerchantSubSellerSubSellerNrState { get; init; }

    /// <summary>
    /// Required for transactions performed by registered payment facilitators. The street name and house number of the sub-merchant's address.
    /// * Format: Alphanumeric
    /// * Maximum length: 60 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchant.subSeller[subSellerNr].street")]
    public string? SubMerchantSubSellerSubSellerNrStreet { get; init; }

    /// <summary>
    /// Required for transactions performed by registered payment facilitators. The tax ID of the sub-merchant.
    /// * Format: Numeric
    /// * Fixed length: 11 digits for the CPF or 14 digits for the CNPJ
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchant.subSeller[subSellerNr].taxId")]
    public string? SubMerchantSubSellerSubSellerNrTaxId { get; init; }
}
