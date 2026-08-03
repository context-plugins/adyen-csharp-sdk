using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The legal entity type.
/// <para>
/// Possible values: <b>Business</b>, <b>Individual</b>, <b>NonProfit</b>, <b>PublicCompany</b>, or <b>Partnership</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LegalEntityType>))]
public sealed record LegalEntityType : StringEnum<LegalEntityType>
{
    private LegalEntityType(string value) : base(value)
    {
    }

    public static readonly LegalEntityType Business = new("Business");

    public static readonly LegalEntityType Individual = new("Individual");

    public static readonly LegalEntityType NonProfit = new("NonProfit");

    public static readonly LegalEntityType Partnership = new("Partnership");

    public static readonly LegalEntityType PublicCompany = new("PublicCompany");

    public static LegalEntityType FromValue(string value) => FromValueCore(value);
}
