using System;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Passenger
{
    /// <summary>
    /// The passenger's date of birth.
    /// * Format <c>yyyy-MM-dd</c>
    /// * minLength: 10
    /// * maxLength: 10
    /// * <b>additionalData key:</b> <c>airline.passenger[N].date_of_birth</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfBirth")]
    public DateTimeOffset? DateOfBirth { get; init; }

    /// <summary>
    /// The passenger's first name.
    /// &gt; This field is required if the airline data includes passenger details or leg details.
    /// * Encoding: ASCII
    /// * <b>additionalData key:</b> <c>airline.passenger[N].first_name</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstName")]
    public string? FirstName { get; init; }

    /// <summary>
    /// The passenger's last name.
    /// &gt; This field is required if the airline data includes passenger details or leg details.
    /// * Encoding: ASCII
    /// * <b>additionalData key:</b> <c>airline.passenger[N].last_name</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastName")]
    public string? LastName { get; init; }

    /// <summary>
    /// The passenger's phone number, including country code. This is an alphanumeric field that can include the '+' and '-' signs.
    /// * Encoding: ASCII
    /// * minLength: 3 characters
    /// * maxLength: 30 characters
    /// * <b>additionalData key:</b> <c>airline.passenger[N].phone_number</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// The IATA passenger type code (PTC).
    /// * Encoding: ASCII
    /// * minLength: 3 characters
    /// * maxLength: 6 characters
    /// * <b>additionalData key:</b> <c>airline.passenger[N].traveller_type</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("travellerType")]
    public string? TravellerType { get; init; }
}
