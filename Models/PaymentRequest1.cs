using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PaymentRequest1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountInfo")]
    public AccountInfo2? AccountInfo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalAmount")]
    public AdditionalAmount? AdditionalAmount { get; init; }

    /// <summary>
    /// This field contains additional data, which may be required for a particular payment request.
    /// <para>
    /// The <c>additionalData</c> object consists of entries, each of which includes the key and value.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalData")]
    public IReadOnlyDictionary<string, string>? AdditionalData { get; init; }

    [JsonPropertyName("amount")]
    public required Amount16 Amount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applicationInfo")]
    public ApplicationInfo1? ApplicationInfo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccount")]
    public BankAccount9? BankAccount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingAddress")]
    public BillingAddress7? BillingAddress { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("browserInfo")]
    public BrowserInfo2? BrowserInfo { get; init; }

    /// <summary>
    /// The delay between the authorisation and scheduled auto-capture, specified in hours.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("captureDelayHours")]
    public int? CaptureDelayHours { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public Card6? Card { get; init; }

    /// <summary>
    /// The shopper's date of birth.
    /// <para>
    /// Format <see href="https://www.w3.org/TR/NOTE-datetime">ISO-8601</see>: YYYY-MM-DD
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfBirth")]
    public DateTimeOffset? DateOfBirth { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dccQuote")]
    public ForexQuote? DccQuote { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliveryAddress")]
    public DeliveryAddress6? DeliveryAddress { get; init; }

    /// <summary>
    /// The date and time the purchased goods should be delivered.
    /// <para>
    /// Format <see href="https://www.w3.org/TR/NOTE-datetime">ISO 8601</see>: YYYY-MM-DDThh:mm:ss.sssTZD
    /// </para>
    /// <para>
    /// Example: 2017-07-17T13:42:40.428+01:00
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliveryDate")]
    public DateTimeOffset? DeliveryDate { get; init; }

    /// <summary>
    /// A string containing the shopper's device fingerprint. For more information, refer to <see href="https://docs.adyen.com/risk-management/device-fingerprinting">Device fingerprinting</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceFingerprint")]
    [MaxLength(5000)]
    public string? DeviceFingerprint { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entityType")]
    public EntityType? EntityType { get; init; }

    /// <summary>
    /// An integer value that is added to the normal fraud score. The value can be either positive or negative.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudOffset")]
    public int? FraudOffset { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundDestination")]
    public FundDestination? FundDestination { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundSource")]
    public FundSource? FundSource { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingSource")]
    public FundingSource? FundingSource { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installments")]
    public Installments2? Installments { get; init; }

    /// <summary>
    /// The <c>localizedShopperStatement</c> field lets you use dynamic values for your shopper statement in a local character set. If this parameter is left empty, not provided, or not applicable (in case of cross-border transactions), then <b>shopperStatement</b> is used.
    /// <para>
    /// Currently, <c>localizedShopperStatement</c> is only supported for payments with Visa, Mastercard, JCB, Diners, and Discover.
    /// </para>
    /// <para>
    /// <b>Supported characters</b>: Hiragana, Katakana, Kanji, and alphanumeric.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("localizedShopperStatement")]
    public IReadOnlyDictionary<string, string>? LocalizedShopperStatement { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mandate")]
    public Mandate1? Mandate { get; init; }

    /// <summary>
    /// The <see href="https://en.wikipedia.org/wiki/Merchant_category_code">merchant category code</see> (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mcc")]
    public string? Mcc { get; init; }

    /// <summary>
    /// The merchant account identifier, with which you want to process the transaction.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// This reference allows linking multiple transactions to each other for reporting purposes (i.e. order auth-rate). The reference should be unique per billing cycle.
    /// The same merchant order reference should never be reused after the first authorised attempt. If used, this field should be supplied for all incoming authorisations.
    /// &gt; We strongly recommend you send the <c>merchantOrderReference</c> value to benefit from linking payment requests when authorisation retries take place. In addition, we recommend you provide <c>retry.orderAttemptNumber</c>, <c>retry.chainAttemptNumber</c>, and <c>retry.skipRetry</c> values in <c>PaymentRequest.additionalData</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantOrderReference")]
    public string? MerchantOrderReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantRiskIndicator")]
    public MerchantRiskIndicator? MerchantRiskIndicator { get; init; }

    /// <summary>
    /// Metadata consists of entries, each of which includes a key and a value.
    /// Limits:
    /// * Maximum 20 key-value pairs per request. When exceeding, the "177" error occurs: "Metadata size exceeds limit".
    /// * Maximum 20 characters per key.
    /// * Maximum 80 characters per value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public IReadOnlyDictionary<string, string>? Metadata { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mpiData")]
    public MpiData? MpiData { get; init; }

    /// <summary>
    /// The two-character country code of the shopper's nationality.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nationality")]
    [MaxLength(2)]
    public string? Nationality { get; init; }

    /// <summary>
    /// When you are doing multiple partial (gift card) payments, this is the <c>pspReference</c> of the first payment. We use this to link the multiple payments to each other. As your own reference for linking multiple payments, use the <c>merchantOrderReference</c>instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orderReference")]
    public string? OrderReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("platformChargebackLogic")]
    public PlatformChargebackLogic1? PlatformChargebackLogic { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurring")]
    public Recurring3? Recurring { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringProcessingModel")]
    public RecurringProcessingModel? RecurringProcessingModel { get; init; }

    /// <summary>
    /// The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement.
    /// If you need to provide multiple references for a transaction, separate them with hyphens ("-").
    /// Maximum length: 80 characters.
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secureRemoteCommerceCheckoutData")]
    public SecureRemoteCommerceCheckoutData? SecureRemoteCommerceCheckoutData { get; init; }

    /// <summary>
    /// Some payment methods require defining a value for this field to specify how to process the transaction.
    /// <para>
    /// For the Bancontact payment method, it can be set to:
    /// * <c>maestro</c> (default), to be processed like a Maestro card, or
    /// * <c>bcmc</c>, to be processed like a Bancontact card.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selectedBrand")]
    public string? SelectedBrand { get; init; }

    /// <summary>
    /// The <c>recurringDetailReference</c> you want to use for this payment. The value <c>LATEST</c> can be used to select the most recently stored recurring detail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selectedRecurringDetailReference")]
    public string? SelectedRecurringDetailReference { get; init; }

    /// <summary>
    /// A session ID used to identify a payment session.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sessionId")]
    public string? SessionId { get; init; }

    /// <summary>
    /// The shopper's email address. We recommend that you provide this data, as it is used in velocity fraud checks. &gt; Required for Visa and JCB transactions that require 3D Secure 2 authentication if you did not include the <c>telephoneNumber</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperEmail")]
    public string? ShopperEmail { get; init; }

    /// <summary>
    /// The shopper's IP address. We recommend that you provide this data, as it is used in a number of risk checks (for instance, number of payment attempts or location-based checks).
    /// &gt; Required for Visa and JCB transactions that require 3D Secure 2 authentication for all web and mobile integrations, if you did not include the <c>shopperEmail</c>. For native mobile integrations, the field is required to support cases where authentication is routed to the redirect flow. This field is also mandatory for some merchants depending on your business model. For more information, <see href="https://www.adyen.help/hc/en-us/requests/new">contact Support</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperIP")]
    public string? ShopperIp { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperInteraction")]
    public ShopperInteraction1? ShopperInteraction { get; init; }

    /// <summary>
    /// The language for the payment. The value combines the two-letter <see href="https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes">ISO 639-1</see> language code with the <see href="https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes">ISO 3166-1 alpha-2</see> country code. For example, <b>nl-NL</b>.
    /// <para>
    /// When using Drop-in/Components, the specified language appears if your front-end global configuration does not set the <c>locale</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperLocale")]
    public string? ShopperLocale { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperName")]
    public ShopperName? ShopperName { get; init; }

    /// <summary>
    /// Required for recurring payments.
    /// Your reference to uniquely identify this shopper, for example user ID or account ID. The value is case-sensitive and must be at least three characters.
    /// &gt; Your reference must not include personally identifiable information (PII) such as name or email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperReference")]
    public string? ShopperReference { get; init; }

    /// <summary>
    /// The text to be shown on the shopper's bank statement.
    ///  We recommend sending a maximum of 22 characters, otherwise banks might truncate the string.
    ///  Allowed characters: <b>a-z</b>, <b>A-Z</b>, <b>0-9</b>, spaces, and special characters <b>. , ' _ - ? + * /</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperStatement")]
    public string? ShopperStatement { get; init; }

    /// <summary>
    /// The shopper's social security number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("socialSecurityNumber")]
    public string? SocialSecurityNumber { get; init; }

    /// <summary>
    /// An array of objects specifying how the payment should be split when using either Adyen for Platforms for <see href="https://docs.adyen.com/marketplaces/split-payments">marketplaces</see> or <see href="https://docs.adyen.com/platforms/split-payments">platforms</see>, or standalone <see href="https://docs.adyen.com/issuing/add-manage-funds#split">Issuing</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splits")]
    public IReadOnlyList<Split>? Splits { get; init; }

    /// <summary>
    /// Required for Adyen for Platforms integrations if you are a platform model. This is your <see href="https://docs.adyen.com/api-explorer/Management/3/post/merchants/(merchantId">reference</see>/stores#request-reference) (on <see href="https://docs.adyen.com/platforms">balance platform</see>) or the <see href="https://docs.adyen.com/api-explorer/Account/latest/post/updateAccountHolder#request-accountHolderDetails-storeDetails-storeReference">storeReference</see> (in the <see href="https://docs.adyen.com/classic-platforms/processing-payments/route-payment-to-store/#route-a-payment-to-a-store">classic integration</see>) for the ecommerce or point-of-sale store that is processing the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("store")]
    [StringLength(16, MinimumLength = 1)]
    public string? Store { get; init; }

    /// <summary>
    /// The shopper's telephone number.
    ///  The phone number must include a plus sign (+) and a country code (1-3 digits), followed by the number (4-15 digits). If the value you provide does not follow the guidelines, we do not submit it for authentication.
    /// &gt; Required for Visa and JCB transactions that require 3D Secure 2 authentication, if you did not include the <c>shopperEmail</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("telephoneNumber")]
    public string? TelephoneNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDS2RequestData")]
    public ThreeDs2RequestData1? ThreeDs2RequestData { get; init; }

    /// <summary>
    /// Required to trigger the <see href="https://docs.adyen.com/online-payments/3d-secure/authentication-only/">authentication-only flow</see>. If set to <b>true</b>, you will only perform the 3D Secure 2 authentication, and will not proceed to the payment authorization.Default: <b>false</b>.
    /// </summary>
    [JsonPropertyName("threeDSAuthenticationOnly")]
    public bool? ThreeDsauthenticationOnly { get; init; } = false;

    /// <summary>
    /// The reference value to aggregate sales totals in reporting. When not specified, the store field is used (if available).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalsGroup")]
    [StringLength(16, MinimumLength = 1)]
    public string? TotalsGroup { get; init; }

    /// <summary>
    /// Set to true if the payment should be routed to a trusted MID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trustedShopper")]
    public bool? TrustedShopper { get; init; }
}
