using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The state required for the account holder.
/// &gt; Permitted values: <c>Processing</c>, <c>Payout</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountStateType>))]
public sealed record AccountStateType : StringEnum<AccountStateType>
{
    private AccountStateType(string value) : base(value)
    {
    }

    public static readonly AccountStateType LimitedPayout = new("LimitedPayout");

    public static readonly AccountStateType LimitedProcessing = new("LimitedProcessing");

    public static readonly AccountStateType LimitlessPayout = new("LimitlessPayout");

    public static readonly AccountStateType LimitlessProcessing = new("LimitlessProcessing");

    public static readonly AccountStateType Payout = new("Payout");

    public static readonly AccountStateType Processing = new("Processing");

    public static AccountStateType FromValue(string value) => FromValueCore(value);
}
