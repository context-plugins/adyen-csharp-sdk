using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The category of the transfer.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>bank</b>: A transfer involving a <see href="https://docs.adyen.com/api-explorer/legalentity/latest/post/transferInstruments#responses-200-id">transfer instrument</see> or a bank account.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>card</b>: A transfer involving a third-party card.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>internal</b>: A transfer between <see href="https://docs.adyen.com/api-explorer/balanceplatform/latest/post/balanceAccounts#responses-200-id">balance accounts</see> within your platform.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>issuedCard</b>: A transfer initiated by an Adyen-issued card.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>platformPayment</b>: Funds movements related to payments that are acquired for your users.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>topUp</b>: An incoming transfer initiated by your user to top up their balance account.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Category3>))]
public sealed record Category3 : StringEnum<Category3>
{
    private Category3(string value) : base(value)
    {
    }

    public static readonly Category3 Bank = new("bank");

    public static readonly Category3 Card = new("card");

    public static readonly Category3 Internal = new("internal");

    public static readonly Category3 IssuedCard = new("issuedCard");

    public static readonly Category3 PlatformPayment = new("platformPayment");

    public static readonly Category3 TopUp = new("topUp");

    public static Category3 FromValue(string value) => FromValueCore(value);
}
