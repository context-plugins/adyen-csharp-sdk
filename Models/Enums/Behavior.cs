using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The method of handling the chargeback.
/// <para>
/// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>, <b>deductAccordingToSplitRatio</b>., Specifies how and from which balance account(s) to deduct the chargeback amount.
/// </para>
/// <para>
/// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>, <b>deductAccordingToSplitRatio</b>., Specifies how and from which balance account(s) to deduct the refund amount.
/// </para>
/// <para>
/// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>, <b>deductAccordingToSplitRatio</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Behavior>))]
public sealed record Behavior : StringEnum<Behavior>
{
    private Behavior(string value) : base(value)
    {
    }

    public static readonly Behavior DeductFromOneBalanceAccount = new("deductFromOneBalanceAccount");

    public static readonly Behavior DeductAccordingToSplitRatio = new("deductAccordingToSplitRatio");

    public static readonly Behavior DeductFromLiableAccount = new("deductFromLiableAccount");

    public static Behavior FromValue(string value) => FromValueCore(value);
}
