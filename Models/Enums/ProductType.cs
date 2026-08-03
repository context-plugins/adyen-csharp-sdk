using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ProductType>))]
public sealed record ProductType : StringEnum<ProductType>
{
    private ProductType(string value) : base(value)
    {
    }

    public static readonly ProductType Goods = new("goods");

    public static readonly ProductType Services = new("services");

    public static ProductType FromValue(string value) => FromValueCore(value);
}
