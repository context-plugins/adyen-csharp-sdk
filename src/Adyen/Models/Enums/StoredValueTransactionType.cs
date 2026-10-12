using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>Reserve</b>
/// * <b>Activate</b>
/// * <b>Load</b>
/// * <b>Unload</b>
/// * <b>Reverse</b>
/// * <b>Duplicate</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StoredValueTransactionType>))]
public sealed record StoredValueTransactionType : OpenStringEnum<StoredValueTransactionType>
{
    private StoredValueTransactionType(string value) : base(value)
    {
    }

    public static readonly StoredValueTransactionType Reserve = new("Reserve");

    public static readonly StoredValueTransactionType Activate = new("Activate");

    public static readonly StoredValueTransactionType Load = new("Load");

    public static readonly StoredValueTransactionType Unload = new("Unload");

    public static readonly StoredValueTransactionType Reverse = new("Reverse");

    public static readonly StoredValueTransactionType Duplicate = new("Duplicate");

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
