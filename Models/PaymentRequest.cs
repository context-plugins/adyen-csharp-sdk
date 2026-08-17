using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;
using Adyen.Models.OneOf;

namespace Adyen.Models;

public record PaymentRequest
{
    /// <summary>
    /// Shopper account information for 3D Secure 2.
    /// &gt; For 3D Secure 2 transactions, we recommend that you include this object to increase the chances of achieving a frictionless flow.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountInfo")]
    public AccountInfo? AccountInfo { get; init; }

    /// <summary>
    /// If you want a <see href="https://docs.adyen.com/payment-methods/cards/bin-data-and-card-verification">BIN or card verification</see> request to use a non-zero value, assign this value to <c>additionalAmount</c> (while the amount must be still set to 0 to trigger BIN or card verification).
    /// Required to be in the same currency as the <c>amount</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalAmount")]
    public Amount1? AdditionalAmount { get; init; }

    /// <summary>
    /// This field contains additional data, which may be required for a particular payment request.
    /// <para>
    /// The <c>additionalData</c> object consists of entries, each of which includes the key and value.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalData")]
    public IReadOnlyDictionary<string, string>? AdditionalData { get; init; }

    /// <summary>
    /// The amount information for the transaction (in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>). For <see href="https://docs.adyen.com/payment-methods/cards/bin-data-and-card-verification">BIN or card verification</see> requests, set amount to 0 (zero).
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount2 Amount { get; init; }

    /// <summary>
    /// Information about your application. For more details, see <see href="https://docs.adyen.com/development-resources/building-adyen-solutions">Building Adyen solutions</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applicationInfo")]
    public ApplicationInfo? ApplicationInfo { get; init; }

    /// <summary>
    /// Data for 3DS authentication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authenticationData")]
    public AuthenticationData3? AuthenticationData { get; init; }

    /// <summary>
    /// The details of the bank account, from which the payment should be made.
    /// &gt; Either <c>bankAccount</c> or <c>card</c> field must be provided in a payment request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccount")]
    public CheckoutBankAccount1? BankAccount { get; init; }

    /// <summary>
    /// The address where to send the invoice.
    /// &gt; The <c>billingAddress</c> object is required in the following scenarios. Include all of the fields within this object.
    /// &gt;* For 3D Secure 2 transactions in all browser-based and mobile implementations.
    /// &gt;* For cross-border payouts to and from Canada.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingAddress")]
    public BillingAddress3? BillingAddress { get; init; }

    /// <summary>
    /// The shopper's browser information.
    /// &gt; For 3D Secure, the full object is required for web integrations. For mobile app integrations, include the <c>userAgent</c> and <c>acceptHeader</c> fields to indicate  that your integration can support a redirect in case a payment is routed to 3D Secure 2 redirect.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("browserInfo")]
    public BrowserInfo? BrowserInfo { get; init; }

    /// <summary>
    /// The <see href="https://docs.adyen.com/online-payments/capture?tab=delayed-individual_2#delayed-automatic-capture">delay between the authorization and automatic capture</see> of the payment, specified in hours.
    /// <para>
    /// Maximum value: <b>672</b> (28 days).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("captureDelayHours")]
    public int? CaptureDelayHours { get; init; }

    /// <summary>
    /// The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the <c>sdkVersion</c> or <c>token</c>.
    /// <para>
    /// Possible values:
    /// * iOS
    /// * Android
    /// * Web
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("channel")]
    public Channel2? Channel { get; init; }

    /// <summary>
    /// Checkout attempt ID that corresponds to the Id generated by the client SDK for tracking user payment journey.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkoutAttemptId")]
    [MaxLength(256)]
    public string? CheckoutAttemptId { get; init; }

    /// <summary>
    /// Information regarding the company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company")]
    public Company1? Company { get; init; }

    /// <summary>
    /// The shopper country code.
    /// <para>
    /// Format: <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see>
    /// Example: NL or DE
    /// </para>
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
    /// The forex quote as returned in the response of the forex service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dccQuote")]
    public ForexQuote2? DccQuote { get; init; }

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
    [JsonPropertyName("deliverAt")]
    public DateTimeOffset? DeliverAt { get; init; }

    /// <summary>
    /// The address where the purchased goods should be delivered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliveryAddress")]
    public DeliveryAddress1? DeliveryAddress { get; init; }

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

    /// <summary>
    /// When true and <c>shopperReference</c> is provided, the shopper will be asked if the payment details should be stored for future <see href="https://docs.adyen.com/get-started-with-adyen/payment-glossary/#one-click-payments-definition">one-click payments</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableOneClick")]
    public bool? EnableOneClick { get; init; }

    /// <summary>
    /// When true and <c>shopperReference</c> is provided, the payment details will be tokenized for payouts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enablePayOut")]
    public bool? EnablePayOut { get; init; }

    /// <summary>
    /// When true and <c>shopperReference</c> is provided, the payment details will be stored for <see href="https://docs.adyen.com/online-payments/tokenization/#recurring-payment-types">recurring payments</see> where the shopper is not present, such as subscription or automatic top-up payments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableRecurring")]
    public bool? EnableRecurring { get; init; }

    /// <summary>
    /// <see href="https://docs.adyen.com/payment-methods/cards/enhanced-scheme-data/">Enhanced scheme data</see> that may be required for processing the payment and/or interchange savings can apply.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData")]
    public EnhancedSchemeData3? EnhancedSchemeData { get; init; }

    /// <summary>
    /// The type of the entity the payment is processed for.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entityType")]
    public EntityType? EntityType { get; init; }

    /// <summary>
    /// An integer value that is added to the normal fraud score. The value can be either positive or negative.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudOffset")]
    public int? FraudOffset { get; init; }

    /// <summary>
    /// The person or entity funding the money.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundOrigin")]
    public FundOrigin1? FundOrigin { get; init; }

    /// <summary>
    /// the person or entity receiving the money
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundRecipient")]
    public FundRecipient1? FundRecipient { get; init; }

    /// <summary>
    /// The reason for the amount update. Possible values:
    /// * <b>delayedCharge</b>
    /// * <b>noShow</b>
    /// * <b>installment</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("industryUsage")]
    public IndustryUsage1? IndustryUsage { get; init; }

    /// <summary>
    /// Contains installment settings. For more information, refer to <see href="https://docs.adyen.com/payment-methods/cards/credit-card-installments">Installments</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installments")]
    public Installments? Installments { get; init; }

    /// <summary>
    /// Price and product information about the purchased items, to be included on the invoice sent to the shopper.
    /// &gt; This field is required for 3x 4x Oney, Affirm, Afterpay, Clearpay, Klarna, Ratepay, and Riverty.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lineItems")]
    public IReadOnlyList<LineItem>? LineItems { get; init; }

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

    /// <summary>
    /// The mandate details to initiate recurring transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mandate")]
    public Mandate? Mandate { get; init; }

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
    /// You can use this reference to link multiple transactions to one another (for example, to track order authorization rate).For each billing cycle, this reference should be unique. After the first authorized payment attempt, do not reuse the reference. If you use this parameter, include it in all of the payment requests that you make.
    ///  We strongly recommend that you:
    /// * Always include this parameter, so that you can benefit from linking payment requests to one another, in case of authorization retries.
    /// * Additionally include the following parameters in the <c>additionalData</c> object: <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/sessions#request-additionalData-AdditionalDataRetry-retry-orderAttemptNumber"><c>retry.orderAttemptNumber</c></see>, <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/sessions#request-additionalData-AdditionalDataRetry-retry-chainAttemptNumber"><c>retry.chainAttemptNumber</c></see>, and <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/sessions#request-additionalData-AdditionalDataRetry-retry-skipRetry"><c>retry.skipRetry</c></see>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantOrderReference")]
    [MaxLength(1000)]
    public string? MerchantOrderReference { get; init; }

    /// <summary>
    /// Additional risk fields for 3D Secure 2.
    /// &gt; For 3D Secure 2 transactions, we recommend that you include this object to increase the chances of achieving a frictionless flow.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantRiskIndicator")]
    public MerchantRiskIndicator1? MerchantRiskIndicator { get; init; }

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

    /// <summary>
    /// Authentication data produced by an MPI (Mastercard SecureCode, Visa Secure, or Cartes Bancaires).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mpiData")]
    public ThreeDSecureData? MpiData { get; init; }

    /// <summary>
    /// The order information required for partial payments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public EncryptedOrderData2? Order { get; init; }

    /// <summary>
    /// When you are doing multiple partial (gift card) payments, this is the <c>pspReference</c> of the first payment. We use this to link the multiple payments to each other. As your own reference for linking multiple payments, use the <c>merchantOrderReference</c>instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orderReference")]
    public string? OrderReference { get; init; }

    /// <summary>
    /// &gt; Required for browser-based (<c>channel</c> <b>Web</b>) 3D Secure 2 transactions.Set this to the origin URL of the page where you are rendering the Drop-in/Component. Do not include subdirectories and a trailing slash.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("origin")]
    [MaxLength(80)]
    public string? Origin { get; init; }

    /// <summary>
    /// The type and required details of a payment method to use.
    /// </summary>
    [JsonPropertyName("paymentMethod")]
    public required PaymentMethod1 PaymentMethod { get; init; }

    /// <summary>
    /// The object that you can use to enable payment validations for a transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentValidations")]
    public PaymentValidations2? PaymentValidations { get; init; }

    /// <summary>
    /// Defines how to book chargebacks when using <see href="https://docs.adyen.com/adyen-for-platforms-model">Adyen for Platforms</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("platformChargebackLogic")]
    public PlatformChargebackLogic? PlatformChargebackLogic { get; init; }

    /// <summary>
    /// Date after which no further authorisations shall be performed. Only for 3D Secure 2.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringExpiry")]
    public string? RecurringExpiry { get; init; }

    /// <summary>
    /// Minimum number of days between authorisations. Only for 3D Secure 2.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringFrequency")]
    public string? RecurringFrequency { get; init; }

    /// <summary>
    /// Defines a recurring payment type. Required when creating a token to store payment details or using stored payment details.
    /// Allowed values:
    /// * <c>Subscription</c> – A transaction for a fixed or variable amount, which follows a fixed schedule.
    /// * <c>CardOnFile</c> – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction.
    /// * <c>UnscheduledCardOnFile</c> – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder's balance drops below a certain amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringProcessingModel")]
    public RecurringProcessingModel? RecurringProcessingModel { get; init; }

    /// <summary>
    /// Specifies the redirect method (GET or POST) when redirecting back from the issuer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirectFromIssuerMethod")]
    public string? RedirectFromIssuerMethod { get; init; }

    /// <summary>
    /// Specifies the redirect method (GET or POST) when redirecting to the issuer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirectToIssuerMethod")]
    public string? RedirectToIssuerMethod { get; init; }

    /// <summary>
    /// The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. To provide multiple references for one transaction, separate the reference values with the hyphen (<c>-</c>) character.We strongly recommend that you use a unique value for each transaction.
    /// Maximum length: 80 characters.
    /// </summary>
    [JsonPropertyName("reference")]
    [MaxLength(80)]
    public required string Reference { get; init; }

    /// <summary>
    /// The URL to return to in case of a redirection.
    /// The format depends on the channel.
    /// * For web, include the protocol <c>http://</c> or <c>https://</c>. You can also include your own additional query parameters, for example, shopper ID or order reference number.
    /// Example: <c>https://your-company.example.com/checkout?shopperOrder=12xy</c>
    /// * For iOS, use the custom URL for your app. To know more about setting custom URL schemes, refer to the <see href="https://developer.apple.com/documentation/uikit/inter-process_communication/allowing_apps_and_websites_to_link_to_your_content/defining_a_custom_url_scheme_for_your_app">Apple Developer documentation</see>.
    /// Example: <c>my-app://</c>
    /// * For Android, use a custom URL handled by an Activity on your app. You can configure it with an <see href="https://developer.android.com/guide/components/intents-filters">intent filter</see>.
    /// Example: <c>my-app://your.package.name</c>
    /// <para>
    /// If the URL to return to includes non-ASCII characters, like spaces or special letters, URL encode the value.
    /// &gt; The URL must not include personally identifiable information (PII), for example name or email address.
    /// </para>
    /// </summary>
    [JsonPropertyName("returnUrl")]
    [MaxLength(1024)]
    public required string ReturnUrl { get; init; }

    /// <summary>
    /// Contains risk data, such as client-side data, used to identify risk for a transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskData")]
    public RiskData4? RiskData { get; init; }

    /// <summary>
    /// The date and time until when the session remains valid, in <see href="https://www.w3.org/TR/NOTE-datetime">ISO 8601</see> format.
    /// <para>
    /// For example: 2020-07-18T15:42:40.428+01:00
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sessionValidity")]
    public string? SessionValidity { get; init; }

    /// <summary>
    /// A unique ID to <see href="https://docs.adyen.com/online-payments/checkout-settings#checkout-shopper-conversion-id">connect the shopper to a single checkout session</see> that uses multiple API requests. You can use this to get insights into conversion rates.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperConversionId")]
    [MaxLength(256)]
    public string? ShopperConversionId { get; init; }

    /// <summary>
    /// The shopper's email address, in valid <see href="https://www.rfc-editor.org/rfc/rfc5322">RFC-5322</see> format. We recommend that you provide this data, because it is used in velocity fraud checks. &gt; Required for Visa and JCB transactions that require 3D Secure 2 authentication if you did not include the <c>telephoneNumber</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperEmail")]
    [MaxLength(256)]
    public string? ShopperEmail { get; init; }

    /// <summary>
    /// The shopper's IP address. We recommend that you provide this data, as it is used in a number of risk checks (for instance, number of payment attempts or location-based checks).
    /// &gt; Required for Visa and JCB transactions that require 3D Secure 2 authentication for all web and mobile integrations, if you did not include the <c>shopperEmail</c>. For native mobile integrations, the field is required to support cases where authentication is routed to the redirect flow. This field is also mandatory for some merchants depending on your business model. For more information, <see href="https://www.adyen.help/hc/en-us/requests/new">contact Support</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperIP")]
    [MaxLength(50)]
    public string? ShopperIp { get; init; }

    /// <summary>
    /// Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer.
    /// For the web service API, Adyen assumes Ecommerce shopper interaction by default.
    /// <para>
    /// This field has the following possible values:
    /// * <c>Ecommerce</c> - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request.
    /// * <c>ContAuth</c> - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment).
    /// * <c>Moto</c> - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone.
    /// * <c>POS</c> - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperInteraction")]
    public ShopperInteraction? ShopperInteraction { get; init; }

    /// <summary>
    /// The language for the payment. The value combines the two-letter <see href="https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes">ISO 639-1</see> language code with the <see href="https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes">ISO 3166-1 alpha-2</see> country code. For example, <b>nl-NL</b>.
    /// <para>
    /// When using Drop-in/Components, the specified language appears if your front-end global configuration does not set the <c>locale</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperLocale")]
    public string? ShopperLocale { get; init; }

    /// <summary>
    /// The shopper's full name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperName")]
    public ShopperName2? ShopperName { get; init; }

    /// <summary>
    /// Required for recurring payments.
    /// Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters.
    /// &gt; Your reference must not include personally identifiable information (PII), for example name or email address.
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
    /// The tax info of the shopper
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperTaxInfo")]
    public ShopperTaxInfo2? ShopperTaxInfo { get; init; }

    /// <summary>
    /// The shopper's social security number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("socialSecurityNumber")]
    [MaxLength(50)]
    public string? SocialSecurityNumber { get; init; }

    /// <summary>
    /// An array of objects specifying how to split a payment when using <see href="https://docs.adyen.com/platforms/process-payments#providing-split-information">Adyen for Platforms</see>, <see href="https://docs.adyen.com/classic-platforms/processing-payments#providing-split-information">Classic Platforms integration</see>, or <see href="https://docs.adyen.com/issuing/manage-funds#split">Issuing</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splits")]
    public IReadOnlyList<Split>? Splits { get; init; }

    /// <summary>
    /// Required for Adyen for Platforms integrations if you are a platform model. This is your <see href="https://docs.adyen.com/api-explorer/Management/3/post/merchants/(merchantId">reference</see>/stores#request-reference) (on <see href="https://docs.adyen.com/platforms">balance platform</see>) or the <see href="https://docs.adyen.com/api-explorer/Account/latest/post/updateAccountHolder#request-accountHolderDetails-storeDetails-storeReference">storeReference</see> (in the <see href="https://docs.adyen.com/classic-platforms/processing-payments/route-payment-to-store/#route-a-payment-to-a-store">classic integration</see>) for the ecommerce or point-of-sale store that is processing the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("store")]
    [StringLength(64, MinimumLength = 1)]
    public string? Store { get; init; }

    /// <summary>
    /// When true and <c>shopperReference</c> is provided, the payment details will be stored for future <see href="https://docs.adyen.com/online-payments/tokenization/#recurring-payment-types">recurring payments</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storePaymentMethod")]
    public bool? StorePaymentMethod { get; init; }

    /// <summary>
    /// This field contains additional information on the submerchant, who is onboarded to an acquirer through a payment facilitator or aggregator
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchants")]
    public IReadOnlyList<SubMerchantInfo>? SubMerchants { get; init; }

    /// <summary>
    /// The <see href="https://docs.adyen.com/online-payments/surcharge/">surcharge</see> amount to apply to the transaction, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>. When you apply surcharge, include the surcharge in the <c>amount.value</c> field.
    /// <para>
    /// Review our <see href="https://docs.adyen.com/development-resources/surcharge-compliance/">Surcharge compliance guide</see> to learn about how to comply with regulatory requirements when applying surcharge.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("surcharge")]
    public Surcharge2? Surcharge { get; init; }

    /// <summary>
    /// The shopper's telephone number.
    ///  The phone number must include a plus sign (+) and a country code (1-3 digits), followed by the number (4-15 digits). If the value you provide does not follow the guidelines, we do not submit it for authentication.
    /// &gt; Required for Visa and JCB transactions that require 3D Secure 2 authentication, if you did not include the <c>shopperEmail</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("telephoneNumber")]
    [MaxLength(64)]
    public string? TelephoneNumber { get; init; }

    /// <summary>
    /// Configuration for creating redundant payment tokens with third-party token vaults using the Adyen Forward API. This feature requires Forward API webhook integration and pre-configured templates in your Adyen account. Contact your Adyen account manager for setup and availability.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("thirdPartyTokenRedundancyInfo")]
    public ThirdPartyTokenRedundancyInfo1? ThirdPartyTokenRedundancyInfo { get; init; }

    /// <summary>
    /// Request fields for 3D Secure 2. To check if any of the following fields are required for your integration, refer to <see href="https://docs.adyen.com/online-payments">Online payments</see> or <see href="https://docs.adyen.com/classic-integration">Classic integration</see> documentation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDS2RequestData")]
    public ThreeDs2RequestFields1? ThreeDs2RequestData { get; init; }

    /// <summary>
    /// Required to trigger the <see href="https://docs.adyen.com/online-payments/3d-secure/authentication-only/">authentication-only flow</see>. If set to <b>true</b>, you will only perform the 3D Secure 2 authentication, and will not proceed to the payment authorisation.Default: <b>false</b>.
    /// </summary>
    [JsonPropertyName("threeDSAuthenticationOnly")]
    public bool? ThreeDsAuthenticationOnly { get; init; } = false;

    /// <summary>
    /// Set to true if the payment should be routed to a trusted MID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trustedShopper")]
    public bool? TrustedShopper { get; init; }
}
