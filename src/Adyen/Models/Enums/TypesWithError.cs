using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TypesWithError>))]
public sealed record TypesWithError : OpenStringEnum<TypesWithError>
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

    public TResult Match<TResult>(Func<TResult> onAbrapetite,
        Func<TResult> onAbrapetiteCredit,
        Func<TResult> onAbrapetiteDebit,
        Func<TResult> onAbrapetitePrepaid,
        Func<TResult> onAccel,
        Func<TResult> onAch,
        Func<TResult> onAffirm,
        Func<TResult> onAfterpaytouch,
        Func<TResult> onAlelo,
        Func<TResult> onAlipay,
        Func<TResult> onAlipayHk,
        Func<TResult> onAlipayPlus,
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
        Func<TResult> onAlipayWap,
        Func<TResult> onAmex,
        Func<TResult> onApplepay,
        Func<TResult> onAvancard,
        Func<TResult> onAvancardCredit,
        Func<TResult> onAvancardDebit,
        Func<TResult> onBaneseCard,
        Func<TResult> onBaneseCardCredit,
        Func<TResult> onBaneseCardDebit,
        Func<TResult> onBaneseCardPrepaid,
        Func<TResult> onBcmc,
        Func<TResult> onBlik,
        Func<TResult> onBlikPos,
        Func<TResult> onBrSchemes,
        Func<TResult> onCarnet,
        Func<TResult> onCartebancaire,
        Func<TResult> onCashapp,
        Func<TResult> onClearpay,
        Func<TResult> onClicktopay,
        Func<TResult> onCooper,
        Func<TResult> onCooperCredit,
        Func<TResult> onCooperDebit,
        Func<TResult> onCooperFoodDebit,
        Func<TResult> onCooperMealDebit,
        Func<TResult> onCooperPrepaid,
        Func<TResult> onCooperPrivateCredit,
        Func<TResult> onCooperRetailCredit,
        Func<TResult> onCredtodos,
        Func<TResult> onCredtodosPrivateCredit,
        Func<TResult> onCredtodosPrivateDebit,
        Func<TResult> onCup,
        Func<TResult> onDiners,
        Func<TResult> onDirectdebitGb,
        Func<TResult> onDiscover,
        Func<TResult> onEbankingFi,
        Func<TResult> onEftDirectdebitCa,
        Func<TResult> onEftposAustralia,
        Func<TResult> onElo,
        Func<TResult> onElocredit,
        Func<TResult> onElodebit,
        Func<TResult> onGirocard,
        Func<TResult> onGivex,
        Func<TResult> onGooglepay,
        Func<TResult> onGreenCard,
        Func<TResult> onGreenCardCredit,
        Func<TResult> onGreenCardDebit,
        Func<TResult> onGreenCardFoodPrepaid,
        Func<TResult> onGreenCardMealPrepaid,
        Func<TResult> onGreenCardPrepaid,
        Func<TResult> onHiper,
        Func<TResult> onHipercard,
        Func<TResult> onIdeal,
        Func<TResult> onInteracCard,
        Func<TResult> onJcb,
        Func<TResult> onKlarna,
        Func<TResult> onKlarnaAccount,
        Func<TResult> onKlarnaB2B,
        Func<TResult> onKlarnaPaynow,
        Func<TResult> onLeCard,
        Func<TResult> onLeCardCredit,
        Func<TResult> onLeCardDebit,
        Func<TResult> onMaestro,
        Func<TResult> onMaestroUsa,
        Func<TResult> onMaxifrota,
        Func<TResult> onMaxifrotaPrepaid,
        Func<TResult> onMbway,
        Func<TResult> onMc,
        Func<TResult> onMcdebit,
        Func<TResult> onMealVoucherFr,
        Func<TResult> onMegaleve,
        Func<TResult> onMegaleveCredit,
        Func<TResult> onMegaleveDebit,
        Func<TResult> onMobilepay,
        Func<TResult> onMultibanco,
        Func<TResult> onNutricash,
        Func<TResult> onNutricashPrepaid,
        Func<TResult> onNyce,
        Func<TResult> onOnlineBankingPl,
        Func<TResult> onPaybybank,
        Func<TResult> onPaybybankPlaid,
        Func<TResult> onPayme,
        Func<TResult> onPaymePos,
        Func<TResult> onPaynow,
        Func<TResult> onPaynowPos,
        Func<TResult> onPaypal,
        Func<TResult> onPayto,
        Func<TResult> onPersonalCard,
        Func<TResult> onPersonalCardCredit,
        Func<TResult> onPersonalCardDebit,
        Func<TResult> onPulse,
        Func<TResult> onRomcard,
        Func<TResult> onRomcardCredit,
        Func<TResult> onRomcardDebit,
        Func<TResult> onSenff,
        Func<TResult> onSenffCredit,
        Func<TResult> onSepadirectdebit,
        Func<TResult> onSodexo,
        Func<TResult> onStar,
        Func<TResult> onSvs,
        Func<TResult> onSwish,
        Func<TResult> onTicket,
        Func<TResult> onTodoGiftcard,
        Func<TResult> onTrustly,
        Func<TResult> onTwint,
        Func<TResult> onTwintPos,
        Func<TResult> onUpBrazil,
        Func<TResult> onUpBrazilCredit,
        Func<TResult> onUpBrazilDebit,
        Func<TResult> onUpBrazilPrepaid,
        Func<TResult> onValeRefeicao,
        Func<TResult> onValeRefeicaoPrepaid,
        Func<TResult> onValuelink,
        Func<TResult> onVegasCard,
        Func<TResult> onVegasCardCredit,
        Func<TResult> onVegasCardDebit,
        Func<TResult> onVeroCard,
        Func<TResult> onVeroCardCredit,
        Func<TResult> onVeroCardDebit,
        Func<TResult> onVeroCardPrepaid,
        Func<TResult> onVipps,
        Func<TResult> onVisa,
        Func<TResult> onVisadebit,
        Func<TResult> onVpay,
        Func<TResult> onWechatpay,
        Func<TResult> onWechatpayPos,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Abrapetite => onAbrapetite(),
            _ when this == AbrapetiteCredit => onAbrapetiteCredit(),
            _ when this == AbrapetiteDebit => onAbrapetiteDebit(),
            _ when this == AbrapetitePrepaid => onAbrapetitePrepaid(),
            _ when this == Accel => onAccel(),
            _ when this == Ach => onAch(),
            _ when this == Affirm => onAffirm(),
            _ when this == Afterpaytouch => onAfterpaytouch(),
            _ when this == Alelo => onAlelo(),
            _ when this == Alipay => onAlipay(),
            _ when this == AlipayHk => onAlipayHk(),
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
            _ when this == AlipayWap => onAlipayWap(),
            _ when this == Amex => onAmex(),
            _ when this == Applepay => onApplepay(),
            _ when this == Avancard => onAvancard(),
            _ when this == AvancardCredit => onAvancardCredit(),
            _ when this == AvancardDebit => onAvancardDebit(),
            _ when this == BaneseCard => onBaneseCard(),
            _ when this == BaneseCardCredit => onBaneseCardCredit(),
            _ when this == BaneseCardDebit => onBaneseCardDebit(),
            _ when this == BaneseCardPrepaid => onBaneseCardPrepaid(),
            _ when this == Bcmc => onBcmc(),
            _ when this == Blik => onBlik(),
            _ when this == BlikPos => onBlikPos(),
            _ when this == BrSchemes => onBrSchemes(),
            _ when this == Carnet => onCarnet(),
            _ when this == Cartebancaire => onCartebancaire(),
            _ when this == Cashapp => onCashapp(),
            _ when this == Clearpay => onClearpay(),
            _ when this == Clicktopay => onClicktopay(),
            _ when this == Cooper => onCooper(),
            _ when this == CooperCredit => onCooperCredit(),
            _ when this == CooperDebit => onCooperDebit(),
            _ when this == CooperFoodDebit => onCooperFoodDebit(),
            _ when this == CooperMealDebit => onCooperMealDebit(),
            _ when this == CooperPrepaid => onCooperPrepaid(),
            _ when this == CooperPrivateCredit => onCooperPrivateCredit(),
            _ when this == CooperRetailCredit => onCooperRetailCredit(),
            _ when this == Credtodos => onCredtodos(),
            _ when this == CredtodosPrivateCredit => onCredtodosPrivateCredit(),
            _ when this == CredtodosPrivateDebit => onCredtodosPrivateDebit(),
            _ when this == Cup => onCup(),
            _ when this == Diners => onDiners(),
            _ when this == DirectdebitGb => onDirectdebitGb(),
            _ when this == Discover => onDiscover(),
            _ when this == EbankingFi => onEbankingFi(),
            _ when this == EftDirectdebitCa => onEftDirectdebitCa(),
            _ when this == EftposAustralia => onEftposAustralia(),
            _ when this == Elo => onElo(),
            _ when this == Elocredit => onElocredit(),
            _ when this == Elodebit => onElodebit(),
            _ when this == Girocard => onGirocard(),
            _ when this == Givex => onGivex(),
            _ when this == Googlepay => onGooglepay(),
            _ when this == GreenCard => onGreenCard(),
            _ when this == GreenCardCredit => onGreenCardCredit(),
            _ when this == GreenCardDebit => onGreenCardDebit(),
            _ when this == GreenCardFoodPrepaid => onGreenCardFoodPrepaid(),
            _ when this == GreenCardMealPrepaid => onGreenCardMealPrepaid(),
            _ when this == GreenCardPrepaid => onGreenCardPrepaid(),
            _ when this == Hiper => onHiper(),
            _ when this == Hipercard => onHipercard(),
            _ when this == Ideal => onIdeal(),
            _ when this == InteracCard => onInteracCard(),
            _ when this == Jcb => onJcb(),
            _ when this == Klarna => onKlarna(),
            _ when this == KlarnaAccount => onKlarnaAccount(),
            _ when this == KlarnaB2B => onKlarnaB2B(),
            _ when this == KlarnaPaynow => onKlarnaPaynow(),
            _ when this == LeCard => onLeCard(),
            _ when this == LeCardCredit => onLeCardCredit(),
            _ when this == LeCardDebit => onLeCardDebit(),
            _ when this == Maestro => onMaestro(),
            _ when this == MaestroUsa => onMaestroUsa(),
            _ when this == Maxifrota => onMaxifrota(),
            _ when this == MaxifrotaPrepaid => onMaxifrotaPrepaid(),
            _ when this == Mbway => onMbway(),
            _ when this == Mc => onMc(),
            _ when this == Mcdebit => onMcdebit(),
            _ when this == MealVoucherFr => onMealVoucherFr(),
            _ when this == Megaleve => onMegaleve(),
            _ when this == MegaleveCredit => onMegaleveCredit(),
            _ when this == MegaleveDebit => onMegaleveDebit(),
            _ when this == Mobilepay => onMobilepay(),
            _ when this == Multibanco => onMultibanco(),
            _ when this == Nutricash => onNutricash(),
            _ when this == NutricashPrepaid => onNutricashPrepaid(),
            _ when this == Nyce => onNyce(),
            _ when this == OnlineBankingPl => onOnlineBankingPl(),
            _ when this == Paybybank => onPaybybank(),
            _ when this == PaybybankPlaid => onPaybybankPlaid(),
            _ when this == Payme => onPayme(),
            _ when this == PaymePos => onPaymePos(),
            _ when this == Paynow => onPaynow(),
            _ when this == PaynowPos => onPaynowPos(),
            _ when this == Paypal => onPaypal(),
            _ when this == Payto => onPayto(),
            _ when this == PersonalCard => onPersonalCard(),
            _ when this == PersonalCardCredit => onPersonalCardCredit(),
            _ when this == PersonalCardDebit => onPersonalCardDebit(),
            _ when this == Pulse => onPulse(),
            _ when this == Romcard => onRomcard(),
            _ when this == RomcardCredit => onRomcardCredit(),
            _ when this == RomcardDebit => onRomcardDebit(),
            _ when this == Senff => onSenff(),
            _ when this == SenffCredit => onSenffCredit(),
            _ when this == Sepadirectdebit => onSepadirectdebit(),
            _ when this == Sodexo => onSodexo(),
            _ when this == Star => onStar(),
            _ when this == Svs => onSvs(),
            _ when this == Swish => onSwish(),
            _ when this == Ticket => onTicket(),
            _ when this == TodoGiftcard => onTodoGiftcard(),
            _ when this == Trustly => onTrustly(),
            _ when this == Twint => onTwint(),
            _ when this == TwintPos => onTwintPos(),
            _ when this == UpBrazil => onUpBrazil(),
            _ when this == UpBrazilCredit => onUpBrazilCredit(),
            _ when this == UpBrazilDebit => onUpBrazilDebit(),
            _ when this == UpBrazilPrepaid => onUpBrazilPrepaid(),
            _ when this == ValeRefeicao => onValeRefeicao(),
            _ when this == ValeRefeicaoPrepaid => onValeRefeicaoPrepaid(),
            _ when this == Valuelink => onValuelink(),
            _ when this == VegasCard => onVegasCard(),
            _ when this == VegasCardCredit => onVegasCardCredit(),
            _ when this == VegasCardDebit => onVegasCardDebit(),
            _ when this == VeroCard => onVeroCard(),
            _ when this == VeroCardCredit => onVeroCardCredit(),
            _ when this == VeroCardDebit => onVeroCardDebit(),
            _ when this == VeroCardPrepaid => onVeroCardPrepaid(),
            _ when this == Vipps => onVipps(),
            _ when this == Visa => onVisa(),
            _ when this == Visadebit => onVisadebit(),
            _ when this == Vpay => onVpay(),
            _ when this == Wechatpay => onWechatpay(),
            _ when this == WechatpayPos => onWechatpayPos(),
            _ => otherwise(Value)
        };

    public void Match(Action onAbrapetite,
        Action onAbrapetiteCredit,
        Action onAbrapetiteDebit,
        Action onAbrapetitePrepaid,
        Action onAccel,
        Action onAch,
        Action onAffirm,
        Action onAfterpaytouch,
        Action onAlelo,
        Action onAlipay,
        Action onAlipayHk,
        Action onAlipayPlus,
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
        Action onAlipayWap,
        Action onAmex,
        Action onApplepay,
        Action onAvancard,
        Action onAvancardCredit,
        Action onAvancardDebit,
        Action onBaneseCard,
        Action onBaneseCardCredit,
        Action onBaneseCardDebit,
        Action onBaneseCardPrepaid,
        Action onBcmc,
        Action onBlik,
        Action onBlikPos,
        Action onBrSchemes,
        Action onCarnet,
        Action onCartebancaire,
        Action onCashapp,
        Action onClearpay,
        Action onClicktopay,
        Action onCooper,
        Action onCooperCredit,
        Action onCooperDebit,
        Action onCooperFoodDebit,
        Action onCooperMealDebit,
        Action onCooperPrepaid,
        Action onCooperPrivateCredit,
        Action onCooperRetailCredit,
        Action onCredtodos,
        Action onCredtodosPrivateCredit,
        Action onCredtodosPrivateDebit,
        Action onCup,
        Action onDiners,
        Action onDirectdebitGb,
        Action onDiscover,
        Action onEbankingFi,
        Action onEftDirectdebitCa,
        Action onEftposAustralia,
        Action onElo,
        Action onElocredit,
        Action onElodebit,
        Action onGirocard,
        Action onGivex,
        Action onGooglepay,
        Action onGreenCard,
        Action onGreenCardCredit,
        Action onGreenCardDebit,
        Action onGreenCardFoodPrepaid,
        Action onGreenCardMealPrepaid,
        Action onGreenCardPrepaid,
        Action onHiper,
        Action onHipercard,
        Action onIdeal,
        Action onInteracCard,
        Action onJcb,
        Action onKlarna,
        Action onKlarnaAccount,
        Action onKlarnaB2B,
        Action onKlarnaPaynow,
        Action onLeCard,
        Action onLeCardCredit,
        Action onLeCardDebit,
        Action onMaestro,
        Action onMaestroUsa,
        Action onMaxifrota,
        Action onMaxifrotaPrepaid,
        Action onMbway,
        Action onMc,
        Action onMcdebit,
        Action onMealVoucherFr,
        Action onMegaleve,
        Action onMegaleveCredit,
        Action onMegaleveDebit,
        Action onMobilepay,
        Action onMultibanco,
        Action onNutricash,
        Action onNutricashPrepaid,
        Action onNyce,
        Action onOnlineBankingPl,
        Action onPaybybank,
        Action onPaybybankPlaid,
        Action onPayme,
        Action onPaymePos,
        Action onPaynow,
        Action onPaynowPos,
        Action onPaypal,
        Action onPayto,
        Action onPersonalCard,
        Action onPersonalCardCredit,
        Action onPersonalCardDebit,
        Action onPulse,
        Action onRomcard,
        Action onRomcardCredit,
        Action onRomcardDebit,
        Action onSenff,
        Action onSenffCredit,
        Action onSepadirectdebit,
        Action onSodexo,
        Action onStar,
        Action onSvs,
        Action onSwish,
        Action onTicket,
        Action onTodoGiftcard,
        Action onTrustly,
        Action onTwint,
        Action onTwintPos,
        Action onUpBrazil,
        Action onUpBrazilCredit,
        Action onUpBrazilDebit,
        Action onUpBrazilPrepaid,
        Action onValeRefeicao,
        Action onValeRefeicaoPrepaid,
        Action onValuelink,
        Action onVegasCard,
        Action onVegasCardCredit,
        Action onVegasCardDebit,
        Action onVeroCard,
        Action onVeroCardCredit,
        Action onVeroCardDebit,
        Action onVeroCardPrepaid,
        Action onVipps,
        Action onVisa,
        Action onVisadebit,
        Action onVpay,
        Action onWechatpay,
        Action onWechatpayPos,
        Action<string> otherwise)
    {
        if (this == Abrapetite) onAbrapetite();
        else if (this == AbrapetiteCredit) onAbrapetiteCredit();
        else if (this == AbrapetiteDebit) onAbrapetiteDebit();
        else if (this == AbrapetitePrepaid) onAbrapetitePrepaid();
        else if (this == Accel) onAccel();
        else if (this == Ach) onAch();
        else if (this == Affirm) onAffirm();
        else if (this == Afterpaytouch) onAfterpaytouch();
        else if (this == Alelo) onAlelo();
        else if (this == Alipay) onAlipay();
        else if (this == AlipayHk) onAlipayHk();
        else if (this == AlipayPlus) onAlipayPlus();
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
        else if (this == AlipayWap) onAlipayWap();
        else if (this == Amex) onAmex();
        else if (this == Applepay) onApplepay();
        else if (this == Avancard) onAvancard();
        else if (this == AvancardCredit) onAvancardCredit();
        else if (this == AvancardDebit) onAvancardDebit();
        else if (this == BaneseCard) onBaneseCard();
        else if (this == BaneseCardCredit) onBaneseCardCredit();
        else if (this == BaneseCardDebit) onBaneseCardDebit();
        else if (this == BaneseCardPrepaid) onBaneseCardPrepaid();
        else if (this == Bcmc) onBcmc();
        else if (this == Blik) onBlik();
        else if (this == BlikPos) onBlikPos();
        else if (this == BrSchemes) onBrSchemes();
        else if (this == Carnet) onCarnet();
        else if (this == Cartebancaire) onCartebancaire();
        else if (this == Cashapp) onCashapp();
        else if (this == Clearpay) onClearpay();
        else if (this == Clicktopay) onClicktopay();
        else if (this == Cooper) onCooper();
        else if (this == CooperCredit) onCooperCredit();
        else if (this == CooperDebit) onCooperDebit();
        else if (this == CooperFoodDebit) onCooperFoodDebit();
        else if (this == CooperMealDebit) onCooperMealDebit();
        else if (this == CooperPrepaid) onCooperPrepaid();
        else if (this == CooperPrivateCredit) onCooperPrivateCredit();
        else if (this == CooperRetailCredit) onCooperRetailCredit();
        else if (this == Credtodos) onCredtodos();
        else if (this == CredtodosPrivateCredit) onCredtodosPrivateCredit();
        else if (this == CredtodosPrivateDebit) onCredtodosPrivateDebit();
        else if (this == Cup) onCup();
        else if (this == Diners) onDiners();
        else if (this == DirectdebitGb) onDirectdebitGb();
        else if (this == Discover) onDiscover();
        else if (this == EbankingFi) onEbankingFi();
        else if (this == EftDirectdebitCa) onEftDirectdebitCa();
        else if (this == EftposAustralia) onEftposAustralia();
        else if (this == Elo) onElo();
        else if (this == Elocredit) onElocredit();
        else if (this == Elodebit) onElodebit();
        else if (this == Girocard) onGirocard();
        else if (this == Givex) onGivex();
        else if (this == Googlepay) onGooglepay();
        else if (this == GreenCard) onGreenCard();
        else if (this == GreenCardCredit) onGreenCardCredit();
        else if (this == GreenCardDebit) onGreenCardDebit();
        else if (this == GreenCardFoodPrepaid) onGreenCardFoodPrepaid();
        else if (this == GreenCardMealPrepaid) onGreenCardMealPrepaid();
        else if (this == GreenCardPrepaid) onGreenCardPrepaid();
        else if (this == Hiper) onHiper();
        else if (this == Hipercard) onHipercard();
        else if (this == Ideal) onIdeal();
        else if (this == InteracCard) onInteracCard();
        else if (this == Jcb) onJcb();
        else if (this == Klarna) onKlarna();
        else if (this == KlarnaAccount) onKlarnaAccount();
        else if (this == KlarnaB2B) onKlarnaB2B();
        else if (this == KlarnaPaynow) onKlarnaPaynow();
        else if (this == LeCard) onLeCard();
        else if (this == LeCardCredit) onLeCardCredit();
        else if (this == LeCardDebit) onLeCardDebit();
        else if (this == Maestro) onMaestro();
        else if (this == MaestroUsa) onMaestroUsa();
        else if (this == Maxifrota) onMaxifrota();
        else if (this == MaxifrotaPrepaid) onMaxifrotaPrepaid();
        else if (this == Mbway) onMbway();
        else if (this == Mc) onMc();
        else if (this == Mcdebit) onMcdebit();
        else if (this == MealVoucherFr) onMealVoucherFr();
        else if (this == Megaleve) onMegaleve();
        else if (this == MegaleveCredit) onMegaleveCredit();
        else if (this == MegaleveDebit) onMegaleveDebit();
        else if (this == Mobilepay) onMobilepay();
        else if (this == Multibanco) onMultibanco();
        else if (this == Nutricash) onNutricash();
        else if (this == NutricashPrepaid) onNutricashPrepaid();
        else if (this == Nyce) onNyce();
        else if (this == OnlineBankingPl) onOnlineBankingPl();
        else if (this == Paybybank) onPaybybank();
        else if (this == PaybybankPlaid) onPaybybankPlaid();
        else if (this == Payme) onPayme();
        else if (this == PaymePos) onPaymePos();
        else if (this == Paynow) onPaynow();
        else if (this == PaynowPos) onPaynowPos();
        else if (this == Paypal) onPaypal();
        else if (this == Payto) onPayto();
        else if (this == PersonalCard) onPersonalCard();
        else if (this == PersonalCardCredit) onPersonalCardCredit();
        else if (this == PersonalCardDebit) onPersonalCardDebit();
        else if (this == Pulse) onPulse();
        else if (this == Romcard) onRomcard();
        else if (this == RomcardCredit) onRomcardCredit();
        else if (this == RomcardDebit) onRomcardDebit();
        else if (this == Senff) onSenff();
        else if (this == SenffCredit) onSenffCredit();
        else if (this == Sepadirectdebit) onSepadirectdebit();
        else if (this == Sodexo) onSodexo();
        else if (this == Star) onStar();
        else if (this == Svs) onSvs();
        else if (this == Swish) onSwish();
        else if (this == Ticket) onTicket();
        else if (this == TodoGiftcard) onTodoGiftcard();
        else if (this == Trustly) onTrustly();
        else if (this == Twint) onTwint();
        else if (this == TwintPos) onTwintPos();
        else if (this == UpBrazil) onUpBrazil();
        else if (this == UpBrazilCredit) onUpBrazilCredit();
        else if (this == UpBrazilDebit) onUpBrazilDebit();
        else if (this == UpBrazilPrepaid) onUpBrazilPrepaid();
        else if (this == ValeRefeicao) onValeRefeicao();
        else if (this == ValeRefeicaoPrepaid) onValeRefeicaoPrepaid();
        else if (this == Valuelink) onValuelink();
        else if (this == VegasCard) onVegasCard();
        else if (this == VegasCardCredit) onVegasCardCredit();
        else if (this == VegasCardDebit) onVegasCardDebit();
        else if (this == VeroCard) onVeroCard();
        else if (this == VeroCardCredit) onVeroCardCredit();
        else if (this == VeroCardDebit) onVeroCardDebit();
        else if (this == VeroCardPrepaid) onVeroCardPrepaid();
        else if (this == Vipps) onVipps();
        else if (this == Visa) onVisa();
        else if (this == Visadebit) onVisadebit();
        else if (this == Vpay) onVpay();
        else if (this == Wechatpay) onWechatpay();
        else if (this == WechatpayPos) onWechatpayPos();
        else otherwise(Value);
    }
}
