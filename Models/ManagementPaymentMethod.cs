using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ManagementPaymentMethod
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accel")]
    public AccelResponseInfo? Accel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("affirm")]
    public AffirmResponseInfo? Affirm { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("afterpayTouch")]
    public AfterpayTouchResponseInfo? AfterpayTouch { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alipayPlus")]
    public AlipayPlusResponseInfo? AlipayPlus { get; init; }

    /// <summary>
    /// Indicates whether receiving payments is allowed. This value is set to <b>true</b> by Adyen after screening your merchant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowed")]
    public bool? Allowed { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amex")]
    public AmexResponseInfo? Amex { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applePay")]
    public ApplePayResponseInfo? ApplePay { get; init; }

    /// <summary>
    /// Payment methods that were also updated as part of an associated transition.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("associatedPaymentMethods")]
    public IReadOnlyList<AssociatedPaymentMethod>? AssociatedPaymentMethods { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bcmc")]
    public BcmcResponseInfo? Bcmc { get; init; }

    /// <summary>
    /// The unique identifier of the business line. Required if you are a <see href="https://docs.adyen.com/platforms">platform model</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessLineId")]
    public string? BusinessLineId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carnet")]
    public AccelUpdateInfo? Carnet { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cartesBancaires")]
    public CartesBancairesResponseInfo? CartesBancaires { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clearpay")]
    public ClearpayResponseInfo? Clearpay { get; init; }

    /// <summary>
    /// The list of countries where a payment method is available. By default, all countries supported by the payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countries")]
    public IReadOnlyList<string>? Countries { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cup")]
    public AccelUpdateInfo? Cup { get; init; }

    /// <summary>
    /// The list of currencies that a payment method supports. By default, all currencies supported by the payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currencies")]
    public IReadOnlyList<string>? Currencies { get; init; }

    /// <summary>
    /// The list of custom routing flags to route payment to the intended acquirer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customRoutingFlags")]
    public IReadOnlyList<string>? CustomRoutingFlags { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("diners")]
    public DinersResponseInfo? Diners { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discover")]
    public AccelUpdateInfo? Discover { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eft_directdebit_CA")]
    public AccelUpdateInfo? EftDirectdebitCa { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eftpos_australia")]
    public AccelUpdateInfo? EftposAustralia { get; init; }

    /// <summary>
    /// Indicates whether the payment method is enabled (<b>true</b>) or disabled (<b>false</b>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("girocard")]
    public AccelUpdateInfo? Girocard { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("givex")]
    public GivexResponseInfo? Givex { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("googlePay")]
    public GooglePayResponseInfo? GooglePay { get; init; }

    /// <summary>
    /// The identifier of the resource.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ideal")]
    public AccelUpdateInfo? Ideal { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interac_card")]
    public AccelUpdateInfo? InteracCard { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("jcb")]
    public JcbresponseInfo? Jcb { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("klarna")]
    public KlarnaResponseInfo? Klarna { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maestro")]
    public AccelUpdateInfo? Maestro { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maestro_usa")]
    public AccelUpdateInfo? MaestroUsa { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mc")]
    public AccelUpdateInfo? Mc { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mealVoucher_FR")]
    public MealVoucherFrresponseInfo? MealVoucherFr { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nyce")]
    public AccelResponseInfo? Nyce { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paybybank_plaid")]
    public PayByBankPlaidResponseInfo? PaybybankPlaid { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payme")]
    public PayMeResponseInfo? Payme { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paypal")]
    public PayPalResponseInfo? Paypal { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payto")]
    public PayToResponseInfo? Payto { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pulse")]
    public AccelResponseInfo? Pulse { get; init; }

    /// <summary>
    /// Your reference for the payment method. Supported characters a-z, A-Z, 0-9.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    [MaxLength(150)]
    public string? Reference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sepadirectdebit")]
    public SepaDirectDebitInfo? Sepadirectdebit { get; init; }

    /// <summary>
    /// The sales channel.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperInteraction")]
    public string? ShopperInteraction { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sodexo")]
    public SodexoResponseInfo? Sodexo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sofort")]
    public SofortResponseInfo? Sofort { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("star")]
    public AccelResponseInfo? Star { get; init; }

    /// <summary>
    /// The unique identifier of the store for which to configure the payment method, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeIds")]
    public IReadOnlyList<string>? StoreIds { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("svs")]
    public SvsResponseInfo? Svs { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("swish")]
    public SwishResponseInfo? Swish { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ticket")]
    public TicketInfo? Ticket { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("twint")]
    public TwintResponseInfo? Twint { get; init; }

    /// <summary>
    /// Payment method <see href="https://docs.adyen.com/development-resources/paymentmethodvariant#management-api">variant</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("valuelink")]
    public ValuelinkResponseInfo? Valuelink { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verificationStatus")]
    public VerificationStatus? VerificationStatus { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vipps")]
    public VippsResponseInfo? Vipps { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visa")]
    public AccelUpdateInfo? Visa { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wechatpay")]
    public WeChatPayPosResponseInfo? Wechatpay { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wechatpay_pos")]
    public WeChatPayPosResponseInfo? WechatpayPos { get; init; }
}
