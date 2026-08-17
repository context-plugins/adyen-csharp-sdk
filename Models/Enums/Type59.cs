using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Payment method <see href="https://docs.adyen.com/development-resources/paymentmethodvariant#management-api">variant</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type59>))]
public sealed record Type59 : StringEnum<Type59>
{
    private Type59(string value) : base(value)
    {
    }

    public static readonly Type59 Abrapetite = new("abrapetite");

    public static readonly Type59 AbrapetiteCredit = new("abrapetite_credit");

    public static readonly Type59 AbrapetiteDebit = new("abrapetite_debit");

    public static readonly Type59 AbrapetitePrepaid = new("abrapetite_prepaid");

    public static readonly Type59 Accel = new("accel");

    public static readonly Type59 Ach = new("ach");

    public static readonly Type59 Affirm = new("affirm");

    public static readonly Type59 Afterpaytouch = new("afterpaytouch");

    public static readonly Type59 Alelo = new("alelo");

    public static readonly Type59 Alipay = new("alipay");

    public static readonly Type59 AlipayHk = new("alipay_hk");

    public static readonly Type59 AlipayPlus = new("alipay_plus");

    public static readonly Type59 AlipayPlusAlipayCn = new("alipay_plus_alipay_cn");

    public static readonly Type59 AlipayPlusAlipayHk = new("alipay_plus_alipay_hk");

    public static readonly Type59 AlipayPlusDana = new("alipay_plus_dana");

    public static readonly Type59 AlipayPlusGcash = new("alipay_plus_gcash");

    public static readonly Type59 AlipayPlusKakaopay = new("alipay_plus_kakaopay");

    public static readonly Type59 AlipayPlusKplus = new("alipay_plus_kplus");

    public static readonly Type59 AlipayPlusNaverpay = new("alipay_plus_naverpay");

    public static readonly Type59 AlipayPlusRabbitlinepay = new("alipay_plus_rabbitlinepay");

    public static readonly Type59 AlipayPlusTosspay = new("alipay_plus_tosspay");

    public static readonly Type59 AlipayPlusTouchngo = new("alipay_plus_touchngo");

    public static readonly Type59 AlipayPlusTruemoney = new("alipay_plus_truemoney");

    public static readonly Type59 AlipayWap = new("alipay_wap");

    public static readonly Type59 Amex = new("amex");

    public static readonly Type59 Applepay = new("applepay");

    public static readonly Type59 Avancard = new("avancard");

    public static readonly Type59 AvancardCredit = new("avancard_credit");

    public static readonly Type59 AvancardDebit = new("avancard_debit");

    public static readonly Type59 BaneseCard = new("banese_card");

    public static readonly Type59 BaneseCardCredit = new("banese_card_credit");

    public static readonly Type59 BaneseCardDebit = new("banese_card_debit");

    public static readonly Type59 BaneseCardPrepaid = new("banese_card_prepaid");

    public static readonly Type59 Bcmc = new("bcmc");

    public static readonly Type59 Blik = new("blik");

    public static readonly Type59 BlikPos = new("blik_pos");

    public static readonly Type59 BrSchemes = new("br_schemes");

    public static readonly Type59 Carnet = new("carnet");

    public static readonly Type59 Cartebancaire = new("cartebancaire");

    public static readonly Type59 Cashapp = new("cashapp");

    public static readonly Type59 Clearpay = new("clearpay");

    public static readonly Type59 Clicktopay = new("clicktopay");

    public static readonly Type59 Cooper = new("cooper");

    public static readonly Type59 CooperCredit = new("cooper_credit");

    public static readonly Type59 CooperDebit = new("cooper_debit");

    public static readonly Type59 CooperFoodDebit = new("cooper_food_debit");

    public static readonly Type59 CooperMealDebit = new("cooper_meal_debit");

    public static readonly Type59 CooperPrepaid = new("cooper_prepaid");

    public static readonly Type59 CooperPrivateCredit = new("cooper_private_credit");

    public static readonly Type59 CooperRetailCredit = new("cooper_retail_credit");

    public static readonly Type59 Credtodos = new("credtodos");

    public static readonly Type59 CredtodosPrivateCredit = new("credtodos_private_credit");

    public static readonly Type59 CredtodosPrivateDebit = new("credtodos_private_debit");

    public static readonly Type59 Cup = new("cup");

    public static readonly Type59 Diners = new("diners");

    public static readonly Type59 DirectdebitGb = new("directdebit_GB");

    public static readonly Type59 Discover = new("discover");

    public static readonly Type59 EbankingFi = new("ebanking_FI");

    public static readonly Type59 EftDirectdebitCa = new("eft_directdebit_CA");

    public static readonly Type59 EftposAustralia = new("eftpos_australia");

    public static readonly Type59 Elo = new("elo");

    public static readonly Type59 Elocredit = new("elocredit");

    public static readonly Type59 Elodebit = new("elodebit");

    public static readonly Type59 Girocard = new("girocard");

    public static readonly Type59 Givex = new("givex");

    public static readonly Type59 Googlepay = new("googlepay");

    public static readonly Type59 GreenCard = new("green_card");

    public static readonly Type59 GreenCardCredit = new("green_card_credit");

    public static readonly Type59 GreenCardDebit = new("green_card_debit");

    public static readonly Type59 GreenCardFoodPrepaid = new("green_card_food_prepaid");

    public static readonly Type59 GreenCardMealPrepaid = new("green_card_meal_prepaid");

    public static readonly Type59 GreenCardPrepaid = new("green_card_prepaid");

    public static readonly Type59 Hiper = new("hiper");

    public static readonly Type59 Hipercard = new("hipercard");

    public static readonly Type59 Ideal = new("ideal");

    public static readonly Type59 InteracCard = new("interac_card");

    public static readonly Type59 Jcb = new("jcb");

    public static readonly Type59 Klarna = new("klarna");

    public static readonly Type59 KlarnaAccount = new("klarna_account");

    public static readonly Type59 KlarnaB2B = new("klarna_b2b");

    public static readonly Type59 KlarnaPaynow = new("klarna_paynow");

    public static readonly Type59 LeCard = new("le_card");

    public static readonly Type59 LeCardCredit = new("le_card_credit");

    public static readonly Type59 LeCardDebit = new("le_card_debit");

    public static readonly Type59 Maestro = new("maestro");

    public static readonly Type59 MaestroUsa = new("maestro_usa");

    public static readonly Type59 Maxifrota = new("maxifrota");

    public static readonly Type59 MaxifrotaPrepaid = new("maxifrota_prepaid");

    public static readonly Type59 Mbway = new("mbway");

    public static readonly Type59 Mc = new("mc");

    public static readonly Type59 Mcdebit = new("mcdebit");

    public static readonly Type59 MealVoucherFr = new("mealVoucher_FR");

    public static readonly Type59 Megaleve = new("megaleve");

    public static readonly Type59 MegaleveCredit = new("megaleve_credit");

    public static readonly Type59 MegaleveDebit = new("megaleve_debit");

    public static readonly Type59 Mobilepay = new("mobilepay");

    public static readonly Type59 Multibanco = new("multibanco");

    public static readonly Type59 Nutricash = new("nutricash");

    public static readonly Type59 NutricashPrepaid = new("nutricash_prepaid");

    public static readonly Type59 Nyce = new("nyce");

    public static readonly Type59 OnlineBankingPl = new("onlineBanking_PL");

    public static readonly Type59 Paybybank = new("paybybank");

    public static readonly Type59 PaybybankPlaid = new("paybybank_plaid");

    public static readonly Type59 Payme = new("payme");

    public static readonly Type59 PaymePos = new("payme_pos");

    public static readonly Type59 Paynow = new("paynow");

    public static readonly Type59 PaynowPos = new("paynow_pos");

    public static readonly Type59 Paypal = new("paypal");

    public static readonly Type59 Payto = new("payto");

    public static readonly Type59 PersonalCard = new("personal_card");

    public static readonly Type59 PersonalCardCredit = new("personal_card_credit");

    public static readonly Type59 PersonalCardDebit = new("personal_card_debit");

    public static readonly Type59 Pulse = new("pulse");

    public static readonly Type59 Romcard = new("romcard");

    public static readonly Type59 RomcardCredit = new("romcard_credit");

    public static readonly Type59 RomcardDebit = new("romcard_debit");

    public static readonly Type59 Senff = new("senff");

    public static readonly Type59 SenffCredit = new("senff_credit");

    public static readonly Type59 Sepadirectdebit = new("sepadirectdebit");

    public static readonly Type59 Sodexo = new("sodexo");

    public static readonly Type59 Star = new("star");

    public static readonly Type59 Svs = new("svs");

    public static readonly Type59 Swish = new("swish");

    public static readonly Type59 Ticket = new("ticket");

    public static readonly Type59 TodoGiftcard = new("todo_giftcard");

    public static readonly Type59 Trustly = new("trustly");

    public static readonly Type59 Twint = new("twint");

    public static readonly Type59 TwintPos = new("twint_pos");

    public static readonly Type59 UpBrazil = new("up_brazil");

    public static readonly Type59 UpBrazilCredit = new("up_brazil_credit");

    public static readonly Type59 UpBrazilDebit = new("up_brazil_debit");

    public static readonly Type59 UpBrazilPrepaid = new("up_brazil_prepaid");

    public static readonly Type59 ValeRefeicao = new("vale_refeicao");

    public static readonly Type59 ValeRefeicaoPrepaid = new("vale_refeicao_prepaid");

    public static readonly Type59 Valuelink = new("valuelink");

    public static readonly Type59 VegasCard = new("vegas_card");

    public static readonly Type59 VegasCardCredit = new("vegas_card_credit");

    public static readonly Type59 VegasCardDebit = new("vegas_card_debit");

    public static readonly Type59 VeroCard = new("vero_card");

    public static readonly Type59 VeroCardCredit = new("vero_card_credit");

    public static readonly Type59 VeroCardDebit = new("vero_card_debit");

    public static readonly Type59 VeroCardPrepaid = new("vero_card_prepaid");

    public static readonly Type59 Vipps = new("vipps");

    public static readonly Type59 Visa = new("visa");

    public static readonly Type59 Visadebit = new("visadebit");

    public static readonly Type59 Vpay = new("vpay");

    public static readonly Type59 Wechatpay = new("wechatpay");

    public static readonly Type59 WechatpayPos = new("wechatpay_pos");

    public static Type59 FromValue(string value) => FromValueCore(value);
}
