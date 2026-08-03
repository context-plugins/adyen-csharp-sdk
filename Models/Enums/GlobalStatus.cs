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
public sealed record GlobalStatus : StringEnum<GlobalStatus>
{
    private GlobalStatus(string value) : base(value)
    {
    }

    public static readonly GlobalStatus Ok = new("OK");

    public static readonly GlobalStatus Busy = new("Busy");

    public static readonly GlobalStatus Maintenance = new("Maintenance");

    public static readonly GlobalStatus Unreachable = new("Unreachable");

    public static GlobalStatus FromValue(string value) => FromValueCore(value);
}
