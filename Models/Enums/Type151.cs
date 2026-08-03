using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The tax reporting classification type.
/// <para>
/// Possible values: <b>nonFinancialNonReportable</b>, <b>financialNonReportable</b>, <b>nonFinancialActive</b>, <b>nonFinancialPassive</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type151>))]
public sealed record Type151 : StringEnum<Type151>
{
    private Type151(string value) : base(value)
    {
    }

    public static readonly Type151 NonFinancialNonReportable = new("nonFinancialNonReportable");

    public static readonly Type151 FinancialNonReportable = new("financialNonReportable");

    public static readonly Type151 NonFinancialActive = new("nonFinancialActive");

    public static readonly Type151 NonFinancialPassive = new("nonFinancialPassive");

    public static Type151 FromValue(string value) => FromValueCore(value);
}
