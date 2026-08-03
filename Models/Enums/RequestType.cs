using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates the type of request to which the rule applies. If not provided, by default, this is set to <b>authorization</b>.
/// <para>
/// Possible values: <b>authorization</b>, <b>authentication</b>, <b>tokenization</b>, <b>bankTransfer</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RequestType>))]
public sealed record RequestType : StringEnum<RequestType>
{
    private RequestType(string value) : base(value)
    {
    }

    public static readonly RequestType Authentication = new("authentication");

    public static readonly RequestType Authorization = new("authorization");

    public static readonly RequestType BankTransfer = new("bankTransfer");

    public static readonly RequestType Tokenization = new("tokenization");

    public static RequestType FromValue(string value) => FromValueCore(value);
}
