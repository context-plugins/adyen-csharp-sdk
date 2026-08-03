using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Deducts the fees due to Adyen (markup or commission) from the specified balance account.
/// <para>
/// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AdyenFees>))]
public sealed record AdyenFees : StringEnum<AdyenFees>
{
    private AdyenFees(string value) : base(value)
    {
    }

    public static readonly AdyenFees DeductFromLiableAccount = new("deductFromLiableAccount");

    public static readonly AdyenFees DeductFromOneBalanceAccount = new("deductFromOneBalanceAccount");

    public static AdyenFees FromValue(string value) => FromValueCore(value);
}
