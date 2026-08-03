using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The HTTP method to use for the request Adyen makes on your behalf to the third party.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<HttpMethodModel>))]
public sealed record HttpMethodModel : StringEnum<HttpMethodModel>
{
    private HttpMethodModel(string value) : base(value)
    {
    }

    public static readonly HttpMethodModel Post = new("post");

    public static readonly HttpMethodModel Put = new("put");

    public static readonly HttpMethodModel Patch = new("patch");

    public static HttpMethodModel FromValue(string value) => FromValueCore(value);
}
