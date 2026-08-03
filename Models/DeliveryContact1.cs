using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The delivery contact (name and address) for physical card delivery.
/// </summary>
public record DeliveryContact1
{
    [JsonPropertyName("address")]
    public required Address15 Address { get; init; }

    /// <summary>
    /// The company name of the contact.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company")]
    public string? Company { get; init; }

    /// <summary>
    /// The email address of the contact.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    /// <summary>
    /// The full phone number of the contact provided as a single string. It will be handled as a landline phone.
    /// <b>Examples:</b> "0031 6 11 22 33 44", "+316/1122-3344", "(0031) 611223344"
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fullPhoneNumber")]
    public string? FullPhoneNumber { get; init; }

    [JsonPropertyName("name")]
    public required Name5 Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumber")]
    public PhoneNumber3? PhoneNumber { get; init; }

    /// <summary>
    /// The URL of the contact's website.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webAddress")]
    public string? WebAddress { get; init; }
}
