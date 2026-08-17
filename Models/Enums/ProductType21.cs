using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of product that you expected to receive.
/// <para>
/// Possible values: <b>goods</b>, <b>services</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ProductType21>))]
public sealed record ProductType21 : StringEnum<ProductType21>
{
    private ProductType21(string value) : base(value)
    {
    }

    public static readonly ProductType21 Goods = new("goods");

    public static readonly ProductType21 Services = new("services");

    public static ProductType21 FromValue(string value) => FromValueCore(value);
}
