using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of entity.
/// <para>
/// Possible values: <b>LegalEntity</b>, <b>BankAccount</b>, <b>Document</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type3>))]
public sealed record Type3 : StringEnum<Type3>
{
    private Type3(string value) : base(value)
    {
    }

    public static readonly Type3 BankAccount = new("BankAccount");

    public static readonly Type3 Document = new("Document");

    public static readonly Type3 LegalEntity = new("LegalEntity");

    public static Type3 FromValue(string value) => FromValueCore(value);
}
