using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// When set to true, you can retry for failed recurring payments. The default value is true.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RetryPolicy>))]
public sealed record RetryPolicy : StringEnum<RetryPolicy>
{
    private RetryPolicy(string value) : base(value)
    {
    }

    public static readonly RetryPolicy True = new("true");

    public static readonly RetryPolicy False = new("false");

    public static RetryPolicy FromValue(string value) => FromValueCore(value);
}
