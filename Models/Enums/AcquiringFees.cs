using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Deducts the acquiring fees (the aggregated amount of interchange and scheme fee) from the specified balance account.
/// <para>
/// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AcquiringFees>))]
public sealed record AcquiringFees : StringEnum<AcquiringFees>
{
    private AcquiringFees(string value) : base(value)
    {
    }

    public static readonly AcquiringFees DeductFromLiableAccount = new("deductFromLiableAccount");

    public static readonly AcquiringFees DeductFromOneBalanceAccount = new("deductFromOneBalanceAccount");

    public static AcquiringFees FromValue(string value) => FromValueCore(value);
}
