using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ProductType1>))]
public sealed record ProductType1 : StringEnum<ProductType1>
{
    private ProductType1(string value) : base(value)
    {
    }

    public static readonly ProductType1 Goods = new("goods");

    public static readonly ProductType1 Services = new("services");

    public static ProductType1 FromValue(string value) => FromValueCore(value);
}
