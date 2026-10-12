using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>directdebit_AU</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type22>))]
public sealed record Type22 : OpenStringEnum<Type22>
{
    private Type22(string value) : base(value)
    {
    }

    public static readonly Type22 DirectdebitAu = new("directdebit_AU");

    public TResult Match<TResult>(Func<TResult> onDirectdebitAu, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DirectdebitAu => onDirectdebitAu(),
            _ => otherwise(Value)
        };

    public void Match(Action onDirectdebitAu, Action<string> otherwise)
    {
        if (this == DirectdebitAu) onDirectdebitAu();
        else otherwise(Value);
    }
}
