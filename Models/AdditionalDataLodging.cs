using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AdditionalDataLodging
{
    /// <summary>
    /// A code that corresponds to the category of lodging charges for the payment. Possible values:
    /// * 1: Lodging
    /// * 2: No show reservation
    /// * 3: Advanced deposit
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lodging.SpecialProgramCode")]
    public string? LodgingSpecialProgramCode { get; init; }

    /// <summary>
    /// The arrival date.
    /// * Date format: <b>yyyyMmDd</b>. For example, for 2023 April 22, <b>20230422</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lodging.checkInDate")]
    public string? LodgingCheckInDate { get; init; }

    /// <summary>
    /// The departure date.
    /// * Date format: <b>yyyyMmDd</b>. For example, for 2023 April 22, <b>20230422</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lodging.checkOutDate")]
    public string? LodgingCheckOutDate { get; init; }

    /// <summary>
    /// The toll-free phone number for the lodging.
    /// * Format: numeric
    /// * Max length: 17 characters.
    /// * For US and CA numbers must be 10 characters in length
    /// * Must not start with a space
    /// * Must not contain any special characters such as + or -
    /// * Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lodging.customerServiceTollFreeNumber")]
    public string? LodgingCustomerServiceTollFreeNumber { get; init; }

    /// <summary>
    /// Identifies that the facility complies with the Hotel and Motel Fire Safety Act of 1990. Must be 'Y' or 'N'.
    /// * Format: alphabetic
    /// * Max length: 1 character
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lodging.fireSafetyActIndicator")]
    public string? LodgingFireSafetyActIndicator { get; init; }

    /// <summary>
    /// The folio cash advances, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * Format: numeric
    /// * Max length: 12 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lodging.folioCashAdvances")]
    public string? LodgingFolioCashAdvances { get; init; }

    /// <summary>
    /// The card acceptor’s internal invoice or billing ID reference number.
    /// * Max length: 25 characters
    /// * Must not start with a space
    /// * Must not contain any special characters
    /// * Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lodging.folioNumber")]
    public string? LodgingFolioNumber { get; init; }

    /// <summary>
    /// Any charges for food and beverages associated with the booking, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * Format: numeric
    /// * Max length: 12 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lodging.foodBeverageCharges")]
    public string? LodgingFoodBeverageCharges { get; init; }

    /// <summary>
    /// Indicates if the customer didn't check in for their booking.
    ///  Possible values:
    /// * <b>Y</b>: the customer didn't check in
    /// * <b>N</b>: the customer checked in
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lodging.noShowIndicator")]
    public string? LodgingNoShowIndicator { get; init; }

    /// <summary>
    /// The prepaid expenses for the booking.
    /// * Format: numeric
    /// * Max length: 12 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lodging.prepaidExpenses")]
    public string? LodgingPrepaidExpenses { get; init; }

    /// <summary>
    /// The lodging property location's phone number.
    /// * Format: numeric
    /// * Min length: 10 characters
    /// * Max length: 17 characters
    /// * For US and CA numbers must be 10 characters in length
    /// * Must not start with a space
    /// * Must not contain any special characters such as + or -
    /// * Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lodging.propertyPhoneNumber")]
    public string? LodgingPropertyPhoneNumber { get; init; }

    /// <summary>
    /// The total number of nights the room is booked for.
    /// * Format: numeric
    /// * Must be a number between 0 and 99
    /// * Max length: 4 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lodging.room1.numberOfNights")]
    public string? LodgingRoom1NumberOfNights { get; init; }

    /// <summary>
    /// The rate for the room, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * Format: numeric
    /// * Max length: 12 characters
    /// * Must not be a negative number
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lodging.room1.rate")]
    public string? LodgingRoom1Rate { get; init; }

    /// <summary>
    /// The total room tax amount, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * Format: numeric
    /// * Max length: 12 characters
    /// * Must not be a negative number
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lodging.totalRoomTax")]
    public string? LodgingTotalRoomTax { get; init; }

    /// <summary>
    /// The total tax amount, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * Format: numeric
    /// * Max length: 12 characters
    /// * Must not be a negative number
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lodging.totalTax")]
    public string? LodgingTotalTax { get; init; }

    /// <summary>
    /// The number of nights. This should be included in the auth message.
    /// * Format: numeric
    /// * Max length: 4 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("travelEntertainmentAuthData.duration")]
    public string? TravelEntertainmentAuthDataDuration { get; init; }

    /// <summary>
    /// Indicates what market-specific dataset will be submitted. Must be 'H' for Hotel. This should be included in the auth message.
    /// <list type="bullet">
    ///   <item><description>Format: alphanumeric</description></item>
    ///   <item><description>Max length: 1 character</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("travelEntertainmentAuthData.market")]
    public string? TravelEntertainmentAuthDataMarket { get; init; }
}
