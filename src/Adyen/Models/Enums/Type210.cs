using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of terminal action. The value <b>ForceReboot</b> triggers an immediate reboot of the specified terminal(s).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type210>))]
public sealed record Type210 : OpenStringEnum<Type210>
{
    private Type210(string value) : base(value)
    {
    }

    public static readonly Type210 ForceReboot = new("ForceReboot");

    public TResult Match<TResult>(Func<TResult> onForceReboot, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ForceReboot => onForceReboot(),
            _ => otherwise(Value)
        };

    public void Match(Action onForceReboot, Action<string> otherwise)
    {
        if (this == ForceReboot) onForceReboot();
        else otherwise(Value);
    }
}
