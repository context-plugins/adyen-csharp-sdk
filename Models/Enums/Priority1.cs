using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Determines how long it takes for the funds to reach the bank account. Adyen pays out based on the <see href="https://docs.adyen.com/account/getting-paid#payout-frequency">payout frequency</see>. Depending on the currencies and banks involved in transferring the money, it may take up to three days for the payout funds to arrive in the bank account.
/// <para>
///  Possible values:
/// * <b>first</b>: same day.
/// * <b>urgent</b>: the next day.
/// * <b>normal</b>: between 1 and 3 days.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Priority1>))]
public sealed record Priority1 : StringEnum<Priority1>
{
    private Priority1(string value) : base(value)
    {
    }

    public static readonly Priority1 First = new("first");

    public static readonly Priority1 Normal = new("normal");

    public static readonly Priority1 Urgent = new("urgent");

    public static Priority1 FromValue(string value) => FromValueCore(value);
}
