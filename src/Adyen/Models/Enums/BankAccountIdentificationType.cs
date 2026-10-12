using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<BankAccountIdentificationType>))]
public sealed record BankAccountIdentificationType : OpenStringEnum<BankAccountIdentificationType>
{
    private BankAccountIdentificationType(string value) : base(value)
    {
    }

    public static readonly BankAccountIdentificationType AuLocal = new("auLocal");

    public static readonly BankAccountIdentificationType BrLocal = new("brLocal");

    public static readonly BankAccountIdentificationType CaLocal = new("caLocal");

    public static readonly BankAccountIdentificationType CzLocal = new("czLocal");

    public static readonly BankAccountIdentificationType DkLocal = new("dkLocal");

    public static readonly BankAccountIdentificationType HkLocal = new("hkLocal");

    public static readonly BankAccountIdentificationType HuLocal = new("huLocal");

    public static readonly BankAccountIdentificationType Iban = new("iban");

    public static readonly BankAccountIdentificationType InLocal = new("inLocal");

    public static readonly BankAccountIdentificationType JpLocal = new("jpLocal");

    public static readonly BankAccountIdentificationType Legacy = new("legacy");

    public static readonly BankAccountIdentificationType MxLocal = new("mxLocal");

    public static readonly BankAccountIdentificationType MyLocal = new("myLocal");

    public static readonly BankAccountIdentificationType NoLocal = new("noLocal");

    public static readonly BankAccountIdentificationType NumberAndBic = new("numberAndBic");

    public static readonly BankAccountIdentificationType NzLocal = new("nzLocal");

    public static readonly BankAccountIdentificationType PlLocal = new("plLocal");

    public static readonly BankAccountIdentificationType SeLocal = new("seLocal");

    public static readonly BankAccountIdentificationType SgLocal = new("sgLocal");

    public static readonly BankAccountIdentificationType UkLocal = new("ukLocal");

    public static readonly BankAccountIdentificationType UsLocal = new("usLocal");

    public TResult Match<TResult>(Func<TResult> onAuLocal,
        Func<TResult> onBrLocal,
        Func<TResult> onCaLocal,
        Func<TResult> onCzLocal,
        Func<TResult> onDkLocal,
        Func<TResult> onHkLocal,
        Func<TResult> onHuLocal,
        Func<TResult> onIban,
        Func<TResult> onInLocal,
        Func<TResult> onJpLocal,
        Func<TResult> onLegacy,
        Func<TResult> onMxLocal,
        Func<TResult> onMyLocal,
        Func<TResult> onNoLocal,
        Func<TResult> onNumberAndBic,
        Func<TResult> onNzLocal,
        Func<TResult> onPlLocal,
        Func<TResult> onSeLocal,
        Func<TResult> onSgLocal,
        Func<TResult> onUkLocal,
        Func<TResult> onUsLocal,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AuLocal => onAuLocal(),
            _ when this == BrLocal => onBrLocal(),
            _ when this == CaLocal => onCaLocal(),
            _ when this == CzLocal => onCzLocal(),
            _ when this == DkLocal => onDkLocal(),
            _ when this == HkLocal => onHkLocal(),
            _ when this == HuLocal => onHuLocal(),
            _ when this == Iban => onIban(),
            _ when this == InLocal => onInLocal(),
            _ when this == JpLocal => onJpLocal(),
            _ when this == Legacy => onLegacy(),
            _ when this == MxLocal => onMxLocal(),
            _ when this == MyLocal => onMyLocal(),
            _ when this == NoLocal => onNoLocal(),
            _ when this == NumberAndBic => onNumberAndBic(),
            _ when this == NzLocal => onNzLocal(),
            _ when this == PlLocal => onPlLocal(),
            _ when this == SeLocal => onSeLocal(),
            _ when this == SgLocal => onSgLocal(),
            _ when this == UkLocal => onUkLocal(),
            _ when this == UsLocal => onUsLocal(),
            _ => otherwise(Value)
        };

    public void Match(Action onAuLocal,
        Action onBrLocal,
        Action onCaLocal,
        Action onCzLocal,
        Action onDkLocal,
        Action onHkLocal,
        Action onHuLocal,
        Action onIban,
        Action onInLocal,
        Action onJpLocal,
        Action onLegacy,
        Action onMxLocal,
        Action onMyLocal,
        Action onNoLocal,
        Action onNumberAndBic,
        Action onNzLocal,
        Action onPlLocal,
        Action onSeLocal,
        Action onSgLocal,
        Action onUkLocal,
        Action onUsLocal,
        Action<string> otherwise)
    {
        if (this == AuLocal) onAuLocal();
        else if (this == BrLocal) onBrLocal();
        else if (this == CaLocal) onCaLocal();
        else if (this == CzLocal) onCzLocal();
        else if (this == DkLocal) onDkLocal();
        else if (this == HkLocal) onHkLocal();
        else if (this == HuLocal) onHuLocal();
        else if (this == Iban) onIban();
        else if (this == InLocal) onInLocal();
        else if (this == JpLocal) onJpLocal();
        else if (this == Legacy) onLegacy();
        else if (this == MxLocal) onMxLocal();
        else if (this == MyLocal) onMyLocal();
        else if (this == NoLocal) onNoLocal();
        else if (this == NumberAndBic) onNumberAndBic();
        else if (this == NzLocal) onNzLocal();
        else if (this == PlLocal) onPlLocal();
        else if (this == SeLocal) onSeLocal();
        else if (this == SgLocal) onSgLocal();
        else if (this == UkLocal) onUkLocal();
        else if (this == UsLocal) onUsLocal();
        else otherwise(Value);
    }
}
