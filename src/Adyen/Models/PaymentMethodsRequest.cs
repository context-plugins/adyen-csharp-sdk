using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PaymentMethodsRequest
{
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
    /// The amount information for the transaction (in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>). For <see href="https://docs.adyen.com/payment-methods/cards/bin-data-and-card-verification">BIN or card verification</see> requests, set amount to 0 (zero).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount2? Amount { get; init; }

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
    /// The shopper's browser information.
    /// &gt; For 3D Secure, the full object is required for web integrations. For mobile app integrations, include the <c>userAgent</c> and <c>acceptHeader</c> fields to indicate  that your integration can support a redirect in case a payment is routed to 3D Secure 2 redirect.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("browserInfo")]
    public BrowserInfo? BrowserInfo { get; init; }

    /// <summary>
    /// The platform where a payment transaction takes place. This field can be used for filtering out payment methods that are only available on specific platforms. Possible values:
    /// * iOS
    /// * Android
    /// * Web
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("channel")]
    public Channel3? Channel { get; init; }

    /// <summary>
    /// The shopper country code.
    /// <para>
    /// Format: <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see>
    /// Example: NL or DE
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; init; }

    /// <summary>
    /// The merchant account identifier, with which you want to process the transaction.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// The order information required for partial payments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public EncryptedOrderData2? Order { get; init; }

    /// <summary>
    /// A unique ID to <see href="https://docs.adyen.com/online-payments/checkout-settings#checkout-shopper-conversion-id">connect the shopper to a single checkout session</see> that uses multiple API requests. You can use this to get insights into conversion rates.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperConversionId")]
    [MaxLength(256)]
    public string? ShopperConversionId { get; init; }

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
    /// Required for recurring payments.
    /// Your reference to uniquely identify this shopper, for example user ID or account ID. The value is case-sensitive and must be at least three characters.
    /// &gt; Your reference must not include personally identifiable information (PII) such as name or email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperReference")]
    public string? ShopperReference { get; init; }

    /// <summary>
    /// Boolean value indicating whether the card payment method should be split into separate debit and credit options.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splitCardFundingSources")]
    public bool? SplitCardFundingSources { get; init; } = false;

    /// <summary>
    /// Required for Adyen for Platforms integrations if you are a platform model. This is your <see href="https://docs.adyen.com/api-explorer/Management/3/post/merchants/(merchantId">reference</see>/stores#request-reference) (on <see href="https://docs.adyen.com/platforms">balance platform</see>) or the <see href="https://docs.adyen.com/api-explorer/Account/latest/post/updateAccountHolder#request-accountHolderDetails-storeDetails-storeReference">storeReference</see> (in the <see href="https://docs.adyen.com/classic-platforms/processing-payments/route-payment-to-store/#route-a-payment-to-a-store">classic integration</see>) for the ecommerce or point-of-sale store that is processing the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("store")]
    [StringLength(16, MinimumLength = 1)]
    public string? Store { get; init; }

    /// <summary>
    /// Specifies how payment methods should be filtered based on the <c>store</c> parameter:
    ///   - <b>exclusive</b>: Only payment methods belonging to the specified <c>store</c> are returned.
    ///   - <b>inclusive</b>: Payment methods from the <c>store</c> and those not associated with any other store are returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeFiltrationMode")]
    public StoreFiltrationMode2? StoreFiltrationMode { get; init; }

    /// <summary>
    /// The shopper's telephone number.
    ///  The phone number must include a plus sign (+) and a country code (1-3 digits), followed by the number (4-15 digits). If the value you provide does not follow the guidelines, we do not submit it for authentication.
    /// &gt; Required for Visa and JCB transactions that require 3D Secure 2 authentication, if you did not include the <c>shopperEmail</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("telephoneNumber")]
    public string? TelephoneNumber { get; init; }
}
