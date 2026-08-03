using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Deducts the transaction fee due to Adyen under <see href="https://www.adyen.com/what-is-interchange">Interchange ++ pricing</see> from the specified balance account.
/// <para>
/// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AdyenMarkup>))]
public sealed record AdyenMarkup : StringEnum<AdyenMarkup>
{
    private AdyenMarkup(string value) : base(value)
    {
    }

    public static readonly AdyenMarkup DeductFromLiableAccount = new("deductFromLiableAccount");

    public static readonly AdyenMarkup DeductFromOneBalanceAccount = new("deductFromOneBalanceAccount");

    public static AdyenMarkup FromValue(string value) => FromValueCore(value);
}
