using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The priority for the bank transfer. This sets the speed at which the transfer is sent and the fees that you have to pay. Required for transfers with <c>category</c> <b>bank</b>.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>regular</b>: For normal, low-value transactions.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>fast</b>: A faster way to transfer funds, but the fees are higher. Recommended for high-priority, low-value transactions.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>wire</b>: The fastest way to transfer funds, but this has the highest fees. Recommended for high-priority, high-value transactions.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>instant</b>: For instant funds transfers within the United States and in <see href="https://www.ecb.europa.eu/paym/integration/retail/sepa/html/index.en.html">SEPA locations</see>.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>crossBorder</b>: For high-value transfers to a recipient in a different country.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>internal</b>: For transfers to an Adyen-issued business bank account (by bank account number/IBAN).</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Priority1>))]
public sealed record Priority1 : StringEnum<Priority1>
{
    private Priority1(string value) : base(value)
    {
    }

    public static readonly Priority1 CrossBorder = new("crossBorder");

    public static readonly Priority1 Fast = new("fast");

    public static readonly Priority1 Instant = new("instant");

    public static readonly Priority1 Internal = new("internal");

    public static readonly Priority1 Regular = new("regular");

    public static readonly Priority1 Wire = new("wire");

    public static Priority1 FromValue(string value) => FromValueCore(value);
}
