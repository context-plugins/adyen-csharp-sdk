using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The SSL protocol employed by the endpoint.
/// &gt;Permitted values: <c>TLSv12</c>, <c>TLSv13</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SslProtocol>))]
public sealed record SslProtocol : OpenStringEnum<SslProtocol>
{
    private SslProtocol(string value) : base(value)
    {
    }

    public static readonly SslProtocol TlSv12 = new("TLSv12");

    public static readonly SslProtocol TlSv13 = new("TLSv13");

    public TResult Match<TResult>(Func<TResult> onTlSv12, Func<TResult> onTlSv13, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == TlSv12 => onTlSv12(),
            _ when this == TlSv13 => onTlSv13(),
            _ => otherwise(Value)
        };

    public void Match(Action onTlSv12, Action onTlSv13, Action<string> otherwise)
    {
        if (this == TlSv12) onTlSv12();
        else if (this == TlSv13) onTlSv13();
        else otherwise(Value);
    }
}
