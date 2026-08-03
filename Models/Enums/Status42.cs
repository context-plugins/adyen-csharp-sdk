using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the request. This indicates whether the order was successfully updated with PayPal.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status42>))]
public sealed record Status42 : StringEnum<Status42>
{
    private Status42(string value) : base(value)
    {
    }

    public static readonly Status42 Error = new("error");

    public static readonly Status42 Success = new("success");

    public static Status42 FromValue(string value) => FromValueCore(value);
}
