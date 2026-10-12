using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>OK</b>
/// * <b>Busy</b>
/// * <b>Maintenance</b>
/// * <b>Unreachable</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GlobalStatus>))]
public sealed record GlobalStatus : OpenStringEnum<GlobalStatus>
{
    private GlobalStatus(string value) : base(value)
    {
    }

    public static readonly GlobalStatus Ok = new("OK");

    public static readonly GlobalStatus Busy = new("Busy");

    public static readonly GlobalStatus Maintenance = new("Maintenance");

    public static readonly GlobalStatus Unreachable = new("Unreachable");

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
