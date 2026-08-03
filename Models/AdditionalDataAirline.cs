using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AdditionalDataAirline
{
    /// <summary>
    /// The reference number for the invoice, issued by the agency.
    /// * Encoding: ASCII
    /// * minLength: 1 character
    /// * maxLength: 6 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.agency_invoice_number")]
    public string? AirlineAgencyInvoiceNumber { get; init; }

    /// <summary>
    /// The two-letter agency plan identifier.
    /// * Encoding: ASCII
    /// * minLength: 2 characters
    /// * maxLength: 2 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.agency_plan_name")]
    public string? AirlineAgencyPlanName { get; init; }

    /// <summary>
    /// The <see href="https://www.iata.org/services/pages/codes.aspx">IATA</see> 3-digit accounting code (PAX) that identifies the carrier.
    /// * Format: IATA 3-digit accounting code (PAX)
    /// * Example: KLM = 074
    /// * minLength: 3 characters
    /// * maxLength: 3 characters
    /// * Must not be all spaces
    /// * Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.airline_code")]
    public string? AirlineAirlineCode { get; init; }

    /// <summary>
    /// The <see href="https://www.iata.org/services/pages/codes.aspx">IATA</see> 2-letter accounting code (PAX) that identifies the carrier.
    /// * Encoding: ASCII
    /// * Example: KLM = KL
    /// * minLength: 2 characters
    /// * maxLength: 2 characters
    /// * Must not be all spaces
    /// * Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.airline_designator_code")]
    public string? AirlineAirlineDesignatorCode { get; init; }

    /// <summary>
    /// The amount charged for boarding the plane, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * Encoding: Numeric
    /// * minLength: 1 character
    /// * maxLength: 18 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.boarding_fee")]
    public string? AirlineBoardingFee { get; init; }

    /// <summary>
    /// The <see href="https://en.wikipedia.org/wiki/Computer_reservation_system">CRS</see> used to make the reservation and purchase the ticket.
    /// * Encoding: ASCII
    /// * minLength: 4 characters
    /// * maxLength: 4 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.computerized_reservation_system")]
    public string? AirlineComputerizedReservationSystem { get; init; }

    /// <summary>
    /// The alphanumeric customer reference number.
    /// * Encoding: ASCII
    /// * maxLength: 20 characters
    /// * If you send more than 20 characters, the customer reference number is truncated
    /// * Must not be all spaces
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.customer_reference_number")]
    public string? AirlineCustomerReferenceNumber { get; init; }

    /// <summary>
    /// A code that identifies the type of item bought. The description of the code can appear on credit card statements.
    /// * Encoding: ASCII
    /// * Example: Passenger ticket = 01
    /// * minLength: 2 characters
    /// * maxLength: 2 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.document_type")]
    public string? AirlineDocumentType { get; init; }

    /// <summary>
    /// The flight departure date. Local time <c>(HH:mm)</c> is optional.
    /// * Date format: <c>yyyy-MM-dd</c>
    /// * Date and time format: <c>yyyy-MM-dd HH:mm</c>
    /// * minLength: 10 characters
    /// * maxLength: 16 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.flight_date")]
    public string? AirlineFlightDate { get; init; }

    /// <summary>
    /// The date that the ticket was issued to the passenger.
    /// * minLength: 6 characters
    /// * maxLength: 6 characters
    /// * Date format: YYMMDD
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.issue_date")]
    public string? AirlineIssueDate { get; init; }

    /// <summary>
    /// The <see href="https://www.iata.org/services/pages/codes.aspx">IATA</see> 2-letter accounting code (PAX) that identifies the carrier.
    /// This field is required if the airline data includes leg details.
    /// * Example: KLM = KL
    /// * minLength: 2 characters
    /// * maxLength: 2 characters
    /// * Must not be all spaces
    /// * Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.leg.carrier_code")]
    public string? AirlineLegCarrierCode { get; init; }

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
    ///   <item><description>Must not be all spaces</description></item>
    ///   <item><description>Must not be all zeros.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.leg.class_of_travel")]
    public string? AirlineLegClassOfTravel { get; init; }

    /// <summary>
    /// Date and time of travel in <see href="https://en.wikipedia.org/wiki/ISO_8601">ISO 8601</see> format <c>yyyy-MM-dd HH:mm</c>.
    /// * Encoding: ASCII
    /// * minLength: 16 characters
    /// * maxLength: 16 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.leg.date_of_travel")]
    public string? AirlineLegDateOfTravel { get; init; }

    /// <summary>
    /// The <see href="https://www.iata.org/services/pages/codes.aspx">IATA</see> three-letter airport code of the departure airport.
    /// This field is required if the airline data includes leg details.
    /// <list type="bullet">
    ///   <item><description>Encoding: ASCII</description></item>
    ///   <item><description>Example: Amsterdam = AMS</description></item>
    ///   <item><description>minLength: 3 characters</description></item>
    ///   <item><description>maxLength: 3 characters</description></item>
    ///   <item><description>Must not be all spaces</description></item>
    ///   <item><description>Must not be all zeros.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.leg.depart_airport")]
    public string? AirlineLegDepartAirport { get; init; }

    /// <summary>
    /// The amount of <see href="https://en.wikipedia.org/wiki/Departure_tax">departure tax</see> charged, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * Encoding: Numeric
    /// * minLength: 1
    /// * maxLength: 12
    /// * Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.leg.depart_tax")]
    public string? AirlineLegDepartTax { get; init; }

    /// <summary>
    /// The <see href="https://www.iata.org/services/pages/codes.aspx">IATA</see> 3-letter airport code of the destination airport.
    /// This field is required if the airline data includes leg details.
    /// * Example: Amsterdam = AMS
    /// * Encoding: ASCII
    /// * minLength: 3 characters
    /// * maxLength: 3 characters
    /// * Must not be all spaces
    /// * Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.leg.destination_code")]
    public string? AirlineLegDestinationCode { get; init; }

    /// <summary>
    /// The <see href="https://en.wikipedia.org/wiki/Fare_basis_code">fare basis code</see>, alphanumeric.
    /// * minLength: 1 character
    /// * maxLength: 15 characters
    /// * Must not be all spaces
    /// * Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.leg.fare_base_code")]
    public string? AirlineLegFareBaseCode { get; init; }

    /// <summary>
    /// The flight identifier.
    /// * minLength: 1 character
    /// * maxLength: 5 characters
    /// * Must not be all spaces
    /// * Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.leg.flight_number")]
    public string? AirlineLegFlightNumber { get; init; }

    /// <summary>
    /// A one-letter code that indicates whether the passenger is entitled to make a stopover. Can be a space, O if the passenger is entitled to make a stopover, or X if they are not.
    /// * Encoding: ASCII
    /// * minLength: 1 character
    /// * maxLength: 1 character
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.leg.stop_over_code")]
    public string? AirlineLegStopOverCode { get; init; }

    /// <summary>
    /// The passenger's date of birth.
    /// <para>
    /// Date format: <c>yyyy-MM-dd</c>
    /// * minLength: 10
    /// * maxLength: 10
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.passenger.date_of_birth")]
    public string? AirlinePassengerDateOfBirth { get; init; }

    /// <summary>
    /// The passenger's first name.
    /// &gt; This field is required if the airline data includes passenger details or leg details.
    /// * Encoding: ASCII
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.passenger.first_name")]
    public string? AirlinePassengerFirstName { get; init; }

    /// <summary>
    /// The passenger's last name.
    /// &gt; This field is required if the airline data includes passenger details or leg details.
    /// * Encoding: ASCII
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.passenger.last_name")]
    public string? AirlinePassengerLastName { get; init; }

    /// <summary>
    /// The passenger's phone number, including country code. This is an alphanumeric field that can include the '+' and '-' signs.
    /// * Encoding: ASCII
    /// * minLength: 3 characters
    /// * maxLength: 30 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.passenger.phone_number")]
    public string? AirlinePassengerPhoneNumber { get; init; }

    /// <summary>
    /// The IATA passenger type code (PTC).
    /// * Encoding: ASCII
    /// * minLength: 3 characters
    /// * maxLength: 6 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.passenger.traveller_type")]
    public string? AirlinePassengerTravellerType { get; init; }

    /// <summary>
    /// The passenger's name, initials, and title.
    /// * Format: last name + first name or initials + title
    /// * Example: *FLYER / MARY MS*
    /// * minLength: 1 character
    /// * maxLength: 20 characters
    /// * If you send more than 20 characters, the name is truncated
    /// * Must not be all spaces
    /// * Must not be all zeros.
    /// </summary>
    [JsonPropertyName("airline.passenger_name")]
    public required string AirlinePassengerName { get; init; }

    /// <summary>
    /// The address of the organization that issued the ticket.
    /// * minLength: 0 characters
    /// * maxLength: 16 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.ticket_issue_address")]
    public string? AirlineTicketIssueAddress { get; init; }

    /// <summary>
    /// The ticket's unique identifier.
    /// * minLength: 1 character
    /// * maxLength: 15 characters
    /// * Must not be all spaces
    /// * Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.ticket_number")]
    public string? AirlineTicketNumber { get; init; }

    /// <summary>
    /// The unique identifier from IATA or ARC for the travel agency that issues the ticket.
    /// * Encoding: ASCII
    /// * minLength: 1 character
    /// * maxLength: 8 characters
    /// * Must not be all spaces
    /// * Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.travel_agency_code")]
    public string? AirlineTravelAgencyCode { get; init; }

    /// <summary>
    /// The name of the travel agency.
    /// <list type="bullet">
    ///   <item><description>Encoding: ASCII</description></item>
    ///   <item><description>minLength: 1 character</description></item>
    ///   <item><description>maxLength: 25 characters</description></item>
    ///   <item><description>Must not be all spaces</description></item>
    ///   <item><description>Must not be all zeros.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline.travel_agency_name")]
    public string? AirlineTravelAgencyName { get; init; }
}
