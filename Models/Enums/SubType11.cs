using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The specific category of <b>other</b> dispute that you are raising.
/// <para>
/// Possible values: <b>atmDispute</b>, <b>cancelledGoodsServices</b>, <b>cancelledRecurring</b>, <b>counterfeit</b>, <b>creditNotProcessed</b>, <b>notAsDescribed</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SubType11>))]
public sealed record SubType11 : StringEnum<SubType11>
{
    private SubType11(string value) : base(value)
    {
    }

    public static readonly SubType11 AtmDispute = new("atmDispute");

    public static readonly SubType11 CancelledGoodsServices = new("cancelledGoodsServices");

    public static readonly SubType11 CancelledRecurring = new("cancelledRecurring");

    public static readonly SubType11 CreditNotProcessed = new("creditNotProcessed");

    public static readonly SubType11 Counterfeit = new("counterfeit");

    public static readonly SubType11 NotAsDescribed = new("notAsDescribed");

    public static SubType11 FromValue(string value) => FromValueCore(value);
}
