using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type311>))]
public sealed record Type311 : StringEnum<Type311>
{
    private Type311(string value) : base(value)
    {
    }

    public static readonly Type311 BankAccount = new("BankAccount");

    public static readonly Type311 Document = new("Document");

    public static readonly Type311 LegalEntity = new("LegalEntity");

    public static readonly Type311 Product = new("product");

    public static Type311 FromValue(string value) => FromValueCore(value);
}
