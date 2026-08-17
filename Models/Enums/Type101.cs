using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of device.
/// <para>
/// Possible values: <b>ios</b>, <b>android</b>, <b>browser</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type101>))]
public sealed record Type101 : StringEnum<Type101>
{
    private Type101(string value) : base(value)
    {
    }

    public static readonly Type101 Ios = new("ios");

    public static readonly Type101 Android = new("android");

    public static readonly Type101 Browser = new("browser");

    public static Type101 FromValue(string value) => FromValueCore(value);
}
