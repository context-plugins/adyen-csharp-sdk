using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record LevelTwoThree
{
    /// <summary>
    /// The reference number to identify the customer and their order.
    /// * Format: ASCII
    /// * Max length: 25 characters
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>enhancedSchemeData.customerReference</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerReferenceNumber")]
    public string? CustomerReferenceNumber { get; init; }

    /// <summary>
    /// The destination address information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("destination")]
    public Destination1? Destination { get; init; }

    /// <summary>
    /// The duty tax amount, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// * <b>additionalData key:</b> <c>enhancedSchemeData.dutyAmount</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dutyAmount")]
    public long? DutyAmount { get; init; }

    /// <summary>
    /// The shipping amount, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// * <b>additionalData key:</b> <c>enhancedSchemeData.freightAmount</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("freightAmount")]
    public long? FreightAmount { get; init; }

    /// <summary>
    /// The list of item detail lines.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("itemDetailLines")]
    public IReadOnlyList<ItemDetailLine>? ItemDetailLines { get; init; }

    /// <summary>
    /// The date of the order.
    /// * Min Length: 10 characters
    /// * Max Length: 10 characters
    /// * Format <see href="https://www.w3.org/TR/NOTE-datetime">ISO 8601</see>: yyyy-MM-dd
    /// * <b>additionalData key:</b> <c>enhancedSchemeData.orderDate</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orderDate")]
    public DateTimeOffset? OrderDate { get; init; }

    /// <summary>
    /// The postal code of the address where the item is shipped from.
    /// * Encoding: ASCII
    /// * Max length: 10 characters
    /// * For the US, it must be in five or nine digits format. For example, 10001 or 10001-0000.
    /// * For Canada, it must be in 6 digits format. For example, M4B 1G5.
    /// * <b>additionalData key:</b> <c>enhancedSchemeData.shipFromPostalCode</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipFromPostalCode")]
    public string? ShipFromPostalCode { get; init; }

    /// <summary>
    /// The amount of state or provincial <see href="https://docs.adyen.com/payment-methods/cards/enhanced-scheme-data/l2-l3#requirements-to-send-level-2-3-esd">tax included in the total transaction amount</see>, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// * For L2 data: must not be all zeroes.
    /// * For L3 data: can be zero.
    /// * <b>additionalData key:</b> <c>enhancedSchemeData.totalTaxAmount</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalTaxAmount")]
    public long? TotalTaxAmount { get; init; }
}
