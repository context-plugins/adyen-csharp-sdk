using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Deducts the scheme fee from the specified balance account.
/// <para>
/// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SchemeFee>))]
public sealed record SchemeFee : StringEnum<SchemeFee>
{
    private SchemeFee(string value) : base(value)
    {
    }

    public static readonly SchemeFee DeductFromLiableAccount = new("deductFromLiableAccount");

    public static readonly SchemeFee DeductFromOneBalanceAccount = new("deductFromOneBalanceAccount");

    public static SchemeFee FromValue(string value) => FromValueCore(value);
}
