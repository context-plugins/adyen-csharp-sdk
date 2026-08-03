using System;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PickupInfo
{
    /// <summary>
    /// The city where the car is rented.
    /// * Format: ASCII
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>carRental.locationCity</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    public string? City { get; init; }

    /// <summary>
    /// The country where the car is rented, in <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> format.
    /// * maxLength: 2 characters
    /// * <b>additionalData key:</b> <c>carRental.locationCountry</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; init; }

    /// <summary>
    /// The pick-up date.
    /// * minLength: 10 characters
    /// * maxLength: 10 characters
    /// * Format <see href="https://www.w3.org/TR/NOTE-datetime">ISO 8601</see>: yyyy-MM-dd
    /// * <b>additionalData key:</b> <c>carRental.checkOutDate</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date")]
    public DateTimeOffset? Date { get; init; }

    /// <summary>
    /// The state or province where the car is rented.
    /// * maxLength: 3 characters
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>carRental.locationStateProvince</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stateOrProvince")]
    public string? StateOrProvince { get; init; }
}
