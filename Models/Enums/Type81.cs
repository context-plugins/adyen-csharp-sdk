using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of terminal action: Uninstall an Android certificate.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type81>))]
public sealed record Type81 : StringEnum<Type81>
{
    private Type81(string value) : base(value)
    {
    }

    public static readonly Type81 UninstallAndroidCertificate = new("UninstallAndroidCertificate");

    public static Type81 FromValue(string value) => FromValueCore(value);
}
