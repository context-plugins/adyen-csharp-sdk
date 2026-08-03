using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The result of the cancellation request.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>Received</b> – Indicates the cancellation has successfully been received by Adyen, and will be processed.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ResultCode18>))]
public sealed record ResultCode18 : StringEnum<ResultCode18>
{
    private ResultCode18(string value) : base(value)
    {
    }

    public static readonly ResultCode18 Received = new("Received");

    public static ResultCode18 FromValue(string value) => FromValueCore(value);
}
