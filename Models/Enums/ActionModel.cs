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
[JsonConverter(typeof(StringEnumConverter<ActionModel>))]
public sealed record ActionModel : StringEnum<ActionModel>
{
    private ActionModel(string value) : base(value)
    {
    }

    public static readonly ActionModel Close = new("CLOSE");

    public static readonly ActionModel Nothing = new("NOTHING");

    public static readonly ActionModel Update = new("UPDATE");

    public static ActionModel FromValue(string value) => FromValueCore(value);
}
