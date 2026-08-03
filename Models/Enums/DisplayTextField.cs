using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DisplayTextField>))]
public sealed record DisplayTextField : StringEnum<DisplayTextField>
{
    private DisplayTextField(string value) : base(value)
    {
    }

    public static readonly DisplayTextField CauseName = new("causeName");

    public static readonly DisplayTextField NonprofitName = new("nonprofitName");

    public static DisplayTextField FromValue(string value) => FromValueCore(value);
}
