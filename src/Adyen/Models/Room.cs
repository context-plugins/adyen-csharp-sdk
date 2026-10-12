using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Room
{
    /// <summary>
    /// The total number of nights the room is booked for.
    /// * Format: Numeric
    /// * Must be a number between 1 and 99
    /// * <b>additionalData key:</b> <c>lodging.room[N].numberOfNights</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberOfNights")]
    public int? NumberOfNights { get; init; }

    /// <summary>
    /// Room rate per night, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// * <b>additionalData key:</b> <c>lodging.room[N].rate</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rate")]
    public long? Rate { get; init; }
}
