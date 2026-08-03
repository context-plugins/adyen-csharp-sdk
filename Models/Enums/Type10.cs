using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of device.
/// <para>
/// Possible values: <b>ios</b>, <b>android</b>, <b>browser</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type10>))]
public sealed record Type10 : StringEnum<Type10>
{
    private Type10(string value) : base(value)
    {
    }

    public static readonly Type10 Ios = new("ios");

    public static readonly Type10 Android = new("android");

    public static readonly Type10 Browser = new("browser");

    public static Type10 FromValue(string value) => FromValueCore(value);
}
