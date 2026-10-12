using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates whether the specified <c>eventType</c> is sent to your webhook endpoint.
/// Possible values:
/// * <b>INCLUDE</b>: Send the specified <c>eventType</c>.
/// * <b>EXCLUDE</b>: Send all event types except the specified <c>eventType</c> and other event types with the <c>includeMode</c> set to <b>EXCLUDE</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IncludeMode>))]
public sealed record IncludeMode : OpenStringEnum<IncludeMode>
{
    private IncludeMode(string value) : base(value)
    {
    }

    public static readonly IncludeMode Exclude = new("EXCLUDE");

    public static readonly IncludeMode Include = new("INCLUDE");

    public TResult Match<TResult>(Func<TResult> onExclude, Func<TResult> onInclude, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Exclude => onExclude(),
            _ when this == Include => onInclude(),
            _ => otherwise(Value)
        };

    public void Match(Action onExclude, Action onInclude, Action<string> otherwise)
    {
        if (this == Exclude) onExclude();
        else if (this == Include) onInclude();
        else otherwise(Value);
    }
}
