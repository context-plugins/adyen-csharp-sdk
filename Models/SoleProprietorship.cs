using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record SoleProprietorship
{
    /// <summary>
    /// The two-character <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> country code of the governing country.
    /// </summary>
    [JsonPropertyName("countryOfGoverningLaw")]
    public required string CountryOfGoverningLaw { get; init; }

    /// <summary>
    /// The date when the legal arrangement was incorporated in YYYY-MM-DD format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfIncorporation")]
    public string? DateOfIncorporation { get; init; }

    /// <summary>
    /// The registered name, if different from the <c>name</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("doingBusinessAs")]
    public string? DoingBusinessAs { get; init; }

    /// <summary>
    /// Set this to <b>true</b> if the legal arrangement does not have a <c>Doing business as</c> name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("doingBusinessAsAbsent")]
    public bool? DoingBusinessAsAbsent { get; init; }

    /// <summary>
    /// The information from the financial report of the sole proprietorship.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("financialReports")]
    public IReadOnlyList<FinancialReport>? FinancialReports { get; init; }

    /// <summary>
    /// The legal name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("principalPlaceOfBusiness")]
    public Address1? PrincipalPlaceOfBusiness { get; init; }

    [JsonPropertyName("registeredAddress")]
    public required Address1 RegisteredAddress { get; init; }

    /// <summary>
    /// The registration number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("registrationNumber")]
    public string? RegistrationNumber { get; init; }

    /// <summary>
    /// The tax information is absent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxAbsent")]
    public bool? TaxAbsent { get; init; }

    /// <summary>
    /// The tax information of the entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxInformation")]
    public IReadOnlyList<TaxInformation>? TaxInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vatAbsenceReason")]
    public VatAbsenceReason1? VatAbsenceReason { get; init; }

    /// <summary>
    /// The VAT number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vatNumber")]
    public string? VatNumber { get; init; }
}
