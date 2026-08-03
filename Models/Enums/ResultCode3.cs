using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The result of the payment. Possible values:
/// <list type="bullet">
///   <item><description><b>Success</b> – The operation has been completed successfully.</description></item>
///   <item><description><b>Refused</b> – The operation was refused. The reason is given in the <c>refusalReason</c> field.</description></item>
///   <item><description><b>Error</b> – There was an error when the operation was processed. The reason is given in the <c>refusalReason</c> field.</description></item>
///   <item><description><b>NotEnoughBalance</b> – The amount on the payment method is lower than the amount given in the request. Only applicable to balance checks.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ResultCode3>))]
public sealed record ResultCode3 : StringEnum<ResultCode3>
{
    private ResultCode3(string value) : base(value)
    {
    }

    public static readonly ResultCode3 Success = new("Success");

    public static readonly ResultCode3 Refused = new("Refused");

    public static readonly ResultCode3 Error = new("Error");

    public static readonly ResultCode3 NotEnoughBalance = new("NotEnoughBalance");

    public static ResultCode3 FromValue(string value) => FromValueCore(value);
}
