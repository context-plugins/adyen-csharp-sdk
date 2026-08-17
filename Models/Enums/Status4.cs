using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the request. This indicates whether the order was successfully updated with PayPal.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status4>))]
public sealed record Status4 : StringEnum<Status4>
{
    private Status4(string value) : base(value)
    {
    }

    public static readonly Status4 Error = new("error");

    public static readonly Status4 Success = new("success");

    public static Status4 FromValue(string value) => FromValueCore(value);
}
