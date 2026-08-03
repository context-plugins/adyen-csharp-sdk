using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of events data.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>merchantPurchaseData</b>: merchant purchase data</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type87>))]
public sealed record Type87 : StringEnum<Type87>
{
    private Type87(string value) : base(value)
    {
    }

    public static readonly Type87 MerchantPurchaseData = new("merchantPurchaseData");

    public static Type87 FromValue(string value) => FromValueCore(value);
}
