using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of transfer. Possible values:
/// <list type="bullet">
///   <item><description><b>bank</b>: Transfer to a <see href="https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id">transfer instrument</see> or a bank account.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Category35>))]
public sealed record Category35 : StringEnum<Category35>
{
    private Category35(string value) : base(value)
    {
    }

    public static readonly Category35 Bank = new("bank");

    public static Category35 FromValue(string value) => FromValueCore(value);
}
