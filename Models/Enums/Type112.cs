using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of entity that owns the bank account or card.
/// <para>
/// Possible values: <b>individual</b>, <b>organization</b>, or <b>unknown</b>.
/// </para>
/// <para>
/// Required when <c>category</c> is <b>card</b>. In this case, the value must be <b>individual</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type112>))]
public sealed record Type112 : StringEnum<Type112>
{
    private Type112(string value) : base(value)
    {
    }

    public static readonly Type112 Individual = new("individual");

    public static readonly Type112 Organization = new("organization");

    public static readonly Type112 Unknown = new("unknown");

    public static Type112 FromValue(string value) => FromValueCore(value);
}
