using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PaymentLinkResponse
{
    /// <summary>
    /// List of payment methods to be presented to the shopper. To refer to payment methods, use their <see href="https://docs.adyen.com/payment-methods/payment-method-types">payment method type</see>.
    /// <para>
    /// Example: <c>"allowedPaymentMethods":["ideal","applepay"]</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedPaymentMethods")]
    public IReadOnlyList<string>? AllowedPaymentMethods { get; init; }

    [JsonPropertyName("amount")]
    public required Amount16 Amount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applicationInfo")]
    public ApplicationInfo1? ApplicationInfo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingAddress")]
    public BillingAddress7? BillingAddress { get; init; }

    /// <summary>
    /// List of payment methods to be hidden from the shopper. To refer to payment methods, use their <see href="https://docs.adyen.com/payment-methods/payment-method-types">payment method type</see>.
    /// <para>
    /// Example: <c>"blockedPaymentMethods":["ideal","applepay"]</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("blockedPaymentMethods")]
    public IReadOnlyList<string>? BlockedPaymentMethods { get; init; }

    /// <summary>
    /// The delay between the authorisation and scheduled auto-capture, specified in hours.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("captureDelayHours")]
    public int? CaptureDelayHours { get; init; }

    /// <summary>
    /// The shopper's two-letter country code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countryCode")]
    [MaxLength(100)]
    public string? CountryCode { get; init; }

    /// <summary>
    /// The shopper's date of birth.
    /// <para>
    /// Format <see href="https://www.w3.org/TR/NOTE-datetime">ISO-8601</see>: YYYY-MM-DD
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfBirth")]
    public DateTimeOffset? DateOfBirth { get; init; }

    /// <summary>
    /// The date and time when the purchased goods should be delivered.
    /// <para>
    /// <see href="https://www.w3.org/TR/NOTE-datetime">ISO 8601</see> format: YYYY-MM-DDThh:mm:ss+TZD, for example, <b>2020-12-18T10:15:30+01:00</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliverAt")]
    public DateTimeOffset? DeliverAt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliveryAddress")]
    public DeliveryAddress6? DeliveryAddress { get; init; }

    /// <summary>
    /// A short description visible on the payment page.
    /// Maximum length: 280 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The date when the payment link expires.
    /// <para>
    /// <see href="https://www.w3.org/TR/NOTE-datetime">ISO 8601</see> format with time zone offset: YYYY-MM-DDThh:mm:ss+TZD, for example, <b>2020-12-18T10:15:30+01:00</b>.
    /// </para>
    /// <para>
    /// The maximum expiry date is 70 days after the payment link is created.
    /// </para>
    /// <para>
    /// If not provided, the payment link expires 24 hours after it was created.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiresAt")]
    public DateTimeOffset? ExpiresAt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundOrigin")]
    public FundOrigin? FundOrigin { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundRecipient")]
    public FundRecipient? FundRecipient { get; init; }

    /// <summary>
    /// A unique identifier of the payment link.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// A set of key-value pairs that specifies the installment options available per payment method. The key must be a payment method name in lowercase. For example, <b>card</b> to specify installment options for all cards, or <b>visa</b> or <b>mc</b>. The value must be an object containing the installment options.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installmentOptions")]
    public IReadOnlyDictionary<string, InstallmentOption>? InstallmentOptions { get; init; }

    /// <summary>
    /// Price and product information about the purchased items, to be included on the invoice sent to the shopper.
    /// &gt; This field is required for 3x 4x Oney, Affirm, Afterpay, Clearpay, Klarna, Ratepay, and Riverty.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lineItems")]
    public IReadOnlyList<LineItem>? LineItems { get; init; }

    /// <summary>
    /// Indicates if the payment must be <see href="https://docs.adyen.com/online-payments/capture">captured manually</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("manualCapture")]
    public bool? ManualCapture { get; init; }

    /// <summary>
    /// The <see href="https://en.wikipedia.org/wiki/Merchant_category_code">merchant category code</see> (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mcc")]
    [MaxLength(16)]
    public string? Mcc { get; init; }

    /// <summary>
    /// The merchant account identifier for which the payment link is created.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// This reference allows linking multiple transactions to each other for reporting purposes (for example, order auth-rate). The reference should be unique per billing cycle.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantOrderReference")]
    [MaxLength(1000)]
    public string? MerchantOrderReference { get; init; }

    /// <summary>
    /// Metadata consists of entries, each of which includes a key and a value.
    /// Limitations:
    /// * Maximum 20 key-value pairs per request. Otherwise, error "177" occurs: "Metadata size exceeds limit"
    /// * Maximum 20 characters per key. Otherwise, error "178" occurs: "Metadata key size exceeds limit"
    /// * A key cannot have the name <c>checkout.linkId</c>. Any value that you provide with this key is going to be replaced by the real payment link ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public IReadOnlyDictionary<string, string>? Metadata { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("platformChargebackLogic")]
    public PlatformChargebackLogic1? PlatformChargebackLogic { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringProcessingModel")]
    public RecurringProcessingModel4? RecurringProcessingModel { get; init; }

    /// <summary>
    /// A reference that is used to uniquely identify the payment in future communications about the payment status.
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; init; }

    /// <summary>
    /// List of fields that the shopper has to provide on the payment page before completing the payment. For more information, refer to <see href="https://docs.adyen.com/unified-commerce/pay-by-link/payment-links/api#shopper-information">Provide shopper information</see>.
    /// <para>
    /// Possible values:
    /// * <b>billingAddress</b> – The address where to send the invoice.
    /// * <b>deliveryAddress</b> – The address where the purchased goods should be delivered.
    /// * <b>shopperEmail</b> – The shopper's email address.
    /// * <b>shopperName</b> – The shopper's full name.
    /// * <b>telephoneNumber</b> – The shopper's phone number.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requiredShopperFields")]
    public IReadOnlyList<RequiredShopperField>? RequiredShopperFields { get; init; }

    /// <summary>
    /// Website URL used for redirection after payment is completed.
    /// If provided, a <b>Continue</b> button will be shown on the payment page. If shoppers select the button, they are redirected to the specified URL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returnUrl")]
    [MaxLength(8000)]
    public string? ReturnUrl { get; init; }

    /// <summary>
    /// Indicates whether the payment link can be reused for multiple payments. If not provided, this defaults to <b>false</b> which means the link can be used for one successful payment only.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reusable")]
    public bool? Reusable { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskData")]
    public RiskData? RiskData { get; init; }

    /// <summary>
    /// The shopper's email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperEmail")]
    [MaxLength(500)]
    public string? ShopperEmail { get; init; }

    /// <summary>
    /// The language to be used in the payment page, specified by a combination of a language and country code. For example, <c>en-US</c>.
    /// <para>
    /// For a list of shopper locales that Pay by Link supports, refer to <see href="https://docs.adyen.com/unified-commerce/pay-by-link/payment-links/api#language">Language and localization</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperLocale")]
    [MaxLength(32)]
    public string? ShopperLocale { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperName")]
    public ShopperName? ShopperName { get; init; }

    /// <summary>
    /// Your reference to uniquely identify this shopper, for example user ID or account ID. The value is case-sensitive and must be at least three characters.
    /// &gt; Your reference must not include personally identifiable information (PII) such as name or email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperReference")]
    [StringLength(256, MinimumLength = 3)]
    public string? ShopperReference { get; init; }

    /// <summary>
    /// The text to be shown on the shopper's bank statement.
    ///  We recommend sending a maximum of 22 characters, otherwise banks might truncate the string.
    ///  Allowed characters: <b>a-z</b>, <b>A-Z</b>, <b>0-9</b>, spaces, and special characters <b>. , ' _ - ? + * /</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperStatement")]
    [MaxLength(10000)]
    public string? ShopperStatement { get; init; }

    /// <summary>
    /// Set to <b>false</b> to hide the button that lets the shopper remove a stored payment method.
    /// </summary>
    [JsonPropertyName("showRemovePaymentMethodButton")]
    public bool? ShowRemovePaymentMethodButton { get; init; } = true;

    /// <summary>
    /// The shopper's social security number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("socialSecurityNumber")]
    [MaxLength(32)]
    public string? SocialSecurityNumber { get; init; }

    /// <summary>
    /// Boolean value indicating whether the card payment method should be split into separate debit and credit options.
    /// </summary>
    [JsonPropertyName("splitCardFundingSources")]
    public bool? SplitCardFundingSources { get; init; } = false;

    /// <summary>
    /// An array of objects specifying how to split a payment when using <see href="https://docs.adyen.com/platforms/process-payments#providing-split-information">Adyen for Platforms</see>, <see href="https://docs.adyen.com/classic-platforms/processing-payments#providing-split-information">Classic Platforms integration</see>, or <see href="https://docs.adyen.com/issuing/manage-funds#split">Issuing</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splits")]
    public IReadOnlyList<Split>? Splits { get; init; }

    [JsonPropertyName("status")]
    public required Status31 Status { get; init; }

    /// <summary>
    /// The physical store, for which this payment is processed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("store")]
    public string? Store { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storePaymentMethodMode")]
    public StorePaymentMethodMode2? StorePaymentMethodMode { get; init; }

    /// <summary>
    /// The shopper's telephone number.
    ///  The phone number must include a plus sign (+) and a country code (1-3 digits), followed by the number (4-15 digits). If the value you provide does not follow the guidelines, we do not submit it for authentication.
    /// &gt; Required for Visa and JCB transactions that require 3D Secure 2 authentication, if you did not include the <c>shopperEmail</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("telephoneNumber")]
    [MaxLength(32)]
    public string? TelephoneNumber { get; init; }

    /// <summary>
    /// A <see href="https://docs.adyen.com/unified-commerce/pay-by-link/payment-links/api#themes">theme</see> to customize the appearance of the payment page. If not specified, the payment page is rendered according to the theme set as default in your Customer Area.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("themeId")]
    public string? ThemeId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDS2RequestData")]
    public CheckoutSessionThreeDs2RequestData? ThreeDs2RequestData { get; init; }

    /// <summary>
    /// The date when the payment link status was updated.
    /// <para>
    /// <see href="https://www.w3.org/TR/NOTE-datetime">ISO 8601</see> format: YYYY-MM-DDThh:mm:ss+TZD, for example, <b>2020-12-18T10:15:30+01:00</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? UpdatedAt { get; init; }

    /// <summary>
    /// The URL at which the shopper can complete the payment.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; init; }
}
