using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TotalDetail>))]
public sealed record TotalDetail : StringEnum<TotalDetail>
{
    private TotalDetail(string value) : base(value)
    {
    }

    public static readonly TotalDetail Poiid = new("POIID");

    public static readonly TotalDetail SaleId = new("SaleID");

    public static readonly TotalDetail OperatorId = new("OperatorID");

    public static readonly TotalDetail ShiftNumber = new("ShiftNumber");

    public static readonly TotalDetail TotalsGroupId = new("TotalsGroupID");

    public static TotalDetail FromValue(string value) => FromValueCore(value);
}
