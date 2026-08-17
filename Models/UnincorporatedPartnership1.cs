using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Information about the unincorporated partnership. Required if <c>type</c> is <b>unincorporatedPartnership</b>.
/// </summary>
public record UnincorporatedPartnership1
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
    /// Short description about the Legal Arrangement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

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
    /// The legal name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The business address. Required if the principal place of business is different from the <c>registeredAddress</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("principalPlaceOfBusiness")]
    public Address41? PrincipalPlaceOfBusiness { get; init; }

    /// <summary>
    /// The address registered at the registrar, such as the Chamber of Commerce.
    /// </summary>
    [JsonPropertyName("registeredAddress")]
    public required Address51 RegisteredAddress { get; init; }

    /// <summary>
    /// The registration number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("registrationNumber")]
    public string? RegistrationNumber { get; init; }

    /// <summary>
    /// The tax information of the entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxInformation")]
    public IReadOnlyList<TaxInformation>? TaxInformation { get; init; }

    /// <summary>
    /// Type of Partnership.
    /// <para>
    /// Possible values:
    /// *  <b>limitedPartnership</b>
    /// *  <b>generalPartnership</b>
    /// *  <b>familyPartnership</b>
    /// *  <b>commercialPartnership</b>
    /// *  <b>publicPartnership</b>
    /// *  <b>otherPartnership</b>
    /// *  <b>gbr</b>
    /// *  <b>gmbh</b>
    /// *  <b>kgaa</b>
    /// *  <b>cv</b>
    /// *  <b>vof</b>
    /// *  <b>maatschap</b>
    /// *  <b>privateFundLimitedPartnership</b>
    /// *  <b>businessTrustEntity</b>
    /// *  <b>businessPartnership</b>
    /// *  <b>limitedLiabilityPartnership</b>
    /// *  <b>eg</b>
    /// *  <b>cooperative</b>
    /// *  <b>vos</b>
    /// *  <b>comunidadDeBienes</b>
    /// *  <b>herenciaYacente</b>
    /// *  <b>comunidadDePropietarios</b>
    /// *  <b>sep</b>
    /// *  <b>sca</b>
    /// *  <b>bt</b>
    /// *  <b>kkt</b>
    /// *  <b>scs</b>
    /// *  <b>snc</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type191? Type { get; init; }

    /// <summary>
    /// The reason for not providing a VAT number.
    /// <para>
    /// Possible values: <b>industryExemption</b>, <b>belowTaxThreshold</b>.
    /// </para>
    /// </summary>
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
