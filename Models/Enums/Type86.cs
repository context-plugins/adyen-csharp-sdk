using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of events data.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>issuingTransactionData</b>: issuing transaction data</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type86>))]
public sealed record Type86 : StringEnum<Type86>
{
    private Type86(string value) : base(value)
    {
    }

    public static readonly Type86 IssuingTransactionData = new("issuingTransactionData");

    public static Type86 FromValue(string value) => FromValueCore(value);
}
