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
public sealed record ActionEnum : StringEnum<ActionEnum>
{
    private ActionEnum(string value) : base(value)
    {
    }

    public static readonly ActionEnum Close = new("CLOSE");

    public static readonly ActionEnum Nothing = new("NOTHING");

    public static readonly ActionEnum Update = new("UPDATE");

    public static ActionEnum FromValue(string value) => FromValueCore(value);
}
