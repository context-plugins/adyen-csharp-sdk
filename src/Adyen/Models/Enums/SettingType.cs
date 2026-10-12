using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SettingType>))]
public sealed record SettingType : OpenStringEnum<SettingType>
{
    private SettingType(string value) : base(value)
    {
    }

    public static readonly SettingType Balance = new("balance");

    public TResult Match<TResult>(Func<TResult> onBalance, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Balance => onBalance(),
            _ => otherwise(Value)
        };

    public void Match(Action onBalance, Action<string> otherwise)
    {
        if (this == Balance) onBalance();
        else otherwise(Value);
    }
}
