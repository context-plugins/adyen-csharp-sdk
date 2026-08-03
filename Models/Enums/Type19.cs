using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the action.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type19>))]
public sealed record Type19 : StringEnum<Type19>
{
    private Type19(string value) : base(value)
    {
    }

    public static readonly Type19 Sdk = new("sdk");

    public static readonly Type19 WechatpaySdk = new("wechatpaySDK");

    public static Type19 FromValue(string value) => FromValueCore(value);
}
