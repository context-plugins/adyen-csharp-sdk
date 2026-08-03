using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SdkUiType>))]
public sealed record SdkUiType : StringEnum<SdkUiType>
{
    private SdkUiType(string value) : base(value)
    {
    }

    public static readonly SdkUiType MultiSelect = new("multiSelect");

    public static readonly SdkUiType OtherHtml = new("otherHtml");

    public static readonly SdkUiType OutOfBand = new("outOfBand");

    public static readonly SdkUiType SingleSelect = new("singleSelect");

    public static readonly SdkUiType Text = new("text");

    public static SdkUiType FromValue(string value) => FromValueCore(value);
}
