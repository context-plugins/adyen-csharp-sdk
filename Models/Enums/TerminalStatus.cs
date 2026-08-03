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
public sealed record TerminalStatus : StringEnum<TerminalStatus>
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

    public static readonly TerminalStatus ReAssignToMerchantInventoryPending = new("ReAssignToMerchantInventoryPending");

    public static readonly TerminalStatus ReAssignToStorePending = new("ReAssignToStorePending");

    public static readonly TerminalStatus SwitchedOff = new("SwitchedOff");

    public static TerminalStatus FromValue(string value) => FromValueCore(value);
}
