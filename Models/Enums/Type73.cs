using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of terminal action: Uninstall an Android app.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type73>))]
public sealed record Type73 : StringEnum<Type73>
{
    private Type73(string value) : base(value)
    {
    }

    public static readonly Type73 UninstallAndroidApp = new("UninstallAndroidApp");

    public static Type73 FromValue(string value) => FromValueCore(value);
}
