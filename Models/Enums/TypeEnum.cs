using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the document. Possible values: <b>ID</b>, <b>DRIVINGLICENSE</b>, <b>PASSPORT</b>, <b>SOCIALSECURITY</b>, <b>VISA</b>.
/// <para>
/// To delete an existing entry for a document <c>type</c>, send only the <c>type</c> field in your request.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeEnum>))]
public sealed record TypeEnum : StringEnum<TypeEnum>
{
    private TypeEnum(string value) : base(value)
    {
    }

    public static readonly TypeEnum Drivinglicense = new("DRIVINGLICENSE");

    public static readonly TypeEnum Id = new("ID");

    public static readonly TypeEnum Passport = new("PASSPORT");

    public static readonly TypeEnum Socialsecurity = new("SOCIALSECURITY");

    public static readonly TypeEnum Visa = new("VISA");

    public static TypeEnum FromValue(string value) => FromValueCore(value);
}
