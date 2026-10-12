using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of component.
/// <para>
/// For <see href="https://docs.adyen.com/platforms/onboard-users/components">Onboarding components</see>, set this to <b>onboarding</b>.
/// </para>
/// <para>
/// For <see href="https://docs.adyen.com/platforms/build-user-dashboards">Platform Experience components</see>, set this to <b>platform</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ProductType2>))]
public sealed record ProductType2 : OpenStringEnum<ProductType2>
{
    private ProductType2(string value) : base(value)
    {
    }

    public static readonly ProductType2 Onboarding = new("onboarding");

    public static readonly ProductType2 Platform = new("platform");

    public static readonly ProductType2 Bank = new("bank");

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
