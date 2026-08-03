using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of legal entity of the new account holder.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LegalEntity1>))]
public sealed record LegalEntity1 : StringEnum<LegalEntity1>
{
    private LegalEntity1(string value) : base(value)
    {
    }

    public static readonly LegalEntity1 Business = new("Business");

    public static readonly LegalEntity1 Individual = new("Individual");

    public static readonly LegalEntity1 NonProfit = new("NonProfit");

    public static readonly LegalEntity1 Partnership = new("Partnership");

    public static readonly LegalEntity1 PublicCompany = new("PublicCompany");

    public static LegalEntity1 FromValue(string value) => FromValueCore(value);
}
