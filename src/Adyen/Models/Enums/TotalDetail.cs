using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TotalDetail>))]
public sealed record TotalDetail : OpenStringEnum<TotalDetail>
{
    private TotalDetail(string value) : base(value)
    {
    }

    public static readonly TotalDetail Poiid = new("POIID");

    public static readonly TotalDetail SaleId = new("SaleID");

    public static readonly TotalDetail OperatorId = new("OperatorID");

    public static readonly TotalDetail ShiftNumber = new("ShiftNumber");

    public static readonly TotalDetail TotalsGroupId = new("TotalsGroupID");

    public TResult Match<TResult>(Func<TResult> onPoiid,
        Func<TResult> onSaleId,
        Func<TResult> onOperatorId,
        Func<TResult> onShiftNumber,
        Func<TResult> onTotalsGroupId,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Poiid => onPoiid(),
            _ when this == SaleId => onSaleId(),
            _ when this == OperatorId => onOperatorId(),
            _ when this == ShiftNumber => onShiftNumber(),
            _ when this == TotalsGroupId => onTotalsGroupId(),
            _ => otherwise(Value)
        };

    public void Match(Action onPoiid,
        Action onSaleId,
        Action onOperatorId,
        Action onShiftNumber,
        Action onTotalsGroupId,
        Action<string> otherwise)
    {
        if (this == Poiid) onPoiid();
        else if (this == SaleId) onSaleId();
        else if (this == OperatorId) onOperatorId();
        else if (this == ShiftNumber) onShiftNumber();
        else if (this == TotalsGroupId) onTotalsGroupId();
        else otherwise(Value);
    }
}
