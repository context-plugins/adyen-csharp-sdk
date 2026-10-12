using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the terminal:
/// <list type="bullet">
///   <item><description><c>OnlineToday</c>, <c>OnlineLast1Day</c>, <c>OnlineLast2Days</c> etcetera to <c>OnlineLast7Days</c>: Indicates when in the past week the terminal was last online.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>SwitchedOff</c>: Indicates it was more than a week ago that the terminal was last online.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ReAssignToInventoryPending</c>, <c>ReAssignToStorePending</c>, <c>ReAssignToMerchantInventoryPending</c>: Indicates the terminal is scheduled to be reassigned.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TerminalStatus>))]
public sealed record TerminalStatus : OpenStringEnum<TerminalStatus>
{
    private TerminalStatus(string value) : base(value)
    {
    }

    public static readonly TerminalStatus OnlineLast1Day = new("OnlineLast1Day");

    public static readonly TerminalStatus OnlineLast2Days = new("OnlineLast2Days");

    public static readonly TerminalStatus OnlineLast3Days = new("OnlineLast3Days");

    public static readonly TerminalStatus OnlineLast4Days = new("OnlineLast4Days");

    public static readonly TerminalStatus OnlineLast5Days = new("OnlineLast5Days");

    public static readonly TerminalStatus OnlineLast6Days = new("OnlineLast6Days");

    public static readonly TerminalStatus OnlineLast7Days = new("OnlineLast7Days");

    public static readonly TerminalStatus OnlineToday = new("OnlineToday");

    public static readonly TerminalStatus ReAssignToInventoryPending = new("ReAssignToInventoryPending");

    public static readonly TerminalStatus ReAssignToMerchantInventoryPending = new(
        "ReAssignToMerchantInventoryPending");

    public static readonly TerminalStatus ReAssignToStorePending = new("ReAssignToStorePending");

    public static readonly TerminalStatus SwitchedOff = new("SwitchedOff");

    public TResult Match<TResult>(Func<TResult> onOnlineLast1Day,
        Func<TResult> onOnlineLast2Days,
        Func<TResult> onOnlineLast3Days,
        Func<TResult> onOnlineLast4Days,
        Func<TResult> onOnlineLast5Days,
        Func<TResult> onOnlineLast6Days,
        Func<TResult> onOnlineLast7Days,
        Func<TResult> onOnlineToday,
        Func<TResult> onReAssignToInventoryPending,
        Func<TResult> onReAssignToMerchantInventoryPending,
        Func<TResult> onReAssignToStorePending,
        Func<TResult> onSwitchedOff,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == OnlineLast1Day => onOnlineLast1Day(),
            _ when this == OnlineLast2Days => onOnlineLast2Days(),
            _ when this == OnlineLast3Days => onOnlineLast3Days(),
            _ when this == OnlineLast4Days => onOnlineLast4Days(),
            _ when this == OnlineLast5Days => onOnlineLast5Days(),
            _ when this == OnlineLast6Days => onOnlineLast6Days(),
            _ when this == OnlineLast7Days => onOnlineLast7Days(),
            _ when this == OnlineToday => onOnlineToday(),
            _ when this == ReAssignToInventoryPending => onReAssignToInventoryPending(),
            _ when this == ReAssignToMerchantInventoryPending => onReAssignToMerchantInventoryPending(),
            _ when this == ReAssignToStorePending => onReAssignToStorePending(),
            _ when this == SwitchedOff => onSwitchedOff(),
            _ => otherwise(Value)
        };

    public void Match(Action onOnlineLast1Day,
        Action onOnlineLast2Days,
        Action onOnlineLast3Days,
        Action onOnlineLast4Days,
        Action onOnlineLast5Days,
        Action onOnlineLast6Days,
        Action onOnlineLast7Days,
        Action onOnlineToday,
        Action onReAssignToInventoryPending,
        Action onReAssignToMerchantInventoryPending,
        Action onReAssignToStorePending,
        Action onSwitchedOff,
        Action<string> otherwise)
    {
        if (this == OnlineLast1Day) onOnlineLast1Day();
        else if (this == OnlineLast2Days) onOnlineLast2Days();
        else if (this == OnlineLast3Days) onOnlineLast3Days();
        else if (this == OnlineLast4Days) onOnlineLast4Days();
        else if (this == OnlineLast5Days) onOnlineLast5Days();
        else if (this == OnlineLast6Days) onOnlineLast6Days();
        else if (this == OnlineLast7Days) onOnlineLast7Days();
        else if (this == OnlineToday) onOnlineToday();
        else if (this == ReAssignToInventoryPending) onReAssignToInventoryPending();
        else if (this == ReAssignToMerchantInventoryPending) onReAssignToMerchantInventoryPending();
        else if (this == ReAssignToStorePending) onReAssignToStorePending();
        else if (this == SwitchedOff) onSwitchedOff();
        else otherwise(Value);
    }
}
