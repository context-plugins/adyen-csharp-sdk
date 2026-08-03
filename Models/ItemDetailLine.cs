using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ItemDetailLine
{
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
    ///   <item><description><b>additionalData key:</b> <c>enhancedSchemeData.itemDetailLine[N].commodityCode</c></description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("commodityCode")]
    public string? CommodityCode { get; init; }

    /// <summary>
    /// A description of the item, that provides details about the purchase.
    /// <para>
    ///  For Visa transactions with level 3 ESD, the description must not be the same or very similar to your merchant name, or, consist only of common words like "product", or "service".
    /// * Encoding: ASCII
    /// * Max length: 26 characters
    /// * Must not be a single character.
    /// * Must not be blank.
    /// * Must not be all special characters.
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>enhancedSchemeData.itemDetailLine[N].description</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The discount amount, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// * <b>additionalData key:</b> <c>enhancedSchemeData.itemDetailLine[N].discountAmount</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discountAmount")]
    public long? DiscountAmount { get; init; }

    /// <summary>
    /// The product code. Must be a unique product code associated with the item or service. This can be your unique code for the item, or the manufacturer's product code.
    /// * Encoding: ASCII.
    /// * Max length: 12 characters
    /// * <b>additionalData key:</b> <c>enhancedSchemeData.itemDetailLine[N].productCode</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productCode")]
    public string? ProductCode { get; init; }

    /// <summary>
    /// The number of items. Must be an integer greater than zero.
    /// * Encoding: Numeric
    /// * Max value: 9999
    /// * <b>additionalData key:</b> <c>enhancedSchemeData.itemDetailLine[N].quantity</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity")]
    public long? Quantity { get; init; }

    /// <summary>
    /// The total amount for the line item, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// <para>
    /// See <see href="https://docs.adyen.com//payment-methods/cards/enhanced-scheme-data/l2-l3#amount-requirements">Amount requirements for level 2/3 ESD</see> to learn more about how to calculate the line item total.
    /// * <b>additionalData key:</b> <c>enhancedSchemeData.itemDetailLine[N].totalAmount</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalAmount")]
    public long? TotalAmount { get; init; }

    /// <summary>
    /// The unit of measurement for an item.
    /// * Encoding: ASCII
    /// * Max length: 3 characters
    /// * <b>additionalData key:</b> <c>enhancedSchemeData.itemDetailLine[N].unitOfMeasure</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unitOfMeasure")]
    public string? UnitOfMeasure { get; init; }

    /// <summary>
    /// The unit price, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// * <b>additionalData key:</b> <c>enhancedSchemeData.itemDetailLine[N].unitPrice</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unitPrice")]
    public long? UnitPrice { get; init; }
}
