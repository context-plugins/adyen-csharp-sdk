using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>billdesk</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type121>))]
public sealed record Type121 : StringEnum<Type121>
{
    private Type121(string value) : base(value)
    {
    }

    public static readonly Type121 BilldeskOnline = new("billdesk_online");

    public static readonly Type121 BilldeskWallet = new("billdesk_wallet");

    public static Type121 FromValue(string value) => FromValueCore(value);
}
