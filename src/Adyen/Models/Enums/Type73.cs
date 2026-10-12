using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the transfer event. Possible values: <b>accounting</b>, <b>tracking</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type73>))]
public sealed record Type73 : OpenStringEnum<Type73>
{
    private Type73(string value) : base(value)
    {
    }

    public static readonly Type73 Accounting = new("accounting");

    public static readonly Type73 Tracing = new("tracing");

    public static readonly Type73 Tracking = new("tracking");

    public TResult Match<TResult>(Func<TResult> onAccounting,
        Func<TResult> onTracing,
        Func<TResult> onTracking,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Accounting => onAccounting(),
            _ when this == Tracing => onTracing(),
            _ when this == Tracking => onTracking(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccounting, Action onTracing, Action onTracking, Action<string> otherwise)
    {
        if (this == Accounting) onAccounting();
        else if (this == Tracing) onTracing();
        else if (this == Tracking) onTracking();
        else otherwise(Value);
    }
}
