using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the document. Possible values: <b>ID</b>, <b>DRIVINGLICENSE</b>, <b>PASSPORT</b>, <b>SOCIALSECURITY</b>, <b>VISA</b>.
/// <para>
/// To delete an existing entry for a document <c>type</c>, send only the <c>type</c> field in your request.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type15>))]
public sealed record Type15 : StringEnum<Type15>
{
    private Type15(string value) : base(value)
    {
    }

    public static readonly Type15 Drivinglicense = new("DRIVINGLICENSE");

    public static readonly Type15 Id = new("ID");

    public static readonly Type15 Passport = new("PASSPORT");

    public static readonly Type15 Socialsecurity = new("SOCIALSECURITY");

    public static readonly Type15 Visa = new("VISA");

    public static Type15 FromValue(string value) => FromValueCore(value);
}
