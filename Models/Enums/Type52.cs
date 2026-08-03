using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The payment method type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type52>))]
public sealed record Type52 : StringEnum<Type52>
{
    private Type52(string value) : base(value)
    {
    }

    public static readonly Type52 AlipayPlus = new("alipay_plus");

    public static readonly Type52 AlipayPlusAlipayCn = new("alipay_plus_alipay_cn");

    public static readonly Type52 AlipayPlusAlipayHk = new("alipay_plus_alipay_hk");

    public static readonly Type52 AlipayPlusDana = new("alipay_plus_dana");

    public static readonly Type52 AlipayPlusGcash = new("alipay_plus_gcash");

    public static readonly Type52 AlipayPlusKakaopay = new("alipay_plus_kakaopay");

    public static readonly Type52 AlipayPlusKplus = new("alipay_plus_kplus");

    public static readonly Type52 AlipayPlusNaverpay = new("alipay_plus_naverpay");

    public static readonly Type52 AlipayPlusRabbitlinepay = new("alipay_plus_rabbitlinepay");

    public static readonly Type52 AlipayPlusTosspay = new("alipay_plus_tosspay");

    public static readonly Type52 AlipayPlusTouchngo = new("alipay_plus_touchngo");

    public static readonly Type52 AlipayPlusTruemoney = new("alipay_plus_truemoney");

    public static readonly Type52 BcmcMobile = new("bcmc_mobile");

    public static readonly Type52 BcmcMobileQr = new("bcmc_mobile_QR");

    public static readonly Type52 BcmcMobileApp = new("bcmc_mobile_app");

    public static readonly Type52 MomoWallet = new("momo_wallet");

    public static readonly Type52 MomoWalletApp = new("momo_wallet_app");

    public static readonly Type52 PaymayaWallet = new("paymaya_wallet");

    public static readonly Type52 GrabpaySg = new("grabpay_SG");

    public static readonly Type52 GrabpayMy = new("grabpay_MY");

    public static readonly Type52 GrabpayTh = new("grabpay_TH");

    public static readonly Type52 GrabpayId = new("grabpay_ID");

    public static readonly Type52 GrabpayVn = new("grabpay_VN");

    public static readonly Type52 GrabpayPh = new("grabpay_PH");

    public static readonly Type52 Oxxo = new("oxxo");

    public static readonly Type52 Gcash = new("gcash");

    public static readonly Type52 Dana = new("dana");

    public static readonly Type52 Kakaopay = new("kakaopay");

    public static readonly Type52 Truemoney = new("truemoney");

    public static readonly Type52 Paysafecard = new("paysafecard");

    public static readonly Type52 GopayWallet = new("gopay_wallet");

    public static Type52 FromValue(string value) => FromValueCore(value);
}
