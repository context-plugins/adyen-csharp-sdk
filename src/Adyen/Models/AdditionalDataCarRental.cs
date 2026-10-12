using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AdditionalDataCarRental
{
    /// <summary>
    /// The pick-up date.
    /// * Date format: <c>yyyyMMdd</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental.checkOutDate")]
    public string? CarRentalCheckOutDate { get; init; }

    /// <summary>
    /// The customer service phone number of the car rental company.
    /// * Format: Alphanumeric
    /// * maxLength: 17
    /// * For US and CA numbers must be 10 characters in length
    /// * Must not start with a space
    /// * Must not contain any special characters such as + or -
    /// *Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental.customerServiceTollFreeNumber")]
    public string? CarRentalCustomerServiceTollFreeNumber { get; init; }

    /// <summary>
    /// Number of days for which the car is being rented.
    /// * Format: Numeric
    /// * maxLength: 4
    /// * Must not be all spaces
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental.daysRented")]
    public string? CarRentalDaysRented { get; init; }

    /// <summary>
    /// Any fuel charges associated with the rental, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * Format: Numeric
    /// * maxLength: 12
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental.fuelCharges")]
    public string? CarRentalFuelCharges { get; init; }

    /// <summary>
    /// Any insurance charges associated with the rental, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * Format: Numeric
    /// * maxLength: 12
    /// * Must not be all spaces
    /// *Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental.insuranceCharges")]
    public string? CarRentalInsuranceCharges { get; init; }

    /// <summary>
    /// The city where the car is rented.
    /// * Format: Alphanumeric
    /// * maxLength: 18
    /// * Must not start with a space or be all spaces
    /// *Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental.locationCity")]
    public string? CarRentalLocationCity { get; init; }

    /// <summary>
    /// The country where the car is rented, in <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> format.
    /// * Format: Alphanumeric
    /// * maxLength: 2
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental.locationCountry")]
    public string? CarRentalLocationCountry { get; init; }

    /// <summary>
    /// The state or province where the car is rented.
    /// * Format: Alphanumeric
    /// * maxLength: 2
    /// * Must not start with a space or be all spaces
    /// *Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental.locationStateProvince")]
    public string? CarRentalLocationStateProvince { get; init; }

    /// <summary>
    /// Indicates if the customer didn't pick up their rental car.
    /// * Y - Customer did not pick up their car
    /// * N - Not applicable
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental.noShowIndicator")]
    public string? CarRentalNoShowIndicator { get; init; }

    /// <summary>
    /// The charge for not returning a car to the original rental location, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * maxLength: 12
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental.oneWayDropOffCharges")]
    public string? CarRentalOneWayDropOffCharges { get; init; }

    /// <summary>
    /// The daily rental rate, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * Format: Alphanumeric
    /// * maxLength: 12
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental.rate")]
    public string? CarRentalRate { get; init; }

    /// <summary>
    /// Specifies whether the given rate is applied daily or weekly.
    /// * D - Daily rate
    /// * W - Weekly rate
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental.rateIndicator")]
    public string? CarRentalRateIndicator { get; init; }

    /// <summary>
    /// The rental agreement number for the car rental.
    /// * Format: Alphanumeric
    /// * maxLength: 9
    /// * Must not start with a space or be all spaces
    /// *Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental.rentalAgreementNumber")]
    public string? CarRentalRentalAgreementNumber { get; init; }

    /// <summary>
    /// The classification of the rental car.
    /// * Format: Alphanumeric
    /// * maxLength: 4
    /// * Must not start with a space or be all spaces
    /// *Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental.rentalClassId")]
    public string? CarRentalRentalClassId { get; init; }

    /// <summary>
    /// The name of the person renting the car.
    /// * Format: Alphanumeric
    /// * maxLength: 26
    /// * If you send more than 26 characters, the name is truncated
    /// * Must not start with a space or be all spaces
    /// *Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental.renterName")]
    public string? CarRentalRenterName { get; init; }

    /// <summary>
    /// The city where the car must be returned.
    /// * Format: Alphanumeric
    /// * maxLength: 18
    /// * Must not start with a space or be all spaces
    /// *Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental.returnCity")]
    public string? CarRentalReturnCity { get; init; }

    /// <summary>
    /// The country where the car must be returned, in <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> format.
    /// * Format: Alphanumeric
    /// * maxLength: 2
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental.returnCountry")]
    public string? CarRentalReturnCountry { get; init; }

    /// <summary>
    /// The last date to return the car by.
    /// * Date format: <c>yyyyMMdd</c>
    /// * maxLength: 8
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental.returnDate")]
    public string? CarRentalReturnDate { get; init; }

    /// <summary>
    /// The agency code, phone number, or address abbreviation
    /// * Format: Alphanumeric
    /// * maxLength: 10
    /// * Must not start with a space or be all spaces
    /// *Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental.returnLocationId")]
    public string? CarRentalReturnLocationId { get; init; }

    /// <summary>
    /// The state or province where the car must be returned.
    /// * Format: Alphanumeric
    /// * maxLength: 3
    /// * Must not start with a space or be all spaces
    /// *Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental.returnStateProvince")]
    public string? CarRentalReturnStateProvince { get; init; }

    /// <summary>
    /// Indicates if the goods or services were tax-exempt, or if tax was not paid on them.
    /// <para>
    /// Values:
    /// * Y - Goods or services were tax exempt
    /// * N - Tax was not collected
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental.taxExemptIndicator")]
    public string? CarRentalTaxExemptIndicator { get; init; }

    /// <summary>
    /// Number of days the car is rented for. This should be included in the auth message.
    /// * Format: Numeric
    /// * maxLength: 4
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("travelEntertainmentAuthData.duration")]
    public string? TravelEntertainmentAuthDataDuration { get; init; }

    /// <summary>
    /// Indicates what market-specific dataset will be submitted or is being submitted. Value should be 'A' for car rental. This should be included in the auth message.
    /// * Format: Alphanumeric
    /// * maxLength: 1
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("travelEntertainmentAuthData.market")]
    public string? TravelEntertainmentAuthDataMarket { get; init; }
}
