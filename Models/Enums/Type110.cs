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
[JsonConverter(typeof(StringEnumConverter<Type110>))]
public sealed record Type110 : StringEnum<Type110>
{
    private Type110(string value) : base(value)
    {
    }

    public static readonly Type110 Individual = new("individual");

    public static readonly Type110 Organization = new("organization");

    public static readonly Type110 Unknown = new("unknown");

    public static Type110 FromValue(string value) => FromValueCore(value);
}
