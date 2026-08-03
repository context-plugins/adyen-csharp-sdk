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
public sealed record GlobalStatus1 : StringEnum<GlobalStatus1>
{
    private GlobalStatus1(string value) : base(value)
    {
    }

    public static readonly GlobalStatus1 Ok = new("OK");

    public static readonly GlobalStatus1 Busy = new("Busy");

    public static readonly GlobalStatus1 Maintenance = new("Maintenance");

    public static readonly GlobalStatus1 Unreachable = new("Unreachable");

    public static GlobalStatus1 FromValue(string value) => FromValueCore(value);
}
