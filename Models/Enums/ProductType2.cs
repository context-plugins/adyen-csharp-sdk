using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of product that you expected to receive.
/// <para>
/// Possible values: <b>goods</b>, <b>services</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ProductType2>))]
public sealed record ProductType2 : StringEnum<ProductType2>
{
    private ProductType2(string value) : base(value)
    {
    }

    public static readonly ProductType2 Goods = new("goods");

    public static readonly ProductType2 Services = new("services");

    public static ProductType2 FromValue(string value) => FromValueCore(value);
}
