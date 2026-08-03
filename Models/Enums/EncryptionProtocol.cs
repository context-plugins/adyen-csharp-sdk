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
public sealed record EncryptionProtocol : StringEnum<EncryptionProtocol>
{
    private EncryptionProtocol(string value) : base(value)
    {
    }

    public static readonly EncryptionProtocol Http = new("HTTP");

    public static readonly EncryptionProtocol Tlsv12 = new("TLSv1.2");

    public static readonly EncryptionProtocol Tlsv13 = new("TLSv1.3");

    public static EncryptionProtocol FromValue(string value) => FromValueCore(value);
}
