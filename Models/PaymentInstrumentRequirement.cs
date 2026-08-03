using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PaymentInstrumentRequirement
{
    /// <summary>
    /// Specifies the requirements for the payment instrument that need to be included in the request for a particular route.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The two-character <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> country code where the payment instrument is issued. For example, <b>NL</b> or <b>US</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuingCountryCode")]
    public string? IssuingCountryCode { get; init; }

    /// <summary>
    /// The two-character ISO-3166-1 alpha-2 country code list for payment instruments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuingCountryCodes")]
    public IReadOnlyList<string>? IssuingCountryCodes { get; init; }

    /// <summary>
    /// Specifies if the requirement only applies to transfers to another balance platform.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("onlyForCrossBalancePlatform")]
    public bool? OnlyForCrossBalancePlatform { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentInstrumentType")]
    public PaymentInstrumentType? PaymentInstrumentType { get; init; }

    /// <summary>
    /// <b>paymentInstrumentRequirement</b>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type363 Type { get; init; }
}
