using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The funding source of the payment method.
/// <para>
/// Possible values:
/// * <b>credit</b>
/// * <b>debit</b>
/// * <b>prepaid</b>
/// * <b>deferred_debit</b>
/// * <b>charged</b>
/// * <b>ANY</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FundingSource1>))]
public sealed record FundingSource1 : StringEnum<FundingSource1>
{
    private FundingSource1(string value) : base(value)
    {
    }

    public static readonly FundingSource1 Charged = new("charged");

    public static readonly FundingSource1 Credit = new("credit");

    public static readonly FundingSource1 Debit = new("debit");

    public static readonly FundingSource1 DeferredDebit = new("deferred_debit");

    public static readonly FundingSource1 Prepaid = new("prepaid");

    public static readonly FundingSource1 Any = new("ANY");

    public static FundingSource1 FromValue(string value) => FromValueCore(value);
}
