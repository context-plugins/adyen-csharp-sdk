using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AdditionalDataLevel23
{
    /// <summary>
    /// The reference number to identify the customer and their order.
    /// * Encoding: ASCII
    /// * Max length: 25 characters
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.customerReference")]
    public string? EnhancedSchemeDataCustomerReference { get; init; }

    /// <summary>
    /// The three-letter <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3">ISO 3166-1 alpha-3 country code</see> for the destination address.
    /// * Encoding: ASCII
    /// * Fixed length: 3 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.destinationCountryCode")]
    public string? EnhancedSchemeDataDestinationCountryCode { get; init; }

    /// <summary>
    /// The postal code of the destination address.
    /// * Encoding: ASCII
    /// * Max length: 10 characters
    /// * Must not start with a space.
    /// * For the US, it must be in five or nine digits format. For example, 10001 or 10001-0000.
    /// * For Canada, it must be in 6 digits format. For example, M4B 1G5.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.destinationPostalCode")]
    public string? EnhancedSchemeDataDestinationPostalCode { get; init; }

    /// <summary>
    /// The state or province code of the destination address.
    /// * Encoding: ASCII
    /// * Max length: 3 characters
    /// * Must not start with a space.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.destinationStateProvinceCode")]
    public string? EnhancedSchemeDataDestinationStateProvinceCode { get; init; }

    /// <summary>
    /// The duty tax amount, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max length: 12 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.dutyAmount")]
    public string? EnhancedSchemeDataDutyAmount { get; init; }

    /// <summary>
    /// The shipping amount, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max length: 12 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.freightAmount")]
    public string? EnhancedSchemeDataFreightAmount { get; init; }

    /// <summary>
    /// The code that identifies the item in a standardized commodity coding scheme. There are different commodity coding schemes:
    /// * <see href="https://www.ungm.org/public/unspsc">UNSPSC commodity codes</see>
    /// * <see href="https://www.wcoomd.org/en/topics/nomenclature/overview.aspx">HS commodity codes</see>
    /// * <see href="https://www.census.gov/naics/">NAICS commodity codes</see>
    /// * <see href="https://www.census.gov/naics/napcs/">NAPCS commodity codes</see>
    /// <list type="bullet">
    ///   <item><description>Encoding: ASCII</description></item>
    ///   <item><description>Max length: 12 characters</description></item>
    ///   <item><description>Must not start with a space or be all spaces.</description></item>
    ///   <item><description>Must not be all zeros.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.itemDetailLine[itemNr].commodityCode")]
    public string? EnhancedSchemeDataItemDetailLineItemNrCommodityCode { get; init; }

    /// <summary>
    /// A description of the item, that provides details about the purchase.
    /// <para>
    ///  For Visa transactions with level 3 ESD, the description must not be the same or very similar to your merchant name, or, consist only of common words like "product", or "service".
    /// * Encoding: ASCII
    /// * Max length: 26 characters
    /// * Must not be a single character.
    /// * Must not be blank.
    /// * Must not be all special characters.
    /// * Must not be blank.
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.itemDetailLine[itemNr].description")]
    public string? EnhancedSchemeDataItemDetailLineItemNrDescription { get; init; }

    /// <summary>
    /// The discount amount, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max length: 12 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.itemDetailLine[itemNr].discountAmount")]
    public string? EnhancedSchemeDataItemDetailLineItemNrDiscountAmount { get; init; }

    /// <summary>
    /// The product code. Must be a unique product code associated with the item or service. This can be your unique code for the item, or the manufacturer's product code.
    /// * Encoding: ASCII.
    /// * Max length: 12 characters
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.itemDetailLine[itemNr].productCode")]
    public string? EnhancedSchemeDataItemDetailLineItemNrProductCode { get; init; }

    /// <summary>
    /// The number of items. Must be an integer greater than zero.
    /// * Encoding: Numeric
    /// * Max length: 12 characters
    /// * Must not start with a space or be all spaces.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.itemDetailLine[itemNr].quantity")]
    public string? EnhancedSchemeDataItemDetailLineItemNrQuantity { get; init; }

    /// <summary>
    /// The total amount for the line item, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>. See <see href="https://docs.adyen.com//payment-methods/cards/enhanced-scheme-data/l2-l3#amount-requirements">Amount requirements for level 2/3 ESD</see> to learn more about how to calculate the line item total.
    /// * For example, 2000 means USD 20.00.
    /// * Max length: 12 characters
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.itemDetailLine[itemNr].totalAmount")]
    public string? EnhancedSchemeDataItemDetailLineItemNrTotalAmount { get; init; }

    /// <summary>
    /// The unit of measurement for an item.
    /// * Encoding: ASCII
    /// * Max length: 3 characters
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.itemDetailLine[itemNr].unitOfMeasure")]
    public string? EnhancedSchemeDataItemDetailLineItemNrUnitOfMeasure { get; init; }

    /// <summary>
    /// The unit price in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max length: 12 characters
    /// * Must not be all zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.itemDetailLine[itemNr].unitPrice")]
    public string? EnhancedSchemeDataItemDetailLineItemNrUnitPrice { get; init; }

    /// <summary>
    /// The order date.
    /// * Format: <c>ddMMyy</c>
    /// * Encoding: ASCII
    /// * Max length: 6 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.orderDate")]
    public string? EnhancedSchemeDataOrderDate { get; init; }

    /// <summary>
    /// The postal code of the address where the item is shipped from.
    /// * Encoding: ASCII
    /// * Max length: 10 characters
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.For the US, it must be in five or nine digits format. For example, 10001 or 10001-0000.
    /// * For Canada, it must be in 6 digits format. For example, M4B 1G5.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.shipFromPostalCode")]
    public string? EnhancedSchemeDataShipFromPostalCode { get; init; }

    /// <summary>
    /// The amount of state or provincial <see href="https://docs.adyen.com/payment-methods/cards/enhanced-scheme-data/l2-l3#requirements-to-send-level-2-3-esd">tax included in the total transaction amount</see>, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max length: 12 characters
    /// * For L2 data: must not be all zeroes.
    /// * For L3 data: can be zero.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData.totalTaxAmount")]
    public string? EnhancedSchemeDataTotalTaxAmount { get; init; }
}
