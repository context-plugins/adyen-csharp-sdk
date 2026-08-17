using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of terminal action: Install an Android app.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type32>))]
public sealed record Type32 : StringEnum<Type32>
{
    private Type32(string value) : base(value)
    {
    }

    public static readonly Type32 InstallAndroidApp = new("InstallAndroidApp");

    public static Type32 FromValue(string value) => FromValueCore(value);
}
