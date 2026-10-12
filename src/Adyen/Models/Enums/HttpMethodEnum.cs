using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The HTTP method to use for the request Adyen makes on your behalf to the third party.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<HttpMethodEnum>))]
public sealed record HttpMethodEnum : OpenStringEnum<HttpMethodEnum>
{
    private HttpMethodEnum(string value) : base(value)
    {
    }

    public static readonly HttpMethodEnum Post = new("post");

    public static readonly HttpMethodEnum Put = new("put");

    public static readonly HttpMethodEnum Patch = new("patch");

    public TResult Match<TResult>(Func<TResult> onPost,
        Func<TResult> onPut,
        Func<TResult> onPatch,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Post => onPost(),
            _ when this == Put => onPut(),
            _ when this == Patch => onPatch(),
            _ => otherwise(Value)
        };

    public void Match(Action onPost, Action onPut, Action onPatch, Action<string> otherwise)
    {
        if (this == Post) onPost();
        else if (this == Put) onPut();
        else if (this == Patch) onPatch();
        else otherwise(Value);
    }
}
