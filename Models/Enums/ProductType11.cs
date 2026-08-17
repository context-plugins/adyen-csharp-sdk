using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of product that you purchased.
/// <para>
/// Possible values: <b>goods</b>, <b>services</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ProductType11>))]
public sealed record ProductType11 : StringEnum<ProductType11>
{
    private ProductType11(string value) : base(value)
    {
    }

    public static readonly ProductType11 Goods = new("goods");

    public static readonly ProductType11 Services = new("services");

    public static ProductType11 FromValue(string value) => FromValueCore(value);
}
