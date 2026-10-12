using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of terminal action: Install an Android certificate.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type42>))]
public sealed record Type42 : OpenStringEnum<Type42>
{
    private Type42(string value) : base(value)
    {
    }

    public static readonly Type42 InstallAndroidCertificate = new("InstallAndroidCertificate");

    public TResult Match<TResult>(Func<TResult> onInstallAndroidCertificate, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == InstallAndroidCertificate => onInstallAndroidCertificate(),
            _ => otherwise(Value)
        };

    public void Match(Action onInstallAndroidCertificate, Action<string> otherwise)
    {
        if (this == InstallAndroidCertificate) onInstallAndroidCertificate();
        else otherwise(Value);
    }
}
