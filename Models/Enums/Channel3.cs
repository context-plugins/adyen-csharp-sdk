using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The platform where a payment transaction takes place. This field can be used for filtering out payment methods that are only available on specific platforms. Possible values:
/// * iOS
/// * Android
/// * Web
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Channel3>))]
public sealed record Channel3 : StringEnum<Channel3>
{
    private Channel3(string value) : base(value)
    {
    }

    public static readonly Channel3 IOs = new("iOS");

    public static readonly Channel3 Android = new("Android");

    public static readonly Channel3 Web = new("Web");

    public static Channel3 FromValue(string value) => FromValueCore(value);
}
