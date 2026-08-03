using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AuthenticationMethod1>))]
public sealed record AuthenticationMethod1 : StringEnum<AuthenticationMethod1>
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

    public static AuthenticationMethod1 FromValue(string value) => FromValueCore(value);
}
