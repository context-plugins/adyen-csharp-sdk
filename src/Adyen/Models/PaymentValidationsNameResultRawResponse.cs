using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentValidationsNameResultRawResponse
{
    /// <summary>
    /// The raw first name validation result that Adyen received from the scheme. First name validation result is only returned for Visa.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstName")]
    public string? FirstName { get; init; }

    /// <summary>
    /// The raw full name validation result that Adyen received from the scheme. Full name is the only field that is validated for Mastercard
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fullName")]
    public string? FullName { get; init; }

    /// <summary>
    /// The raw last name validation result that Adyen received from the scheme. Last name validation result is only returned for Visa.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastName")]
    public string? LastName { get; init; }

    /// <summary>
    /// The raw middle name validation result that Adyen received from the scheme. Middle name validation result is only returned for Visa.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("middleName")]
    public string? MiddleName { get; init; }

    /// <summary>
    /// The raw name validation status value that Adyen received from the scheme. Only returned for Visa.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }
}
