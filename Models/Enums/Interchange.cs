using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Deducts the interchange fee from specified balance account.
/// <para>
/// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Interchange>))]
public sealed record Interchange : StringEnum<Interchange>
{
    private Interchange(string value) : base(value)
    {
    }

    public static readonly Interchange DeductFromLiableAccount = new("deductFromLiableAccount");

    public static readonly Interchange DeductFromOneBalanceAccount = new("deductFromOneBalanceAccount");

    public static Interchange FromValue(string value) => FromValueCore(value);
}
