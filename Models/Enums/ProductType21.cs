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
[JsonConverter(typeof(StringEnumConverter<ProductType21>))]
public sealed record ProductType21 : StringEnum<ProductType21>
{
    private ProductType21(string value) : base(value)
    {
    }

    public static readonly ProductType21 Onboarding = new("onboarding");

    public static readonly ProductType21 Platform = new("platform");

    public static readonly ProductType21 Bank = new("bank");

    public static ProductType21 FromValue(string value) => FromValueCore(value);
}
