using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of terminal action: Uninstall an Android app.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type71>))]
public sealed record Type71 : OpenStringEnum<Type71>
{
    private Type71(string value) : base(value)
    {
    }

    public static readonly Type71 UninstallAndroidApp = new("UninstallAndroidApp");

    public TResult Match<TResult>(Func<TResult> onUninstallAndroidApp, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == UninstallAndroidApp => onUninstallAndroidApp(),
            _ => otherwise(Value)
        };

    public void Match(Action onUninstallAndroidApp, Action<string> otherwise)
    {
        if (this == UninstallAndroidApp) onUninstallAndroidApp();
        else otherwise(Value);
    }
}
