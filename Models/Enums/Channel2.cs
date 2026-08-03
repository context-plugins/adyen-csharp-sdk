using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the <c>sdkVersion</c> or <c>token</c>.
/// <para>
/// Possible values:
/// * iOS
/// * Android
/// * Web
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Channel2>))]
public sealed record Channel2 : StringEnum<Channel2>
{
    private Channel2(string value) : base(value)
    {
    }

    public static readonly Channel2 IOs = new("iOS");

    public static readonly Channel2 Android = new("Android");

    public static readonly Channel2 Web = new("Web");

    public static Channel2 FromValue(string value) => FromValueCore(value);
}
