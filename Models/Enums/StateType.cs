using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The state to be updated.
/// &gt;Permitted values are: <c>Processing</c>, <c>Payout</c>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StateType>))]
public sealed record StateType : StringEnum<StateType>
{
    private StateType(string value) : base(value)
    {
    }

    public static readonly StateType LimitedPayout = new("LimitedPayout");

    public static readonly StateType LimitedProcessing = new("LimitedProcessing");

    public static readonly StateType LimitlessPayout = new("LimitlessPayout");

    public static readonly StateType LimitlessProcessing = new("LimitlessProcessing");

    public static readonly StateType Payout = new("Payout");

    public static readonly StateType Processing = new("Processing");

    public static StateType FromValue(string value) => FromValueCore(value);
}
