using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Payment method <see href="https://docs.adyen.com/development-resources/paymentmethodvariant#management-api">variant</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type510>))]
public sealed record Type510 : StringEnum<Type510>
{
    private Type510(string value) : base(value)
    {
    }

    public static readonly Type510 Abrapetite = new("abrapetite");

    public static readonly Type510 AbrapetiteCredit = new("abrapetite_credit");

    public static readonly Type510 AbrapetiteDebit = new("abrapetite_debit");

    public static readonly Type510 AbrapetitePrepaid = new("abrapetite_prepaid");

    public static readonly Type510 Accel = new("accel");

    public static readonly Type510 Ach = new("ach");

    public static readonly Type510 Affirm = new("affirm");

    public static readonly Type510 Afterpaytouch = new("afterpaytouch");

    public static readonly Type510 Alelo = new("alelo");

    public static readonly Type510 Alipay = new("alipay");

    public static readonly Type510 AlipayHk = new("alipay_hk");

    public static readonly Type510 AlipayPlus = new("alipay_plus");

    public static readonly Type510 AlipayPlusAlipayCn = new("alipay_plus_alipay_cn");

    public static readonly Type510 AlipayPlusAlipayHk = new("alipay_plus_alipay_hk");

    public static readonly Type510 AlipayPlusDana = new("alipay_plus_dana");

    public static readonly Type510 AlipayPlusGcash = new("alipay_plus_gcash");

    public static readonly Type510 AlipayPlusKakaopay = new("alipay_plus_kakaopay");

    public static readonly Type510 AlipayPlusKplus = new("alipay_plus_kplus");

    public static readonly Type510 AlipayPlusNaverpay = new("alipay_plus_naverpay");

    public static readonly Type510 AlipayPlusRabbitlinepay = new("alipay_plus_rabbitlinepay");

    public static readonly Type510 AlipayPlusTosspay = new("alipay_plus_tosspay");

    public static readonly Type510 AlipayPlusTouchngo = new("alipay_plus_touchngo");

    public static readonly Type510 AlipayPlusTruemoney = new("alipay_plus_truemoney");

    public static readonly Type510 AlipayWap = new("alipay_wap");

    public static readonly Type510 Amex = new("amex");

    public static readonly Type510 Applepay = new("applepay");

    public static readonly Type510 Avancard = new("avancard");

    public static readonly Type510 AvancardCredit = new("avancard_credit");

    public static readonly Type510 AvancardDebit = new("avancard_debit");

    public static readonly Type510 BaneseCard = new("banese_card");

    public static readonly Type510 BaneseCardCredit = new("banese_card_credit");

    public static readonly Type510 BaneseCardDebit = new("banese_card_debit");

    public static readonly Type510 BaneseCardPrepaid = new("banese_card_prepaid");

    public static readonly Type510 Bcmc = new("bcmc");

    public static readonly Type510 Blik = new("blik");

    public static readonly Type510 BlikPos = new("blik_pos");

    public static readonly Type510 BrSchemes = new("br_schemes");

    public static readonly Type510 Carnet = new("carnet");

    public static readonly Type510 Cartebancaire = new("cartebancaire");

    public static readonly Type510 Cashapp = new("cashapp");

    public static readonly Type510 Clearpay = new("clearpay");

    public static readonly Type510 Clicktopay = new("clicktopay");

    public static readonly Type510 Cooper = new("cooper");

    public static readonly Type510 CooperCredit = new("cooper_credit");

    public static readonly Type510 CooperDebit = new("cooper_debit");

    public static readonly Type510 CooperFoodDebit = new("cooper_food_debit");

    public static readonly Type510 CooperMealDebit = new("cooper_meal_debit");

    public static readonly Type510 CooperPrepaid = new("cooper_prepaid");

    public static readonly Type510 CooperPrivateCredit = new("cooper_private_credit");

    public static readonly Type510 CooperRetailCredit = new("cooper_retail_credit");

    public static readonly Type510 Credtodos = new("credtodos");

    public static readonly Type510 CredtodosPrivateCredit = new("credtodos_private_credit");

    public static readonly Type510 CredtodosPrivateDebit = new("credtodos_private_debit");

    public static readonly Type510 Cup = new("cup");

    public static readonly Type510 Diners = new("diners");

    public static readonly Type510 DirectdebitGb = new("directdebit_GB");

    public static readonly Type510 Discover = new("discover");

    public static readonly Type510 EbankingFi = new("ebanking_FI");

    public static readonly Type510 EftDirectdebitCa = new("eft_directdebit_CA");

    public static readonly Type510 EftposAustralia = new("eftpos_australia");

    public static readonly Type510 Elo = new("elo");

    public static readonly Type510 Elocredit = new("elocredit");

    public static readonly Type510 Elodebit = new("elodebit");

    public static readonly Type510 Girocard = new("girocard");

    public static readonly Type510 Givex = new("givex");

    public static readonly Type510 Googlepay = new("googlepay");

    public static readonly Type510 GreenCard = new("green_card");

    public static readonly Type510 GreenCardCredit = new("green_card_credit");

    public static readonly Type510 GreenCardDebit = new("green_card_debit");

    public static readonly Type510 GreenCardFoodPrepaid = new("green_card_food_prepaid");

    public static readonly Type510 GreenCardMealPrepaid = new("green_card_meal_prepaid");

    public static readonly Type510 GreenCardPrepaid = new("green_card_prepaid");

    public static readonly Type510 Hiper = new("hiper");

    public static readonly Type510 Hipercard = new("hipercard");

    public static readonly Type510 Ideal = new("ideal");

    public static readonly Type510 InteracCard = new("interac_card");

    public static readonly Type510 Jcb = new("jcb");

    public static readonly Type510 Klarna = new("klarna");

    public static readonly Type510 KlarnaAccount = new("klarna_account");

    public static readonly Type510 KlarnaB2B = new("klarna_b2b");

    public static readonly Type510 KlarnaPaynow = new("klarna_paynow");

    public static readonly Type510 LeCard = new("le_card");

    public static readonly Type510 LeCardCredit = new("le_card_credit");

    public static readonly Type510 LeCardDebit = new("le_card_debit");

    public static readonly Type510 Maestro = new("maestro");

    public static readonly Type510 MaestroUsa = new("maestro_usa");

    public static readonly Type510 Maxifrota = new("maxifrota");

    public static readonly Type510 MaxifrotaPrepaid = new("maxifrota_prepaid");

    public static readonly Type510 Mbway = new("mbway");

    public static readonly Type510 Mc = new("mc");

    public static readonly Type510 Mcdebit = new("mcdebit");

    public static readonly Type510 MealVoucherFr = new("mealVoucher_FR");

    public static readonly Type510 Megaleve = new("megaleve");

    public static readonly Type510 MegaleveCredit = new("megaleve_credit");

    public static readonly Type510 MegaleveDebit = new("megaleve_debit");

    public static readonly Type510 Mobilepay = new("mobilepay");

    public static readonly Type510 Multibanco = new("multibanco");

    public static readonly Type510 Nutricash = new("nutricash");

    public static readonly Type510 NutricashPrepaid = new("nutricash_prepaid");

    public static readonly Type510 Nyce = new("nyce");

    public static readonly Type510 OnlineBankingPl = new("onlineBanking_PL");

    public static readonly Type510 Paybybank = new("paybybank");

    public static readonly Type510 PaybybankPlaid = new("paybybank_plaid");

    public static readonly Type510 Payme = new("payme");

    public static readonly Type510 PaymePos = new("payme_pos");

    public static readonly Type510 Paynow = new("paynow");

    public static readonly Type510 PaynowPos = new("paynow_pos");

    public static readonly Type510 Paypal = new("paypal");

    public static readonly Type510 Payto = new("payto");

    public static readonly Type510 PersonalCard = new("personal_card");

    public static readonly Type510 PersonalCardCredit = new("personal_card_credit");

    public static readonly Type510 PersonalCardDebit = new("personal_card_debit");

    public static readonly Type510 Pulse = new("pulse");

    public static readonly Type510 Romcard = new("romcard");

    public static readonly Type510 RomcardCredit = new("romcard_credit");

    public static readonly Type510 RomcardDebit = new("romcard_debit");

    public static readonly Type510 Senff = new("senff");

    public static readonly Type510 SenffCredit = new("senff_credit");

    public static readonly Type510 Sepadirectdebit = new("sepadirectdebit");

    public static readonly Type510 Sodexo = new("sodexo");

    public static readonly Type510 Star = new("star");

    public static readonly Type510 Svs = new("svs");

    public static readonly Type510 Swish = new("swish");

    public static readonly Type510 Ticket = new("ticket");

    public static readonly Type510 TodoGiftcard = new("todo_giftcard");

    public static readonly Type510 Trustly = new("trustly");

    public static readonly Type510 Twint = new("twint");

    public static readonly Type510 TwintPos = new("twint_pos");

    public static readonly Type510 UpBrazil = new("up_brazil");

    public static readonly Type510 UpBrazilCredit = new("up_brazil_credit");

    public static readonly Type510 UpBrazilDebit = new("up_brazil_debit");

    public static readonly Type510 UpBrazilPrepaid = new("up_brazil_prepaid");

    public static readonly Type510 ValeRefeicao = new("vale_refeicao");

    public static readonly Type510 ValeRefeicaoPrepaid = new("vale_refeicao_prepaid");

    public static readonly Type510 Valuelink = new("valuelink");

    public static readonly Type510 VegasCard = new("vegas_card");

    public static readonly Type510 VegasCardCredit = new("vegas_card_credit");

    public static readonly Type510 VegasCardDebit = new("vegas_card_debit");

    public static readonly Type510 VeroCard = new("vero_card");

    public static readonly Type510 VeroCardCredit = new("vero_card_credit");

    public static readonly Type510 VeroCardDebit = new("vero_card_debit");

    public static readonly Type510 VeroCardPrepaid = new("vero_card_prepaid");

    public static readonly Type510 Vipps = new("vipps");

    public static readonly Type510 Visa = new("visa");

    public static readonly Type510 Visadebit = new("visadebit");

    public static readonly Type510 Vpay = new("vpay");

    public static readonly Type510 Wechatpay = new("wechatpay");

    public static readonly Type510 WechatpayPos = new("wechatpay_pos");

    public static Type510 FromValue(string value) => FromValueCore(value);
}
