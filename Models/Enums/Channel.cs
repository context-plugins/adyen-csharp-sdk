using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the <c>sdkVersion</c> or <c>token</c>.
/// <para>
/// Possible values:
/// * <b>iOS</b>
/// * <b>Android</b>
/// * <b>Web</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Channel>))]
public sealed record Channel : StringEnum<Channel>
{
    private Channel(string value) : base(value)
    {
    }

    public static readonly Channel IOs = new("iOS");

    public static readonly Channel Android = new("Android");

    public static readonly Channel Web = new("Web");

    public static Channel FromValue(string value) => FromValueCore(value);
}
