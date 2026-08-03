using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of legal entity.
/// <para>
///  Possible values: <b>individual</b>, <b>organization</b>, <b>soleProprietorship</b>, or <b>trust</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type212>))]
public sealed record Type212 : StringEnum<Type212>
{
    private Type212(string value) : base(value)
    {
    }

    public static readonly Type212 Individual = new("individual");

    public static readonly Type212 Organization = new("organization");

    public static readonly Type212 SoleProprietorship = new("soleProprietorship");

    public static readonly Type212 Trust = new("trust");

    public static readonly Type212 UnincorporatedPartnership = new("unincorporatedPartnership");

    public static Type212 FromValue(string value) => FromValueCore(value);
}
