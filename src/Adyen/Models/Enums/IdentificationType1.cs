using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>PAN</b>
/// * <b>ISOTrack2</b>
/// * <b>BarCode</b>
/// * <b>AccountNumber</b>
/// * <b>PhoneNumber</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IdentificationType1>))]
public sealed record IdentificationType1 : OpenStringEnum<IdentificationType1>
{
    private IdentificationType1(string value) : base(value)
    {
    }

    public static readonly IdentificationType1 Pan = new("PAN");

    public static readonly IdentificationType1 IsoTrack2 = new("ISOTrack2");

    public static readonly IdentificationType1 BarCode = new("BarCode");

    public static readonly IdentificationType1 AccountNumber = new("AccountNumber");

    public static readonly IdentificationType1 PhoneNumber = new("PhoneNumber");

    public TResult Match<TResult>(Func<TResult> onPan,
        Func<TResult> onIsoTrack2,
        Func<TResult> onBarCode,
        Func<TResult> onAccountNumber,
        Func<TResult> onPhoneNumber,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pan => onPan(),
            _ when this == IsoTrack2 => onIsoTrack2(),
            _ when this == BarCode => onBarCode(),
            _ when this == AccountNumber => onAccountNumber(),
            _ when this == PhoneNumber => onPhoneNumber(),
            _ => otherwise(Value)
        };

    public void Match(Action onPan,
        Action onIsoTrack2,
        Action onBarCode,
        Action onAccountNumber,
        Action onPhoneNumber,
        Action<string> otherwise)
    {
        if (this == Pan) onPan();
        else if (this == IsoTrack2) onIsoTrack2();
        else if (this == BarCode) onBarCode();
        else if (this == AccountNumber) onAccountNumber();
        else if (this == PhoneNumber) onPhoneNumber();
        else otherwise(Value);
    }
}
