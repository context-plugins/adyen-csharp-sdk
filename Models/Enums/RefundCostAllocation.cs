using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Deducts the refund costs from the specified balance account.
/// <para>
/// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RefundCostAllocation>))]
public sealed record RefundCostAllocation : StringEnum<RefundCostAllocation>
{
    private RefundCostAllocation(string value) : base(value)
    {
    }

    public static readonly RefundCostAllocation DeductFromLiableAccount = new("deductFromLiableAccount");

    public static readonly RefundCostAllocation DeductFromOneBalanceAccount = new("deductFromOneBalanceAccount");

    public static RefundCostAllocation FromValue(string value) => FromValueCore(value);
}
