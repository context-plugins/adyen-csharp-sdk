using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>dbarai</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type20>))]
public sealed record Type20 : OpenStringEnum<Type20>
{
    private Type20(string value) : base(value)
    {
    }

    public static readonly Type20 Dbarai = new("dbarai");

    public TResult Match<TResult>(Func<TResult> onDbarai, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Dbarai => onDbarai(),
            _ => otherwise(Value)
        };

    public void Match(Action onDbarai, Action<string> otherwise)
    {
        if (this == Dbarai) onDbarai();
        else otherwise(Value);
    }
}
