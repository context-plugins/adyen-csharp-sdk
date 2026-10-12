using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The location where the third-party individual's bank account is registered.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountVerificationCountry1>))]
public sealed record AccountVerificationCountry1 : OpenStringEnum<AccountVerificationCountry1>
{
    private AccountVerificationCountry1(string value) : base(value)
    {
    }

    public static readonly AccountVerificationCountry1 Se = new("SE");

    public static readonly AccountVerificationCountry1 Fi = new("FI");

    public static readonly AccountVerificationCountry1 No = new("NO");

    public static readonly AccountVerificationCountry1 Dk = new("DK");

    public static readonly AccountVerificationCountry1 Nl = new("NL");

    public static readonly AccountVerificationCountry1 It = new("IT");

    public static readonly AccountVerificationCountry1 De = new("DE");

    public static readonly AccountVerificationCountry1 At = new("AT");

    public static readonly AccountVerificationCountry1 Es = new("ES");

    public static readonly AccountVerificationCountry1 Pt = new("PT");

    public static readonly AccountVerificationCountry1 Fr = new("FR");

    public static readonly AccountVerificationCountry1 Gb = new("GB");

    public static readonly AccountVerificationCountry1 Be = new("BE");

    public static readonly AccountVerificationCountry1 Lv = new("LV");

    public static readonly AccountVerificationCountry1 Lt = new("LT");

    public static readonly AccountVerificationCountry1 Pl = new("PL");

    public static readonly AccountVerificationCountry1 Ee = new("EE");

    public static readonly AccountVerificationCountry1 Ie = new("IE");

    public static readonly AccountVerificationCountry1 Us = new("US");

    public static readonly AccountVerificationCountry1 Ca = new("CA");

    public static readonly AccountVerificationCountry1 Au = new("AU");

    public TResult Match<TResult>(Func<TResult> onSe,
        Func<TResult> onFi,
        Func<TResult> onNo,
        Func<TResult> onDk,
        Func<TResult> onNl,
        Func<TResult> onIt,
        Func<TResult> onDe,
        Func<TResult> onAt,
        Func<TResult> onEs,
        Func<TResult> onPt,
        Func<TResult> onFr,
        Func<TResult> onGb,
        Func<TResult> onBe,
        Func<TResult> onLv,
        Func<TResult> onLt,
        Func<TResult> onPl,
        Func<TResult> onEe,
        Func<TResult> onIe,
        Func<TResult> onUs,
        Func<TResult> onCa,
        Func<TResult> onAu,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Se => onSe(),
            _ when this == Fi => onFi(),
            _ when this == No => onNo(),
            _ when this == Dk => onDk(),
            _ when this == Nl => onNl(),
            _ when this == It => onIt(),
            _ when this == De => onDe(),
            _ when this == At => onAt(),
            _ when this == Es => onEs(),
            _ when this == Pt => onPt(),
            _ when this == Fr => onFr(),
            _ when this == Gb => onGb(),
            _ when this == Be => onBe(),
            _ when this == Lv => onLv(),
            _ when this == Lt => onLt(),
            _ when this == Pl => onPl(),
            _ when this == Ee => onEe(),
            _ when this == Ie => onIe(),
            _ when this == Us => onUs(),
            _ when this == Ca => onCa(),
            _ when this == Au => onAu(),
            _ => otherwise(Value)
        };

    public void Match(Action onSe,
        Action onFi,
        Action onNo,
        Action onDk,
        Action onNl,
        Action onIt,
        Action onDe,
        Action onAt,
        Action onEs,
        Action onPt,
        Action onFr,
        Action onGb,
        Action onBe,
        Action onLv,
        Action onLt,
        Action onPl,
        Action onEe,
        Action onIe,
        Action onUs,
        Action onCa,
        Action onAu,
        Action<string> otherwise)
    {
        if (this == Se) onSe();
        else if (this == Fi) onFi();
        else if (this == No) onNo();
        else if (this == Dk) onDk();
        else if (this == Nl) onNl();
        else if (this == It) onIt();
        else if (this == De) onDe();
        else if (this == At) onAt();
        else if (this == Es) onEs();
        else if (this == Pt) onPt();
        else if (this == Fr) onFr();
        else if (this == Gb) onGb();
        else if (this == Be) onBe();
        else if (this == Lv) onLv();
        else if (this == Lt) onLt();
        else if (this == Pl) onPl();
        else if (this == Ee) onEe();
        else if (this == Ie) onIe();
        else if (this == Us) onUs();
        else if (this == Ca) onCa();
        else if (this == Au) onAu();
        else otherwise(Value);
    }
}
