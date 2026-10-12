using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Direction on how to handle any payouts that have already been scheduled.
/// <para>
/// Possible values:
/// * <c>CLOSE</c>: close the existing batch of payouts.
/// * <c>UPDATE</c>: reschedule the existing batch to the new schedule.
/// * <c>NOTHING</c> (<b>default</b>): allow the payout to proceed.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ActionEnum>))]
public sealed record ActionEnum : OpenStringEnum<ActionEnum>
{
    private ActionEnum(string value) : base(value)
    {
    }

    public static readonly ActionEnum Close = new("CLOSE");

    public static readonly ActionEnum Nothing = new("NOTHING");

    public static readonly ActionEnum Update = new("UPDATE");

    public TResult Match<TResult>(Func<TResult> onClose,
        Func<TResult> onNothing,
        Func<TResult> onUpdate,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Close => onClose(),
            _ when this == Nothing => onNothing(),
            _ when this == Update => onUpdate(),
            _ => otherwise(Value)
        };

    public void Match(Action onClose, Action onNothing, Action onUpdate, Action<string> otherwise)
    {
        if (this == Close) onClose();
        else if (this == Nothing) onNothing();
        else if (this == Update) onUpdate();
        else otherwise(Value);
    }
}
