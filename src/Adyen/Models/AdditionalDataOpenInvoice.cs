using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AdditionalDataOpenInvoice
{
    /// <summary>
    /// Holds different merchant data points like product, purchase, customer, and so on. It takes data in a Base64 encoded string.
    /// <para>
    /// The <c>merchantData</c> parameter needs to be added to the <c>openinvoicedata</c> signature at the end.
    /// </para>
    /// <para>
    /// Since the field is optional, if it's not included it does not impact computing the merchant signature.
    /// </para>
    /// <para>
    /// Applies only to Klarna.
    /// </para>
    /// <para>
    /// You can contact Klarna for the format and structure of the string.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("openinvoicedata.merchantData")]
    public string? OpeninvoicedataMerchantData { get; init; }

    /// <summary>
    /// The number of invoice lines included in <c>openinvoicedata</c>.
    /// <para>
    /// There needs to be at least one line, so <c>numberOfLines</c> needs to be at least 1.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("openinvoicedata.numberOfLines")]
    public string? OpeninvoicedataNumberOfLines { get; init; }

    /// <summary>
    /// First name of the recipient. If the delivery address and the billing address are different, specify the <c>recipientFirstName</c> and <c>recipientLastName</c> to share the delivery address with Klarna. Otherwise, only the billing address is shared with Klarna.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("openinvoicedata.recipientFirstName")]
    public string? OpeninvoicedataRecipientFirstName { get; init; }

    /// <summary>
    /// Last name of the recipient. If the delivery address and the billing address are different, specify the <c>recipientFirstName</c> and <c>recipientLastName</c> to share the delivery address with Klarna. Otherwise, only the billing address is shared with Klarna.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("openinvoicedata.recipientLastName")]
    public string? OpeninvoicedataRecipientLastName { get; init; }

    /// <summary>
    /// The three-character ISO currency code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("openinvoicedataLine[itemNr].currencyCode")]
    public string? OpeninvoicedataLineItemNrCurrencyCode { get; init; }

    /// <summary>
    /// A text description of the product the invoice line refers to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("openinvoicedataLine[itemNr].description")]
    public string? OpeninvoicedataLineItemNrDescription { get; init; }

    /// <summary>
    /// The price for one item in the invoice line, represented in minor units.
    /// <para>
    /// The due amount for the item, VAT excluded.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("openinvoicedataLine[itemNr].itemAmount")]
    public string? OpeninvoicedataLineItemNrItemAmount { get; init; }

    /// <summary>
    /// A unique id for this item. Required for RatePay if the description of each item is not unique.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("openinvoicedataLine[itemNr].itemId")]
    public string? OpeninvoicedataLineItemNrItemId { get; init; }

    /// <summary>
    /// The VAT due for one item in the invoice line, represented in minor units.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("openinvoicedataLine[itemNr].itemVatAmount")]
    public string? OpeninvoicedataLineItemNrItemVatAmount { get; init; }

    /// <summary>
    /// The VAT percentage for one item in the invoice line, represented in minor units.
    /// <para>
    /// For example, 19% VAT is specified as 1900.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("openinvoicedataLine[itemNr].itemVatPercentage")]
    public string? OpeninvoicedataLineItemNrItemVatPercentage { get; init; }

    /// <summary>
    /// The number of units purchased of a specific product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("openinvoicedataLine[itemNr].numberOfItems")]
    public string? OpeninvoicedataLineItemNrNumberOfItems { get; init; }

    /// <summary>
    /// Name of the shipping company handling the the return shipment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("openinvoicedataLine[itemNr].returnShippingCompany")]
    public string? OpeninvoicedataLineItemNrReturnShippingCompany { get; init; }

    /// <summary>
    /// The tracking number for the return of the shipment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("openinvoicedataLine[itemNr].returnTrackingNumber")]
    public string? OpeninvoicedataLineItemNrReturnTrackingNumber { get; init; }

    /// <summary>
    /// URI where the customer can track the return of their shipment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("openinvoicedataLine[itemNr].returnTrackingUri")]
    public string? OpeninvoicedataLineItemNrReturnTrackingUri { get; init; }

    /// <summary>
    /// Name of the shipping company handling the delivery.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("openinvoicedataLine[itemNr].shippingCompany")]
    public string? OpeninvoicedataLineItemNrShippingCompany { get; init; }

    /// <summary>
    /// Shipping method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("openinvoicedataLine[itemNr].shippingMethod")]
    public string? OpeninvoicedataLineItemNrShippingMethod { get; init; }

    /// <summary>
    /// The tracking number for the shipment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("openinvoicedataLine[itemNr].trackingNumber")]
    public string? OpeninvoicedataLineItemNrTrackingNumber { get; init; }

    /// <summary>
    /// URI where the customer can track their shipment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("openinvoicedataLine[itemNr].trackingUri")]
    public string? OpeninvoicedataLineItemNrTrackingUri { get; init; }
}
