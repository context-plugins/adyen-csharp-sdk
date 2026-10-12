using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The account holder type (personal or business).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountHolderType>))]
public sealed record AccountHolderType : OpenStringEnum<AccountHolderType>
{
    private AccountHolderType(string value) : base(value)
    {
    }

    public static readonly AccountHolderType Business = new("business");

    public static readonly AccountHolderType Personal = new("personal");

    public TResult Match<TResult>(Func<TResult> onBusiness,
        Func<TResult> onPersonal,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Business => onBusiness(),
            _ when this == Personal => onPersonal(),
            _ => otherwise(Value)
        };

    public void Match(Action onBusiness, Action onPersonal, Action<string> otherwise)
    {
        if (this == Business) onBusiness();
        else if (this == Personal) onPersonal();
        else otherwise(Value);
    }
}
