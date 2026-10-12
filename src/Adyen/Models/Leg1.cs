using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Leg1
{
    /// <summary>
    /// The IATA 3-letter airport code of the destination airport. This field is required if the airline data includes leg details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("arrivalAirportCode")]
    public string? ArrivalAirportCode { get; init; }

    /// <summary>
    /// The basic fare code for this leg.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("basicFareCode")]
    public string? BasicFareCode { get; init; }

    /// <summary>
    /// IATA code of the carrier operating the flight.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierCode")]
    public string? CarrierCode { get; init; }

    /// <summary>
    /// The IATA three-letter airport code of the departure airport. This field is required if the airline data includes leg details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("departureAirportCode")]
    public string? DepartureAirportCode { get; init; }

    /// <summary>
    /// The flight departure date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("departureDate")]
    public string? DepartureDate { get; init; }

    /// <summary>
    /// The flight identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("flightNumber")]
    public string? FlightNumber { get; init; }
}
