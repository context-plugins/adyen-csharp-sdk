using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CarRental
{
    /// <summary>
    /// The customer service phone number of the car rental company.
    /// * Format: Alphanumeric
    /// * maxLength: 17
    /// * For US and CA numbers must be 10 characters in length
    /// * Must not contain any special characters such as + or -
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>carRental.customerServiceTollFreeNumber</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerServicePhoneNumber")]
    public string? CustomerServicePhoneNumber { get; init; }

    /// <summary>
    /// Indicates if the customer didn't pick up their rental car.
    /// * <b>additionalData key:</b> <c>carRental.noShowIndicator</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("noShow")]
    public bool? NoShow { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pickupInfo")]
    public PickupInfo? PickupInfo { get; init; }

    /// <summary>
    /// Indicates whether the rental rate is daily or weekly.
    /// * <b>additionalData key:</b> <c>carRental.rateIndicator</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rateType")]
    public RateType? RateType { get; init; }

    /// <summary>
    /// The rental agreement number for the car rental.
    /// * Format: ASCII
    /// * maxLength: 9 characters
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>carRental.rentalAgreementNumber</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rentalAgreementNumber")]
    public string? RentalAgreementNumber { get; init; }

    /// <summary>
    /// The classification of the rental car.
    /// * Format: Alphanumeric
    /// * maxLength: 4 characters
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>carRental.rentalClassId</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rentalClassId")]
    public string? RentalClassId { get; init; }

    /// <summary>
    /// The number of days the car is rented for.
    /// * Format: Numeric
    /// * Max value: 9999
    /// * <b>additionalData key:</b> <c>carRental.daysRented</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rentalDays")]
    public int? RentalDays { get; init; }

    /// <summary>
    /// Rental rate, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// * Frequency of the rental rate is specified in the rateType field.
    /// * <b>additionalData key:</b> <c>carRental.rate</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rentalRate")]
    public long? RentalRate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rentalSurcharges")]
    public RentalSurcharges? RentalSurcharges { get; init; }

    /// <summary>
    /// The name of the person renting the car.
    /// * Format: ASCII
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>carRental.renterName</c>
    /// </summary>
    [JsonPropertyName("renterName")]
    public required string RenterName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returnInfo")]
    public ReturnInfo? ReturnInfo { get; init; }

    /// <summary>
    /// Indicates if the goods or services were tax-exempt, or if tax was not collected.
    /// * <b>additionalData key:</b> <c>carRental.taxExemptIndicator</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxExempt")]
    public bool? TaxExempt { get; init; }
}
