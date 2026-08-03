using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of terminal action: Install an Android certificate.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type42>))]
public sealed record Type42 : StringEnum<Type42>
{
    private Type42(string value) : base(value)
    {
    }

    public static readonly Type42 InstallAndroidCertificate = new("InstallAndroidCertificate");

    public static Type42 FromValue(string value) => FromValueCore(value);
}
