using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>wechatpayMiniProgram</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type57>))]
public sealed record Type57 : StringEnum<Type57>
{
    private Type57(string value) : base(value)
    {
    }

    public static readonly Type57 WechatpayMiniProgram = new("wechatpayMiniProgram");

    public static Type57 FromValue(string value) => FromValueCore(value);
}
