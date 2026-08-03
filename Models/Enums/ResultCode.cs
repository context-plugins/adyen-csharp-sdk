using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The result of the cancellation request.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>Success</b> – Indicates that the balance check was successful.</description></item>
///   <item><description><b>NotEnoughBalance</b> – Commonly indicates that the card did not have enough balance to pay the amount in the request, or that the currency of the balance on the card did not match the currency of the requested amount.</description></item>
///   <item><description><b>Failed</b> – Indicates that the balance check failed.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ResultCode>))]
public sealed record ResultCode : StringEnum<ResultCode>
{
    private ResultCode(string value) : base(value)
    {
    }

    public static readonly ResultCode Success = new("Success");

    public static readonly ResultCode NotEnoughBalance = new("NotEnoughBalance");

    public static readonly ResultCode Failed = new("Failed");

    public static ResultCode FromValue(string value) => FromValueCore(value);
}
