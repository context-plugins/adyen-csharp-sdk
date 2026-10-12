using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The reason for disabling the sweep.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Reason>))]
public sealed record Reason : OpenStringEnum<Reason>
{
    private Reason(string value) : base(value)
    {
    }

    public static readonly Reason AccountHierarchyNotActive = new("accountHierarchyNotActive");

    public static readonly Reason AmountLimitExceeded = new("amountLimitExceeded");

    public static readonly Reason Approved = new("approved");

    public static readonly Reason CounterpartyAccountBlocked = new("counterpartyAccountBlocked");

    public static readonly Reason CounterpartyAccountClosed = new("counterpartyAccountClosed");

    public static readonly Reason CounterpartyAccountNotFound = new("counterpartyAccountNotFound");

    public static readonly Reason CounterpartyAddressRequired = new("counterpartyAddressRequired");

    public static readonly Reason CounterpartyBankTimedOut = new("counterpartyBankTimedOut");

    public static readonly Reason CounterpartyBankUnavailable = new("counterpartyBankUnavailable");

    public static readonly Reason DirectDebitNotSupported = new("directDebitNotSupported");

    public static readonly Reason Error = new("error");

    public static readonly Reason NotEnoughBalance = new("notEnoughBalance");

    public static readonly Reason RefusedByCounterpartyBank = new("refusedByCounterpartyBank");

    public static readonly Reason RouteNotFound = new("routeNotFound");

    public static readonly Reason TransferInstrumentDoesNotExist = new("transferInstrumentDoesNotExist");

    public static readonly Reason Unknown = new("unknown");

    public TResult Match<TResult>(Func<TResult> onAccountHierarchyNotActive,
        Func<TResult> onAmountLimitExceeded,
        Func<TResult> onApproved,
        Func<TResult> onCounterpartyAccountBlocked,
        Func<TResult> onCounterpartyAccountClosed,
        Func<TResult> onCounterpartyAccountNotFound,
        Func<TResult> onCounterpartyAddressRequired,
        Func<TResult> onCounterpartyBankTimedOut,
        Func<TResult> onCounterpartyBankUnavailable,
        Func<TResult> onDirectDebitNotSupported,
        Func<TResult> onError,
        Func<TResult> onNotEnoughBalance,
        Func<TResult> onRefusedByCounterpartyBank,
        Func<TResult> onRouteNotFound,
        Func<TResult> onTransferInstrumentDoesNotExist,
        Func<TResult> onUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AccountHierarchyNotActive => onAccountHierarchyNotActive(),
            _ when this == AmountLimitExceeded => onAmountLimitExceeded(),
            _ when this == Approved => onApproved(),
            _ when this == CounterpartyAccountBlocked => onCounterpartyAccountBlocked(),
            _ when this == CounterpartyAccountClosed => onCounterpartyAccountClosed(),
            _ when this == CounterpartyAccountNotFound => onCounterpartyAccountNotFound(),
            _ when this == CounterpartyAddressRequired => onCounterpartyAddressRequired(),
            _ when this == CounterpartyBankTimedOut => onCounterpartyBankTimedOut(),
            _ when this == CounterpartyBankUnavailable => onCounterpartyBankUnavailable(),
            _ when this == DirectDebitNotSupported => onDirectDebitNotSupported(),
            _ when this == Error => onError(),
            _ when this == NotEnoughBalance => onNotEnoughBalance(),
            _ when this == RefusedByCounterpartyBank => onRefusedByCounterpartyBank(),
            _ when this == RouteNotFound => onRouteNotFound(),
            _ when this == TransferInstrumentDoesNotExist => onTransferInstrumentDoesNotExist(),
            _ when this == Unknown => onUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccountHierarchyNotActive,
        Action onAmountLimitExceeded,
        Action onApproved,
        Action onCounterpartyAccountBlocked,
        Action onCounterpartyAccountClosed,
        Action onCounterpartyAccountNotFound,
        Action onCounterpartyAddressRequired,
        Action onCounterpartyBankTimedOut,
        Action onCounterpartyBankUnavailable,
        Action onDirectDebitNotSupported,
        Action onError,
        Action onNotEnoughBalance,
        Action onRefusedByCounterpartyBank,
        Action onRouteNotFound,
        Action onTransferInstrumentDoesNotExist,
        Action onUnknown,
        Action<string> otherwise)
    {
        if (this == AccountHierarchyNotActive) onAccountHierarchyNotActive();
        else if (this == AmountLimitExceeded) onAmountLimitExceeded();
        else if (this == Approved) onApproved();
        else if (this == CounterpartyAccountBlocked) onCounterpartyAccountBlocked();
        else if (this == CounterpartyAccountClosed) onCounterpartyAccountClosed();
        else if (this == CounterpartyAccountNotFound) onCounterpartyAccountNotFound();
        else if (this == CounterpartyAddressRequired) onCounterpartyAddressRequired();
        else if (this == CounterpartyBankTimedOut) onCounterpartyBankTimedOut();
        else if (this == CounterpartyBankUnavailable) onCounterpartyBankUnavailable();
        else if (this == DirectDebitNotSupported) onDirectDebitNotSupported();
        else if (this == Error) onError();
        else if (this == NotEnoughBalance) onNotEnoughBalance();
        else if (this == RefusedByCounterpartyBank) onRefusedByCounterpartyBank();
        else if (this == RouteNotFound) onRouteNotFound();
        else if (this == TransferInstrumentDoesNotExist) onTransferInstrumentDoesNotExist();
        else if (this == Unknown) onUnknown();
        else otherwise(Value);
    }
}
