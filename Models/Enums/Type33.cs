using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of entity.
/// <para>
/// Possible values: <b>LegalEntity</b>, <b>BankAccount</b>, <b>Document</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type33>))]
public sealed record Type33 : StringEnum<Type33>
{
    private Type33(string value) : base(value)
    {
    }

    public static readonly Type33 BankAccount = new("BankAccount");

    public static readonly Type33 Document = new("Document");

    public static readonly Type33 LegalEntity = new("LegalEntity");

    public static Type33 FromValue(string value) => FromValueCore(value);
}
