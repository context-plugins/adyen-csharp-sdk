using System;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Leg
{
    /// <summary>
    /// The <see href="https://www.iata.org/services/pages/codes.aspx">IATA</see> 2-letter accounting code (PAX) that identifies the carrier.
    /// This field is required if the airline data includes leg details.
    /// * Example: KLM = KL
    /// * minLength: 2 characters
    /// * maxLength: 2 characters
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>airline.leg[N].carrier_code</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierCode")]
    public string? CarrierCode { get; init; }

    /// <summary>
    /// A one-letter travel class identifier.
    ///  The following are common:
    ///  * F: first class
    /// * J: business class
    /// * Y: economy class
    /// * W: premium economy
    /// <list type="bullet">
    ///   <item><description>Encoding: ASCII</description></item>
    ///   <item><description>minLength: 1 character</description></item>
    ///   <item><description>maxLength: 1 character</description></item>
    ///   <item><description>Must not start with a space or be all spaces.</description></item>
    ///   <item><description>Must not be all zeros.</description></item>
    ///   <item><description><b>additionalData key:</b> <c>airline.leg[N].class_of_travel</c></description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("classOfTravel")]
    public string? ClassOfTravel { get; init; }

    /// <summary>
    /// Date and time of travel in format <c>yyyy-MM-ddTHH:mm</c>.
    /// * Use local time of departure airport.
    /// * minLength: 16 characters
    /// * maxLength: 16 characters
    /// * <b>additionalData key:</b> <c>airline.leg[N].date_of_travel</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfTravel")]
    public DateTimeOffset? DateOfTravel { get; init; }

    /// <summary>
    /// The <see href="https://www.iata.org/services/pages/codes.aspx">IATA</see> three-letter airport code of the departure airport.
    /// This field is required if the airline data includes leg details.
    /// <list type="bullet">
    ///   <item><description>Encoding: ASCII</description></item>
    ///   <item><description>Example: Amsterdam = AMS</description></item>
    ///   <item><description>minLength: 3 characters</description></item>
    ///   <item><description>maxLength: 3 characters</description></item>
    ///   <item><description>Must not start with a space or be all spaces.</description></item>
    ///   <item><description>Must not be all zeros.</description></item>
    ///   <item><description><b>additionalData key:</b> <c>airline.leg[N].depart_airport</c></description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("departureAirportCode")]
    public string? DepartureAirportCode { get; init; }

    /// <summary>
    /// The amount of <see href="https://en.wikipedia.org/wiki/Departure_tax">departure tax</see> charged, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * Encoding: Numeric
    /// * minLength: 1
    /// * maxLength: 11
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>airline.leg[N].depart_tax</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("departureTax")]
    public long? DepartureTax { get; init; }

    /// <summary>
    /// The <see href="https://www.iata.org/services/pages/codes.aspx">IATA</see> 3-letter airport code of the destination airport.
    /// This field is required if the airline data includes leg details.
    /// * Example: Amsterdam = AMS
    /// * Encoding: ASCII
    /// * minLength: 3 characters
    /// * maxLength: 3 characters
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>airline.leg[N].destination_code</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("destinationAirportCode")]
    public string? DestinationAirportCode { get; init; }

    /// <summary>
    /// The <see href="https://en.wikipedia.org/wiki/Fare_basis_code">fare basis code</see>, alphanumeric.
    /// * minLength: 1 character
    /// * maxLength: 15 characters
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>airline.leg[N].fare_base_code</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fareBasisCode")]
    public string? FareBasisCode { get; init; }

    /// <summary>
    /// The flight identifier.
    /// * minLength: 1 character
    /// * maxLength: 5 characters
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>airline.leg[N].flight_number</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("flightNumber")]
    public string? FlightNumber { get; init; }

    /// <summary>
    /// A one-letter code that indicates whether the passenger is entitled to make a stopover. Can be a space, O if the passenger is entitled to make a stopover, or X if they are not.
    /// * Encoding: ASCII
    /// * minLength: 1 character
    /// * maxLength: 1 character
    /// * <b>additionalData key:</b> <c>airline.leg[N].stop_over_code</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stopOverCode")]
    public string? StopOverCode { get; init; }
}
