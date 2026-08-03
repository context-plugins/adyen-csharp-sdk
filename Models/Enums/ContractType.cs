using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The contract type of the grant offer. Possible value: <b>cashAdvance</b>, <b>loan</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ContractType>))]
public sealed record ContractType : StringEnum<ContractType>
{
    private ContractType(string value) : base(value)
    {
    }

    public static readonly ContractType CashAdvance = new("cashAdvance");

    public static readonly ContractType Loan = new("loan");

    public static ContractType FromValue(string value) => FromValueCore(value);
}
