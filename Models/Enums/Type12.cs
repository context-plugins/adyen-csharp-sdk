using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>billdesk</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type12>))]
public sealed record Type12 : StringEnum<Type12>
{
    private Type12(string value) : base(value)
    {
    }

    public static readonly Type12 BilldeskOnline = new("billdesk_online");

    public static readonly Type12 BilldeskWallet = new("billdesk_wallet");

    public static Type12 FromValue(string value) => FromValueCore(value);
}
