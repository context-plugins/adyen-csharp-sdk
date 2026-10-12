using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AuthenticationMethod1>))]
public sealed record AuthenticationMethod1 : OpenStringEnum<AuthenticationMethod1>
{
    private AuthenticationMethod1(string value) : base(value)
    {
    }

    public static readonly AuthenticationMethod1 Bypass = new("Bypass");

    public static readonly AuthenticationMethod1 ManualVerification = new("ManualVerification");

    public static readonly AuthenticationMethod1 MerchantAuthentication = new("MerchantAuthentication");

    public static readonly AuthenticationMethod1 OfflinePin = new("OfflinePIN");

    public static readonly AuthenticationMethod1 OnlinePin = new("OnlinePIN");

    public static readonly AuthenticationMethod1 PaperSignature = new("PaperSignature");

    public static readonly AuthenticationMethod1 SecuredChannel = new("SecuredChannel");

    public static readonly AuthenticationMethod1 SecureCertificate = new("SecureCertificate");

    public static readonly AuthenticationMethod1 SecureNoCertificate = new("SecureNoCertificate");

    public static readonly AuthenticationMethod1 SignatureCapture = new("SignatureCapture");

    public static readonly AuthenticationMethod1 UnknownMethod = new("UnknownMethod");

    public TResult Match<TResult>(Func<TResult> onBypass,
        Func<TResult> onManualVerification,
        Func<TResult> onMerchantAuthentication,
        Func<TResult> onOfflinePin,
        Func<TResult> onOnlinePin,
        Func<TResult> onPaperSignature,
        Func<TResult> onSecuredChannel,
        Func<TResult> onSecureCertificate,
        Func<TResult> onSecureNoCertificate,
        Func<TResult> onSignatureCapture,
        Func<TResult> onUnknownMethod,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Bypass => onBypass(),
            _ when this == ManualVerification => onManualVerification(),
            _ when this == MerchantAuthentication => onMerchantAuthentication(),
            _ when this == OfflinePin => onOfflinePin(),
            _ when this == OnlinePin => onOnlinePin(),
            _ when this == PaperSignature => onPaperSignature(),
            _ when this == SecuredChannel => onSecuredChannel(),
            _ when this == SecureCertificate => onSecureCertificate(),
            _ when this == SecureNoCertificate => onSecureNoCertificate(),
            _ when this == SignatureCapture => onSignatureCapture(),
            _ when this == UnknownMethod => onUnknownMethod(),
            _ => otherwise(Value)
        };

    public void Match(Action onBypass,
        Action onManualVerification,
        Action onMerchantAuthentication,
        Action onOfflinePin,
        Action onOnlinePin,
        Action onPaperSignature,
        Action onSecuredChannel,
        Action onSecureCertificate,
        Action onSecureNoCertificate,
        Action onSignatureCapture,
        Action onUnknownMethod,
        Action<string> otherwise)
    {
        if (this == Bypass) onBypass();
        else if (this == ManualVerification) onManualVerification();
        else if (this == MerchantAuthentication) onMerchantAuthentication();
        else if (this == OfflinePin) onOfflinePin();
        else if (this == OnlinePin) onOnlinePin();
        else if (this == PaperSignature) onPaperSignature();
        else if (this == SecuredChannel) onSecuredChannel();
        else if (this == SecureCertificate) onSecureCertificate();
        else if (this == SecureNoCertificate) onSecureNoCertificate();
        else if (this == SignatureCapture) onSignatureCapture();
        else if (this == UnknownMethod) onUnknownMethod();
        else otherwise(Value);
    }
}
