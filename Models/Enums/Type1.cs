using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The <see href="https://docs.adyen.com/classic-platforms/verification-process/legal-arrangements#types-of-legal-arrangements">type of legal arrangement</see>.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>Association</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>Partnership</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>SoleProprietorship</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>Trust</b></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type1>))]
public sealed record Type1 : StringEnum<Type1>
{
    private Type1(string value) : base(value)
    {
    }

    public static readonly Type1 Association = new("Association");

    public static readonly Type1 Partnership = new("Partnership");

    public static readonly Type1 SoleProprietorship = new("SoleProprietorship");

    public static readonly Type1 Trust = new("Trust");

    public static Type1 FromValue(string value) => FromValueCore(value);
}
