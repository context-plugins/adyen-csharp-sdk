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
[JsonConverter(typeof(StringEnumConverter<Type110>))]
public sealed record Type110 : StringEnum<Type110>
{
    private Type110(string value) : base(value)
    {
    }

    public static readonly Type110 Association = new("Association");

    public static readonly Type110 Partnership = new("Partnership");

    public static readonly Type110 SoleProprietorship = new("SoleProprietorship");

    public static readonly Type110 Trust = new("Trust");

    public static Type110 FromValue(string value) => FromValueCore(value);
}
