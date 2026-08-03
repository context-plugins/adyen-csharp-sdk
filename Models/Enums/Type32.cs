using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type32>))]
public sealed record Type32 : StringEnum<Type32>
{
    private Type32(string value) : base(value)
    {
    }

    public static readonly Type32 BankAccount = new("BankAccount");

    public static readonly Type32 Document = new("Document");

    public static readonly Type32 LegalEntity = new("LegalEntity");

    public static readonly Type32 Product = new("product");

    public static Type32 FromValue(string value) => FromValueCore(value);
}
