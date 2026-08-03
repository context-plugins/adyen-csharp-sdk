using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Books the surcharge amount to the specified balance account.
/// <para>
/// Possible values: <b>addToLiableAccount</b>, <b>addToOneBalanceAccount</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Surcharge3>))]
public sealed record Surcharge3 : StringEnum<Surcharge3>
{
    private Surcharge3(string value) : base(value)
    {
    }

    public static readonly Surcharge3 AddToLiableAccount = new("addToLiableAccount");

    public static readonly Surcharge3 AddToOneBalanceAccount = new("addToOneBalanceAccount");

    public static Surcharge3 FromValue(string value) => FromValueCore(value);
}
