using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ProductType3>))]
public sealed record ProductType3 : StringEnum<ProductType3>
{
    private ProductType3(string value) : base(value)
    {
    }

    public static readonly ProductType3 Onboarding = new("onboarding");

    public static readonly ProductType3 Platform = new("platform");

    public static readonly ProductType3 Bank = new("bank");

    public static ProductType3 FromValue(string value) => FromValueCore(value);
}
