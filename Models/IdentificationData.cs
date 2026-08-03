using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record IdentificationData
{
    /// <summary>
    /// The card number of the document that was issued (AU only).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardNumber")]
    public string? CardNumber { get; init; }

    /// <summary>
    /// The expiry date of the document, in YYYY-MM-DD format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiryDate")]
    public string? ExpiryDate { get; init; }

    /// <summary>
    /// The two-character <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> country code where the document was issued. For example, <b>US</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuerCountry")]
    public string? IssuerCountry { get; init; }

    /// <summary>
    /// The state or province where the document was issued (AU only).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuerState")]
    public string? IssuerState { get; init; }

    /// <summary>
    /// Applies only to individuals in the US. Set to <b>true</b> if the individual does not have an SSN. To verify their identity, Adyen will require them to upload an ID document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nationalIdExempt")]
    public bool? NationalIdExempt { get; init; }

    /// <summary>
    /// The number in the document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    public string? Number { get; init; }

    [JsonPropertyName("type")]
    public required Type132 Type { get; init; }
}
