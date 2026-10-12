using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The event.
/// &gt;Permitted values: <c>InactivateAccount</c>, <c>RefundNotPaidOutTransfers</c>.
/// For more information, refer to <see href="https://docs.adyen.com/classic-platforms/verification-process">Verification checks</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Event>))]
public sealed record Event : OpenStringEnum<Event>
{
    private Event(string value) : base(value)
    {
    }

    public static readonly Event InactivateAccount = new("InactivateAccount");

    public static readonly Event RefundNotPaidOutTransfers = new("RefundNotPaidOutTransfers");

    public TResult Match<TResult>(Func<TResult> onInactivateAccount,
        Func<TResult> onRefundNotPaidOutTransfers,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == InactivateAccount => onInactivateAccount(),
            _ when this == RefundNotPaidOutTransfers => onRefundNotPaidOutTransfers(),
            _ => otherwise(Value)
        };

    public void Match(Action onInactivateAccount, Action onRefundNotPaidOutTransfers, Action<string> otherwise)
    {
        if (this == InactivateAccount) onInactivateAccount();
        else if (this == RefundNotPaidOutTransfers) onRefundNotPaidOutTransfers();
        else otherwise(Value);
    }
}
