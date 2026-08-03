using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdditionalSalesChannel>))]
public sealed record AdditionalSalesChannel : StringEnum<AdditionalSalesChannel>
{
    private AdditionalSalesChannel(string value) : base(value)
    {
    }

    public static readonly AdditionalSalesChannel ECommerce = new("eCommerce");

    public static readonly AdditionalSalesChannel EcomMoto = new("ecomMoto");

    public static readonly AdditionalSalesChannel Pos = new("pos");

    public static readonly AdditionalSalesChannel PosMoto = new("posMoto");

    public static AdditionalSalesChannel FromValue(string value) => FromValueCore(value);
}
