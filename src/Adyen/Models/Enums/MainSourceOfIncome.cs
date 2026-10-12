using System;
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
public sealed record MainSourceOfIncome : OpenStringEnum<MainSourceOfIncome>
{
    private MainSourceOfIncome(string value) : base(value)
    {
    }

    public static readonly MainSourceOfIncome BusinessOperation = new("businessOperation");

    public static readonly MainSourceOfIncome RealEstateSales = new("realEstateSales");

    public static readonly MainSourceOfIncome InvestmentInterestOrRoyalty = new("investmentInterestOrRoyalty");

    public static readonly MainSourceOfIncome PropertyRental = new("propertyRental");

    public static readonly MainSourceOfIncome Other = new("other");

    public TResult Match<TResult>(Func<TResult> onBusinessOperation,
        Func<TResult> onRealEstateSales,
        Func<TResult> onInvestmentInterestOrRoyalty,
        Func<TResult> onPropertyRental,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BusinessOperation => onBusinessOperation(),
            _ when this == RealEstateSales => onRealEstateSales(),
            _ when this == InvestmentInterestOrRoyalty => onInvestmentInterestOrRoyalty(),
            _ when this == PropertyRental => onPropertyRental(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onBusinessOperation,
        Action onRealEstateSales,
        Action onInvestmentInterestOrRoyalty,
        Action onPropertyRental,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == BusinessOperation) onBusinessOperation();
        else if (this == RealEstateSales) onRealEstateSales();
        else if (this == InvestmentInterestOrRoyalty) onInvestmentInterestOrRoyalty();
        else if (this == PropertyRental) onPropertyRental();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
