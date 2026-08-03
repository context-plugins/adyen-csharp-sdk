using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SettingType>))]
public sealed record SettingType : StringEnum<SettingType>
{
    private SettingType(string value) : base(value)
    {
    }

    public static readonly SettingType Balance = new("balance");

    public static SettingType FromValue(string value) => FromValueCore(value);
}
