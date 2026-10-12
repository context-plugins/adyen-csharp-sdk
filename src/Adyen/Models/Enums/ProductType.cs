using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ProductType>))]
public sealed record ProductType : OpenStringEnum<ProductType>
{
    private ProductType(string value) : base(value)
    {
    }

    public static readonly ProductType Onboarding = new("onboarding");

    public static readonly ProductType Platform = new("platform");

    public static readonly ProductType Bank = new("bank");

    public TResult Match<TResult>(Func<TResult> onOnboarding,
        Func<TResult> onPlatform,
        Func<TResult> onBank,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Onboarding => onOnboarding(),
            _ when this == Platform => onPlatform(),
            _ when this == Bank => onBank(),
            _ => otherwise(Value)
        };

    public void Match(Action onOnboarding, Action onPlatform, Action onBank, Action<string> otherwise)
    {
        if (this == Onboarding) onOnboarding();
        else if (this == Platform) onPlatform();
        else if (this == Bank) onBank();
        else otherwise(Value);
    }
}
