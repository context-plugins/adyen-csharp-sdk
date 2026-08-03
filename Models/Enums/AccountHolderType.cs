using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The account holder type (personal or business).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountHolderType>))]
public sealed record AccountHolderType : StringEnum<AccountHolderType>
{
    private AccountHolderType(string value) : base(value)
    {
    }

    public static readonly AccountHolderType Business = new("business");

    public static readonly AccountHolderType Personal = new("personal");

    public static AccountHolderType FromValue(string value) => FromValueCore(value);
}
