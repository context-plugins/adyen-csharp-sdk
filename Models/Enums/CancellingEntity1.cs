using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The party that initiated the cancellation of the transaction.
/// <para>
/// Possible values: <b>merchant</b>, <b>cardholder</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CancellingEntity1>))]
public sealed record CancellingEntity1 : StringEnum<CancellingEntity1>
{
    private CancellingEntity1(string value) : base(value)
    {
    }

    public static readonly CancellingEntity1 Merchant = new("merchant");

    public static readonly CancellingEntity1 Cardholder = new("cardholder");

    public static CancellingEntity1 FromValue(string value) => FromValueCore(value);
}
