using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the store. Possible values are:
/// <list type="bullet">
///   <item><description><b>active</b>: This value is assigned automatically when a store is created.</description></item>
///   <item><description><b>inactive</b>: The maximum <see href="https://docs.adyen.com/point-of-sale/determine-account-structure/configure-features#payment-features">transaction limits and number of Store-and-Forward transactions</see> for the store are set to 0. This blocks new transactions, but captures are still possible.</description></item>
///   <item><description><b>closed</b>: The terminals of the store are reassigned to the merchant inventory, so they can't process payments.</description></item>
/// </list>
/// <para>
/// You can change the status from <b>active</b> to <b>inactive</b>, and from <b>inactive</b> to <b>active</b> or <b>closed</b>.
/// Once <b>closed</b>, a store can't be reopened.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status43>))]
public sealed record Status43 : StringEnum<Status43>
{
    private Status43(string value) : base(value)
    {
    }

    public static readonly Status43 Active = new("active");

    public static readonly Status43 Closed = new("closed");

    public static readonly Status43 Inactive = new("inactive");

    public static Status43 FromValue(string value) => FromValueCore(value);
}
