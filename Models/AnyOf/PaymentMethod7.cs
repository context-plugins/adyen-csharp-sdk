using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// The type and required details of a payment method to use.
/// </summary>
[JsonConverter(typeof(PaymentMethod7Converter))]
public record PaymentMethod7
{
    private readonly Optional<AchdirectDebit> _achdirectDebitValue;

    private readonly Optional<Affirm> _affirmValue;

    private readonly Optional<Afterpay> _afterpayValue;

    private readonly Optional<Alma> _almaValue;

    private readonly Optional<AmazonPay> _amazonPayValue;

    private readonly Optional<Ancv> _ancvValue;

    private readonly Optional<AndroidPay> _androidPayValue;

    private readonly Optional<ApplePayDetails> _applePayDetailsValue;

    private readonly Optional<AuPay> _auPayValue;

    private readonly Optional<BacsdirectDebit> _bacsdirectDebitValue;

    private readonly Optional<BillDesk> _billDeskValue;

    private readonly Optional<Blik> _blikValue;

    private readonly Optional<CardDetails> _cardDetailsValue;

    private readonly Optional<StoredPaymentMethod> _storedPaymentMethodValue;

    private readonly Optional<Cellulant> _cellulantValue;

    private readonly Optional<Dbarai> _dbaraiValue;

    private readonly Optional<DirectDebitAu> _directDebitAuValue;

    private readonly Optional<Doku> _dokuValue;

    private readonly Optional<Dragonpay> _dragonpayValue;

    private readonly Optional<EBankingFinland> _ebankingFinlandValue;

    private readonly Optional<Voucher> _voucherValue;

    private readonly Optional<EftdirectDebit> _eftdirectDebitValue;

    private readonly Optional<DetailsoftokensthatarenotstoredwithAdyen> _detailsoftokensthatarenotstoredwithAdyenValue;

    private readonly Optional<Fastlane> _fastlaneValue;

    private readonly Optional<StoredPaymentMethod2> _storedPaymentMethod2Value;

    private readonly Optional<GooglePayDetails> _googlePayDetailsValue;

    private readonly Optional<IdealDetails> _idealDetailsValue;

    private readonly Optional<Klarna> _klarnaValue;

    private readonly Optional<KlarnaNetwork> _klarnaNetworkValue;

    private readonly Optional<Masterpass> _masterpassValue;

    private readonly Optional<Mbway> _mbwayValue;

    private readonly Optional<MobilePay> _mobilePayValue;

    private readonly Optional<Molpay> _molpayValue;

    private readonly Optional<OpenInvoice> _openInvoiceValue;

    private readonly Optional<PayByBankAisdirectDebit> _payByBankAisdirectDebitValue;

    private readonly Optional<PayByBank> _payByBankValue;

    private readonly Optional<PayPal> _payPalValue;

    private readonly Optional<PayPay> _payPayValue;

    private readonly Optional<PayTo> _payToValue;

    private readonly Optional<PayU> _payUValue;

    private readonly Optional<PayWithGoogleDetails> _payWithGoogleDetailsValue;

    private readonly Optional<PaymentDetails2> _paymentDetails2Value;

    private readonly Optional<StoredPaymentMethod4> _storedPaymentMethod4Value;

    private readonly Optional<StoredPaymentMethod5> _storedPaymentMethod5Value;

    private readonly Optional<Pselatam> _pselatamValue;

    private readonly Optional<RakutenPay> _rakutenPayValue;

    private readonly Optional<Ratepay> _ratepayValue;

    private readonly Optional<Riverty> _rivertyValue;

    private readonly Optional<SamsungPay> _samsungPayValue;

    private readonly Optional<SepadirectDebit> _sepadirectDebitValue;

    private readonly Optional<StoredPaymentMethod6> _storedPaymentMethod6Value;

    private readonly Optional<Twint> _twintValue;

    private readonly Optional<Upicollect> _upicollectValue;

    private readonly Optional<Upiintent> _upiintentValue;

    private readonly Optional<Upiqr> _upiqrValue;

    private readonly Optional<Vipps> _vippsValue;

    private readonly Optional<VisaCheckout> _visaCheckoutValue;

    private readonly Optional<WeChatPay> _weChatPayValue;

    private readonly Optional<WeChatPayMiniProgram> _weChatPayMiniProgramValue;

    private readonly Optional<Zip> _zipValue;

    private PaymentMethod7(Optional<AchdirectDebit> achdirectDebitValue,
        Optional<Affirm> affirmValue,
        Optional<Afterpay> afterpayValue,
        Optional<Alma> almaValue,
        Optional<AmazonPay> amazonPayValue,
        Optional<Ancv> ancvValue,
        Optional<AndroidPay> androidPayValue,
        Optional<ApplePayDetails> applePayDetailsValue,
        Optional<AuPay> auPayValue,
        Optional<BacsdirectDebit> bacsdirectDebitValue,
        Optional<BillDesk> billDeskValue,
        Optional<Blik> blikValue,
        Optional<CardDetails> cardDetailsValue,
        Optional<StoredPaymentMethod> storedPaymentMethodValue,
        Optional<Cellulant> cellulantValue,
        Optional<Dbarai> dbaraiValue,
        Optional<DirectDebitAu> directDebitAuValue,
        Optional<Doku> dokuValue,
        Optional<Dragonpay> dragonpayValue,
        Optional<EBankingFinland> ebankingFinlandValue,
        Optional<Voucher> voucherValue,
        Optional<EftdirectDebit> eftdirectDebitValue,
        Optional<DetailsoftokensthatarenotstoredwithAdyen> detailsoftokensthatarenotstoredwithAdyenValue,
        Optional<Fastlane> fastlaneValue,
        Optional<StoredPaymentMethod2> storedPaymentMethod2Value,
        Optional<GooglePayDetails> googlePayDetailsValue,
        Optional<IdealDetails> idealDetailsValue,
        Optional<Klarna> klarnaValue,
        Optional<KlarnaNetwork> klarnaNetworkValue,
        Optional<Masterpass> masterpassValue,
        Optional<Mbway> mbwayValue,
        Optional<MobilePay> mobilePayValue,
        Optional<Molpay> molpayValue,
        Optional<OpenInvoice> openInvoiceValue,
        Optional<PayByBankAisdirectDebit> payByBankAisdirectDebitValue,
        Optional<PayByBank> payByBankValue,
        Optional<PayPal> payPalValue,
        Optional<PayPay> payPayValue,
        Optional<PayTo> payToValue,
        Optional<PayU> payUValue,
        Optional<PayWithGoogleDetails> payWithGoogleDetailsValue,
        Optional<PaymentDetails2> paymentDetails2Value,
        Optional<StoredPaymentMethod4> storedPaymentMethod4Value,
        Optional<StoredPaymentMethod5> storedPaymentMethod5Value,
        Optional<Pselatam> pselatamValue,
        Optional<RakutenPay> rakutenPayValue,
        Optional<Ratepay> ratepayValue,
        Optional<Riverty> rivertyValue,
        Optional<SamsungPay> samsungPayValue,
        Optional<SepadirectDebit> sepadirectDebitValue,
        Optional<StoredPaymentMethod6> storedPaymentMethod6Value,
        Optional<Twint> twintValue,
        Optional<Upicollect> upicollectValue,
        Optional<Upiintent> upiintentValue,
        Optional<Upiqr> upiqrValue,
        Optional<Vipps> vippsValue,
        Optional<VisaCheckout> visaCheckoutValue,
        Optional<WeChatPay> weChatPayValue,
        Optional<WeChatPayMiniProgram> weChatPayMiniProgramValue,
        Optional<Zip> zipValue)
    {
        _achdirectDebitValue = achdirectDebitValue;
        _affirmValue = affirmValue;
        _afterpayValue = afterpayValue;
        _almaValue = almaValue;
        _amazonPayValue = amazonPayValue;
        _ancvValue = ancvValue;
        _androidPayValue = androidPayValue;
        _applePayDetailsValue = applePayDetailsValue;
        _auPayValue = auPayValue;
        _bacsdirectDebitValue = bacsdirectDebitValue;
        _billDeskValue = billDeskValue;
        _blikValue = blikValue;
        _cardDetailsValue = cardDetailsValue;
        _storedPaymentMethodValue = storedPaymentMethodValue;
        _cellulantValue = cellulantValue;
        _dbaraiValue = dbaraiValue;
        _directDebitAuValue = directDebitAuValue;
        _dokuValue = dokuValue;
        _dragonpayValue = dragonpayValue;
        _ebankingFinlandValue = ebankingFinlandValue;
        _voucherValue = voucherValue;
        _eftdirectDebitValue = eftdirectDebitValue;
        _detailsoftokensthatarenotstoredwithAdyenValue = detailsoftokensthatarenotstoredwithAdyenValue;
        _fastlaneValue = fastlaneValue;
        _storedPaymentMethod2Value = storedPaymentMethod2Value;
        _googlePayDetailsValue = googlePayDetailsValue;
        _idealDetailsValue = idealDetailsValue;
        _klarnaValue = klarnaValue;
        _klarnaNetworkValue = klarnaNetworkValue;
        _masterpassValue = masterpassValue;
        _mbwayValue = mbwayValue;
        _mobilePayValue = mobilePayValue;
        _molpayValue = molpayValue;
        _openInvoiceValue = openInvoiceValue;
        _payByBankAisdirectDebitValue = payByBankAisdirectDebitValue;
        _payByBankValue = payByBankValue;
        _payPalValue = payPalValue;
        _payPayValue = payPayValue;
        _payToValue = payToValue;
        _payUValue = payUValue;
        _payWithGoogleDetailsValue = payWithGoogleDetailsValue;
        _paymentDetails2Value = paymentDetails2Value;
        _storedPaymentMethod4Value = storedPaymentMethod4Value;
        _storedPaymentMethod5Value = storedPaymentMethod5Value;
        _pselatamValue = pselatamValue;
        _rakutenPayValue = rakutenPayValue;
        _ratepayValue = ratepayValue;
        _rivertyValue = rivertyValue;
        _samsungPayValue = samsungPayValue;
        _sepadirectDebitValue = sepadirectDebitValue;
        _storedPaymentMethod6Value = storedPaymentMethod6Value;
        _twintValue = twintValue;
        _upicollectValue = upicollectValue;
        _upiintentValue = upiintentValue;
        _upiqrValue = upiqrValue;
        _vippsValue = vippsValue;
        _visaCheckoutValue = visaCheckoutValue;
        _weChatPayValue = weChatPayValue;
        _weChatPayMiniProgramValue = weChatPayMiniProgramValue;
        _zipValue = zipValue;
    }

    public static PaymentMethod7 AchdirectDebit(AchdirectDebit value) =>
        new(Optional<AchdirectDebit>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 Affirm(Affirm value) =>
        new(default,
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
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 Afterpay(Afterpay value) =>
        new(default,
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
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 Alma(Alma value) =>
        new(default,
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
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 AmazonPay(AmazonPay value) =>
        new(default,
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
            default,
            default);

    public static PaymentMethod7 Ancv(Ancv value) =>
        new(default,
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
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 AndroidPay(AndroidPay value) =>
        new(default,
            default,
            default,
            default,
            default,
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
            default);

    public static PaymentMethod7 ApplePayDetails(ApplePayDetails value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<ApplePayDetails>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 AuPay(AuPay value) =>
        new(default,
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
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 BacsdirectDebit(BacsdirectDebit value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<BacsdirectDebit>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 BillDesk(BillDesk value) =>
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
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 Blik(Blik value) =>
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
            Optional<Blik>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 CardDetails(CardDetails value) =>
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
            default);

    public static PaymentMethod7 StoredPaymentMethod(StoredPaymentMethod value) =>
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
            Optional<StoredPaymentMethod>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 Cellulant(Cellulant value) =>
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
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 Dbarai(Dbarai value) =>
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
            Optional<Dbarai>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 DirectDebitAu(DirectDebitAu value) =>
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
            Optional<DirectDebitAu>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 Doku(Doku value) =>
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
            default,
            default,
            default,
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

    public static PaymentMethod7 Dragonpay(Dragonpay value) =>
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
            Optional<Dragonpay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 EbankingFinland(EBankingFinland value) =>
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
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 Voucher(Voucher value) =>
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
            Optional<Voucher>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 EftdirectDebit(EftdirectDebit value) =>
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
            Optional<EftdirectDebit>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 DetailsoftokensthatarenotstoredwithAdyen(DetailsoftokensthatarenotstoredwithAdyen value) =>
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
            Optional<DetailsoftokensthatarenotstoredwithAdyen>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 Fastlane(Fastlane value) =>
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
            default);

    public static PaymentMethod7 StoredPaymentMethod2(StoredPaymentMethod2 value) =>
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
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 GooglePayDetails(GooglePayDetails value) =>
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
            default);

    public static PaymentMethod7 IdealDetails(IdealDetails value) =>
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
            default);

    public static PaymentMethod7 Klarna(Klarna value) =>
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
            default);

    public static PaymentMethod7 KlarnaNetwork(KlarnaNetwork value) =>
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
            default);

    public static PaymentMethod7 Masterpass(Masterpass value) =>
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
            default);

    public static PaymentMethod7 Mbway(Mbway value) =>
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
            Optional<Mbway>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 MobilePay(MobilePay value) =>
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

    public static PaymentMethod7 Molpay(Molpay value) =>
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
            Optional<Molpay>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 OpenInvoice(OpenInvoice value) =>
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
            default,
            default,
            default,
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

    public static PaymentMethod7 PayByBankAisdirectDebit(PayByBankAisdirectDebit value) =>
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
            Optional<PayByBankAisdirectDebit>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 PayByBank(PayByBank value) =>
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
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod7 PayPal(PayPal value) =>
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
            default);

    public static PaymentMethod7 PayPay(PayPay value) =>
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
            default);

    public static PaymentMethod7 PayTo(PayTo value) =>
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
            Optional<PayTo>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 PayU(PayU value) =>
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
            default);

    public static PaymentMethod7 PayWithGoogleDetails(PayWithGoogleDetails value) =>
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
            default);

    public static PaymentMethod7 PaymentDetails2(PaymentDetails2 value) =>
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
            Optional<PaymentDetails2>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 StoredPaymentMethod4(StoredPaymentMethod4 value) =>
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
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod7 StoredPaymentMethod5(StoredPaymentMethod5 value) =>
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
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod7 Pselatam(Pselatam value) =>
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
            Optional<Pselatam>.Some(value),
            default,
            default,
            default,
            default,
            default,
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

    public static PaymentMethod7 RakutenPay(RakutenPay value) =>
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
            default);

    public static PaymentMethod7 Ratepay(Ratepay value) =>
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
            default);

    public static PaymentMethod7 Riverty(Riverty value) =>
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
            default);

    public static PaymentMethod7 SamsungPay(SamsungPay value) =>
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
            default);

    public static PaymentMethod7 SepadirectDebit(SepadirectDebit value) =>
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
            Optional<SepadirectDebit>.Some(value),
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

    public static PaymentMethod7 StoredPaymentMethod6(StoredPaymentMethod6 value) =>
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
            Optional<StoredPaymentMethod6>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod7 Twint(Twint value) =>
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
            Optional<Twint>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod7 Upicollect(Upicollect value) =>
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
            Optional<Upicollect>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod7 Upiintent(Upiintent value) =>
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
            Optional<Upiintent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod7 Upiqr(Upiqr value) =>
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
            Optional<Upiqr>.Some(value),
            default,
            default,
            default,
            default,
            default);

    public static PaymentMethod7 Vipps(Vipps value) =>
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
            Optional<Vipps>.Some(value),
            default,
            default,
            default,
            default);

    public static PaymentMethod7 VisaCheckout(VisaCheckout value) =>
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
            Optional<VisaCheckout>.Some(value),
            default,
            default,
            default);

    public static PaymentMethod7 WeChatPay(WeChatPay value) =>
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
            Optional<WeChatPay>.Some(value),
            default,
            default);

    public static PaymentMethod7 WeChatPayMiniProgram(WeChatPayMiniProgram value) =>
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
            Optional<WeChatPayMiniProgram>.Some(value),
            default);

    public static PaymentMethod7 Zip(Zip value) =>
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
            Optional<Zip>.Some(value));

    public bool TryGetAchdirectDebit(out AchdirectDebit value) => _achdirectDebitValue.TryGetValue(out value);

    public bool TryGetAffirm(out Affirm value) => _affirmValue.TryGetValue(out value);

    public bool TryGetAfterpay(out Afterpay value) => _afterpayValue.TryGetValue(out value);

    public bool TryGetAlma(out Alma value) => _almaValue.TryGetValue(out value);

    public bool TryGetAmazonPay(out AmazonPay value) => _amazonPayValue.TryGetValue(out value);

    public bool TryGetAncv(out Ancv value) => _ancvValue.TryGetValue(out value);

    public bool TryGetAndroidPay(out AndroidPay value) => _androidPayValue.TryGetValue(out value);

    public bool TryGetApplePayDetails(out ApplePayDetails value) =>
        _applePayDetailsValue.TryGetValue(out value);

    public bool TryGetAuPay(out AuPay value) => _auPayValue.TryGetValue(out value);

    public bool TryGetBacsdirectDebit(out BacsdirectDebit value) =>
        _bacsdirectDebitValue.TryGetValue(out value);

    public bool TryGetBillDesk(out BillDesk value) => _billDeskValue.TryGetValue(out value);

    public bool TryGetBlik(out Blik value) => _blikValue.TryGetValue(out value);

    public bool TryGetCardDetails(out CardDetails value) => _cardDetailsValue.TryGetValue(out value);

    public bool TryGetStoredPaymentMethod(out StoredPaymentMethod value) =>
        _storedPaymentMethodValue.TryGetValue(out value);

    public bool TryGetCellulant(out Cellulant value) => _cellulantValue.TryGetValue(out value);

    public bool TryGetDbarai(out Dbarai value) => _dbaraiValue.TryGetValue(out value);

    public bool TryGetDirectDebitAu(out DirectDebitAu value) => _directDebitAuValue.TryGetValue(out value);

    public bool TryGetDoku(out Doku value) => _dokuValue.TryGetValue(out value);

    public bool TryGetDragonpay(out Dragonpay value) => _dragonpayValue.TryGetValue(out value);

    public bool TryGetEbankingFinland(out EBankingFinland value) =>
        _ebankingFinlandValue.TryGetValue(out value);

    public bool TryGetVoucher(out Voucher value) => _voucherValue.TryGetValue(out value);

    public bool TryGetEftdirectDebit(out EftdirectDebit value) => _eftdirectDebitValue.TryGetValue(out value);

    public bool TryGetDetailsoftokensthatarenotstoredwithAdyen(out DetailsoftokensthatarenotstoredwithAdyen value) =>
        _detailsoftokensthatarenotstoredwithAdyenValue.TryGetValue(out value);

    public bool TryGetFastlane(out Fastlane value) => _fastlaneValue.TryGetValue(out value);

    public bool TryGetStoredPaymentMethod2(out StoredPaymentMethod2 value) =>
        _storedPaymentMethod2Value.TryGetValue(out value);

    public bool TryGetGooglePayDetails(out GooglePayDetails value) =>
        _googlePayDetailsValue.TryGetValue(out value);

    public bool TryGetIdealDetails(out IdealDetails value) => _idealDetailsValue.TryGetValue(out value);

    public bool TryGetKlarna(out Klarna value) => _klarnaValue.TryGetValue(out value);

    public bool TryGetKlarnaNetwork(out KlarnaNetwork value) => _klarnaNetworkValue.TryGetValue(out value);

    public bool TryGetMasterpass(out Masterpass value) => _masterpassValue.TryGetValue(out value);

    public bool TryGetMbway(out Mbway value) => _mbwayValue.TryGetValue(out value);

    public bool TryGetMobilePay(out MobilePay value) => _mobilePayValue.TryGetValue(out value);

    public bool TryGetMolpay(out Molpay value) => _molpayValue.TryGetValue(out value);

    public bool TryGetOpenInvoice(out OpenInvoice value) => _openInvoiceValue.TryGetValue(out value);

    public bool TryGetPayByBankAisdirectDebit(out PayByBankAisdirectDebit value) =>
        _payByBankAisdirectDebitValue.TryGetValue(out value);

    public bool TryGetPayByBank(out PayByBank value) => _payByBankValue.TryGetValue(out value);

    public bool TryGetPayPal(out PayPal value) => _payPalValue.TryGetValue(out value);

    public bool TryGetPayPay(out PayPay value) => _payPayValue.TryGetValue(out value);

    public bool TryGetPayTo(out PayTo value) => _payToValue.TryGetValue(out value);

    public bool TryGetPayU(out PayU value) => _payUValue.TryGetValue(out value);

    public bool TryGetPayWithGoogleDetails(out PayWithGoogleDetails value) =>
        _payWithGoogleDetailsValue.TryGetValue(out value);

    public bool TryGetPaymentDetails2(out PaymentDetails2 value) =>
        _paymentDetails2Value.TryGetValue(out value);

    public bool TryGetStoredPaymentMethod4(out StoredPaymentMethod4 value) =>
        _storedPaymentMethod4Value.TryGetValue(out value);

    public bool TryGetStoredPaymentMethod5(out StoredPaymentMethod5 value) =>
        _storedPaymentMethod5Value.TryGetValue(out value);

    public bool TryGetPselatam(out Pselatam value) => _pselatamValue.TryGetValue(out value);

    public bool TryGetRakutenPay(out RakutenPay value) => _rakutenPayValue.TryGetValue(out value);

    public bool TryGetRatepay(out Ratepay value) => _ratepayValue.TryGetValue(out value);

    public bool TryGetRiverty(out Riverty value) => _rivertyValue.TryGetValue(out value);

    public bool TryGetSamsungPay(out SamsungPay value) => _samsungPayValue.TryGetValue(out value);

    public bool TryGetSepadirectDebit(out SepadirectDebit value) =>
        _sepadirectDebitValue.TryGetValue(out value);

    public bool TryGetStoredPaymentMethod6(out StoredPaymentMethod6 value) =>
        _storedPaymentMethod6Value.TryGetValue(out value);

    public bool TryGetTwint(out Twint value) => _twintValue.TryGetValue(out value);

    public bool TryGetUpicollect(out Upicollect value) => _upicollectValue.TryGetValue(out value);

    public bool TryGetUpiintent(out Upiintent value) => _upiintentValue.TryGetValue(out value);

    public bool TryGetUpiqr(out Upiqr value) => _upiqrValue.TryGetValue(out value);

    public bool TryGetVipps(out Vipps value) => _vippsValue.TryGetValue(out value);

    public bool TryGetVisaCheckout(out VisaCheckout value) => _visaCheckoutValue.TryGetValue(out value);

    public bool TryGetWeChatPay(out WeChatPay value) => _weChatPayValue.TryGetValue(out value);

    public bool TryGetWeChatPayMiniProgram(out WeChatPayMiniProgram value) =>
        _weChatPayMiniProgramValue.TryGetValue(out value);

    public bool TryGetZip(out Zip value) => _zipValue.TryGetValue(out value);

    public static implicit operator PaymentMethod7(AchdirectDebit value) => AchdirectDebit(value);

    public static implicit operator PaymentMethod7(Affirm value) => Affirm(value);

    public static implicit operator PaymentMethod7(Afterpay value) => Afterpay(value);

    public static implicit operator PaymentMethod7(Alma value) => Alma(value);

    public static implicit operator PaymentMethod7(AmazonPay value) => AmazonPay(value);

    public static implicit operator PaymentMethod7(Ancv value) => Ancv(value);

    public static implicit operator PaymentMethod7(AndroidPay value) => AndroidPay(value);

    public static implicit operator PaymentMethod7(ApplePayDetails value) => ApplePayDetails(value);

    public static implicit operator PaymentMethod7(AuPay value) => AuPay(value);

    public static implicit operator PaymentMethod7(BacsdirectDebit value) => BacsdirectDebit(value);

    public static implicit operator PaymentMethod7(BillDesk value) => BillDesk(value);

    public static implicit operator PaymentMethod7(Blik value) => Blik(value);

    public static implicit operator PaymentMethod7(CardDetails value) => CardDetails(value);

    public static implicit operator PaymentMethod7(StoredPaymentMethod value) => StoredPaymentMethod(value);

    public static implicit operator PaymentMethod7(Cellulant value) => Cellulant(value);

    public static implicit operator PaymentMethod7(Dbarai value) => Dbarai(value);

    public static implicit operator PaymentMethod7(DirectDebitAu value) => DirectDebitAu(value);

    public static implicit operator PaymentMethod7(Doku value) => Doku(value);

    public static implicit operator PaymentMethod7(Dragonpay value) => Dragonpay(value);

    public static implicit operator PaymentMethod7(EBankingFinland value) => EbankingFinland(value);

    public static implicit operator PaymentMethod7(Voucher value) => Voucher(value);

    public static implicit operator PaymentMethod7(EftdirectDebit value) => EftdirectDebit(value);

    public static implicit operator PaymentMethod7(DetailsoftokensthatarenotstoredwithAdyen value) =>
        DetailsoftokensthatarenotstoredwithAdyen(value);

    public static implicit operator PaymentMethod7(Fastlane value) => Fastlane(value);

    public static implicit operator PaymentMethod7(StoredPaymentMethod2 value) => StoredPaymentMethod2(value);

    public static implicit operator PaymentMethod7(GooglePayDetails value) => GooglePayDetails(value);

    public static implicit operator PaymentMethod7(IdealDetails value) => IdealDetails(value);

    public static implicit operator PaymentMethod7(Klarna value) => Klarna(value);

    public static implicit operator PaymentMethod7(KlarnaNetwork value) => KlarnaNetwork(value);

    public static implicit operator PaymentMethod7(Masterpass value) => Masterpass(value);

    public static implicit operator PaymentMethod7(Mbway value) => Mbway(value);

    public static implicit operator PaymentMethod7(MobilePay value) => MobilePay(value);

    public static implicit operator PaymentMethod7(Molpay value) => Molpay(value);

    public static implicit operator PaymentMethod7(OpenInvoice value) => OpenInvoice(value);

    public static implicit operator PaymentMethod7(PayByBankAisdirectDebit value) =>
        PayByBankAisdirectDebit(value);

    public static implicit operator PaymentMethod7(PayByBank value) => PayByBank(value);

    public static implicit operator PaymentMethod7(PayPal value) => PayPal(value);

    public static implicit operator PaymentMethod7(PayPay value) => PayPay(value);

    public static implicit operator PaymentMethod7(PayTo value) => PayTo(value);

    public static implicit operator PaymentMethod7(PayU value) => PayU(value);

    public static implicit operator PaymentMethod7(PayWithGoogleDetails value) => PayWithGoogleDetails(value);

    public static implicit operator PaymentMethod7(PaymentDetails2 value) => PaymentDetails2(value);

    public static implicit operator PaymentMethod7(StoredPaymentMethod4 value) => StoredPaymentMethod4(value);

    public static implicit operator PaymentMethod7(StoredPaymentMethod5 value) => StoredPaymentMethod5(value);

    public static implicit operator PaymentMethod7(Pselatam value) => Pselatam(value);

    public static implicit operator PaymentMethod7(RakutenPay value) => RakutenPay(value);

    public static implicit operator PaymentMethod7(Ratepay value) => Ratepay(value);

    public static implicit operator PaymentMethod7(Riverty value) => Riverty(value);

    public static implicit operator PaymentMethod7(SamsungPay value) => SamsungPay(value);

    public static implicit operator PaymentMethod7(SepadirectDebit value) => SepadirectDebit(value);

    public static implicit operator PaymentMethod7(StoredPaymentMethod6 value) => StoredPaymentMethod6(value);

    public static implicit operator PaymentMethod7(Twint value) => Twint(value);

    public static implicit operator PaymentMethod7(Upicollect value) => Upicollect(value);

    public static implicit operator PaymentMethod7(Upiintent value) => Upiintent(value);

    public static implicit operator PaymentMethod7(Upiqr value) => Upiqr(value);

    public static implicit operator PaymentMethod7(Vipps value) => Vipps(value);

    public static implicit operator PaymentMethod7(VisaCheckout value) => VisaCheckout(value);

    public static implicit operator PaymentMethod7(WeChatPay value) => WeChatPay(value);

    public static implicit operator PaymentMethod7(WeChatPayMiniProgram value) => WeChatPayMiniProgram(value);

    public static implicit operator PaymentMethod7(Zip value) => Zip(value);
}

file sealed class PaymentMethod7Converter : JsonConverter<PaymentMethod7>
{
    public override PaymentMethod7 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<AchdirectDebit>(root, options, out var achdirectDebitValue))
        {
            return PaymentMethod7.AchdirectDebit(achdirectDebitValue);
        }
        if (JsonSerializer.TryDeserialize<Affirm>(root, options, out var affirmValue))
        {
            return PaymentMethod7.Affirm(affirmValue);
        }
        if (JsonSerializer.TryDeserialize<Afterpay>(root, options, out var afterpayValue))
        {
            return PaymentMethod7.Afterpay(afterpayValue);
        }
        if (JsonSerializer.TryDeserialize<Alma>(root, options, out var almaValue))
        {
            return PaymentMethod7.Alma(almaValue);
        }
        if (JsonSerializer.TryDeserialize<AmazonPay>(root, options, out var amazonPayValue))
        {
            return PaymentMethod7.AmazonPay(amazonPayValue);
        }
        if (JsonSerializer.TryDeserialize<Ancv>(root, options, out var ancvValue))
        {
            return PaymentMethod7.Ancv(ancvValue);
        }
        if (JsonSerializer.TryDeserialize<AndroidPay>(root, options, out var androidPayValue))
        {
            return PaymentMethod7.AndroidPay(androidPayValue);
        }
        if (JsonSerializer.TryDeserialize<ApplePayDetails>(root, options, out var applePayDetailsValue))
        {
            return PaymentMethod7.ApplePayDetails(applePayDetailsValue);
        }
        if (JsonSerializer.TryDeserialize<AuPay>(root, options, out var auPayValue))
        {
            return PaymentMethod7.AuPay(auPayValue);
        }
        if (JsonSerializer.TryDeserialize<BacsdirectDebit>(root, options, out var bacsdirectDebitValue))
        {
            return PaymentMethod7.BacsdirectDebit(bacsdirectDebitValue);
        }
        if (JsonSerializer.TryDeserialize<BillDesk>(root, options, out var billDeskValue))
        {
            return PaymentMethod7.BillDesk(billDeskValue);
        }
        if (JsonSerializer.TryDeserialize<Blik>(root, options, out var blikValue))
        {
            return PaymentMethod7.Blik(blikValue);
        }
        if (JsonSerializer.TryDeserialize<CardDetails>(root, options, out var cardDetailsValue))
        {
            return PaymentMethod7.CardDetails(cardDetailsValue);
        }
        if (JsonSerializer.TryDeserialize<StoredPaymentMethod>(root, options, out var storedPaymentMethodValue))
        {
            return PaymentMethod7.StoredPaymentMethod(storedPaymentMethodValue);
        }
        if (JsonSerializer.TryDeserialize<Cellulant>(root, options, out var cellulantValue))
        {
            return PaymentMethod7.Cellulant(cellulantValue);
        }
        if (JsonSerializer.TryDeserialize<Dbarai>(root, options, out var dbaraiValue))
        {
            return PaymentMethod7.Dbarai(dbaraiValue);
        }
        if (JsonSerializer.TryDeserialize<DirectDebitAu>(root, options, out var directDebitAuValue))
        {
            return PaymentMethod7.DirectDebitAu(directDebitAuValue);
        }
        if (JsonSerializer.TryDeserialize<Doku>(root, options, out var dokuValue))
        {
            return PaymentMethod7.Doku(dokuValue);
        }
        if (JsonSerializer.TryDeserialize<Dragonpay>(root, options, out var dragonpayValue))
        {
            return PaymentMethod7.Dragonpay(dragonpayValue);
        }
        if (JsonSerializer.TryDeserialize<EBankingFinland>(root, options, out var ebankingFinlandValue))
        {
            return PaymentMethod7.EbankingFinland(ebankingFinlandValue);
        }
        if (JsonSerializer.TryDeserialize<Voucher>(root, options, out var voucherValue))
        {
            return PaymentMethod7.Voucher(voucherValue);
        }
        if (JsonSerializer.TryDeserialize<EftdirectDebit>(root, options, out var eftdirectDebitValue))
        {
            return PaymentMethod7.EftdirectDebit(eftdirectDebitValue);
        }
        if (JsonSerializer.TryDeserialize<DetailsoftokensthatarenotstoredwithAdyen>(root,
            options,
            out var detailsoftokensthatarenotstoredwithAdyenValue))
        {
            return PaymentMethod7.DetailsoftokensthatarenotstoredwithAdyen(detailsoftokensthatarenotstoredwithAdyenValue);
        }
        if (JsonSerializer.TryDeserialize<Fastlane>(root, options, out var fastlaneValue))
        {
            return PaymentMethod7.Fastlane(fastlaneValue);
        }
        if (JsonSerializer.TryDeserialize<StoredPaymentMethod2>(root, options, out var storedPaymentMethod2Value))
        {
            return PaymentMethod7.StoredPaymentMethod2(storedPaymentMethod2Value);
        }
        if (JsonSerializer.TryDeserialize<GooglePayDetails>(root, options, out var googlePayDetailsValue))
        {
            return PaymentMethod7.GooglePayDetails(googlePayDetailsValue);
        }
        if (JsonSerializer.TryDeserialize<IdealDetails>(root, options, out var idealDetailsValue))
        {
            return PaymentMethod7.IdealDetails(idealDetailsValue);
        }
        if (JsonSerializer.TryDeserialize<Klarna>(root, options, out var klarnaValue))
        {
            return PaymentMethod7.Klarna(klarnaValue);
        }
        if (JsonSerializer.TryDeserialize<KlarnaNetwork>(root, options, out var klarnaNetworkValue))
        {
            return PaymentMethod7.KlarnaNetwork(klarnaNetworkValue);
        }
        if (JsonSerializer.TryDeserialize<Masterpass>(root, options, out var masterpassValue))
        {
            return PaymentMethod7.Masterpass(masterpassValue);
        }
        if (JsonSerializer.TryDeserialize<Mbway>(root, options, out var mbwayValue))
        {
            return PaymentMethod7.Mbway(mbwayValue);
        }
        if (JsonSerializer.TryDeserialize<MobilePay>(root, options, out var mobilePayValue))
        {
            return PaymentMethod7.MobilePay(mobilePayValue);
        }
        if (JsonSerializer.TryDeserialize<Molpay>(root, options, out var molpayValue))
        {
            return PaymentMethod7.Molpay(molpayValue);
        }
        if (JsonSerializer.TryDeserialize<OpenInvoice>(root, options, out var openInvoiceValue))
        {
            return PaymentMethod7.OpenInvoice(openInvoiceValue);
        }
        if (JsonSerializer.TryDeserialize<PayByBankAisdirectDebit>(root,
            options,
            out var payByBankAisdirectDebitValue))
        {
            return PaymentMethod7.PayByBankAisdirectDebit(payByBankAisdirectDebitValue);
        }
        if (JsonSerializer.TryDeserialize<PayByBank>(root, options, out var payByBankValue))
        {
            return PaymentMethod7.PayByBank(payByBankValue);
        }
        if (JsonSerializer.TryDeserialize<PayPal>(root, options, out var payPalValue))
        {
            return PaymentMethod7.PayPal(payPalValue);
        }
        if (JsonSerializer.TryDeserialize<PayPay>(root, options, out var payPayValue))
        {
            return PaymentMethod7.PayPay(payPayValue);
        }
        if (JsonSerializer.TryDeserialize<PayTo>(root, options, out var payToValue))
        {
            return PaymentMethod7.PayTo(payToValue);
        }
        if (JsonSerializer.TryDeserialize<PayU>(root, options, out var payUValue))
        {
            return PaymentMethod7.PayU(payUValue);
        }
        if (JsonSerializer.TryDeserialize<PayWithGoogleDetails>(root, options, out var payWithGoogleDetailsValue))
        {
            return PaymentMethod7.PayWithGoogleDetails(payWithGoogleDetailsValue);
        }
        if (JsonSerializer.TryDeserialize<PaymentDetails2>(root, options, out var paymentDetails2Value))
        {
            return PaymentMethod7.PaymentDetails2(paymentDetails2Value);
        }
        if (JsonSerializer.TryDeserialize<StoredPaymentMethod4>(root, options, out var storedPaymentMethod4Value))
        {
            return PaymentMethod7.StoredPaymentMethod4(storedPaymentMethod4Value);
        }
        if (JsonSerializer.TryDeserialize<StoredPaymentMethod5>(root, options, out var storedPaymentMethod5Value))
        {
            return PaymentMethod7.StoredPaymentMethod5(storedPaymentMethod5Value);
        }
        if (JsonSerializer.TryDeserialize<Pselatam>(root, options, out var pselatamValue))
        {
            return PaymentMethod7.Pselatam(pselatamValue);
        }
        if (JsonSerializer.TryDeserialize<RakutenPay>(root, options, out var rakutenPayValue))
        {
            return PaymentMethod7.RakutenPay(rakutenPayValue);
        }
        if (JsonSerializer.TryDeserialize<Ratepay>(root, options, out var ratepayValue))
        {
            return PaymentMethod7.Ratepay(ratepayValue);
        }
        if (JsonSerializer.TryDeserialize<Riverty>(root, options, out var rivertyValue))
        {
            return PaymentMethod7.Riverty(rivertyValue);
        }
        if (JsonSerializer.TryDeserialize<SamsungPay>(root, options, out var samsungPayValue))
        {
            return PaymentMethod7.SamsungPay(samsungPayValue);
        }
        if (JsonSerializer.TryDeserialize<SepadirectDebit>(root, options, out var sepadirectDebitValue))
        {
            return PaymentMethod7.SepadirectDebit(sepadirectDebitValue);
        }
        if (JsonSerializer.TryDeserialize<StoredPaymentMethod6>(root, options, out var storedPaymentMethod6Value))
        {
            return PaymentMethod7.StoredPaymentMethod6(storedPaymentMethod6Value);
        }
        if (JsonSerializer.TryDeserialize<Twint>(root, options, out var twintValue))
        {
            return PaymentMethod7.Twint(twintValue);
        }
        if (JsonSerializer.TryDeserialize<Upicollect>(root, options, out var upicollectValue))
        {
            return PaymentMethod7.Upicollect(upicollectValue);
        }
        if (JsonSerializer.TryDeserialize<Upiintent>(root, options, out var upiintentValue))
        {
            return PaymentMethod7.Upiintent(upiintentValue);
        }
        if (JsonSerializer.TryDeserialize<Upiqr>(root, options, out var upiqrValue))
        {
            return PaymentMethod7.Upiqr(upiqrValue);
        }
        if (JsonSerializer.TryDeserialize<Vipps>(root, options, out var vippsValue))
        {
            return PaymentMethod7.Vipps(vippsValue);
        }
        if (JsonSerializer.TryDeserialize<VisaCheckout>(root, options, out var visaCheckoutValue))
        {
            return PaymentMethod7.VisaCheckout(visaCheckoutValue);
        }
        if (JsonSerializer.TryDeserialize<WeChatPay>(root, options, out var weChatPayValue))
        {
            return PaymentMethod7.WeChatPay(weChatPayValue);
        }
        if (JsonSerializer.TryDeserialize<WeChatPayMiniProgram>(root, options, out var weChatPayMiniProgramValue))
        {
            return PaymentMethod7.WeChatPayMiniProgram(weChatPayMiniProgramValue);
        }
        if (JsonSerializer.TryDeserialize<Zip>(root, options, out var zipValue))
        {
            return PaymentMethod7.Zip(zipValue);
        }
        throw new JsonException($"JSON does not match AchdirectDebit or Affirm or Afterpay or Alma or AmazonPay or Ancv or AndroidPay or ApplePayDetails or AuPay or BacsdirectDebit or BillDesk or Blik or CardDetails or StoredPaymentMethod or Cellulant or Dbarai or DirectDebitAu or Doku or Dragonpay or EBankingFinland or Voucher or EftdirectDebit or DetailsoftokensthatarenotstoredwithAdyen or Fastlane or StoredPaymentMethod2 or GooglePayDetails or IdealDetails or Klarna or KlarnaNetwork or Masterpass or Mbway or MobilePay or Molpay or OpenInvoice or PayByBankAisdirectDebit or PayByBank or PayPal or PayPay or PayTo or PayU or PayWithGoogleDetails or PaymentDetails2 or StoredPaymentMethod4 or StoredPaymentMethod5 or Pselatam or RakutenPay or Ratepay or Riverty or SamsungPay or SepadirectDebit or StoredPaymentMethod6 or Twint or Upicollect or Upiintent or Upiqr or Vipps or VisaCheckout or WeChatPay or WeChatPayMiniProgram or Zip schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, PaymentMethod7 value, JsonSerializerOptions options)
    {
        if (value.TryGetAchdirectDebit(out var achdirectDebitValue))
        {
            JsonSerializer.Serialize(writer, achdirectDebitValue, options);
        }
        else if (value.TryGetAffirm(out var affirmValue))
        {
            JsonSerializer.Serialize(writer, affirmValue, options);
        }
        else if (value.TryGetAfterpay(out var afterpayValue))
        {
            JsonSerializer.Serialize(writer, afterpayValue, options);
        }
        else if (value.TryGetAlma(out var almaValue))
        {
            JsonSerializer.Serialize(writer, almaValue, options);
        }
        else if (value.TryGetAmazonPay(out var amazonPayValue))
        {
            JsonSerializer.Serialize(writer, amazonPayValue, options);
        }
        else if (value.TryGetAncv(out var ancvValue))
        {
            JsonSerializer.Serialize(writer, ancvValue, options);
        }
        else if (value.TryGetAndroidPay(out var androidPayValue))
        {
            JsonSerializer.Serialize(writer, androidPayValue, options);
        }
        else if (value.TryGetApplePayDetails(out var applePayDetailsValue))
        {
            JsonSerializer.Serialize(writer, applePayDetailsValue, options);
        }
        else if (value.TryGetAuPay(out var auPayValue))
        {
            JsonSerializer.Serialize(writer, auPayValue, options);
        }
        else if (value.TryGetBacsdirectDebit(out var bacsdirectDebitValue))
        {
            JsonSerializer.Serialize(writer, bacsdirectDebitValue, options);
        }
        else if (value.TryGetBillDesk(out var billDeskValue))
        {
            JsonSerializer.Serialize(writer, billDeskValue, options);
        }
        else if (value.TryGetBlik(out var blikValue))
        {
            JsonSerializer.Serialize(writer, blikValue, options);
        }
        else if (value.TryGetCardDetails(out var cardDetailsValue))
        {
            JsonSerializer.Serialize(writer, cardDetailsValue, options);
        }
        else if (value.TryGetStoredPaymentMethod(out var storedPaymentMethodValue))
        {
            JsonSerializer.Serialize(writer, storedPaymentMethodValue, options);
        }
        else if (value.TryGetCellulant(out var cellulantValue))
        {
            JsonSerializer.Serialize(writer, cellulantValue, options);
        }
        else if (value.TryGetDbarai(out var dbaraiValue))
        {
            JsonSerializer.Serialize(writer, dbaraiValue, options);
        }
        else if (value.TryGetDirectDebitAu(out var directDebitAuValue))
        {
            JsonSerializer.Serialize(writer, directDebitAuValue, options);
        }
        else if (value.TryGetDoku(out var dokuValue))
        {
            JsonSerializer.Serialize(writer, dokuValue, options);
        }
        else if (value.TryGetDragonpay(out var dragonpayValue))
        {
            JsonSerializer.Serialize(writer, dragonpayValue, options);
        }
        else if (value.TryGetEbankingFinland(out var ebankingFinlandValue))
        {
            JsonSerializer.Serialize(writer, ebankingFinlandValue, options);
        }
        else if (value.TryGetVoucher(out var voucherValue))
        {
            JsonSerializer.Serialize(writer, voucherValue, options);
        }
        else if (value.TryGetEftdirectDebit(out var eftdirectDebitValue))
        {
            JsonSerializer.Serialize(writer, eftdirectDebitValue, options);
        }
        else if (value.TryGetDetailsoftokensthatarenotstoredwithAdyen(out var detailsoftokensthatarenotstoredwithAdyenValue))
        {
            JsonSerializer.Serialize(writer, detailsoftokensthatarenotstoredwithAdyenValue, options);
        }
        else if (value.TryGetFastlane(out var fastlaneValue))
        {
            JsonSerializer.Serialize(writer, fastlaneValue, options);
        }
        else if (value.TryGetStoredPaymentMethod2(out var storedPaymentMethod2Value))
        {
            JsonSerializer.Serialize(writer, storedPaymentMethod2Value, options);
        }
        else if (value.TryGetGooglePayDetails(out var googlePayDetailsValue))
        {
            JsonSerializer.Serialize(writer, googlePayDetailsValue, options);
        }
        else if (value.TryGetIdealDetails(out var idealDetailsValue))
        {
            JsonSerializer.Serialize(writer, idealDetailsValue, options);
        }
        else if (value.TryGetKlarna(out var klarnaValue))
        {
            JsonSerializer.Serialize(writer, klarnaValue, options);
        }
        else if (value.TryGetKlarnaNetwork(out var klarnaNetworkValue))
        {
            JsonSerializer.Serialize(writer, klarnaNetworkValue, options);
        }
        else if (value.TryGetMasterpass(out var masterpassValue))
        {
            JsonSerializer.Serialize(writer, masterpassValue, options);
        }
        else if (value.TryGetMbway(out var mbwayValue))
        {
            JsonSerializer.Serialize(writer, mbwayValue, options);
        }
        else if (value.TryGetMobilePay(out var mobilePayValue))
        {
            JsonSerializer.Serialize(writer, mobilePayValue, options);
        }
        else if (value.TryGetMolpay(out var molpayValue))
        {
            JsonSerializer.Serialize(writer, molpayValue, options);
        }
        else if (value.TryGetOpenInvoice(out var openInvoiceValue))
        {
            JsonSerializer.Serialize(writer, openInvoiceValue, options);
        }
        else if (value.TryGetPayByBankAisdirectDebit(out var payByBankAisdirectDebitValue))
        {
            JsonSerializer.Serialize(writer, payByBankAisdirectDebitValue, options);
        }
        else if (value.TryGetPayByBank(out var payByBankValue))
        {
            JsonSerializer.Serialize(writer, payByBankValue, options);
        }
        else if (value.TryGetPayPal(out var payPalValue))
        {
            JsonSerializer.Serialize(writer, payPalValue, options);
        }
        else if (value.TryGetPayPay(out var payPayValue))
        {
            JsonSerializer.Serialize(writer, payPayValue, options);
        }
        else if (value.TryGetPayTo(out var payToValue))
        {
            JsonSerializer.Serialize(writer, payToValue, options);
        }
        else if (value.TryGetPayU(out var payUValue))
        {
            JsonSerializer.Serialize(writer, payUValue, options);
        }
        else if (value.TryGetPayWithGoogleDetails(out var payWithGoogleDetailsValue))
        {
            JsonSerializer.Serialize(writer, payWithGoogleDetailsValue, options);
        }
        else if (value.TryGetPaymentDetails2(out var paymentDetails2Value))
        {
            JsonSerializer.Serialize(writer, paymentDetails2Value, options);
        }
        else if (value.TryGetStoredPaymentMethod4(out var storedPaymentMethod4Value))
        {
            JsonSerializer.Serialize(writer, storedPaymentMethod4Value, options);
        }
        else if (value.TryGetStoredPaymentMethod5(out var storedPaymentMethod5Value))
        {
            JsonSerializer.Serialize(writer, storedPaymentMethod5Value, options);
        }
        else if (value.TryGetPselatam(out var pselatamValue))
        {
            JsonSerializer.Serialize(writer, pselatamValue, options);
        }
        else if (value.TryGetRakutenPay(out var rakutenPayValue))
        {
            JsonSerializer.Serialize(writer, rakutenPayValue, options);
        }
        else if (value.TryGetRatepay(out var ratepayValue))
        {
            JsonSerializer.Serialize(writer, ratepayValue, options);
        }
        else if (value.TryGetRiverty(out var rivertyValue))
        {
            JsonSerializer.Serialize(writer, rivertyValue, options);
        }
        else if (value.TryGetSamsungPay(out var samsungPayValue))
        {
            JsonSerializer.Serialize(writer, samsungPayValue, options);
        }
        else if (value.TryGetSepadirectDebit(out var sepadirectDebitValue))
        {
            JsonSerializer.Serialize(writer, sepadirectDebitValue, options);
        }
        else if (value.TryGetStoredPaymentMethod6(out var storedPaymentMethod6Value))
        {
            JsonSerializer.Serialize(writer, storedPaymentMethod6Value, options);
        }
        else if (value.TryGetTwint(out var twintValue))
        {
            JsonSerializer.Serialize(writer, twintValue, options);
        }
        else if (value.TryGetUpicollect(out var upicollectValue))
        {
            JsonSerializer.Serialize(writer, upicollectValue, options);
        }
        else if (value.TryGetUpiintent(out var upiintentValue))
        {
            JsonSerializer.Serialize(writer, upiintentValue, options);
        }
        else if (value.TryGetUpiqr(out var upiqrValue))
        {
            JsonSerializer.Serialize(writer, upiqrValue, options);
        }
        else if (value.TryGetVipps(out var vippsValue))
        {
            JsonSerializer.Serialize(writer, vippsValue, options);
        }
        else if (value.TryGetVisaCheckout(out var visaCheckoutValue))
        {
            JsonSerializer.Serialize(writer, visaCheckoutValue, options);
        }
        else if (value.TryGetWeChatPay(out var weChatPayValue))
        {
            JsonSerializer.Serialize(writer, weChatPayValue, options);
        }
        else if (value.TryGetWeChatPayMiniProgram(out var weChatPayMiniProgramValue))
        {
            JsonSerializer.Serialize(writer, weChatPayMiniProgramValue, options);
        }
        else if (value.TryGetZip(out var zipValue))
        {
            JsonSerializer.Serialize(writer, zipValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(PaymentMethod7)} contains no valid value to serialize.");
        }
    }
}
