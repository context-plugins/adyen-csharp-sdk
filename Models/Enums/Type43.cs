using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The payment method type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type43>))]
public sealed record Type43 : StringEnum<Type43>
{
    private Type43(string value) : base(value)
    {
    }

    public static readonly Type43 Alipay = new("alipay");

    public static readonly Type43 Multibanco = new("multibanco");

    public static readonly Type43 BankTransfer = new("bankTransfer");

    public static readonly Type43 BankTransferIban = new("bankTransfer_IBAN");

    public static readonly Type43 Paynow = new("paynow");

    public static readonly Type43 AffirmPos = new("affirm_pos");

    public static readonly Type43 Iris = new("iris");

    public static readonly Type43 Wero = new("wero");

    public static readonly Type43 Trustly = new("trustly");

    public static readonly Type43 Trustlyvector = new("trustlyvector");

    public static readonly Type43 Oney = new("oney");

    public static readonly Type43 Facilypay = new("facilypay");

    public static readonly Type43 Facilypay3X = new("facilypay_3x");

    public static readonly Type43 Facilypay4X = new("facilypay_4x");

    public static readonly Type43 Facilypay6X = new("facilypay_6x");

    public static readonly Type43 Facilypay10X = new("facilypay_10x");

    public static readonly Type43 Facilypay12X = new("facilypay_12x");

    public static readonly Type43 Unionpay = new("unionpay");

    public static readonly Type43 KcpBanktransfer = new("kcp_banktransfer");

    public static readonly Type43 KcpPayco = new("kcp_payco");

    public static readonly Type43 KcpCreditcard = new("kcp_creditcard");

    public static readonly Type43 WechatpaySdk = new("wechatpaySDK");

    public static readonly Type43 WechatpayQr = new("wechatpayQR");

    public static readonly Type43 WechatpayWeb = new("wechatpayWeb");

    public static readonly Type43 MolpayBoost = new("molpay_boost");

    public static readonly Type43 WalletIn = new("wallet_IN");

    public static readonly Type43 PayuInCashcard = new("payu_IN_cashcard");

    public static readonly Type43 PayuInNb = new("payu_IN_nb");

    public static readonly Type43 Paytm = new("paytm");

    public static readonly Type43 MolpayEbankingVn = new("molpay_ebanking_VN");

    public static readonly Type43 MolpayEbankingMy = new("molpay_ebanking_MY");

    public static readonly Type43 MolpayEbankingDirectMy = new("molpay_ebanking_direct_MY");

    public static readonly Type43 Swish = new("swish");

    public static readonly Type43 Bizum = new("bizum");

    public static readonly Type43 Walley = new("walley");

    public static readonly Type43 WalleyB2B = new("walley_b2b");

    public static readonly Type43 Paypo = new("paypo");

    public static readonly Type43 Scalapay = new("scalapay");

    public static readonly Type43 Scalapay3X = new("scalapay_3x");

    public static readonly Type43 Scalapay4X = new("scalapay_4x");

    public static readonly Type43 MolpayFpx = new("molpay_fpx");

    public static readonly Type43 Payme = new("payme");

    public static readonly Type43 PaymePos = new("payme_pos");

    public static readonly Type43 Konbini = new("konbini");

    public static readonly Type43 DirectEbanking = new("directEbanking");

    public static readonly Type43 Boletobancario = new("boletobancario");

    public static readonly Type43 Cashticket = new("cashticket");

    public static readonly Type43 Ikano = new("ikano");

    public static readonly Type43 Karenmillen = new("karenmillen");

    public static readonly Type43 Oasis = new("oasis");

    public static readonly Type43 Warehouse = new("warehouse");

    public static readonly Type43 PrimeiropayBoleto = new("primeiropay_boleto");

    public static readonly Type43 Mada = new("mada");

    public static readonly Type43 Benefit = new("benefit");

    public static readonly Type43 Knet = new("knet");

    public static readonly Type43 Omannet = new("omannet");

    public static readonly Type43 KcpNaverpay = new("kcp_naverpay");

    public static readonly Type43 Fawry = new("fawry");

    public static readonly Type43 Atome = new("atome");

    public static readonly Type43 Naps = new("naps");

    public static readonly Type43 Nordea = new("nordea");

    public static readonly Type43 BoletobancarioBradesco = new("boletobancario_bradesco");

    public static readonly Type43 BoletobancarioItau = new("boletobancario_itau");

    public static readonly Type43 BoletobancarioSantander = new("boletobancario_santander");

    public static readonly Type43 BoletobancarioBancodobrasil = new("boletobancario_bancodobrasil");

    public static readonly Type43 BoletobancarioHsbc = new("boletobancario_hsbc");

    public static readonly Type43 MolpayMaybank2U = new("molpay_maybank2u");

    public static readonly Type43 MolpayCimb = new("molpay_cimb");

    public static readonly Type43 MolpayRhb = new("molpay_rhb");

    public static readonly Type43 MolpayAmb = new("molpay_amb");

    public static readonly Type43 MolpayHlb = new("molpay_hlb");

    public static readonly Type43 MolpayAffinEpg = new("molpay_affin_epg");

    public static readonly Type43 MolpayBankislam = new("molpay_bankislam");

    public static readonly Type43 MolpayPublicbank = new("molpay_publicbank");

    public static readonly Type43 FpxAgrobank = new("fpx_agrobank");

    public static readonly Type43 Touchngo = new("touchngo");

    public static readonly Type43 Maybank2UMae = new("maybank2u_mae");

    public static readonly Type43 Duitnow = new("duitnow");

    public static readonly Type43 Promptpay = new("promptpay");

    public static readonly Type43 TwintPos = new("twint_pos");

    public static readonly Type43 AlipayHk = new("alipay_hk");

    public static readonly Type43 AlipayHkWeb = new("alipay_hk_web");

    public static readonly Type43 AlipayHkWap = new("alipay_hk_wap");

    public static readonly Type43 AlipayWap = new("alipay_wap");

    public static readonly Type43 Balanceplatform = new("balanceplatform");

    public static Type43 FromValue(string value) => FromValueCore(value);
}
