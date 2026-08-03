using System.Text.Json.Serialization;

namespace Adyen.Models;

public record RentalSurcharges
{
    /// <summary>
    /// The fuel charges associated with the rental, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// * <b>additionalData key:</b> <c>carRental.fuelCharges</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fuel")]
    public long? Fuel { get; init; }

    /// <summary>
    /// Any insurance charges associated with the rental, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// * <b>additionalData key:</b> <c>carRental.insuranceCharges</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("insurance")]
    public long? Insurance { get; init; }

    /// <summary>
    /// The charge for not returning a car to the original rental location, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// * <b>additionalData key:</b> <c>carRental.oneWayDropOffCharges</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("oneWayDropOff")]
    public long? OneWayDropOff { get; init; }
}
