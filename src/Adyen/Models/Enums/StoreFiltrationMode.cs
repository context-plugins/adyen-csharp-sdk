using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Specifies how payment methods should be filtered based on the 'store' parameter:
///   - 'exclusive': Only payment methods belonging to the specified 'store' are returned.
///   - 'inclusive': Payment methods from the 'store' and those not associated with any other store are returned.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StoreFiltrationMode>))]
public sealed record StoreFiltrationMode : OpenStringEnum<StoreFiltrationMode>
{
    private StoreFiltrationMode(string value) : base(value)
    {
    }

    public static readonly StoreFiltrationMode Exclusive = new("exclusive");

    public static readonly StoreFiltrationMode Inclusive = new("inclusive");

    public static readonly StoreFiltrationMode SkipFilter = new("skipFilter");

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
