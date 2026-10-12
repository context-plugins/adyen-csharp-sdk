using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Identification of operation to proceed on the stored value account or the stored value card.
/// Copy.
/// Possible values:
/// * <b>Activate</b>
/// * <b>Duplicate</b>
/// * <b>Load</b>
/// * <b>Reserve</b>
/// * <b>Reverse</b>
/// * <b>Unload</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StoredValueTransactionType2>))]
public sealed record StoredValueTransactionType2 : OpenStringEnum<StoredValueTransactionType2>
{
    private StoredValueTransactionType2(string value) : base(value)
    {
    }

    public static readonly StoredValueTransactionType2 Reserve = new("Reserve");

    public static readonly StoredValueTransactionType2 Activate = new("Activate");

    public static readonly StoredValueTransactionType2 Load = new("Load");

    public static readonly StoredValueTransactionType2 Unload = new("Unload");

    public static readonly StoredValueTransactionType2 Reverse = new("Reverse");

    public static readonly StoredValueTransactionType2 Duplicate = new("Duplicate");

    public TResult Match<TResult>(Func<TResult> onReserve,
        Func<TResult> onActivate,
        Func<TResult> onLoad,
        Func<TResult> onUnload,
        Func<TResult> onReverse,
        Func<TResult> onDuplicate,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Reserve => onReserve(),
            _ when this == Activate => onActivate(),
            _ when this == Load => onLoad(),
            _ when this == Unload => onUnload(),
            _ when this == Reverse => onReverse(),
            _ when this == Duplicate => onDuplicate(),
            _ => otherwise(Value)
        };

    public void Match(Action onReserve,
        Action onActivate,
        Action onLoad,
        Action onUnload,
        Action onReverse,
        Action onDuplicate,
        Action<string> otherwise)
    {
        if (this == Reserve) onReserve();
        else if (this == Activate) onActivate();
        else if (this == Load) onLoad();
        else if (this == Unload) onUnload();
        else if (this == Reverse) onReverse();
        else if (this == Duplicate) onDuplicate();
        else otherwise(Value);
    }
}
