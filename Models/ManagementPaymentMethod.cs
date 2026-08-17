using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ManagementPaymentMethod
{
    /// <summary>
    /// <b>accel</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accel")]
    public AccelResponseInfo1? Accel { get; init; }

    /// <summary>
    /// *affirm** details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("affirm")]
    public AffirmResponseInfo1? Affirm { get; init; }

    /// <summary>
    /// <b>afterpaytouch</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("afterpayTouch")]
    public AfterpayTouchResponseInfo1? AfterpayTouch { get; init; }

    /// <summary>
    /// <b>alipay_plus</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alipayPlus")]
    public AlipayPlusResponseInfo1? AlipayPlus { get; init; }

    /// <summary>
    /// Indicates whether receiving payments is allowed. This value is set to <b>true</b> by Adyen after screening your merchant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowed")]
    public bool? Allowed { get; init; }

    /// <summary>
    /// <b>amex</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amex")]
    public AmexResponseInfo1? Amex { get; init; }

    /// <summary>
    /// <b>applepay</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applePay")]
    public ApplePayResponseInfo1? ApplePay { get; init; }

    /// <summary>
    /// Payment methods that were also updated as part of an associated transition.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("associatedPaymentMethods")]
    public IReadOnlyList<AssociatedPaymentMethod>? AssociatedPaymentMethods { get; init; }

    /// <summary>
    /// <b>bcmc</b> (Bancontact) details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bcmc")]
    public BcmcResponseInfo1? Bcmc { get; init; }

    /// <summary>
    /// The unique identifier of the business line. Required if you are a <see href="https://docs.adyen.com/platforms">platform model</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessLineId")]
    public string? BusinessLineId { get; init; }

    /// <summary>
    /// <b>carnet</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carnet")]
    public CarnetResponseInfo1? Carnet { get; init; }

    /// <summary>
    /// <b>cartesbancaire</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cartesBancaires")]
    public CartesBancairesResponseInfo1? CartesBancaires { get; init; }

    /// <summary>
    /// <b>clearpay</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clearpay")]
    public ClearpayResponseInfo1? Clearpay { get; init; }

    /// <summary>
    /// The list of countries where a payment method is available. By default, all countries supported by the payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countries")]
    public IReadOnlyList<string>? Countries { get; init; }

    /// <summary>
    /// <b>cup</b> (China Union Pay) details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cup")]
    public CupResponseInfo1? Cup { get; init; }

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
    /// <b>diners</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("diners")]
    public DinersResponseInfo1? Diners { get; init; }

    /// <summary>
    /// <b>discover</b>. details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discover")]
    public DiscoverResponseInfo1? Discover { get; init; }

    /// <summary>
    /// <b>eft_directdebit_CA</b> (EFT PAD) details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eft_directdebit_CA")]
    public EftDirectDebitCaResponseInfo1? EftDirectdebitCa { get; init; }

    /// <summary>
    /// <b>eftpos_australia</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eftpos_australia")]
    public EftPosAustraliaResponseInfo1? EftposAustralia { get; init; }

    /// <summary>
    /// Indicates whether the payment method is enabled (<b>true</b>) or disabled (<b>false</b>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }

    /// <summary>
    /// <b>girocard</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("girocard")]
    public GirocardResponseInfo1? Girocard { get; init; }

    /// <summary>
    /// <b>givex</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("givex")]
    public GivexResponseInfo1? Givex { get; init; }

    /// <summary>
    /// <b>googlepay</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("googlePay")]
    public GooglePayResponseInfo1? GooglePay { get; init; }

    /// <summary>
    /// The identifier of the resource.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// <b>ideal</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ideal")]
    public IdealResponseInfo1? Ideal { get; init; }

    /// <summary>
    /// <b>interac_card</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interac_card")]
    public InteracCardResponseInfo1? InteracCard { get; init; }

    /// <summary>
    /// <b>jcb</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("jcb")]
    public JcbResponseInfo1? Jcb { get; init; }

    /// <summary>
    /// <b>klarna</b> or its variant details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("klarna")]
    public KlarnaResponseInfo1? Klarna { get; init; }

    /// <summary>
    /// <b>maestro</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maestro")]
    public MaestroResponseInfo1? Maestro { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>maestro_usa</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maestro_usa")]
    public MaestroUsaResponseInfo1? MaestroUsa { get; init; }

    /// <summary>
    /// <b>mc</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mc")]
    public McResponseInfo1? Mc { get; init; }

    /// <summary>
    /// <b>mealVoucher_FR</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mealVoucher_FR")]
    public MealVoucherFrResponseInfo1? MealVoucherFr { get; init; }

    /// <summary>
    /// <b>nyce</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nyce")]
    public NyceResponseInfo1? Nyce { get; init; }

    /// <summary>
    /// <b>paybybank_plaid</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paybybank_plaid")]
    public PayByBankPlaidResponseInfo1? PaybybankPlaid { get; init; }

    /// <summary>
    /// <b>payme</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payme")]
    public PayMeResponseInfo1? Payme { get; init; }

    /// <summary>
    /// <b>paypal</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paypal")]
    public PayPalResponseInfo1? Paypal { get; init; }

    /// <summary>
    /// <b>payto</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payto")]
    public PayToResponseInfo1? Payto { get; init; }

    /// <summary>
    /// <b>pulse</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pulse")]
    public PulseResponseInfo2? Pulse { get; init; }

    /// <summary>
    /// Your reference for the payment method. Supported characters a-z, A-Z, 0-9.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    [MaxLength(150)]
    public string? Reference { get; init; }

    /// <summary>
    /// <b>sepadirectdebit</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sepadirectdebit")]
    public SepaDirectDebitResponseInfo2? Sepadirectdebit { get; init; }

    /// <summary>
    /// The sales channel.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperInteraction")]
    public string? ShopperInteraction { get; init; }

    /// <summary>
    /// <b>sodexo</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sodexo")]
    public SodexoResponseInfo2? Sodexo { get; init; }

    /// <summary>
    /// Sofort details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sofort")]
    public SofortResponseInfo2? Sofort { get; init; }

    /// <summary>
    /// <b>star</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("star")]
    public StarResponseInfo2? Star { get; init; }

    /// <summary>
    /// The unique identifier of the store for which to configure the payment method, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeIds")]
    public IReadOnlyList<string>? StoreIds { get; init; }

    /// <summary>
    /// <b>svs</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("svs")]
    public SvsResponseInfo2? Svs { get; init; }

    /// <summary>
    /// <b>swish</b> or its variant details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("swish")]
    public SwishResponseInfo2? Swish { get; init; }

    /// <summary>
    /// <b>ticket</b> (Edenred Brazil) details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ticket")]
    public TicketResponseInfo2? Ticket { get; init; }

    /// <summary>
    /// <b>twint</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("twint")]
    public TwintResponseInfo2? Twint { get; init; }

    /// <summary>
    /// Payment method <see href="https://docs.adyen.com/development-resources/paymentmethodvariant#management-api">variant</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// <b>valuelink</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("valuelink")]
    public ValuelinkResponseInfo2? Valuelink { get; init; }

    /// <summary>
    /// Payment method status. Possible values:
    /// * <b>valid</b>
    /// * <b>pending</b>
    /// * <b>invalid</b>
    /// * <b>rejected</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verificationStatus")]
    public VerificationStatus? VerificationStatus { get; init; }

    /// <summary>
    /// <b>vipps</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vipps")]
    public VippsResponseInfo2? Vipps { get; init; }

    /// <summary>
    /// <b>visa</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visa")]
    public VisaResponseInfo2? Visa { get; init; }

    /// <summary>
    /// <b>wechatpay</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wechatpay")]
    public WeChatPayResponseInfo2? Wechatpay { get; init; }

    /// <summary>
    /// <b>wechatpay_pos</b> details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wechatpay_pos")]
    public WeChatPayPosResponseInfo2? WechatpayPos { get; init; }
}
