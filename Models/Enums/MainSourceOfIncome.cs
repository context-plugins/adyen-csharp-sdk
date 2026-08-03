using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The organization's main source of income. Only required if <c>businessType</c> is <b>other</b>.
/// <para>
/// Possible values: <b>businessOperation</b>, <b>realEstateSales</b>, <b>investmentInterestOrRoyalty</b>, <b>propertyRental</b>, <b>other</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MainSourceOfIncome>))]
public sealed record MainSourceOfIncome : StringEnum<MainSourceOfIncome>
{
    private MainSourceOfIncome(string value) : base(value)
    {
    }

    public static readonly MainSourceOfIncome BusinessOperation = new("businessOperation");

    public static readonly MainSourceOfIncome RealEstateSales = new("realEstateSales");

    public static readonly MainSourceOfIncome InvestmentInterestOrRoyalty = new("investmentInterestOrRoyalty");

    public static readonly MainSourceOfIncome PropertyRental = new("propertyRental");

    public static readonly MainSourceOfIncome Other = new("other");

    public static MainSourceOfIncome FromValue(string value) => FromValueCore(value);
}
