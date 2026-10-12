using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Global status of a POI Server or POI Terminal.
/// Possible values:
/// * <b>Busy</b>
/// * <b>Maintenance</b>
/// * <b>OK</b>
/// * <b>Unreachable</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GlobalStatus1>))]
public sealed record GlobalStatus1 : OpenStringEnum<GlobalStatus1>
{
    private GlobalStatus1(string value) : base(value)
    {
    }

    public static readonly GlobalStatus1 Ok = new("OK");

    public static readonly GlobalStatus1 Busy = new("Busy");

    public static readonly GlobalStatus1 Maintenance = new("Maintenance");

    public static readonly GlobalStatus1 Unreachable = new("Unreachable");

    public TResult Match<TResult>(Func<TResult> onOk,
        Func<TResult> onBusy,
        Func<TResult> onMaintenance,
        Func<TResult> onUnreachable,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ok => onOk(),
            _ when this == Busy => onBusy(),
            _ when this == Maintenance => onMaintenance(),
            _ when this == Unreachable => onUnreachable(),
            _ => otherwise(Value)
        };

    public void Match(Action onOk, Action onBusy, Action onMaintenance, Action onUnreachable, Action<string> otherwise)
    {
        if (this == Ok) onOk();
        else if (this == Busy) onBusy();
        else if (this == Maintenance) onMaintenance();
        else if (this == Unreachable) onUnreachable();
        else otherwise(Value);
    }
}
