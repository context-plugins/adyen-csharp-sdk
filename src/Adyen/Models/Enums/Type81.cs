using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of terminal action: Uninstall an Android certificate.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type81>))]
public sealed record Type81 : OpenStringEnum<Type81>
{
    private Type81(string value) : base(value)
    {
    }

    public static readonly Type81 UninstallAndroidCertificate = new("UninstallAndroidCertificate");

    public TResult Match<TResult>(Func<TResult> onUninstallAndroidCertificate, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == UninstallAndroidCertificate => onUninstallAndroidCertificate(),
            _ => otherwise(Value)
        };

    public void Match(Action onUninstallAndroidCertificate, Action<string> otherwise)
    {
        if (this == UninstallAndroidCertificate) onUninstallAndroidCertificate();
        else otherwise(Value);
    }
}
