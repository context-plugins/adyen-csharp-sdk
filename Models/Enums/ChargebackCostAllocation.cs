using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Deducts the chargeback costs from the specified balance account.
/// <para>
/// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ChargebackCostAllocation>))]
public sealed record ChargebackCostAllocation : StringEnum<ChargebackCostAllocation>
{
    private ChargebackCostAllocation(string value) : base(value)
    {
    }

    public static readonly ChargebackCostAllocation DeductFromLiableAccount = new("deductFromLiableAccount");

    public static readonly ChargebackCostAllocation DeductFromOneBalanceAccount = new("deductFromOneBalanceAccount");

    public static ChargebackCostAllocation FromValue(string value) => FromValueCore(value);
}
