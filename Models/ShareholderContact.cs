using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ShareholderContact
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public ViasAddress? Address { get; init; }

    /// <summary>
    /// The e-mail address of the person.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    /// <summary>
    /// The phone number of the person provided as a single string.  It will be handled as a landline phone.
    /// Examples: "0031 6 11 22 33 44", "+316/1122-3344", "(0031) 611223344"
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fullPhoneNumber")]
    public string? FullPhoneNumber { get; init; }

    /// <summary>
    /// Job title of the person. Required when the <c>shareholderType</c> is <b>Controller</b>.
    /// <para>
    /// Example values: <b>Chief Executive Officer</b>, <b>Chief Financial Officer</b>, <b>Chief Operating Officer</b>, <b>President</b>, <b>Vice President</b>, <b>Executive President</b>, <b>Managing Member</b>, <b>Partner</b>, <b>Treasurer</b>, <b>Director</b>, or <b>Other</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("jobTitle")]
    public string? JobTitle { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public ViasName? Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personalData")]
    public ViasPersonalData? PersonalData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumber")]
    public PhoneNumber3? PhoneNumber { get; init; }

    /// <summary>
    /// The unique identifier (UUID) of the shareholder entry.
    /// &gt;<b>If, during an Account Holder create or update request, this field is left blank (but other fields provided), a new Shareholder will be created with a procedurally-generated UUID.</b>
    /// <para>
    /// &gt;<b>If, during an Account Holder create request, a UUID is provided, the creation of Account Holder will fail with a validation Error..</b>
    /// </para>
    /// <para>
    /// &gt;<b>If, during an Account Holder update request, a UUID that is not correlated with an existing Shareholder is provided, the update of the Shareholder will fail.</b>
    /// </para>
    /// <para>
    /// &gt;<b>If, during an Account Holder update request, a UUID that is correlated with an existing Shareholder is provided, the existing Shareholder will be updated.</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shareholderCode")]
    public string? ShareholderCode { get; init; }

    /// <summary>
    /// Your reference for the shareholder entry.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shareholderReference")]
    public string? ShareholderReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shareholderType")]
    public ShareholderType? ShareholderType { get; init; }

    /// <summary>
    /// The URL of the person's website.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webAddress")]
    public string? WebAddress { get; init; }
}
