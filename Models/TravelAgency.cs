using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TravelAgency
{
    /// <summary>
    /// The unique identifier from IATA or ARC for the travel agency that issues the ticket.
    /// * Encoding: ASCII
    /// * minLength: 1 character
    /// * maxLength: 8 characters
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>airline.travel_agency_code</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    /// <summary>
    /// The name of the travel agency.
    /// <list type="bullet">
    ///   <item><description>Encoding: ASCII</description></item>
    ///   <item><description>minLength: 1 character</description></item>
    ///   <item><description>maxLength: 25 characters</description></item>
    ///   <item><description>Must not start with a space or be all spaces.</description></item>
    ///   <item><description>Must not be all zeros.</description></item>
    ///   <item><description><b>additionalData key:</b> <c>airline.travel_agency_name</c></description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
