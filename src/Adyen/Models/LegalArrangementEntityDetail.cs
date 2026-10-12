using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record LegalArrangementEntityDetail
{
    /// <summary>
    /// The address of the entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public ViasAddress5? Address { get; init; }

    /// <summary>
    /// Required when creating an entity with <c>legalEntityType</c> <b>Business</b>, <b>NonProfit</b>, <b>PublicCompany</b>, or <b>Partnership</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessDetails")]
    public BusinessDetails1? BusinessDetails { get; init; }

    /// <summary>
    /// The e-mail address of the entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    /// <summary>
    /// The phone number of the contact provided as a single string.  It will be handled as a landline phone.
    /// <b>Examples:</b> "0031 6 11 22 33 44", "+316/1122-3344", "(0031) 611223344"
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fullPhoneNumber")]
    public string? FullPhoneNumber { get; init; }

    /// <summary>
    /// Required when creating an entity with <c>legalEntityType</c> <b>Individual</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("individualDetails")]
    public IndividualDetails1? IndividualDetails { get; init; }

    /// <summary>
    /// Adyen-generated unique alphanumeric identifier (UUID) for the entry, returned in the response when you create a legal arrangement entity.
    /// Use only when updating an account holder. If you include this field when creating an account holder, the request will fail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangementEntityCode")]
    public string? LegalArrangementEntityCode { get; init; }

    /// <summary>
    /// Your reference for the legal arrangement entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangementEntityReference")]
    public string? LegalArrangementEntityReference { get; init; }

    /// <summary>
    /// An array containing the roles of the entity in the legal arrangement.
    /// <para>
    /// The possible values depend on the legal arrangement <c>type</c>.
    /// </para>
    /// <list type="bullet">
    ///   <item><description>For <c>type</c> <b>Association</b>: <b>ControllingPerson</b> and <b>Shareholder</b>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>For <c>type</c> <b>Partnership</b>: <b>Partner</b> and <b>Shareholder</b>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>For <c>type</c> <b>Trust</b>: <b>Trustee</b>, <b>Settlor</b>, <b>Protector</b>, <b>Beneficiary</b>,  and <b>Shareholder</b>.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangementMembers")]
    public IReadOnlyList<LegalArrangementMember>? LegalArrangementMembers { get; init; }

    /// <summary>
    /// The legal entity type.
    /// <para>
    /// Possible values: <b>Business</b>, <b>Individual</b>, <b>NonProfit</b>, <b>PublicCompany</b>, or <b>Partnership</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalEntityType")]
    public LegalEntityType? LegalEntityType { get; init; }

    /// <summary>
    /// The phone number of the entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumber")]
    public ViasPhoneNumber2? PhoneNumber { get; init; }

    /// <summary>
    /// The URL of the website of the contact.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webAddress")]
    public string? WebAddress { get; init; }
}
