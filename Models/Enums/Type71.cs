using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of terminal action: Uninstall an Android app.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type71>))]
public sealed record Type71 : StringEnum<Type71>
{
    private Type71(string value) : base(value)
    {
    }

    public static readonly Type71 UninstallAndroidApp = new("UninstallAndroidApp");

    public static Type71 FromValue(string value) => FromValueCore(value);
}
