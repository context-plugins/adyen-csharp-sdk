using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>issuedCard</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type511>))]
public sealed record Type511 : OpenStringEnum<Type511>
{
    private Type511(string value) : base(value)
    {
    }

    public static readonly Type511 IssuedCard = new("issuedCard");

    public TResult Match<TResult>(Func<TResult> onIssuedCard, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == IssuedCard => onIssuedCard(),
            _ => otherwise(Value)
        };

    public void Match(Action onIssuedCard, Action<string> otherwise)
    {
        if (this == IssuedCard) onIssuedCard();
        else otherwise(Value);
    }
}
