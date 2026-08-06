using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The HTTP method to use for the request Adyen makes on your behalf to the third party.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<HttpMethodEnum>))]
public sealed record HttpMethodEnum : StringEnum<HttpMethodEnum>
{
    private HttpMethodEnum(string value) : base(value)
    {
    }

    public static readonly HttpMethodEnum Post = new("post");

    public static readonly HttpMethodEnum Put = new("put");

    public static readonly HttpMethodEnum Patch = new("patch");

    public static HttpMethodEnum FromValue(string value) => FromValueCore(value);
}
