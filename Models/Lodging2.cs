using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// <see href="https://docs.adyen.com/payment-methods/cards/enhanced-scheme-data/lodging/">Lodging enhanced scheme data</see> that may be required for processing the transaction and/or for interchange savings.
/// </summary>
public record Lodging2
{
    /// <summary>
    /// The check-in date.
    /// * Min Length: 10 characters
    /// * Max Length: 10 characters
    /// * Format <see href="https://www.w3.org/TR/NOTE-datetime">ISO 8601</see>: yyyy-MM-dd
    /// * <b>additionalData key:</b> <c>lodging.checkInDate</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkInDate")]
    public DateTimeOffset? CheckInDate { get; init; }

    /// <summary>
    /// The check-out date.
    /// * Min Length: 10 characters
    /// * Max Length: 10 characters
    /// * Format <see href="https://www.w3.org/TR/NOTE-datetime">ISO 8601</see>: yyyy-MM-dd
    /// * <b>additionalData key:</b> <c>lodging.checkOutDate</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkOutDate")]
    public DateTimeOffset? CheckOutDate { get; init; }

    /// <summary>
    /// The toll-free phone number for the lodging customer service.
    /// * Format: Alphanumeric
    /// * For US and CA numbers must be 10 characters in length
    /// * Must not start with a space
    /// * Must not contain any special characters such as + or -
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>lodging.customerServiceTollFreeNumber</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerServicePhoneNumber")]
    public string? CustomerServicePhoneNumber { get; init; }

    /// <summary>
    /// Indicates that the facility complies with the Hotel and Motel Fire Safety Act of 1990.
    /// * <b>additionalData key:</b> <c>lodging.fireSafetyActIndicator</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fireSafetyCompliance")]
    public bool? FireSafetyCompliance { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("folio")]
    public Folio? Folio { get; init; }

    /// <summary>
    /// Any charges for food and beverages associated with the booking, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// * <b>additionalData key:</b> <c>lodging.foodBeverageCharges</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("foodBeverageCharges")]
    public long? FoodBeverageCharges { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lodgingChargeType")]
    public LodgingChargeType? LodgingChargeType { get; init; }

    /// <summary>
    /// Indicates if the customer didn't check in for their booking.
    /// * <b>additionalData key:</b> <c>lodging.noShowIndicator</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("noShow")]
    public bool? NoShow { get; init; }

    /// <summary>
    /// The prepaid expenses for the booking, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// * <b>additionalData key:</b> <c>lodging.prepaidExpenses</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prepaidExpenses")]
    public long? PrepaidExpenses { get; init; }

    /// <summary>
    /// The lodging property location's phone number.
    /// * Format: Alphanumeric
    /// * Min length: 10 characters
    /// * For US and CA numbers must be 10 characters in length
    /// * Must not start with a space
    /// * Must not contain any special characters such as + or -
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>lodging.propertyPhoneNumber</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("propertyPhoneNumber")]
    public string? PropertyPhoneNumber { get; init; }

    /// <summary>
    /// The name of the person renting the room.
    /// * Format: ASCII
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>lodging.renterName</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("renterName")]
    public string? RenterName { get; init; }

    /// <summary>
    /// The list of rooms booked.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rooms")]
    public IReadOnlyList<Room>? Rooms { get; init; }

    /// <summary>
    /// The total room tax amount, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// * <b>additionalData key:</b> <c>lodging.totalRoomTax</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalRoomTax")]
    public long? TotalRoomTax { get; init; }

    /// <summary>
    /// The total tax amount, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// * <b>additionalData key:</b> <c>lodging.totalTax</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalTax")]
    public long? TotalTax { get; init; }
}
