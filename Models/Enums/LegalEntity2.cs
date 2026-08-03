using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The legal entity of the account holder.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LegalEntity2>))]
public sealed record LegalEntity2 : StringEnum<LegalEntity2>
{
    private LegalEntity2(string value) : base(value)
    {
    }

    public static readonly LegalEntity2 Business = new("Business");

    public static readonly LegalEntity2 Individual = new("Individual");

    public static readonly LegalEntity2 NonProfit = new("NonProfit");

    public static readonly LegalEntity2 Partnership = new("Partnership");

    public static readonly LegalEntity2 PublicCompany = new("PublicCompany");

    public static LegalEntity2 FromValue(string value) => FromValueCore(value);
}
