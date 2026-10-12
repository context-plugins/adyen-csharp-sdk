using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of terminal action: Update Release.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type61>))]
public sealed record Type61 : OpenStringEnum<Type61>
{
    private Type61(string value) : base(value)
    {
    }

    public static readonly Type61 ReleaseUpdate = new("ReleaseUpdate");

    public TResult Match<TResult>(Func<TResult> onReleaseUpdate, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ReleaseUpdate => onReleaseUpdate(),
            _ => otherwise(Value)
        };

    public void Match(Action onReleaseUpdate, Action<string> otherwise)
    {
        if (this == ReleaseUpdate) onReleaseUpdate();
        else otherwise(Value);
    }
}
