using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentValidationsNameResultResponse
{
    /// <summary>
    /// Informs you if the first name your shopper provided matches the cardholder first name on file at the issuing bank. The first name is only validated for Visa. Possible values:
    /// <para>
    /// <b>match</b>, <b>partialMatch</b>, <b>noMatch</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstName")]
    public string? FirstName { get; init; }

    /// <summary>
    /// Informs you if the full name your shopper provided matches the cardholder name on file at the issuing bank. The full name is the only field that is validated for Mastercard. Possible values:
    /// <para>
    /// <b>match</b>, <b>partialMatch</b>, <b>noMatch</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fullName")]
    public string? FullName { get; init; }

    /// <summary>
    /// Informs you if the last name your shopper provided matches the cardholder last name on file at the issuing bank. The last name is only validated for Visa. Possible values:
    /// <para>
    /// <b>match</b>, <b>partialMatch</b>, <b>noMatch</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastName")]
    public string? LastName { get; init; }

    /// <summary>
    /// Informs you if the middle name your shopper provided matches the cardholder middle name on file at the issuing bank. The middle name is only validated for Visa. Possible values:
    /// <para>
    /// <b>match</b>, <b>partialMatch</b>, <b>noMatch</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("middleName")]
    public string? MiddleName { get; init; }
}
