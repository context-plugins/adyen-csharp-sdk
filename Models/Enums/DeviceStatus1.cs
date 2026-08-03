using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates if the device has an active cloud connection. Possible values:
/// * <b>ONLINE</b>
/// * <b>OFFLINE</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DeviceStatus1>))]
public sealed record DeviceStatus1 : StringEnum<DeviceStatus1>
{
    private DeviceStatus1(string value) : base(value)
    {
    }

    public static readonly DeviceStatus1 Online = new("ONLINE");

    public static readonly DeviceStatus1 Offline = new("OFFLINE");

    public static DeviceStatus1 FromValue(string value) => FromValueCore(value);
}
