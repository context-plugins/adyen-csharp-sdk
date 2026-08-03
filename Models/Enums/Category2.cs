using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of transfer.
/// <para>
///  Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>bank</b>: Transfer to a <see href="https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id">transfer instrument</see> or a bank account.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Category2>))]
public sealed record Category2 : StringEnum<Category2>
{
    private Category2(string value) : base(value)
    {
    }

    public static readonly Category2 Bank = new("bank");

    public static readonly Category2 Card = new("card");

    public static readonly Category2 Grants = new("grants");

    public static readonly Category2 Interest = new("interest");

    public static readonly Category2 Internal = new("internal");

    public static readonly Category2 IssuedCard = new("issuedCard");

    public static readonly Category2 Migration = new("migration");

    public static readonly Category2 PlatformPayment = new("platformPayment");

    public static readonly Category2 TopUp = new("topUp");

    public static readonly Category2 Upgrade = new("upgrade");

    public static Category2 FromValue(string value) => FromValueCore(value);
}
