using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models.OneOf;

/// <summary>
/// The type and required details of a payment method to use.
/// </summary>
[JsonConverter(typeof(PaymentMethod11Converter))]
public record PaymentMethod11
{
    private readonly Optional<ApplePayDetails> _applePayDetailsValue;

    private readonly Optional<SamsungPay> _samsungPayValue;

    private readonly Optional<AndroidPay> _androidPayValue;

    private readonly Optional<VisaCheckout> _visaCheckoutValue;

    private readonly Optional<PayWithGoogleDetails> _payWithGoogleDetailsValue;

    private readonly Optional<AmazonPay> _amazonPayValue;

    private readonly Optional<Masterpass> _masterpassValue;

    private readonly Optional<GooglePayDetails> _googlePayDetailsValue;

    private readonly Optional<Fastlane> _fastlaneValue;

    private readonly Optional<PaymentDetails> _paymentDetailsValue;

    private readonly Optional<StoredPaymentMethod6> _storedPaymentMethod6Value;

    private readonly Optional<CardDetails> _cardDetailsValue;

    private readonly Optional<DetailsOfTokensThatAreNotStoredWithAdyen> _detailsOfTokensThatAreNotStoredWithAdyenValue;

    private readonly Optional<AchDirectDebit> _achDirectDebitValue;

    private readonly Optional<EftDirectDebit> _eftDirectDebitValue;

    private readonly Optional<Klarna> _klarnaValue;

    private readonly Optional<KlarnaNetwork> _klarnaNetworkValue;

    private readonly Optional<Afterpay> _afterpayValue;

    private readonly Optional<Zip> _zipValue;

    private readonly Optional<Ratepay> _ratepayValue;

    private readonly Optional<Affirm> _affirmValue;

    private readonly Optional<Riverty> _rivertyValue;

    private readonly Optional<IdealDetails> _idealDetailsValue;

    private readonly Optional<PayPal> _payPalValue;

    private readonly Optional<PayPay> _payPayValue;

    private readonly Optional<RakutenPay> _rakutenPayValue;

    private readonly Optional<AuPay> _auPayValue;

    private readonly Optional<DBarai> _dBaraiValue;

    private readonly Optional<SepaDirectDebit> _sepaDirectDebitValue;

    private readonly Optional<Doku> _dokuValue;

    private readonly Optional<Vipps> _vippsValue;

    private readonly Optional<MobilePay> _mobilePayValue;

    private readonly Optional<Cellulant> _cellulantValue;

    private readonly Optional<WeChatPay> _weChatPayValue;

    private readonly Optional<WeChatPayMiniProgram> _weChatPayMiniProgramValue;

    private readonly Optional<MolPay> _molPayValue;

    private readonly Optional<BillDesk> _billDeskValue;

    private readonly Optional<PayU> _payUValue;

    private readonly Optional<PseLatam> _pseLatamValue;

    private readonly Optional<UpiCollect> _upiCollectValue;

    private readonly Optional<UpiIntent> _upiIntentValue;

    private readonly Optional<UpiQr> _upiQrValue;

    private readonly Optional<StoredPaymentMethod2> _storedPaymentMethod2Value;

    private readonly Optional<PayByBank> _payByBankValue;

    private readonly Optional<PayByBankAisDirectDebit> _payByBankAisDirectDebitValue;

    private readonly Optional<OpenInvoice> _openInvoiceValue;

    private readonly Optional<EBankingFinland> _eBankingFinlandValue;

    private readonly Optional<Twint> _twintValue;

    private readonly Optional<StoredPaymentMethod4> _storedPaymentMethod4Value;

    private readonly Optional<StoredPaymentMethod5> _storedPaymentMethod5Value;

    private readonly Optional<Alma> _almaValue;

    private readonly Optional<Ancv> _ancvValue;

    private readonly Optional<PayTo> _payToValue;

    private readonly Optional<DirectDebitAu> _directDebitAuValue;

    private readonly Optional<Voucher> _voucherValue;

    private readonly Optional<Dragonpay> _dragonpayValue;

    private readonly Optional<BacsDirectDebit> _bacsDirectDebitValue;

    private readonly Optional<Blik> _blikValue;

    private readonly Optional<MbWay> _mbWayValue;

    private readonly Optional<StoredPaymentMethod> _storedPaymentMethodValue;

    private PaymentMethod11(Optional<ApplePayDetails> applePayDetailsValue,
        Optional<SamsungPay> samsungPayValue,
        Optional<AndroidPay> androidPayValue,
        Optional<VisaCheckout> visaCheckoutValue,
        Optional<PayWithGoogleDetails> payWithGoogleDetailsValue,
        Optional<AmazonPay> amazonPayValue,
        Optional<Masterpass> masterpassValue,
        Optional<GooglePayDetails> googlePayDetailsValue,
        Optional<Fastlane> fastlaneValue,
        Optional<PaymentDetails> paymentDetailsValue,
        Optional<StoredPaymentMethod6> storedPaymentMethod6Value,
        Optional<CardDetails> cardDetailsValue,
        Optional<DetailsOfTokensThatAreNotStoredWithAdyen> detailsOfTokensThatAreNotStoredWithAdyenValue,
        Optional<AchDirectDebit> achDirectDebitValue,
        Optional<EftDirectDebit> eftDirectDebitValue,
        Optional<Klarna> klarnaValue,
        Optional<KlarnaNetwork> klarnaNetworkValue,
        Optional<Afterpay> afterpayValue,
        Optional<Zip> zipValue,
        Optional<Ratepay> ratepayValue,
        Optional<Affirm> affirmValue,
        Optional<Riverty> rivertyValue,
        Optional<IdealDetails> idealDetailsValue,
        Optional<PayPal> payPalValue,
        Optional<PayPay> payPayValue,
        Optional<RakutenPay> rakutenPayValue,
        Optional<AuPay> auPayValue,
        Optional<DBarai> dBaraiValue,
        Optional<SepaDirectDebit> sepaDirectDebitValue,
        Optional<Doku> dokuValue,
        Optional<Vipps> vippsValue,
        Optional<MobilePay> mobilePayValue,
        Optional<Cellulant> cellulantValue,
        Optional<WeChatPay> weChatPayValue,
        Optional<WeChatPayMiniProgram> weChatPayMiniProgramValue,
        Optional<MolPay> molPayValue,
        Optional<BillDesk> billDeskValue,
        Optional<PayU> payUValue,
        Optional<PseLatam> pseLatamValue,
        Optional<UpiCollect> upiCollectValue,
        Optional<UpiIntent> upiIntentValue,
        Optional<UpiQr> upiQrValue,
        Optional<StoredPaymentMethod2> storedPaymentMethod2Value,
        Optional<PayByBank> payByBankValue,
        Optional<PayByBankAisDirectDebit> payByBankAisDirectDebitValue,
        Optional<OpenInvoice> openInvoiceValue,
        Optional<EBankingFinland> eBankingFinlandValue,
        Optional<Twint> twintValue,
        Optional<StoredPaymentMethod4> storedPaymentMethod4Value,
        Optional<StoredPaymentMethod5> storedPaymentMethod5Value,
        Optional<Alma> almaValue,
        Optional<Ancv> ancvValue,
        Optional<PayTo> payToValue,
        Optional<DirectDebitAu> directDebitAuValue,
        Optional<Voucher> voucherValue,
        Optional<Dragonpay> dragonpayValue,
        Optional<BacsDirectDebit> bacsDirectDebitValue,
        Optional<Blik> blikValue,
        Optional<MbWay> mbWayValue,
        Optional<StoredPaymentMethod> storedPaymentMethodValue)
    {
        _applePayDetailsValue = applePayDetailsValue;
        _samsungPayValue = samsungPayValue;
        _androidPayValue = androidPayValue;
        _visaCheckoutValue = visaCheckoutValue;
        _payWithGoogleDetailsValue = payWithGoogleDetailsValue;
        _amazonPayValue = amazonPayValue;
        _masterpassValue = masterpassValue;
        _googlePayDetailsValue = googlePayDetailsValue;
        _fastlaneValue = fastlaneValue;
        _paymentDetailsValue = paymentDetailsValue;
        _storedPaymentMethod6Value = storedPaymentMethod6Value;
        _cardDetailsValue = cardDetailsValue;
        _detailsOfTokensThatAreNotStoredWithAdyenValue = detailsOfTokensThatAreNotStoredWithAdyenValue;
        _achDirectDebitValue = achDirectDebitValue;
        _eftDirectDebitValue = eftDirectDebitValue;
        _klarnaValue = klarnaValue;
        _klarnaNetworkValue = klarnaNetworkValue;
        _afterpayValue = afterpayValue;
        _zipValue = zipValue;
        _ratepayValue = ratepayValue;
        _affirmValue = affirmValue;
        _rivertyValue = rivertyValue;
        _idealDetailsValue = idealDetailsValue;
        _payPalValue = payPalValue;
        _payPayValue = payPayValue;
        _rakutenPayValue = rakutenPayValue;
        _auPayValue = auPayValue;
        _dBaraiValue = dBaraiValue;
        _sepaDirectDebitValue = sepaDirectDebitValue;
        _dokuValue = dokuValue;
        _vippsValue = vippsValue;
        _mobilePayValue = mobilePayValue;
        _cellulantValue = cellulantValue;
        _weChatPayValue = weChatPayValue;
        _weChatPayMiniProgramValue = weChatPayMiniProgramValue;
        _molPayValue = molPayValue;
        _billDeskValue = billDeskValue;
        _payUValue = payUValue;
        _pseLatamValue = pseLatamValue;
        _upiCollectValue = upiCollectValue;
        _upiIntentValue = upiIntentValue;
        _upiQrValue = upiQrValue;
        _storedPaymentMethod2Value = storedPaymentMethod2Value;
        _payByBankValue = payByBankValue;
        _payByBankAisDirectDebitValue = payByBankAisDirectDebitValue;
        _openInvoiceValue = openInvoiceValue;
        _eBankingFinlandValue = eBankingFinlandValue;
        _twintValue = twintValue;
        _storedPaymentMethod4Value = storedPaymentMethod4Value;
        _storedPaymentMethod5Value = storedPaymentMethod5Value;
        _almaValue = almaValue;
        _ancvValue = ancvValue;
        _payToValue = payToValue;
        _directDebitAuValue = directDebitAuValue;
        _voucherValue = voucherValue;
        _dragonpayValue = dragonpayValue;
        _bacsDirectDebitValue = bacsDirectDebitValue;
        _blikValue = blikValue;
        _mbWayValue = mbWayValue;
        _storedPaymentMethodValue = storedPaymentMethodValue;
    }

    public static PaymentMethod11 ApplePayDetails(ApplePayDetails value) =>
        new(Optional<ApplePayDetails>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 SamsungPay(SamsungPay value) =>
        new(default,
            Optional<SamsungPay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 AndroidPay(AndroidPay value) =>
        new(default,
            default,
            Optional<AndroidPay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 VisaCheckout(VisaCheckout value) =>
        new(default,
            default,
            default,
            Optional<VisaCheckout>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 PayWithGoogleDetails(PayWithGoogleDetails value) =>
        new(default,
            default,
            default,
            default,
            Optional<PayWithGoogleDetails>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 AmazonPay(AmazonPay value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<AmazonPay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 Masterpass(Masterpass value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            Optional<Masterpass>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 GooglePayDetails(GooglePayDetails value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<GooglePayDetails>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 Fastlane(Fastlane value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Fastlane>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 PaymentDetails(PaymentDetails value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<PaymentDetails>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 StoredPaymentMethod6(StoredPaymentMethod6 value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<StoredPaymentMethod6>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 CardDetails(CardDetails value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<CardDetails>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 DetailsOfTokensThatAreNotStoredWithAdyen(DetailsOfTokensThatAreNotStoredWithAdyen value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<DetailsOfTokensThatAreNotStoredWithAdyen>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 AchDirectDebit(AchDirectDebit value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<AchDirectDebit>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 EftDirectDebit(EftDirectDebit value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<EftDirectDebit>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 Klarna(Klarna value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Klarna>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 KlarnaNetwork(KlarnaNetwork value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<KlarnaNetwork>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 Afterpay(Afterpay value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Afterpay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 Zip(Zip value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Zip>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 Ratepay(Ratepay value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Ratepay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 Affirm(Affirm value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Affirm>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 Riverty(Riverty value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Riverty>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 IdealDetails(IdealDetails value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<IdealDetails>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 PayPal(PayPal value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<PayPal>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 PayPay(PayPay value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<PayPay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 RakutenPay(RakutenPay value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<RakutenPay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 AuPay(AuPay value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<AuPay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 DBarai(DBarai value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<DBarai>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 SepaDirectDebit(SepaDirectDebit value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<SepaDirectDebit>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 Doku(Doku value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Doku>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 Vipps(Vipps value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Vipps>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 MobilePay(MobilePay value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<MobilePay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 Cellulant(Cellulant value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Cellulant>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 WeChatPay(WeChatPay value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<WeChatPay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 WeChatPayMiniProgram(WeChatPayMiniProgram value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<WeChatPayMiniProgram>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 MolPay(MolPay value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<MolPay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 BillDesk(BillDesk value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<BillDesk>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 PayU(PayU value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<PayU>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 PseLatam(PseLatam value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<PseLatam>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 UpiCollect(UpiCollect value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<UpiCollect>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 UpiIntent(UpiIntent value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<UpiIntent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 UpiQr(UpiQr value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<UpiQr>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 StoredPaymentMethod2(StoredPaymentMethod2 value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<StoredPaymentMethod2>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 PayByBank(PayByBank value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<PayByBank>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 PayByBankAisDirectDebit(PayByBankAisDirectDebit value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<PayByBankAisDirectDebit>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 OpenInvoice(OpenInvoice value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<OpenInvoice>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 EBankingFinland(EBankingFinland value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<EBankingFinland>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 Twint(Twint value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Twint>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 StoredPaymentMethod4(StoredPaymentMethod4 value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<StoredPaymentMethod4>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 StoredPaymentMethod5(StoredPaymentMethod5 value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<StoredPaymentMethod5>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 Alma(Alma value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Alma>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 Ancv(Ancv value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Ancv>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 PayTo(PayTo value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<PayTo>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 DirectDebitAu(DirectDebitAu value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<DirectDebitAu>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 Voucher(Voucher value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Voucher>.Some(value),
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod11 Dragonpay(Dragonpay value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Dragonpay>.Some(value),
            default,
            default,
            default,
            default);

    public static PaymentMethod11 BacsDirectDebit(BacsDirectDebit value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<BacsDirectDebit>.Some(value),
            default,
            default,
            default);

    public static PaymentMethod11 Blik(Blik value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<Blik>.Some(value),
            default,
            default);

    public static PaymentMethod11 MbWay(MbWay value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<MbWay>.Some(value),
            default);

    public static PaymentMethod11 StoredPaymentMethod(StoredPaymentMethod value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<StoredPaymentMethod>.Some(value));

    public bool TryGetApplePayDetails(out ApplePayDetails value) =>
        _applePayDetailsValue.TryGetValue(out value);

    public bool TryGetSamsungPay(out SamsungPay value) => _samsungPayValue.TryGetValue(out value);

    public bool TryGetAndroidPay(out AndroidPay value) => _androidPayValue.TryGetValue(out value);

    public bool TryGetVisaCheckout(out VisaCheckout value) => _visaCheckoutValue.TryGetValue(out value);

    public bool TryGetPayWithGoogleDetails(out PayWithGoogleDetails value) =>
        _payWithGoogleDetailsValue.TryGetValue(out value);

    public bool TryGetAmazonPay(out AmazonPay value) => _amazonPayValue.TryGetValue(out value);

    public bool TryGetMasterpass(out Masterpass value) => _masterpassValue.TryGetValue(out value);

    public bool TryGetGooglePayDetails(out GooglePayDetails value) =>
        _googlePayDetailsValue.TryGetValue(out value);

    public bool TryGetFastlane(out Fastlane value) => _fastlaneValue.TryGetValue(out value);

    public bool TryGetPaymentDetails(out PaymentDetails value) => _paymentDetailsValue.TryGetValue(out value);

    public bool TryGetStoredPaymentMethod6(out StoredPaymentMethod6 value) =>
        _storedPaymentMethod6Value.TryGetValue(out value);

    public bool TryGetCardDetails(out CardDetails value) => _cardDetailsValue.TryGetValue(out value);

    public bool TryGetDetailsOfTokensThatAreNotStoredWithAdyen(out DetailsOfTokensThatAreNotStoredWithAdyen value) =>
        _detailsOfTokensThatAreNotStoredWithAdyenValue.TryGetValue(out value);

    public bool TryGetAchDirectDebit(out AchDirectDebit value) => _achDirectDebitValue.TryGetValue(out value);

    public bool TryGetEftDirectDebit(out EftDirectDebit value) => _eftDirectDebitValue.TryGetValue(out value);

    public bool TryGetKlarna(out Klarna value) => _klarnaValue.TryGetValue(out value);

    public bool TryGetKlarnaNetwork(out KlarnaNetwork value) => _klarnaNetworkValue.TryGetValue(out value);

    public bool TryGetAfterpay(out Afterpay value) => _afterpayValue.TryGetValue(out value);

    public bool TryGetZip(out Zip value) => _zipValue.TryGetValue(out value);

    public bool TryGetRatepay(out Ratepay value) => _ratepayValue.TryGetValue(out value);

    public bool TryGetAffirm(out Affirm value) => _affirmValue.TryGetValue(out value);

    public bool TryGetRiverty(out Riverty value) => _rivertyValue.TryGetValue(out value);

    public bool TryGetIdealDetails(out IdealDetails value) => _idealDetailsValue.TryGetValue(out value);

    public bool TryGetPayPal(out PayPal value) => _payPalValue.TryGetValue(out value);

    public bool TryGetPayPay(out PayPay value) => _payPayValue.TryGetValue(out value);

    public bool TryGetRakutenPay(out RakutenPay value) => _rakutenPayValue.TryGetValue(out value);

    public bool TryGetAuPay(out AuPay value) => _auPayValue.TryGetValue(out value);

    public bool TryGetDBarai(out DBarai value) => _dBaraiValue.TryGetValue(out value);

    public bool TryGetSepaDirectDebit(out SepaDirectDebit value) =>
        _sepaDirectDebitValue.TryGetValue(out value);

    public bool TryGetDoku(out Doku value) => _dokuValue.TryGetValue(out value);

    public bool TryGetVipps(out Vipps value) => _vippsValue.TryGetValue(out value);

    public bool TryGetMobilePay(out MobilePay value) => _mobilePayValue.TryGetValue(out value);

    public bool TryGetCellulant(out Cellulant value) => _cellulantValue.TryGetValue(out value);

    public bool TryGetWeChatPay(out WeChatPay value) => _weChatPayValue.TryGetValue(out value);

    public bool TryGetWeChatPayMiniProgram(out WeChatPayMiniProgram value) =>
        _weChatPayMiniProgramValue.TryGetValue(out value);

    public bool TryGetMolPay(out MolPay value) => _molPayValue.TryGetValue(out value);

    public bool TryGetBillDesk(out BillDesk value) => _billDeskValue.TryGetValue(out value);

    public bool TryGetPayU(out PayU value) => _payUValue.TryGetValue(out value);

    public bool TryGetPseLatam(out PseLatam value) => _pseLatamValue.TryGetValue(out value);

    public bool TryGetUpiCollect(out UpiCollect value) => _upiCollectValue.TryGetValue(out value);

    public bool TryGetUpiIntent(out UpiIntent value) => _upiIntentValue.TryGetValue(out value);

    public bool TryGetUpiQr(out UpiQr value) => _upiQrValue.TryGetValue(out value);

    public bool TryGetStoredPaymentMethod2(out StoredPaymentMethod2 value) =>
        _storedPaymentMethod2Value.TryGetValue(out value);

    public bool TryGetPayByBank(out PayByBank value) => _payByBankValue.TryGetValue(out value);

    public bool TryGetPayByBankAisDirectDebit(out PayByBankAisDirectDebit value) =>
        _payByBankAisDirectDebitValue.TryGetValue(out value);

    public bool TryGetOpenInvoice(out OpenInvoice value) => _openInvoiceValue.TryGetValue(out value);

    public bool TryGetEBankingFinland(out EBankingFinland value) =>
        _eBankingFinlandValue.TryGetValue(out value);

    public bool TryGetTwint(out Twint value) => _twintValue.TryGetValue(out value);

    public bool TryGetStoredPaymentMethod4(out StoredPaymentMethod4 value) =>
        _storedPaymentMethod4Value.TryGetValue(out value);

    public bool TryGetStoredPaymentMethod5(out StoredPaymentMethod5 value) =>
        _storedPaymentMethod5Value.TryGetValue(out value);

    public bool TryGetAlma(out Alma value) => _almaValue.TryGetValue(out value);

    public bool TryGetAncv(out Ancv value) => _ancvValue.TryGetValue(out value);

    public bool TryGetPayTo(out PayTo value) => _payToValue.TryGetValue(out value);

    public bool TryGetDirectDebitAu(out DirectDebitAu value) => _directDebitAuValue.TryGetValue(out value);

    public bool TryGetVoucher(out Voucher value) => _voucherValue.TryGetValue(out value);

    public bool TryGetDragonpay(out Dragonpay value) => _dragonpayValue.TryGetValue(out value);

    public bool TryGetBacsDirectDebit(out BacsDirectDebit value) =>
        _bacsDirectDebitValue.TryGetValue(out value);

    public bool TryGetBlik(out Blik value) => _blikValue.TryGetValue(out value);

    public bool TryGetMbWay(out MbWay value) => _mbWayValue.TryGetValue(out value);

    public bool TryGetStoredPaymentMethod(out StoredPaymentMethod value) =>
        _storedPaymentMethodValue.TryGetValue(out value);

    public static implicit operator PaymentMethod11(ApplePayDetails value) => ApplePayDetails(value);

    public static implicit operator PaymentMethod11(SamsungPay value) => SamsungPay(value);

    public static implicit operator PaymentMethod11(AndroidPay value) => AndroidPay(value);

    public static implicit operator PaymentMethod11(VisaCheckout value) => VisaCheckout(value);

    public static implicit operator PaymentMethod11(PayWithGoogleDetails value) => PayWithGoogleDetails(value);

    public static implicit operator PaymentMethod11(AmazonPay value) => AmazonPay(value);

    public static implicit operator PaymentMethod11(Masterpass value) => Masterpass(value);

    public static implicit operator PaymentMethod11(GooglePayDetails value) => GooglePayDetails(value);

    public static implicit operator PaymentMethod11(Fastlane value) => Fastlane(value);

    public static implicit operator PaymentMethod11(PaymentDetails value) => PaymentDetails(value);

    public static implicit operator PaymentMethod11(StoredPaymentMethod6 value) => StoredPaymentMethod6(value);

    public static implicit operator PaymentMethod11(CardDetails value) => CardDetails(value);

    public static implicit operator PaymentMethod11(DetailsOfTokensThatAreNotStoredWithAdyen value) =>
        DetailsOfTokensThatAreNotStoredWithAdyen(value);

    public static implicit operator PaymentMethod11(AchDirectDebit value) => AchDirectDebit(value);

    public static implicit operator PaymentMethod11(EftDirectDebit value) => EftDirectDebit(value);

    public static implicit operator PaymentMethod11(Klarna value) => Klarna(value);

    public static implicit operator PaymentMethod11(KlarnaNetwork value) => KlarnaNetwork(value);

    public static implicit operator PaymentMethod11(Afterpay value) => Afterpay(value);

    public static implicit operator PaymentMethod11(Zip value) => Zip(value);

    public static implicit operator PaymentMethod11(Ratepay value) => Ratepay(value);

    public static implicit operator PaymentMethod11(Affirm value) => Affirm(value);

    public static implicit operator PaymentMethod11(Riverty value) => Riverty(value);

    public static implicit operator PaymentMethod11(IdealDetails value) => IdealDetails(value);

    public static implicit operator PaymentMethod11(PayPal value) => PayPal(value);

    public static implicit operator PaymentMethod11(PayPay value) => PayPay(value);

    public static implicit operator PaymentMethod11(RakutenPay value) => RakutenPay(value);

    public static implicit operator PaymentMethod11(AuPay value) => AuPay(value);

    public static implicit operator PaymentMethod11(DBarai value) => DBarai(value);

    public static implicit operator PaymentMethod11(SepaDirectDebit value) => SepaDirectDebit(value);

    public static implicit operator PaymentMethod11(Doku value) => Doku(value);

    public static implicit operator PaymentMethod11(Vipps value) => Vipps(value);

    public static implicit operator PaymentMethod11(MobilePay value) => MobilePay(value);

    public static implicit operator PaymentMethod11(Cellulant value) => Cellulant(value);

    public static implicit operator PaymentMethod11(WeChatPay value) => WeChatPay(value);

    public static implicit operator PaymentMethod11(WeChatPayMiniProgram value) => WeChatPayMiniProgram(value);

    public static implicit operator PaymentMethod11(MolPay value) => MolPay(value);

    public static implicit operator PaymentMethod11(BillDesk value) => BillDesk(value);

    public static implicit operator PaymentMethod11(PayU value) => PayU(value);

    public static implicit operator PaymentMethod11(PseLatam value) => PseLatam(value);

    public static implicit operator PaymentMethod11(UpiCollect value) => UpiCollect(value);

    public static implicit operator PaymentMethod11(UpiIntent value) => UpiIntent(value);

    public static implicit operator PaymentMethod11(UpiQr value) => UpiQr(value);

    public static implicit operator PaymentMethod11(StoredPaymentMethod2 value) => StoredPaymentMethod2(value);

    public static implicit operator PaymentMethod11(PayByBank value) => PayByBank(value);

    public static implicit operator PaymentMethod11(PayByBankAisDirectDebit value) =>
        PayByBankAisDirectDebit(value);

    public static implicit operator PaymentMethod11(OpenInvoice value) => OpenInvoice(value);

    public static implicit operator PaymentMethod11(EBankingFinland value) => EBankingFinland(value);

    public static implicit operator PaymentMethod11(Twint value) => Twint(value);

    public static implicit operator PaymentMethod11(StoredPaymentMethod4 value) => StoredPaymentMethod4(value);

    public static implicit operator PaymentMethod11(StoredPaymentMethod5 value) => StoredPaymentMethod5(value);

    public static implicit operator PaymentMethod11(Alma value) => Alma(value);

    public static implicit operator PaymentMethod11(Ancv value) => Ancv(value);

    public static implicit operator PaymentMethod11(PayTo value) => PayTo(value);

    public static implicit operator PaymentMethod11(DirectDebitAu value) => DirectDebitAu(value);

    public static implicit operator PaymentMethod11(Voucher value) => Voucher(value);

    public static implicit operator PaymentMethod11(Dragonpay value) => Dragonpay(value);

    public static implicit operator PaymentMethod11(BacsDirectDebit value) => BacsDirectDebit(value);

    public static implicit operator PaymentMethod11(Blik value) => Blik(value);

    public static implicit operator PaymentMethod11(MbWay value) => MbWay(value);

    public static implicit operator PaymentMethod11(StoredPaymentMethod value) => StoredPaymentMethod(value);
}

file sealed class PaymentMethod11Converter : JsonConverter<PaymentMethod11>
{
    public override PaymentMethod11 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var typeProperty))
        {
            throw new JsonException("Missing required 'type' discriminator field");
        }
        var discriminator = typeProperty.GetString();
        return discriminator switch
        {
            "applepay" => PaymentMethod11.ApplePayDetails(root.Deserialize<ApplePayDetails>(options)!),
            "samsungpay" => PaymentMethod11.SamsungPay(root.Deserialize<SamsungPay>(options)!),
            "androidpay" => PaymentMethod11.AndroidPay(root.Deserialize<AndroidPay>(options)!),
            "visacheckout" => PaymentMethod11.VisaCheckout(root.Deserialize<VisaCheckout>(options)!),
            "paywithgoogle" => PaymentMethod11.PayWithGoogleDetails(root.Deserialize<PayWithGoogleDetails>(options)!),
            "amazonpay" => PaymentMethod11.AmazonPay(root.Deserialize<AmazonPay>(options)!),
            "masterpass" => PaymentMethod11.Masterpass(root.Deserialize<Masterpass>(options)!),
            "googlepay" => PaymentMethod11.GooglePayDetails(root.Deserialize<GooglePayDetails>(options)!),
            "fastlane" => PaymentMethod11.Fastlane(root.Deserialize<Fastlane>(options)!),
            "alipay" or "multibanco" or "bankTransfer" or "bankTransfer_IBAN" or "paynow" or "affirm_pos" or
                "iris" or
                "wero" or
                "trustly" or
                "trustlyvector" or
                "oney" or
                "facilypay" or
                "facilypay_3x" or
                "facilypay_4x" or
                "facilypay_6x" or
                "facilypay_10x" or
                "facilypay_12x" or
                "unionpay" or
                "kcp_banktransfer" or
                "kcp_payco" or
                "kcp_creditcard" or
                "wechatpaySDK" or
                "wechatpayQR" or
                "wechatpayWeb" or
                "molpay_boost" or
                "wallet_IN" or
                "payu_IN_cashcard" or
                "payu_IN_nb" or
                "paytm" or
                "molpay_ebanking_VN" or
                "molpay_ebanking_MY" or
                "molpay_ebanking_direct_MY" or
                "swish" or
                "bizum" or
                "walley" or
                "walley_b2b" or
                "paypo" or
                "scalapay" or
                "scalapay_3x" or
                "scalapay_4x" or
                "molpay_fpx" or
                "payme" or
                "payme_pos" or
                "konbini" or
                "directEbanking" or
                "boletobancario" or
                "cashticket" or
                "ikano" or
                "karenmillen" or
                "oasis" or
                "warehouse" or
                "primeiropay_boleto" or
                "mada" or
                "benefit" or
                "knet" or
                "omannet" or
                "kcp_naverpay" or
                "fawry" or
                "atome" or
                "naps" or
                "nordea" or
                "boletobancario_bradesco" or
                "boletobancario_itau" or
                "boletobancario_santander" or
                "boletobancario_bancodobrasil" or
                "boletobancario_hsbc" or
                "molpay_maybank2u" or
                "molpay_cimb" or
                "molpay_rhb" or
                "molpay_amb" or
                "molpay_hlb" or
                "molpay_affin_epg" or
                "molpay_bankislam" or
                "molpay_publicbank" or
                "fpx_agrobank" or
                "touchngo" or
                "maybank2u_mae" or
                "duitnow" or
                "promptpay" or
                "twint_pos" or
                "alipay_hk" or
                "alipay_hk_web" or
                "alipay_hk_wap" or
                "alipay_wap" or
                "balanceplatform" => PaymentMethod11.PaymentDetails(root.Deserialize<PaymentDetails>(options)!),
            "alipay_plus" or "alipay_plus_alipay_cn" or "alipay_plus_alipay_hk" or "alipay_plus_dana" or
                "alipay_plus_gcash" or
                "alipay_plus_kakaopay" or
                "alipay_plus_kplus" or
                "alipay_plus_naverpay" or
                "alipay_plus_rabbitlinepay" or
                "alipay_plus_tosspay" or
                "alipay_plus_touchngo" or
                "alipay_plus_truemoney" or
                "bcmc_mobile" or
                "bcmc_mobile_QR" or
                "bcmc_mobile_app" or
                "momo_wallet" or
                "momo_wallet_app" or
                "paymaya_wallet" or
                "grabpay_SG" or
                "grabpay_MY" or
                "grabpay_TH" or
                "grabpay_ID" or
                "grabpay_VN" or
                "grabpay_PH" or
                "oxxo" or
                "gcash" or
                "dana" or
                "kakaopay" or
                "truemoney" or
                "paysafecard" or
                "gopay_wallet" => PaymentMethod11.StoredPaymentMethod6(root.Deserialize<StoredPaymentMethod6>(options)!),
            "bcmc" or "scheme" or "networkToken" or "altId" or "giftcard" or "alliancedata" or "card" => PaymentMethod11.CardDetails(root.Deserialize<CardDetails>(options)!),
            "externalToken" => PaymentMethod11.DetailsOfTokensThatAreNotStoredWithAdyen(root.Deserialize<DetailsOfTokensThatAreNotStoredWithAdyen>(options)!),
            "ach" or "ach_plaid" => PaymentMethod11.AchDirectDebit(root.Deserialize<AchDirectDebit>(options)!),
            "eft_directdebit_CA" => PaymentMethod11.EftDirectDebit(root.Deserialize<EftDirectDebit>(options)!),
            "klarna" or "klarnapayments" or "klarnapayments_account" or "klarnapayments_b2b" or "klarna_paynow" or
                "klarna_account" or
                "klarna_b2b" => PaymentMethod11.Klarna(root.Deserialize<Klarna>(options)!),
            "klarna_network" => PaymentMethod11.KlarnaNetwork(root.Deserialize<KlarnaNetwork>(options)!),
            "afterpay_default" or "afterpaytouch" or "afterpaytouch_pos" or "clearpay" or "afterpay_b2b" => PaymentMethod11.Afterpay(root.Deserialize<Afterpay>(options)!),
            "zip" or "zip_pos" => PaymentMethod11.Zip(root.Deserialize<Zip>(options)!),
            "ratepay" or "ratepay_directdebit" => PaymentMethod11.Ratepay(root.Deserialize<Ratepay>(options)!),
            "affirm" => PaymentMethod11.Affirm(root.Deserialize<Affirm>(options)!),
            "riverty_account" or "riverty" or "riverty_installments" or "sepadirectdebit_riverty" => PaymentMethod11.Riverty(root.Deserialize<Riverty>(options)!),
            "ideal" => PaymentMethod11.IdealDetails(root.Deserialize<IdealDetails>(options)!),
            "paypal" => PaymentMethod11.PayPal(root.Deserialize<PayPal>(options)!),
            "paypay" => PaymentMethod11.PayPay(root.Deserialize<PayPay>(options)!),
            "rakutenpay" => PaymentMethod11.RakutenPay(root.Deserialize<RakutenPay>(options)!),
            "aupay" => PaymentMethod11.AuPay(root.Deserialize<AuPay>(options)!),
            "dbarai" => PaymentMethod11.DBarai(root.Deserialize<DBarai>(options)!),
            "sepadirectdebit" or "sepadirectdebit_amazonpay" => PaymentMethod11.SepaDirectDebit(root.Deserialize<SepaDirectDebit>(options)!),
            "doku" or "doku_wallet" or "doku_ovo" or "doku_permata_lite_atm" or "doku_permata_atm" or
                "doku_alfamart" or
                "doku_indomaret" or
                "doku_sinarmas_va" or
                "doku_bca_va" or
                "doku_mandiri_va" or
                "doku_cimb_va" or
                "doku_danamon_va" or
                "doku_bri_va" or
                "doku_bni_va" or
                "doku_bni" or
                "doku_paymentmethods" or
                "doku_atm_mandiri_va" or
                "doku_briepay" or
                "doku_mandiri_multipayment_lite" or
                "doku_card" or
                "doku_atm_mandiri_va_lite" or
                "doku_bca_klikpay" or
                "doku_mandiri_multipayment" or
                "doku_mandiri_clickpay" => PaymentMethod11.Doku(root.Deserialize<Doku>(options)!),
            "vipps" => PaymentMethod11.Vipps(root.Deserialize<Vipps>(options)!),
            "mobilepay" => PaymentMethod11.MobilePay(root.Deserialize<MobilePay>(options)!),
            "cellulant" => PaymentMethod11.Cellulant(root.Deserialize<Cellulant>(options)!),
            "wechatpay" or "wechatpay_pos" => PaymentMethod11.WeChatPay(root.Deserialize<WeChatPay>(options)!),
            "wechatpayMiniProgram" => PaymentMethod11.WeChatPayMiniProgram(root.Deserialize<WeChatPayMiniProgram>(options)!),
            "molpay_ebanking_fpx_MY" or "molpay_ebanking_TH" or "molpay_krungsribank" or "molpay_krungthaibank" or
                "molpay_siamcommercialbank" or
                "molpay_bangkokbank" or
                "molpay_kbank" => PaymentMethod11.MolPay(root.Deserialize<MolPay>(options)!),
            "billdesk_online" or "billdesk_wallet" => PaymentMethod11.BillDesk(root.Deserialize<BillDesk>(options)!),
            "payu_IN_upi" => PaymentMethod11.PayU(root.Deserialize<PayU>(options)!),
            "pse_payulatam" => PaymentMethod11.PseLatam(root.Deserialize<PseLatam>(options)!),
            "upi_collect" => PaymentMethod11.UpiCollect(root.Deserialize<UpiCollect>(options)!),
            "upi_intent" => PaymentMethod11.UpiIntent(root.Deserialize<UpiIntent>(options)!),
            "upi_qr" => PaymentMethod11.UpiQr(root.Deserialize<UpiQr>(options)!),
            "onlineBanking_PL" or "eps" or "onlineBanking_SK" or "onlineBanking_CZ" or "onlinebanking_IN" => PaymentMethod11.StoredPaymentMethod2(root.Deserialize<StoredPaymentMethod2>(options)!),
            "paybybank" => PaymentMethod11.PayByBank(root.Deserialize<PayByBank>(options)!),
            "paybybank_AIS_DD" => PaymentMethod11.PayByBankAisDirectDebit(root.Deserialize<PayByBankAisDirectDebit>(options)!),
            "openinvoice" or "afterpay_directdebit" or "atome_pos" => PaymentMethod11.OpenInvoice(root.Deserialize<OpenInvoice>(options)!),
            "ebanking_FI" => PaymentMethod11.EBankingFinland(root.Deserialize<EBankingFinland>(options)!),
            "twint" => PaymentMethod11.Twint(root.Deserialize<Twint>(options)!),
            "pix" => PaymentMethod11.StoredPaymentMethod4(root.Deserialize<StoredPaymentMethod4>(options)!),
            "paybybank_pix" => PaymentMethod11.StoredPaymentMethod5(root.Deserialize<StoredPaymentMethod5>(options)!),
            "alma" => PaymentMethod11.Alma(root.Deserialize<Alma>(options)!),
            "ancv" => PaymentMethod11.Ancv(root.Deserialize<Ancv>(options)!),
            "payto" => PaymentMethod11.PayTo(root.Deserialize<PayTo>(options)!),
            "directdebit_AU" => PaymentMethod11.DirectDebitAu(root.Deserialize<DirectDebitAu>(options)!),
            "econtext_seven_eleven" or "econtext_online" or "econtext" or "econtext_stores" or "econtext_atm" => PaymentMethod11.Voucher(root.Deserialize<Voucher>(options)!),
            "dragonpay_ebanking" or "dragonpay_otc_banking" or "dragonpay_otc_non_banking" or
                "dragonpay_otc_philippines" => PaymentMethod11.Dragonpay(root.Deserialize<Dragonpay>(options)!),
            "directdebit_GB" => PaymentMethod11.BacsDirectDebit(root.Deserialize<BacsDirectDebit>(options)!),
            "blik" => PaymentMethod11.Blik(root.Deserialize<Blik>(options)!),
            "mbway" => PaymentMethod11.MbWay(root.Deserialize<MbWay>(options)!),
            "cashapp" => PaymentMethod11.StoredPaymentMethod(root.Deserialize<StoredPaymentMethod>(options)!),
            _ => throw new JsonException($"JSON does not match ApplePayDetails or SamsungPay or AndroidPay or VisaCheckout or PayWithGoogleDetails or AmazonPay or Masterpass or GooglePayDetails or Fastlane or PaymentDetails or StoredPaymentMethod6 or CardDetails or DetailsOfTokensThatAreNotStoredWithAdyen or AchDirectDebit or EftDirectDebit or Klarna or KlarnaNetwork or Afterpay or Zip or Ratepay or Affirm or Riverty or IdealDetails or PayPal or PayPay or RakutenPay or AuPay or DBarai or SepaDirectDebit or Doku or Vipps or MobilePay or Cellulant or WeChatPay or WeChatPayMiniProgram or MolPay or BillDesk or PayU or PseLatam or UpiCollect or UpiIntent or UpiQr or StoredPaymentMethod2 or PayByBank or PayByBankAisDirectDebit or OpenInvoice or EBankingFinland or Twint or StoredPaymentMethod4 or StoredPaymentMethod5 or Alma or Ancv or PayTo or DirectDebitAu or Voucher or Dragonpay or BacsDirectDebit or Blik or MbWay or StoredPaymentMethod schemas: {root.ToString()}")
        };
    }

    public override void Write(Utf8JsonWriter writer, PaymentMethod11 value, JsonSerializerOptions options)
    {
        if (value.TryGetApplePayDetails(out var applePayDetailsValue))
        {
            JsonSerializer.Serialize(writer, applePayDetailsValue, options);
        }
        else if (value.TryGetSamsungPay(out var samsungPayValue))
        {
            JsonSerializer.Serialize(writer, samsungPayValue, options);
        }
        else if (value.TryGetAndroidPay(out var androidPayValue))
        {
            JsonSerializer.Serialize(writer, androidPayValue, options);
        }
        else if (value.TryGetVisaCheckout(out var visaCheckoutValue))
        {
            JsonSerializer.Serialize(writer, visaCheckoutValue, options);
        }
        else if (value.TryGetPayWithGoogleDetails(out var payWithGoogleDetailsValue))
        {
            JsonSerializer.Serialize(writer, payWithGoogleDetailsValue, options);
        }
        else if (value.TryGetAmazonPay(out var amazonPayValue))
        {
            JsonSerializer.Serialize(writer, amazonPayValue, options);
        }
        else if (value.TryGetMasterpass(out var masterpassValue))
        {
            JsonSerializer.Serialize(writer, masterpassValue, options);
        }
        else if (value.TryGetGooglePayDetails(out var googlePayDetailsValue))
        {
            JsonSerializer.Serialize(writer, googlePayDetailsValue, options);
        }
        else if (value.TryGetFastlane(out var fastlaneValue))
        {
            JsonSerializer.Serialize(writer, fastlaneValue, options);
        }
        else if (value.TryGetPaymentDetails(out var paymentDetailsValue))
        {
            JsonSerializer.Serialize(writer, paymentDetailsValue, options);
        }
        else if (value.TryGetStoredPaymentMethod6(out var storedPaymentMethod6Value))
        {
            JsonSerializer.Serialize(writer, storedPaymentMethod6Value, options);
        }
        else if (value.TryGetCardDetails(out var cardDetailsValue))
        {
            JsonSerializer.Serialize(writer, cardDetailsValue, options);
        }
        else if (value.TryGetDetailsOfTokensThatAreNotStoredWithAdyen(out var detailsOfTokensThatAreNotStoredWithAdyenValue))
        {
            JsonSerializer.Serialize(writer, detailsOfTokensThatAreNotStoredWithAdyenValue, options);
        }
        else if (value.TryGetAchDirectDebit(out var achDirectDebitValue))
        {
            JsonSerializer.Serialize(writer, achDirectDebitValue, options);
        }
        else if (value.TryGetEftDirectDebit(out var eftDirectDebitValue))
        {
            JsonSerializer.Serialize(writer, eftDirectDebitValue, options);
        }
        else if (value.TryGetKlarna(out var klarnaValue))
        {
            JsonSerializer.Serialize(writer, klarnaValue, options);
        }
        else if (value.TryGetKlarnaNetwork(out var klarnaNetworkValue))
        {
            JsonSerializer.Serialize(writer, klarnaNetworkValue, options);
        }
        else if (value.TryGetAfterpay(out var afterpayValue))
        {
            JsonSerializer.Serialize(writer, afterpayValue, options);
        }
        else if (value.TryGetZip(out var zipValue))
        {
            JsonSerializer.Serialize(writer, zipValue, options);
        }
        else if (value.TryGetRatepay(out var ratepayValue))
        {
            JsonSerializer.Serialize(writer, ratepayValue, options);
        }
        else if (value.TryGetAffirm(out var affirmValue))
        {
            JsonSerializer.Serialize(writer, affirmValue, options);
        }
        else if (value.TryGetRiverty(out var rivertyValue))
        {
            JsonSerializer.Serialize(writer, rivertyValue, options);
        }
        else if (value.TryGetIdealDetails(out var idealDetailsValue))
        {
            JsonSerializer.Serialize(writer, idealDetailsValue, options);
        }
        else if (value.TryGetPayPal(out var payPalValue))
        {
            JsonSerializer.Serialize(writer, payPalValue, options);
        }
        else if (value.TryGetPayPay(out var payPayValue))
        {
            JsonSerializer.Serialize(writer, payPayValue, options);
        }
        else if (value.TryGetRakutenPay(out var rakutenPayValue))
        {
            JsonSerializer.Serialize(writer, rakutenPayValue, options);
        }
        else if (value.TryGetAuPay(out var auPayValue))
        {
            JsonSerializer.Serialize(writer, auPayValue, options);
        }
        else if (value.TryGetDBarai(out var dBaraiValue))
        {
            JsonSerializer.Serialize(writer, dBaraiValue, options);
        }
        else if (value.TryGetSepaDirectDebit(out var sepaDirectDebitValue))
        {
            JsonSerializer.Serialize(writer, sepaDirectDebitValue, options);
        }
        else if (value.TryGetDoku(out var dokuValue))
        {
            JsonSerializer.Serialize(writer, dokuValue, options);
        }
        else if (value.TryGetVipps(out var vippsValue))
        {
            JsonSerializer.Serialize(writer, vippsValue, options);
        }
        else if (value.TryGetMobilePay(out var mobilePayValue))
        {
            JsonSerializer.Serialize(writer, mobilePayValue, options);
        }
        else if (value.TryGetCellulant(out var cellulantValue))
        {
            JsonSerializer.Serialize(writer, cellulantValue, options);
        }
        else if (value.TryGetWeChatPay(out var weChatPayValue))
        {
            JsonSerializer.Serialize(writer, weChatPayValue, options);
        }
        else if (value.TryGetWeChatPayMiniProgram(out var weChatPayMiniProgramValue))
        {
            JsonSerializer.Serialize(writer, weChatPayMiniProgramValue, options);
        }
        else if (value.TryGetMolPay(out var molPayValue))
        {
            JsonSerializer.Serialize(writer, molPayValue, options);
        }
        else if (value.TryGetBillDesk(out var billDeskValue))
        {
            JsonSerializer.Serialize(writer, billDeskValue, options);
        }
        else if (value.TryGetPayU(out var payUValue))
        {
            JsonSerializer.Serialize(writer, payUValue, options);
        }
        else if (value.TryGetPseLatam(out var pseLatamValue))
        {
            JsonSerializer.Serialize(writer, pseLatamValue, options);
        }
        else if (value.TryGetUpiCollect(out var upiCollectValue))
        {
            JsonSerializer.Serialize(writer, upiCollectValue, options);
        }
        else if (value.TryGetUpiIntent(out var upiIntentValue))
        {
            JsonSerializer.Serialize(writer, upiIntentValue, options);
        }
        else if (value.TryGetUpiQr(out var upiQrValue))
        {
            JsonSerializer.Serialize(writer, upiQrValue, options);
        }
        else if (value.TryGetStoredPaymentMethod2(out var storedPaymentMethod2Value))
        {
            JsonSerializer.Serialize(writer, storedPaymentMethod2Value, options);
        }
        else if (value.TryGetPayByBank(out var payByBankValue))
        {
            JsonSerializer.Serialize(writer, payByBankValue, options);
        }
        else if (value.TryGetPayByBankAisDirectDebit(out var payByBankAisDirectDebitValue))
        {
            JsonSerializer.Serialize(writer, payByBankAisDirectDebitValue, options);
        }
        else if (value.TryGetOpenInvoice(out var openInvoiceValue))
        {
            JsonSerializer.Serialize(writer, openInvoiceValue, options);
        }
        else if (value.TryGetEBankingFinland(out var eBankingFinlandValue))
        {
            JsonSerializer.Serialize(writer, eBankingFinlandValue, options);
        }
        else if (value.TryGetTwint(out var twintValue))
        {
            JsonSerializer.Serialize(writer, twintValue, options);
        }
        else if (value.TryGetStoredPaymentMethod4(out var storedPaymentMethod4Value))
        {
            JsonSerializer.Serialize(writer, storedPaymentMethod4Value, options);
        }
        else if (value.TryGetStoredPaymentMethod5(out var storedPaymentMethod5Value))
        {
            JsonSerializer.Serialize(writer, storedPaymentMethod5Value, options);
        }
        else if (value.TryGetAlma(out var almaValue))
        {
            JsonSerializer.Serialize(writer, almaValue, options);
        }
        else if (value.TryGetAncv(out var ancvValue))
        {
            JsonSerializer.Serialize(writer, ancvValue, options);
        }
        else if (value.TryGetPayTo(out var payToValue))
        {
            JsonSerializer.Serialize(writer, payToValue, options);
        }
        else if (value.TryGetDirectDebitAu(out var directDebitAuValue))
        {
            JsonSerializer.Serialize(writer, directDebitAuValue, options);
        }
        else if (value.TryGetVoucher(out var voucherValue))
        {
            JsonSerializer.Serialize(writer, voucherValue, options);
        }
        else if (value.TryGetDragonpay(out var dragonpayValue))
        {
            JsonSerializer.Serialize(writer, dragonpayValue, options);
        }
        else if (value.TryGetBacsDirectDebit(out var bacsDirectDebitValue))
        {
            JsonSerializer.Serialize(writer, bacsDirectDebitValue, options);
        }
        else if (value.TryGetBlik(out var blikValue))
        {
            JsonSerializer.Serialize(writer, blikValue, options);
        }
        else if (value.TryGetMbWay(out var mbWayValue))
        {
            JsonSerializer.Serialize(writer, mbWayValue, options);
        }
        else if (value.TryGetStoredPaymentMethod(out var storedPaymentMethodValue))
        {
            JsonSerializer.Serialize(writer, storedPaymentMethodValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(PaymentMethod11)} contains no valid value to serialize.");
        }
    }
}
