using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of terminal action: Install an Android app.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type32>))]
public sealed record Type32 : OpenStringEnum<Type32>
{
    private Type32(string value) : base(value)
    {
    }

    public static readonly Type32 InstallAndroidApp = new("InstallAndroidApp");

    public TResult Match<TResult>(Func<TResult> onInstallAndroidApp, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == InstallAndroidApp => onInstallAndroidApp(),
            _ => otherwise(Value)
        };

    public void Match(Action onInstallAndroidApp, Action<string> otherwise)
    {
        if (this == InstallAndroidApp) onInstallAndroidApp();
        else otherwise(Value);
    }
}
