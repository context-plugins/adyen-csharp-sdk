using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PaymentMethodSetupInfo
{
    /// <summary>
    /// Details to provide if <c>type</c> is <b>accel</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accel")]
    public AccelInfo1? Accel { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>affirm</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("affirm")]
    public AffirmInfo1? Affirm { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>afterpaytouch</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("afterpayTouch")]
    public AfterpayTouchInfo1? AfterpayTouch { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>alipay_plus</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alipayPlus")]
    public AlipayPlusInfo1? AlipayPlus { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>amex</b>.
    /// For merchants operating in Australia, New Zealand &amp; Canada, JCB and American Express are automatically requested together.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amex")]
    public AmexInfo1? Amex { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>applepay</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applePay")]
    public ApplePayInfo1? ApplePay { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>bcmc</b> (Bancontact).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bcmc")]
    public BcmcInfo1? Bcmc { get; init; }

    /// <summary>
    /// The unique identifier of the business line. Required if you are a <see href="https://docs.adyen.com/platforms">platform model</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessLineId")]
    public string? BusinessLineId { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>carnet</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carnet")]
    public CarnetInfo1? Carnet { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>cartebancaire</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cartesBancaires")]
    public CartesBancairesInfo1? CartesBancaires { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>clearpay</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clearpay")]
    public ClearpayInfo1? Clearpay { get; init; }

    /// <summary>
    /// The list of countries where a payment method is available. By default, all countries supported by the payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countries")]
    public IReadOnlyList<string>? Countries { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>cup</b> (China Union Pay).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cup")]
    public GenericPmWithTdiInfo1? Cup { get; init; }

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

    /// <summary>
    /// Details to provide if <c>type</c> is <b>diners</b>.
    /// For merchants operating in Japan, Diners payments are processed through the JCB network. This means that you must include <see href="https://docs.adyen.com/api-explorer/Management/latest/post/merchants/(merchantId">JCB-specific fields</see>/paymentMethodSettings/(paymentMethodId)#request-jcb) in this object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("diners")]
    public DinersInfo1? Diners { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>discover</b>.
    /// For merchants operating in Japan, request <see href="https://docs.adyen.com/api-explorer/Management/latest/post/merchants/(merchantId">Diners</see>/paymentMethodSettings/(paymentMethodId)#request-diners) payment method instead. Discover is automatically requested, together with Diners.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discover")]
    public GenericPmWithTdiInfo2? Discover { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>eft_directdebit_CA</b> (EFT PAD).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eft_directdebit_CA")]
    public GenericPmWithTdiInfo3? EftDirectdebitCa { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>eftpos_australia</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eftpos_australia")]
    public GenericPmWithTdiInfo4? EftposAustralia { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>girocard</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("girocard")]
    public GenericPmWithTdiInfo5? Girocard { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>givex</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("givex")]
    public GivexInfo1? Givex { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>googlepay</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("googlePay")]
    public GooglePayInfo1? GooglePay { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>ideal</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ideal")]
    public GenericPmWithTdiInfo6? Ideal { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>interac_card</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interac_card")]
    public GenericPmWithTdiInfo7? InteracCard { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>jcb</b>.
    /// For merchants operating in Japan, <c>midNumber</c>, <c>reuseMidNumber</c>, and <c>serviceLevel</c> fields are required.
    /// For merchants operating outside of Japan, these fields are not required.
    /// For merchants operating in Australia, New Zealand &amp; Canada, JCB and American Express are automatically requested together.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("jcb")]
    public JcbInfo1? Jcb { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>klarna</b> or its variant.
    /// <para>
    /// You can use the following payment method <c>type</c> values for Klarna:
    /// * <b>klarna</b>: Klarna Pay Later
    /// * <b>klarna_account</b>: Klarna Pay over time
    /// * <b>klarna_paynow</b>: Klarna Pay now
    /// * <b>klarna_b2b</b>: <see href="https://docs.adyen.com/payment-methods/klarna/billie">Billie via Klarna</see>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("klarna")]
    public KlarnaInfo1? Klarna { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>maestro</b>.
    /// In the US, <c>maestro</c> is not supported; use <c>maestro_usa</c> instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maestro")]
    public GenericPmWithTdiInfo8? Maestro { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>maestro_usa</b>.
    /// Only for Maestro USA, otherwise use <c>maestro</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maestro_usa")]
    public GenericPmWithTdiInfo9? MaestroUsa { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>mc</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mc")]
    public GenericPmWithTdiInfo10? Mc { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>mealVoucher_FR</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mealVoucher_FR")]
    public MealVoucherFrInfo1? MealVoucherFr { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>nyce</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nyce")]
    public NyceInfo1? Nyce { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>paybybank_plaid</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paybybank_plaid")]
    public PayByBankPlaidInfo1? PaybybankPlaid { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>payme</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payme")]
    public PayMeInfo1? Payme { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>paypal</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paypal")]
    public PayPalInfo1? Paypal { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>payto</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payto")]
    public PayToInfo1? Payto { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>pulse</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pulse")]
    public PulseInfo2? Pulse { get; init; }

    /// <summary>
    /// Your reference for the payment method. Supported characters a-z, A-Z, 0-9.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    [MaxLength(150)]
    public string? Reference { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>sepadirectdebit</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sepadirectdebit")]
    public SepaDirectDebitInfo2? Sepadirectdebit { get; init; }

    /// <summary>
    /// The sales channel. Required if:
    /// - The merchant account does not have a sales channel.
    /// - <c>type</c> is <b>alipay</b>.
    /// <para>
    /// When you provide this field, it overrides the default sales channel set on the merchant account.
    /// </para>
    /// <para>
    /// Possible values: <b>eCommerce</b>, <b>pos</b>, <b>contAuth</b>, and <b>moto</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperInteraction")]
    public ShopperInteraction1? ShopperInteraction { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>sodexo</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sodexo")]
    public SodexoInfo2? Sodexo { get; init; }

    /// <summary>
    /// Sofort details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sofort")]
    public SofortInfo2? Sofort { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>star</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("star")]
    public StarInfo2? Star { get; init; }

    /// <summary>
    /// The unique identifier of the store for which to configure the payment method, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeIds")]
    public IReadOnlyList<string>? StoreIds { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>svs</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("svs")]
    public SvsInfo2? Svs { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>swish</b>.
    ///  - This field is required only if you have a contract with Swish. Swish handles settlement directly with you (not through Adyen).
    ///  - If not specified then it's assumed that you are using Adyen's contract with Swish.You don't have a direct relationship with Swish.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("swish")]
    public SwishInfo2? Swish { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>ticket</b> (Edenred Brazil).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ticket")]
    public TicketInfo2? Ticket { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>twint</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("twint")]
    public TwintInfo2? Twint { get; init; }

    /// <summary>
    /// Payment method <see href="https://docs.adyen.com/development-resources/paymentmethodvariant#management-api">variant</see>.
    /// </summary>
    [JsonPropertyName("type")]
    public required Type59 Type { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>valuelink</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("valuelink")]
    public ValuelinkInfo2? Valuelink { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>vipps</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vipps")]
    public VippsInfo2? Vipps { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>visa</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visa")]
    public GenericPmWithTdiInfo11? Visa { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>wechatpay</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wechatpay")]
    public WeChatPayInfo2? Wechatpay { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>wechatpay_pos</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wechatpay_pos")]
    public WeChatPayPosInfo2? WechatpayPos { get; init; }
}
