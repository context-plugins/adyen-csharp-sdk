using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>openinvoice</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type39>))]
public sealed record Type39 : OpenStringEnum<Type39>
{
    private Type39(string value) : base(value)
    {
    }

    public static readonly Type39 Openinvoice = new("openinvoice");

    public static readonly Type39 AfterpayDirectdebit = new("afterpay_directdebit");

    public static readonly Type39 AtomePos = new("atome_pos");

    public TResult Match<TResult>(Func<TResult> onOpeninvoice,
        Func<TResult> onAfterpayDirectdebit,
        Func<TResult> onAtomePos,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Openinvoice => onOpeninvoice(),
            _ when this == AfterpayDirectdebit => onAfterpayDirectdebit(),
            _ when this == AtomePos => onAtomePos(),
            _ => otherwise(Value)
        };

    public void Match(Action onOpeninvoice, Action onAfterpayDirectdebit, Action onAtomePos, Action<string> otherwise)
    {
        if (this == Openinvoice) onOpeninvoice();
        else if (this == AfterpayDirectdebit) onAfterpayDirectdebit();
        else if (this == AtomePos) onAtomePos();
        else otherwise(Value);
    }
}
