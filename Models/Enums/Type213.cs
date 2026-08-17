using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of legal entity.
/// <para>
///  Possible values: <b>individual</b>, <b>organization</b>, <b>soleProprietorship</b>, or <b>trust</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type213>))]
public sealed record Type213 : StringEnum<Type213>
{
    private Type213(string value) : base(value)
    {
    }

    public static readonly Type213 Individual = new("individual");

    public static readonly Type213 Organization = new("organization");

    public static readonly Type213 SoleProprietorship = new("soleProprietorship");

    public static readonly Type213 Trust = new("trust");

    public static readonly Type213 UnincorporatedPartnership = new("unincorporatedPartnership");

    public static Type213 FromValue(string value) => FromValueCore(value);
}
