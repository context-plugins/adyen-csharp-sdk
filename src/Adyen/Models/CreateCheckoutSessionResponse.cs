using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CreateCheckoutSessionResponse
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
    /// List of payment methods to be presented to the shopper. To refer to payment methods, use their <see href="https://docs.adyen.com/payment-methods/payment-method-types">payment method type</see>.
    /// <para>
    /// Example: <c>"allowedPaymentMethods":["ideal","applepay"]</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedPaymentMethods")]
    public IReadOnlyList<string>? AllowedPaymentMethods { get; init; }

    /// <summary>
    /// The amount of the payment.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount18 Amount { get; init; }

    /// <summary>
    /// Information about your application. For more details, see <see href="https://docs.adyen.com/development-resources/building-adyen-solutions">Building Adyen solutions</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applicationInfo")]
    public ApplicationInfo? ApplicationInfo { get; init; }

    /// <summary>
    /// Configuration data for 3DS payments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authenticationData")]
    public AuthenticationData1? AuthenticationData { get; init; }

    /// <summary>
    /// The address where to send the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingAddress")]
    public BillingAddress1? BillingAddress { get; init; }

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
    /// The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the <c>sdkVersion</c> or <c>token</c>.
    /// <para>
    /// Possible values:
    /// * <b>iOS</b>
    /// * <b>Android</b>
    /// * <b>Web</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("channel")]
    public Channel? Channel { get; init; }

    /// <summary>
    /// Information regarding the company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company")]
    public Company1? Company { get; init; }

    /// <summary>
    /// The shopper's two-letter country code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; init; }

    /// <summary>
    /// The shopper's date of birth in <see href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO8601</see> format.
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

    /// <summary>
    /// The address where the purchased goods should be delivered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliveryAddress")]
    public DeliveryAddress1? DeliveryAddress { get; init; }

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
    /// The date the session expires in <see href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO8601</see> format. When not specified, the expiry date is set to 1 hour after session creation. You cannot set the session expiry to more than 24 hours after session creation.
    /// </summary>
    [JsonPropertyName("expiresAt")]
    public required DateTimeOffset ExpiresAt { get; init; }

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
    /// A unique identifier of the session.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// A set of key-value pairs that specifies the installment options available per payment method. The key must be a payment method name in lowercase. For example, <b>card</b> to specify installment options for all cards, or <b>visa</b> or <b>mc</b>. The value must be an object containing the installment options.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installmentOptions")]
    public IReadOnlyDictionary<string, CheckoutSessionInstallmentOption>? InstallmentOptions { get; init; }

    /// <summary>
    /// Price and product information about the purchased items, to be included on the invoice sent to the shopper.
    /// &gt; This field is required for 3x 4x Oney, Affirm, Afterpay, Clearpay, Klarna, Ratepay, and Riverty.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lineItems")]
    public IReadOnlyList<LineItem>? LineItems { get; init; }

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
    /// This reference allows linking multiple transactions to each other for reporting purposes (i.e. order auth-rate). The reference should be unique per billing cycle.
    /// The same merchant order reference should never be reused after the first authorised attempt. If used, this field should be supplied for all incoming authorisations.
    /// &gt; We strongly recommend you send the <c>merchantOrderReference</c> value to benefit from linking payment requests when authorisation retries take place. In addition, we recommend you provide <c>retry.orderAttemptNumber</c>, <c>retry.chainAttemptNumber</c>, and <c>retry.skipRetry</c> values in <c>PaymentRequest.additionalData</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantOrderReference")]
    public string? MerchantOrderReference { get; init; }

    /// <summary>
    /// Metadata consists of entries, each of which includes a key and a value.
    /// Limits:
    /// * Maximum 20 key-value pairs per request.
    /// * Maximum 20 characters per key.
    /// * Maximum 80 characters per value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public IReadOnlyDictionary<string, string>? Metadata { get; init; }

    /// <summary>
    /// Indicates the type of front end integration. Possible values:
    /// * <b>embedded</b> (default): Drop-in or Components integration
    /// * <b>hosted</b>: Hosted Checkout integration
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mode")]
    public Mode? Mode { get; init; } = Mode.Embedded;

    /// <summary>
    /// Authentication data produced by an MPI (Mastercard SecureCode, Visa Secure, or Cartes Bancaires).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mpiData")]
    public ThreeDSecureData? MpiData { get; init; }

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
    /// Defines a recurring payment type. Required when creating a token to store payment details.
    /// Allowed values:
    /// * <c>Subscription</c> – A transaction for a fixed or variable amount, which follows a fixed schedule.
    /// * <c>CardOnFile</c> – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction.
    /// * <c>UnscheduledCardOnFile</c> – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder's balance drops below a certain amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringProcessingModel")]
    public RecurringProcessingModel1? RecurringProcessingModel { get; init; }

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
    /// The reference to uniquely identify a payment.
    /// </summary>
    [JsonPropertyName("reference")]
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
    /// Any risk-related settings to apply to the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskData")]
    public RiskData1? RiskData { get; init; }

    /// <summary>
    /// The payment session data you need to pass to your front end.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sessionData")]
    public string? SessionData { get; init; }

    /// <summary>
    /// The shopper's email address.
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
    /// The shopper's full name. This object is required for some payment methods such as AfterPay, Klarna, or if you're enrolled in the PayPal Seller Protection program.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperName")]
    public ShopperName1? ShopperName { get; init; }

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
    public string? ShopperStatement { get; init; }

    /// <summary>
    /// Set to true to show the payment amount per installment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("showInstallmentAmount")]
    public bool? ShowInstallmentAmount { get; init; }

    /// <summary>
    /// Set to <b>true</b> to show a button that lets the shopper remove a stored payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("showRemovePaymentMethodButton")]
    public bool? ShowRemovePaymentMethodButton { get; init; }

    /// <summary>
    /// The shopper's social security number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("socialSecurityNumber")]
    public string? SocialSecurityNumber { get; init; }

    /// <summary>
    /// Boolean value indicating whether the card payment method should be split into separate debit and credit options.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splitCardFundingSources")]
    public bool? SplitCardFundingSources { get; init; } = false;

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
    public string? Store { get; init; }

    /// <summary>
    /// Specifies how payment methods should be filtered based on the 'store' parameter:
    ///   - 'exclusive': Only payment methods belonging to the specified 'store' are returned.
    ///   - 'inclusive': Payment methods from the 'store' and those not associated with any other store are returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeFiltrationMode")]
    public StoreFiltrationMode? StoreFiltrationMode { get; init; }

    /// <summary>
    /// When true and <c>shopperReference</c> is provided, the payment details will be stored for future <see href="https://docs.adyen.com/online-payments/tokenization/#recurring-payment-types">recurring payments</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storePaymentMethod")]
    public bool? StorePaymentMethod { get; init; }

    /// <summary>
    /// Indicates if the details of the payment method will be stored for the shopper. Possible values:
    /// * <b>disabled</b> – No details will be stored (default).
    /// * <b>askForConsent</b> – If the <c>shopperReference</c> is provided, the Drop-in/Component shows a checkbox where the shopper can select to store their payment details for card payments.
    /// * <b>enabled</b> – If the <c>shopperReference</c> is provided, the details will be stored without asking the shopper for consent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storePaymentMethodMode")]
    public StorePaymentMethodMode? StorePaymentMethodMode { get; init; }

    /// <summary>
    /// The shopper's telephone number.
    ///  The phone number must include a plus sign (+) and a country code (1-3 digits), followed by the number (4-15 digits). If the value you provide does not follow the guidelines, we do not submit it for authentication.
    /// &gt; Required for Visa and JCB transactions that require 3D Secure 2 authentication, if you did not include the <c>shopperEmail</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("telephoneNumber")]
    public string? TelephoneNumber { get; init; }

    /// <summary>
    /// Sets a custom theme for <see href="https://docs.adyen.com/online-payments/build-your-integration/?platform=Web&amp;integration=Hosted+Checkout">Hosted Checkout</see>. The value can be any of the <b>Theme ID</b> values from your Customer Area.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("themeId")]
    public string? ThemeId { get; init; }

    /// <summary>
    /// Configuration for creating redundant payment tokens with third-party token vaults using the Adyen Forward API. This feature requires Forward API webhook integration and pre-configured templates in your Adyen account. Contact your Adyen account manager for setup and availability.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("thirdPartyTokenRedundancyInfo")]
    public ThirdPartyTokenRedundancyInfo1? ThirdPartyTokenRedundancyInfo { get; init; }

    /// <summary>
    /// Request fields for 3D Secure 2. To check if any of the following fields are required for your integration, refer to <see href="https://docs.adyen.com/online-payments">Online payments</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDS2RequestData")]
    public CheckoutSessionThreeDs2RequestData1? ThreeDs2RequestData { get; init; }

    /// <summary>
    /// Required to trigger the <see href="https://docs.adyen.com/online-payments/3d-secure/authentication-only/">authentication-only flow</see>. If set to <b>true</b>, you will only perform the 3D Secure 2 authentication, and will not proceed to the payment authorization.Default: <b>false</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSAuthenticationOnly")]
    public bool? ThreeDsAuthenticationOnly { get; init; } = false;

    /// <summary>
    /// Set to true if the payment should be routed to a trusted MID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trustedShopper")]
    public bool? TrustedShopper { get; init; }

    /// <summary>
    /// The URL for the Hosted Checkout page. Redirect the shopper to this URL so they can make the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }
}
