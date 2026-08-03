using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of markup that is applied to an authorised payment.
/// <para>
/// Possible values: <b>exchange</b>, <b>forexMarkup</b>, <b>authHoldReserve</b>, <b>atmMarkup</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AmountAdjustmentType>))]
public sealed record AmountAdjustmentType : StringEnum<AmountAdjustmentType>
{
    private AmountAdjustmentType(string value) : base(value)
    {
    }

    public static readonly AmountAdjustmentType AtmMarkup = new("atmMarkup");

    public static readonly AmountAdjustmentType AuthHoldReserve = new("authHoldReserve");

    public static readonly AmountAdjustmentType Exchange = new("exchange");

    public static readonly AmountAdjustmentType ForexMarkup = new("forexMarkup");

    public static AmountAdjustmentType FromValue(string value) => FromValueCore(value);
}
