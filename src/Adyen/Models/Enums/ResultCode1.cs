using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The result of the payment. For more information, see <see href="https://docs.adyen.com/online-payments/payment-result-codes">Result codes</see>.
/// <para>
/// Possible values:
/// </para>
/// <para>
/// * <b>AuthenticationFinished</b> – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions.
/// * <b>AuthenticationNotRequired</b> – The transaction does not require 3D Secure authentication. Returned for <see href="https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only">standalone authentication-only integrations</see>.
/// * <b>Authorised</b> – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state.
/// * <b>Cancelled</b> – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state.
/// * <b>ChallengeShopper</b> – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions.
/// * <b>Error</b> – There was an error when the payment was being processed. The reason is given in the <c>refusalReason</c> field. This is a final state.
/// * <b>IdentifyShopper</b> – The issuer requires the shopper's device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions.
/// * <b>PartiallyAuthorised</b> – The payment has been authorised for a partial amount.
/// This happens for card payments when the merchant supports Partial Authorisations and the cardholder has insufficient funds.
/// * <b>Pending</b> – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment.
/// * <b>PresentToShopper</b> – Indicates that the response contains additional information that you need to present to a shopper, so that they can use it to complete a payment.
/// * <b>Received</b> – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments.
/// * <b>RedirectShopper</b> – Indicates the shopper should be redirected to an external web page or app to complete the authorisation.
/// * <b>Refused</b> – Indicates the payment was refused. The reason is given in the <c>refusalReason</c> field. This is a final state.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ResultCode1>))]
public sealed record ResultCode1 : OpenStringEnum<ResultCode1>
{
    private ResultCode1(string value) : base(value)
    {
    }

    public static readonly ResultCode1 AuthenticationFinished = new("AuthenticationFinished");

    public static readonly ResultCode1 AuthenticationNotRequired = new("AuthenticationNotRequired");

    public static readonly ResultCode1 Authorised = new("Authorised");

    public static readonly ResultCode1 Cancelled = new("Cancelled");

    public static readonly ResultCode1 ChallengeShopper = new("ChallengeShopper");

    public static readonly ResultCode1 Error = new("Error");

    public static readonly ResultCode1 IdentifyShopper = new("IdentifyShopper");

    public static readonly ResultCode1 PartiallyAuthorised = new("PartiallyAuthorised");

    public static readonly ResultCode1 Pending = new("Pending");

    public static readonly ResultCode1 PresentToShopper = new("PresentToShopper");

    public static readonly ResultCode1 Received = new("Received");

    public static readonly ResultCode1 RedirectShopper = new("RedirectShopper");

    public static readonly ResultCode1 Refused = new("Refused");

    public static readonly ResultCode1 Success = new("Success");

    public TResult Match<TResult>(Func<TResult> onAuthenticationFinished,
        Func<TResult> onAuthenticationNotRequired,
        Func<TResult> onAuthorised,
        Func<TResult> onCancelled,
        Func<TResult> onChallengeShopper,
        Func<TResult> onError,
        Func<TResult> onIdentifyShopper,
        Func<TResult> onPartiallyAuthorised,
        Func<TResult> onPending,
        Func<TResult> onPresentToShopper,
        Func<TResult> onReceived,
        Func<TResult> onRedirectShopper,
        Func<TResult> onRefused,
        Func<TResult> onSuccess,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AuthenticationFinished => onAuthenticationFinished(),
            _ when this == AuthenticationNotRequired => onAuthenticationNotRequired(),
            _ when this == Authorised => onAuthorised(),
            _ when this == Cancelled => onCancelled(),
            _ when this == ChallengeShopper => onChallengeShopper(),
            _ when this == Error => onError(),
            _ when this == IdentifyShopper => onIdentifyShopper(),
            _ when this == PartiallyAuthorised => onPartiallyAuthorised(),
            _ when this == Pending => onPending(),
            _ when this == PresentToShopper => onPresentToShopper(),
            _ when this == Received => onReceived(),
            _ when this == RedirectShopper => onRedirectShopper(),
            _ when this == Refused => onRefused(),
            _ when this == Success => onSuccess(),
            _ => otherwise(Value)
        };

    public void Match(Action onAuthenticationFinished,
        Action onAuthenticationNotRequired,
        Action onAuthorised,
        Action onCancelled,
        Action onChallengeShopper,
        Action onError,
        Action onIdentifyShopper,
        Action onPartiallyAuthorised,
        Action onPending,
        Action onPresentToShopper,
        Action onReceived,
        Action onRedirectShopper,
        Action onRefused,
        Action onSuccess,
        Action<string> otherwise)
    {
        if (this == AuthenticationFinished) onAuthenticationFinished();
        else if (this == AuthenticationNotRequired) onAuthenticationNotRequired();
        else if (this == Authorised) onAuthorised();
        else if (this == Cancelled) onCancelled();
        else if (this == ChallengeShopper) onChallengeShopper();
        else if (this == Error) onError();
        else if (this == IdentifyShopper) onIdentifyShopper();
        else if (this == PartiallyAuthorised) onPartiallyAuthorised();
        else if (this == Pending) onPending();
        else if (this == PresentToShopper) onPresentToShopper();
        else if (this == Received) onReceived();
        else if (this == RedirectShopper) onRedirectShopper();
        else if (this == Refused) onRefused();
        else if (this == Success) onSuccess();
        else otherwise(Value);
    }
}
