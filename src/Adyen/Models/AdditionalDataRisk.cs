using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AdditionalDataRisk
{
    /// <summary>
    /// The data for your custom risk field. For more information, refer to <see href="https://docs.adyen.com/risk-management/configure-custom-risk-rules#step-1-create-custom-risk-fields">Create custom risk fields</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskdata.[customFieldName]")]
    public string? RiskdataCustomFieldName { get; init; }

    /// <summary>
    /// The price of item in the basket, represented in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskdata.basket.item[itemNr].amountPerItem")]
    public string? RiskdataBasketItemItemNrAmountPerItem { get; init; }

    /// <summary>
    /// Brand of the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskdata.basket.item[itemNr].brand")]
    public string? RiskdataBasketItemItemNrBrand { get; init; }

    /// <summary>
    /// Category of the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskdata.basket.item[itemNr].category")]
    public string? RiskdataBasketItemItemNrCategory { get; init; }

    /// <summary>
    /// Color of the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskdata.basket.item[itemNr].color")]
    public string? RiskdataBasketItemItemNrColor { get; init; }

    /// <summary>
    /// The three-character <see href="https://en.wikipedia.org/wiki/ISO_4217">ISO currency code</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskdata.basket.item[itemNr].currency")]
    public string? RiskdataBasketItemItemNrCurrency { get; init; }

    /// <summary>
    /// ID of the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskdata.basket.item[itemNr].itemID")]
    public string? RiskdataBasketItemItemNrItemId { get; init; }

    /// <summary>
    /// Manufacturer of the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskdata.basket.item[itemNr].manufacturer")]
    public string? RiskdataBasketItemItemNrManufacturer { get; init; }

    /// <summary>
    /// A text description of the product the invoice line refers to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskdata.basket.item[itemNr].productTitle")]
    public string? RiskdataBasketItemItemNrProductTitle { get; init; }

    /// <summary>
    /// Quantity of the item purchased.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskdata.basket.item[itemNr].quantity")]
    public string? RiskdataBasketItemItemNrQuantity { get; init; }

    /// <summary>
    /// Email associated with the given product in the basket (usually in electronic gift cards).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskdata.basket.item[itemNr].receiverEmail")]
    public string? RiskdataBasketItemItemNrReceiverEmail { get; init; }

    /// <summary>
    /// Size of the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskdata.basket.item[itemNr].size")]
    public string? RiskdataBasketItemItemNrSize { get; init; }

    /// <summary>
    /// <see href="https://en.wikipedia.org/wiki/Stock_keeping_unit">Stock keeping unit</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskdata.basket.item[itemNr].sku")]
    public string? RiskdataBasketItemItemNrSku { get; init; }

    /// <summary>
    /// <see href="https://en.wikipedia.org/wiki/Universal_Product_Code">Universal Product Code</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskdata.basket.item[itemNr].upc")]
    public string? RiskdataBasketItemItemNrUpc { get; init; }

    /// <summary>
    /// Code of the promotion.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskdata.promotions.promotion[itemNr].promotionCode")]
    public string? RiskdataPromotionsPromotionItemNrPromotionCode { get; init; }

    /// <summary>
    /// The discount amount of the promotion, represented in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskdata.promotions.promotion[itemNr].promotionDiscountAmount")]
    public string? RiskdataPromotionsPromotionItemNrPromotionDiscountAmount { get; init; }

    /// <summary>
    /// The three-character <see href="https://en.wikipedia.org/wiki/ISO_4217">ISO currency code</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskdata.promotions.promotion[itemNr].promotionDiscountCurrency")]
    public string? RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency { get; init; }

    /// <summary>
    /// Promotion's percentage discount. It is represented in percentage value and there is no need to include the '%' sign.
    /// <para>
    /// e.g. for a promotion discount of 30%, the value of the field should be 30.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskdata.promotions.promotion[itemNr].promotionDiscountPercentage")]
    public string? RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage { get; init; }

    /// <summary>
    /// Name of the promotion.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskdata.promotions.promotion[itemNr].promotionName")]
    public string? RiskdataPromotionsPromotionItemNrPromotionName { get; init; }

    /// <summary>
    /// Reference number of the risk profile that you want to apply to the payment. If not provided or left blank, the merchant-level account's default risk profile will be applied to the payment. For more information, see <see href="https://docs.adyen.com/risk-management/create-and-use-risk-profiles#dynamically-assign-a-risk-profile-to-a-payment">dynamically assign a risk profile to a payment</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskdata.riskProfileReference")]
    public string? RiskdataRiskProfileReference { get; init; }

    /// <summary>
    /// If this parameter is provided with the value <b>true</b>, risk checks for the payment request are skipped and the transaction will not get a risk score.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskdata.skipRisk")]
    public string? RiskdataSkipRisk { get; init; }
}
