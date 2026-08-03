using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Books the tips (gratuity) to the specified balance account.
/// <para>
/// Possible values: <b>addToLiableAccount</b>, <b>addToOneBalanceAccount</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Tip>))]
public sealed record Tip : StringEnum<Tip>
{
    private Tip(string value) : base(value)
    {
    }

    public static readonly Tip AddToLiableAccount = new("addToLiableAccount");

    public static readonly Tip AddToOneBalanceAccount = new("addToOneBalanceAccount");

    public static Tip FromValue(string value) => FromValueCore(value);
}
