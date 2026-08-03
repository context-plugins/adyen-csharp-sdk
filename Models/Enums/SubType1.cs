using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SubType1>))]
public sealed record SubType1 : StringEnum<SubType1>
{
    private SubType1(string value) : base(value)
    {
    }

    public static readonly SubType1 AtmDispute = new("atmDispute");

    public static readonly SubType1 CancelledGoodsServices = new("cancelledGoodsServices");

    public static readonly SubType1 CancelledRecurring = new("cancelledRecurring");

    public static readonly SubType1 CreditNotProcessed = new("creditNotProcessed");

    public static readonly SubType1 Counterfeit = new("counterfeit");

    public static readonly SubType1 NotAsDescribed = new("notAsDescribed");

    public static SubType1 FromValue(string value) => FromValueCore(value);
}
