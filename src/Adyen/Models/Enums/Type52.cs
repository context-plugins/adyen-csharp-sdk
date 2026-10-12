using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The payment method type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type52>))]
public sealed record Type52 : OpenStringEnum<Type52>
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

    public TResult Match<TResult>(Func<TResult> onAlipayPlus,
        Func<TResult> onAlipayPlusAlipayCn,
        Func<TResult> onAlipayPlusAlipayHk,
        Func<TResult> onAlipayPlusDana,
        Func<TResult> onAlipayPlusGcash,
        Func<TResult> onAlipayPlusKakaopay,
        Func<TResult> onAlipayPlusKplus,
        Func<TResult> onAlipayPlusNaverpay,
        Func<TResult> onAlipayPlusRabbitlinepay,
        Func<TResult> onAlipayPlusTosspay,
        Func<TResult> onAlipayPlusTouchngo,
        Func<TResult> onAlipayPlusTruemoney,
        Func<TResult> onBcmcMobile,
        Func<TResult> onBcmcMobileQr,
        Func<TResult> onBcmcMobileApp,
        Func<TResult> onMomoWallet,
        Func<TResult> onMomoWalletApp,
        Func<TResult> onPaymayaWallet,
        Func<TResult> onGrabpaySg,
        Func<TResult> onGrabpayMy,
        Func<TResult> onGrabpayTh,
        Func<TResult> onGrabpayId,
        Func<TResult> onGrabpayVn,
        Func<TResult> onGrabpayPh,
        Func<TResult> onOxxo,
        Func<TResult> onGcash,
        Func<TResult> onDana,
        Func<TResult> onKakaopay,
        Func<TResult> onTruemoney,
        Func<TResult> onPaysafecard,
        Func<TResult> onGopayWallet,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AlipayPlus => onAlipayPlus(),
            _ when this == AlipayPlusAlipayCn => onAlipayPlusAlipayCn(),
            _ when this == AlipayPlusAlipayHk => onAlipayPlusAlipayHk(),
            _ when this == AlipayPlusDana => onAlipayPlusDana(),
            _ when this == AlipayPlusGcash => onAlipayPlusGcash(),
            _ when this == AlipayPlusKakaopay => onAlipayPlusKakaopay(),
            _ when this == AlipayPlusKplus => onAlipayPlusKplus(),
            _ when this == AlipayPlusNaverpay => onAlipayPlusNaverpay(),
            _ when this == AlipayPlusRabbitlinepay => onAlipayPlusRabbitlinepay(),
            _ when this == AlipayPlusTosspay => onAlipayPlusTosspay(),
            _ when this == AlipayPlusTouchngo => onAlipayPlusTouchngo(),
            _ when this == AlipayPlusTruemoney => onAlipayPlusTruemoney(),
            _ when this == BcmcMobile => onBcmcMobile(),
            _ when this == BcmcMobileQr => onBcmcMobileQr(),
            _ when this == BcmcMobileApp => onBcmcMobileApp(),
            _ when this == MomoWallet => onMomoWallet(),
            _ when this == MomoWalletApp => onMomoWalletApp(),
            _ when this == PaymayaWallet => onPaymayaWallet(),
            _ when this == GrabpaySg => onGrabpaySg(),
            _ when this == GrabpayMy => onGrabpayMy(),
            _ when this == GrabpayTh => onGrabpayTh(),
            _ when this == GrabpayId => onGrabpayId(),
            _ when this == GrabpayVn => onGrabpayVn(),
            _ when this == GrabpayPh => onGrabpayPh(),
            _ when this == Oxxo => onOxxo(),
            _ when this == Gcash => onGcash(),
            _ when this == Dana => onDana(),
            _ when this == Kakaopay => onKakaopay(),
            _ when this == Truemoney => onTruemoney(),
            _ when this == Paysafecard => onPaysafecard(),
            _ when this == GopayWallet => onGopayWallet(),
            _ => otherwise(Value)
        };

    public void Match(Action onAlipayPlus,
        Action onAlipayPlusAlipayCn,
        Action onAlipayPlusAlipayHk,
        Action onAlipayPlusDana,
        Action onAlipayPlusGcash,
        Action onAlipayPlusKakaopay,
        Action onAlipayPlusKplus,
        Action onAlipayPlusNaverpay,
        Action onAlipayPlusRabbitlinepay,
        Action onAlipayPlusTosspay,
        Action onAlipayPlusTouchngo,
        Action onAlipayPlusTruemoney,
        Action onBcmcMobile,
        Action onBcmcMobileQr,
        Action onBcmcMobileApp,
        Action onMomoWallet,
        Action onMomoWalletApp,
        Action onPaymayaWallet,
        Action onGrabpaySg,
        Action onGrabpayMy,
        Action onGrabpayTh,
        Action onGrabpayId,
        Action onGrabpayVn,
        Action onGrabpayPh,
        Action onOxxo,
        Action onGcash,
        Action onDana,
        Action onKakaopay,
        Action onTruemoney,
        Action onPaysafecard,
        Action onGopayWallet,
        Action<string> otherwise)
    {
        if (this == AlipayPlus) onAlipayPlus();
        else if (this == AlipayPlusAlipayCn) onAlipayPlusAlipayCn();
        else if (this == AlipayPlusAlipayHk) onAlipayPlusAlipayHk();
        else if (this == AlipayPlusDana) onAlipayPlusDana();
        else if (this == AlipayPlusGcash) onAlipayPlusGcash();
        else if (this == AlipayPlusKakaopay) onAlipayPlusKakaopay();
        else if (this == AlipayPlusKplus) onAlipayPlusKplus();
        else if (this == AlipayPlusNaverpay) onAlipayPlusNaverpay();
        else if (this == AlipayPlusRabbitlinepay) onAlipayPlusRabbitlinepay();
        else if (this == AlipayPlusTosspay) onAlipayPlusTosspay();
        else if (this == AlipayPlusTouchngo) onAlipayPlusTouchngo();
        else if (this == AlipayPlusTruemoney) onAlipayPlusTruemoney();
        else if (this == BcmcMobile) onBcmcMobile();
        else if (this == BcmcMobileQr) onBcmcMobileQr();
        else if (this == BcmcMobileApp) onBcmcMobileApp();
        else if (this == MomoWallet) onMomoWallet();
        else if (this == MomoWalletApp) onMomoWalletApp();
        else if (this == PaymayaWallet) onPaymayaWallet();
        else if (this == GrabpaySg) onGrabpaySg();
        else if (this == GrabpayMy) onGrabpayMy();
        else if (this == GrabpayTh) onGrabpayTh();
        else if (this == GrabpayId) onGrabpayId();
        else if (this == GrabpayVn) onGrabpayVn();
        else if (this == GrabpayPh) onGrabpayPh();
        else if (this == Oxxo) onOxxo();
        else if (this == Gcash) onGcash();
        else if (this == Dana) onDana();
        else if (this == Kakaopay) onKakaopay();
        else if (this == Truemoney) onTruemoney();
        else if (this == Paysafecard) onPaysafecard();
        else if (this == GopayWallet) onGopayWallet();
        else otherwise(Value);
    }
}
