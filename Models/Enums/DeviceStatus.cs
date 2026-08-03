using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DeviceStatus>))]
public sealed record DeviceStatus : StringEnum<DeviceStatus>
{
    private DeviceStatus(string value) : base(value)
    {
    }

    public static readonly DeviceStatus Online = new("ONLINE");

    public static readonly DeviceStatus Offline = new("OFFLINE");

    public static DeviceStatus FromValue(string value) => FromValueCore(value);
}
