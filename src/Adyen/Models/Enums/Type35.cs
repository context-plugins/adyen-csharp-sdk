using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>masterpass</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type35>))]
public sealed record Type35 : OpenStringEnum<Type35>
{
    private Type35(string value) : base(value)
    {
    }

    public static readonly Type35 Masterpass = new("masterpass");

    public TResult Match<TResult>(Func<TResult> onMasterpass, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Masterpass => onMasterpass(),
            _ => otherwise(Value)
        };

    public void Match(Action onMasterpass, Action<string> otherwise)
    {
        if (this == Masterpass) onMasterpass();
        else otherwise(Value);
    }
}
