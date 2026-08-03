using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of legal entity.
/// <para>
/// Possible values: <b>individual</b>, <b>organization</b>, <b>soleProprietorship</b>, or <b>trust</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type182>))]
public sealed record Type182 : StringEnum<Type182>
{
    private Type182(string value) : base(value)
    {
    }

    public static readonly Type182 Individual = new("individual");

    public static readonly Type182 Organization = new("organization");

    public static readonly Type182 SoleProprietorship = new("soleProprietorship");

    public static readonly Type182 Trust = new("trust");

    public static readonly Type182 UnincorporatedPartnership = new("unincorporatedPartnership");

    public static Type182 FromValue(string value) => FromValueCore(value);
}
