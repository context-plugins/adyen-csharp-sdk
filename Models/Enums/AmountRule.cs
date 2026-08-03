using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The limitation rule of the billing amount.
/// <para>
/// Possible values:
///  * <b>max</b>: The transaction amount can not exceed the <c>amount</c>.
/// </para>
/// <list type="bullet">
///   <item><description><b>exact</b>: The transaction amount should be the same as the <c>amount</c>.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AmountRule>))]
public sealed record AmountRule : StringEnum<AmountRule>
{
    private AmountRule(string value) : base(value)
    {
    }

    public static readonly AmountRule Max = new("max");

    public static readonly AmountRule Exact = new("exact");

    public static AmountRule FromValue(string value) => FromValueCore(value);
}
