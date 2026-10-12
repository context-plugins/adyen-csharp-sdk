using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Specifies how payment methods should be filtered based on the <c>store</c> parameter:
///   - <b>exclusive</b>: Only payment methods belonging to the specified <c>store</c> are returned.
///   - <b>inclusive</b>: Payment methods from the <c>store</c> and those not associated with any other store are returned.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StoreFiltrationMode2>))]
public sealed record StoreFiltrationMode2 : OpenStringEnum<StoreFiltrationMode2>
{
    private StoreFiltrationMode2(string value) : base(value)
    {
    }

    public static readonly StoreFiltrationMode2 Exclusive = new("exclusive");

    public static readonly StoreFiltrationMode2 Inclusive = new("inclusive");

    public static readonly StoreFiltrationMode2 SkipFilter = new("skipFilter");

    public TResult Match<TResult>(Func<TResult> onExclusive,
        Func<TResult> onInclusive,
        Func<TResult> onSkipFilter,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Exclusive => onExclusive(),
            _ when this == Inclusive => onInclusive(),
            _ when this == SkipFilter => onSkipFilter(),
            _ => otherwise(Value)
        };

    public void Match(Action onExclusive, Action onInclusive, Action onSkipFilter, Action<string> otherwise)
    {
        if (this == Exclusive) onExclusive();
        else if (this == Inclusive) onInclusive();
        else if (this == SkipFilter) onSkipFilter();
        else otherwise(Value);
    }
}
