using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ProductType>))]
public sealed record ProductType : StringEnum<ProductType>
{
    private ProductType(string value) : base(value)
    {
    }

    public static readonly ProductType Onboarding = new("onboarding");

    public static readonly ProductType Platform = new("platform");

    public static readonly ProductType Bank = new("bank");

    public static ProductType FromValue(string value) => FromValueCore(value);
}
