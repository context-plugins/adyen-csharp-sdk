using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SignatoryContact
{
    /// <summary>
    /// The address of the person.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public ViasAddress2? Address { get; init; }

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
    /// Job title of the signatory.
    /// <para>
    /// Example values: <b>Chief Executive Officer</b>, <b>Chief Financial Officer</b>, <b>Chief Operating Officer</b>, <b>President</b>, <b>Vice President</b>, <b>Executive President</b>, <b>Managing Member</b>, <b>Partner</b>, <b>Treasurer</b>, <b>Director</b>, or <b>Other</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("jobTitle")]
    public string? JobTitle { get; init; }

    /// <summary>
    /// The name of the person.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public ViasName1? Name { get; init; }

    /// <summary>
    /// Contains information about the person.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personalData")]
    public ViasPersonalData1? PersonalData { get; init; }

    /// <summary>
    /// The phone number of the person.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumber")]
    public ViasPhoneNumber1? PhoneNumber { get; init; }

    /// <summary>
    /// The unique identifier (UUID) of the signatory.
    /// &gt;<b>If, during an Account Holder create or update request, this field is left blank (but other fields provided), a new Signatory will be created with a procedurally-generated UUID.</b>
    /// <para>
    /// &gt;<b>If, during an Account Holder create request, a UUID is provided, the creation of the Signatory will fail while the creation of the Account Holder will continue.</b>
    /// </para>
    /// <para>
    /// &gt;<b>If, during an Account Holder update request, a UUID that is not correlated with an existing Signatory is provided, the update of the Signatory will fail.</b>
    /// </para>
    /// <para>
    /// &gt;<b>If, during an Account Holder update request, a UUID that is correlated with an existing Signatory is provided, the existing Signatory will be updated.</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signatoryCode")]
    public string? SignatoryCode { get; init; }

    /// <summary>
    /// Your reference for the signatory.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signatoryReference")]
    public string? SignatoryReference { get; init; }

    /// <summary>
    /// The URL of the person's website.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webAddress")]
    public string? WebAddress { get; init; }
}
