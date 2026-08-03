using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The result of the order creation request.
///  The value is always <b>Success</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ResultCode23>))]
public sealed record ResultCode23 : StringEnum<ResultCode23>
{
    private ResultCode23(string value) : base(value)
    {
    }

    public static readonly ResultCode23 Success = new("Success");

    public static ResultCode23 FromValue(string value) => FromValueCore(value);
}
