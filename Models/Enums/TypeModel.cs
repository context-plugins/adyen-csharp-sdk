using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the document. Possible values: <b>ID</b>, <b>DRIVINGLICENSE</b>, <b>PASSPORT</b>, <b>SOCIALSECURITY</b>, <b>VISA</b>.
/// <para>
/// To delete an existing entry for a document <c>type</c>, send only the <c>type</c> field in your request.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeModel>))]
public sealed record TypeModel : StringEnum<TypeModel>
{
    private TypeModel(string value) : base(value)
    {
    }

    public static readonly TypeModel Drivinglicense = new("DRIVINGLICENSE");

    public static readonly TypeModel Id = new("ID");

    public static readonly TypeModel Passport = new("PASSPORT");

    public static readonly TypeModel Socialsecurity = new("SOCIALSECURITY");

    public static readonly TypeModel Visa = new("VISA");

    public static TypeModel FromValue(string value) => FromValueCore(value);
}
