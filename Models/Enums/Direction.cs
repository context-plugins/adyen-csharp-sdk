using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The direction of the transfer.
/// <para>
/// Possible values: <b>incoming</b>, <b>outgoing</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Direction>))]
public sealed record Direction : StringEnum<Direction>
{
    private Direction(string value) : base(value)
    {
    }

    public static readonly Direction Incoming = new("incoming");

    public static readonly Direction Outgoing = new("outgoing");

    public static Direction FromValue(string value) => FromValueCore(value);
}
