using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TypesWithError>))]
public sealed record TypesWithError : StringEnum<TypesWithError>
{
    private TypesWithError(string value) : base(value)
    {
    }

    public static readonly TypesWithError Abrapetite = new("abrapetite");

    public static readonly TypesWithError AbrapetiteCredit = new("abrapetite_credit");

    public static readonly TypesWithError AbrapetiteDebit = new("abrapetite_debit");

    public static readonly TypesWithError AbrapetitePrepaid = new("abrapetite_prepaid");

    public static readonly TypesWithError Accel = new("accel");

    public static readonly TypesWithError Ach = new("ach");

    public static readonly TypesWithError Affirm = new("affirm");

    public static readonly TypesWithError Afterpaytouch = new("afterpaytouch");

    public static readonly TypesWithError Alelo = new("alelo");

    public static readonly TypesWithError Alipay = new("alipay");

    public static readonly TypesWithError AlipayHk = new("alipay_hk");

    public static readonly TypesWithError AlipayPlus = new("alipay_plus");

    public static readonly TypesWithError AlipayPlusAlipayCn = new("alipay_plus_alipay_cn");

    public static readonly TypesWithError AlipayPlusAlipayHk = new("alipay_plus_alipay_hk");

    public static readonly TypesWithError AlipayPlusDana = new("alipay_plus_dana");

    public static readonly TypesWithError AlipayPlusGcash = new("alipay_plus_gcash");

    public static readonly TypesWithError AlipayPlusKakaopay = new("alipay_plus_kakaopay");

    public static readonly TypesWithError AlipayPlusKplus = new("alipay_plus_kplus");

    public static readonly TypesWithError AlipayPlusNaverpay = new("alipay_plus_naverpay");

    public static readonly TypesWithError AlipayPlusRabbitlinepay = new("alipay_plus_rabbitlinepay");

    public static readonly TypesWithError AlipayPlusTosspay = new("alipay_plus_tosspay");

    public static readonly TypesWithError AlipayPlusTouchngo = new("alipay_plus_touchngo");

    public static readonly TypesWithError AlipayPlusTruemoney = new("alipay_plus_truemoney");

    public static readonly TypesWithError AlipayWap = new("alipay_wap");

    public static readonly TypesWithError Amex = new("amex");

    public static readonly TypesWithError Applepay = new("applepay");

    public static readonly TypesWithError Avancard = new("avancard");

    public static readonly TypesWithError AvancardCredit = new("avancard_credit");

    public static readonly TypesWithError AvancardDebit = new("avancard_debit");

    public static readonly TypesWithError BaneseCard = new("banese_card");

    public static readonly TypesWithError BaneseCardCredit = new("banese_card_credit");

    public static readonly TypesWithError BaneseCardDebit = new("banese_card_debit");

    public static readonly TypesWithError BaneseCardPrepaid = new("banese_card_prepaid");

    public static readonly TypesWithError Bcmc = new("bcmc");

    public static readonly TypesWithError Blik = new("blik");

    public static readonly TypesWithError BlikPos = new("blik_pos");

    public static readonly TypesWithError BrSchemes = new("br_schemes");

    public static readonly TypesWithError Carnet = new("carnet");

    public static readonly TypesWithError Cartebancaire = new("cartebancaire");

    public static readonly TypesWithError Cashapp = new("cashapp");

    public static readonly TypesWithError Clearpay = new("clearpay");

    public static readonly TypesWithError Clicktopay = new("clicktopay");

    public static readonly TypesWithError Cooper = new("cooper");

    public static readonly TypesWithError CooperCredit = new("cooper_credit");

    public static readonly TypesWithError CooperDebit = new("cooper_debit");

    public static readonly TypesWithError CooperFoodDebit = new("cooper_food_debit");

    public static readonly TypesWithError CooperMealDebit = new("cooper_meal_debit");

    public static readonly TypesWithError CooperPrepaid = new("cooper_prepaid");

    public static readonly TypesWithError CooperPrivateCredit = new("cooper_private_credit");

    public static readonly TypesWithError CooperRetailCredit = new("cooper_retail_credit");

    public static readonly TypesWithError Credtodos = new("credtodos");

    public static readonly TypesWithError CredtodosPrivateCredit = new("credtodos_private_credit");

    public static readonly TypesWithError CredtodosPrivateDebit = new("credtodos_private_debit");

    public static readonly TypesWithError Cup = new("cup");

    public static readonly TypesWithError Diners = new("diners");

    public static readonly TypesWithError DirectdebitGb = new("directdebit_GB");

    public static readonly TypesWithError Discover = new("discover");

    public static readonly TypesWithError EbankingFi = new("ebanking_FI");

    public static readonly TypesWithError EftDirectdebitCa = new("eft_directdebit_CA");

    public static readonly TypesWithError EftposAustralia = new("eftpos_australia");

    public static readonly TypesWithError Elo = new("elo");

    public static readonly TypesWithError Elocredit = new("elocredit");

    public static readonly TypesWithError Elodebit = new("elodebit");

    public static readonly TypesWithError Girocard = new("girocard");

    public static readonly TypesWithError Givex = new("givex");

    public static readonly TypesWithError Googlepay = new("googlepay");

    public static readonly TypesWithError GreenCard = new("green_card");

    public static readonly TypesWithError GreenCardCredit = new("green_card_credit");

    public static readonly TypesWithError GreenCardDebit = new("green_card_debit");

    public static readonly TypesWithError GreenCardFoodPrepaid = new("green_card_food_prepaid");

    public static readonly TypesWithError GreenCardMealPrepaid = new("green_card_meal_prepaid");

    public static readonly TypesWithError GreenCardPrepaid = new("green_card_prepaid");

    public static readonly TypesWithError Hiper = new("hiper");

    public static readonly TypesWithError Hipercard = new("hipercard");

    public static readonly TypesWithError Ideal = new("ideal");

    public static readonly TypesWithError InteracCard = new("interac_card");

    public static readonly TypesWithError Jcb = new("jcb");

    public static readonly TypesWithError Klarna = new("klarna");

    public static readonly TypesWithError KlarnaAccount = new("klarna_account");

    public static readonly TypesWithError KlarnaB2B = new("klarna_b2b");

    public static readonly TypesWithError KlarnaPaynow = new("klarna_paynow");

    public static readonly TypesWithError LeCard = new("le_card");

    public static readonly TypesWithError LeCardCredit = new("le_card_credit");

    public static readonly TypesWithError LeCardDebit = new("le_card_debit");

    public static readonly TypesWithError Maestro = new("maestro");

    public static readonly TypesWithError MaestroUsa = new("maestro_usa");

    public static readonly TypesWithError Maxifrota = new("maxifrota");

    public static readonly TypesWithError MaxifrotaPrepaid = new("maxifrota_prepaid");

    public static readonly TypesWithError Mbway = new("mbway");

    public static readonly TypesWithError Mc = new("mc");

    public static readonly TypesWithError Mcdebit = new("mcdebit");

    public static readonly TypesWithError MealVoucherFr = new("mealVoucher_FR");

    public static readonly TypesWithError Megaleve = new("megaleve");

    public static readonly TypesWithError MegaleveCredit = new("megaleve_credit");

    public static readonly TypesWithError MegaleveDebit = new("megaleve_debit");

    public static readonly TypesWithError Mobilepay = new("mobilepay");

    public static readonly TypesWithError Multibanco = new("multibanco");

    public static readonly TypesWithError Nutricash = new("nutricash");

    public static readonly TypesWithError NutricashPrepaid = new("nutricash_prepaid");

    public static readonly TypesWithError Nyce = new("nyce");

    public static readonly TypesWithError OnlineBankingPl = new("onlineBanking_PL");

    public static readonly TypesWithError Paybybank = new("paybybank");

    public static readonly TypesWithError PaybybankPlaid = new("paybybank_plaid");

    public static readonly TypesWithError Payme = new("payme");

    public static readonly TypesWithError PaymePos = new("payme_pos");

    public static readonly TypesWithError Paynow = new("paynow");

    public static readonly TypesWithError PaynowPos = new("paynow_pos");

    public static readonly TypesWithError Paypal = new("paypal");

    public static readonly TypesWithError Payto = new("payto");

    public static readonly TypesWithError PersonalCard = new("personal_card");

    public static readonly TypesWithError PersonalCardCredit = new("personal_card_credit");

    public static readonly TypesWithError PersonalCardDebit = new("personal_card_debit");

    public static readonly TypesWithError Pulse = new("pulse");

    public static readonly TypesWithError Romcard = new("romcard");

    public static readonly TypesWithError RomcardCredit = new("romcard_credit");

    public static readonly TypesWithError RomcardDebit = new("romcard_debit");

    public static readonly TypesWithError Senff = new("senff");

    public static readonly TypesWithError SenffCredit = new("senff_credit");

    public static readonly TypesWithError Sepadirectdebit = new("sepadirectdebit");

    public static readonly TypesWithError Sodexo = new("sodexo");

    public static readonly TypesWithError Star = new("star");

    public static readonly TypesWithError Svs = new("svs");

    public static readonly TypesWithError Swish = new("swish");

    public static readonly TypesWithError Ticket = new("ticket");

    public static readonly TypesWithError TodoGiftcard = new("todo_giftcard");

    public static readonly TypesWithError Trustly = new("trustly");

    public static readonly TypesWithError Twint = new("twint");

    public static readonly TypesWithError TwintPos = new("twint_pos");

    public static readonly TypesWithError UpBrazil = new("up_brazil");

    public static readonly TypesWithError UpBrazilCredit = new("up_brazil_credit");

    public static readonly TypesWithError UpBrazilDebit = new("up_brazil_debit");

    public static readonly TypesWithError UpBrazilPrepaid = new("up_brazil_prepaid");

    public static readonly TypesWithError ValeRefeicao = new("vale_refeicao");

    public static readonly TypesWithError ValeRefeicaoPrepaid = new("vale_refeicao_prepaid");

    public static readonly TypesWithError Valuelink = new("valuelink");

    public static readonly TypesWithError VegasCard = new("vegas_card");

    public static readonly TypesWithError VegasCardCredit = new("vegas_card_credit");

    public static readonly TypesWithError VegasCardDebit = new("vegas_card_debit");

    public static readonly TypesWithError VeroCard = new("vero_card");

    public static readonly TypesWithError VeroCardCredit = new("vero_card_credit");

    public static readonly TypesWithError VeroCardDebit = new("vero_card_debit");

    public static readonly TypesWithError VeroCardPrepaid = new("vero_card_prepaid");

    public static readonly TypesWithError Vipps = new("vipps");

    public static readonly TypesWithError Visa = new("visa");

    public static readonly TypesWithError Visadebit = new("visadebit");

    public static readonly TypesWithError Vpay = new("vpay");

    public static readonly TypesWithError Wechatpay = new("wechatpay");

    public static readonly TypesWithError WechatpayPos = new("wechatpay_pos");

    public static TypesWithError FromValue(string value) => FromValueCore(value);
}
