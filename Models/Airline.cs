using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Airline
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("agency")]
    public Agency? Agency { get; init; }

    /// <summary>
    /// The amount charged for boarding the plane, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * Encoding: Numeric
    /// * minLength: 1 character
    /// * maxLength: 11 characters
    /// * <b>additionalData key:</b> <c>airline.boarding_fee</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("boardingFee")]
    public long? BoardingFee { get; init; }

    /// <summary>
    /// The <see href="https://www.iata.org/services/pages/codes.aspx">IATA</see> 3-digit accounting code (PAX) that identifies the carrier.
    /// * Format: IATA 3-digit accounting code (PAX)
    /// * Example: KLM = 074
    /// * minLength: 3 characters
    /// * maxLength: 3 characters
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>airline.airline_code</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    /// <summary>
    /// The <see href="https://en.wikipedia.org/wiki/Computer_reservation_system">CRS</see> used to make the reservation and purchase the ticket.
    /// * Encoding: ASCII
    /// * minLength: 4 characters
    /// * maxLength: 4 characters
    /// * <b>additionalData key:</b> <c>airline.computerized_reservation_system</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("computerizedReservationSystem")]
    public string? ComputerizedReservationSystem { get; init; }

    /// <summary>
    /// The alphanumeric customer reference number.
    /// * Encoding: ASCII
    /// * maxLength: 20 characters
    /// * If you send more than 20 characters, the customer reference number is truncated
    /// * Must not start with a space or be all spaces.
    /// * <b>additionalData key:</b> <c>airline.customer_reference_number</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerReferenceNumber")]
    public string? CustomerReferenceNumber { get; init; }

    /// <summary>
    /// The <see href="https://www.iata.org/services/pages/codes.aspx">IATA</see> 2-letter accounting code (PAX) that identifies the carrier.
    /// * Encoding: ASCII
    /// * Example: KLM = KL
    /// * minLength: 2 characters
    /// * maxLength: 2 characters
    /// * Must not start with a space or be all spaces.
    /// * <b>additionalData key:</b> <c>airline.airline_designator_code</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("designatorCode")]
    public string? DesignatorCode { get; init; }

    /// <summary>
    /// A code that identifies the type of item bought. The description of the code can appear on credit card statements.
    /// * Encoding: ASCII
    /// * Example: Passenger ticket = 01
    /// * minLength: 2 characters
    /// * maxLength: 2 characters
    /// * <b>additionalData key:</b> <c>airline.document_type</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("documentType")]
    public string? DocumentType { get; init; }

    /// <summary>
    /// The flight departure date. Time is optional.
    /// * Format for date only: <c>yyyy-MM-dd</c>
    /// * Format for date and time: <c>yyyy-MM-ddTHH:mm</c>
    /// * Use local time of departure airport.
    /// * minLength: 10 characters
    /// * maxLength: 16 characters
    /// * <b>additionalData key:</b> <c>airline.flight_date</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("flightDate")]
    public DateTimeOffset? FlightDate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legs")]
    public IReadOnlyList<Leg>? Legs { get; init; }

    /// <summary>
    /// The passenger's name, initials, and title.
    /// * Format: last name + first name or initials + title
    /// * Example: *FLYER / MARY MS*
    /// * minLength: 1 character
    /// * maxLength: 20 characters
    /// * If you send more than 20 characters, the name is truncated
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>airline.passenger_name</c>
    /// </summary>
    [JsonPropertyName("passengerName")]
    public required string PassengerName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("passengers")]
    public IReadOnlyList<Passenger>? Passengers { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ticket")]
    public Ticket? Ticket { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("travelAgency")]
    public TravelAgency? TravelAgency { get; init; }
}
