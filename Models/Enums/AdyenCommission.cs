using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Deducts the transaction fee due to Adyen under <see href="https://www.adyen.com/knowledge-hub/guides/payments-training-guide/get-the-best-from-your-card-processing">blended rates</see> from the specified balance account.
/// <para>
/// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AdyenCommission>))]
public sealed record AdyenCommission : StringEnum<AdyenCommission>
{
    private AdyenCommission(string value) : base(value)
    {
    }

    public static readonly AdyenCommission DeductFromLiableAccount = new("deductFromLiableAccount");

    public static readonly AdyenCommission DeductFromOneBalanceAccount = new("deductFromOneBalanceAccount");

    public static AdyenCommission FromValue(string value) => FromValueCore(value);
}
