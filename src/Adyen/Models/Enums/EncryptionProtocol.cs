using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// SSL version to access the public webhook URL specified in the <c>url</c> field. Possible values:
/// * <b>TLSv1.3</b>
/// * <b>TLSv1.2</b>
/// * <b>HTTP</b> - Only allowed on Test environment.
/// <para>
/// If not specified, the webhook will use <c>sslVersion</c>: <b>TLSv1.2</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EncryptionProtocol>))]
public sealed record EncryptionProtocol : OpenStringEnum<EncryptionProtocol>
{
    private EncryptionProtocol(string value) : base(value)
    {
    }

    public static readonly EncryptionProtocol Http = new("HTTP");

    public static readonly EncryptionProtocol TlSv12 = new("TLSv1.2");

    public static readonly EncryptionProtocol TlSv13 = new("TLSv1.3");

    public TResult Match<TResult>(Func<TResult> onHttp,
        Func<TResult> onTlSv12,
        Func<TResult> onTlSv13,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Http => onHttp(),
            _ when this == TlSv12 => onTlSv12(),
            _ when this == TlSv13 => onTlSv13(),
            _ => otherwise(Value)
        };

    public void Match(Action onHttp, Action onTlSv12, Action onTlSv13, Action<string> otherwise)
    {
        if (this == Http) onHttp();
        else if (this == TlSv12) onTlSv12();
        else if (this == TlSv13) onTlSv13();
        else otherwise(Value);
    }
}
