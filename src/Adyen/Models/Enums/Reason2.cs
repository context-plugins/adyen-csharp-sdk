using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Additional information about the status of the transfer.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Reason2>))]
public sealed record Reason2 : OpenStringEnum<Reason2>
{
    private Reason2(string value) : base(value)
    {
    }

    public static readonly Reason2 AccountHierarchyNotActive = new("accountHierarchyNotActive");

    public static readonly Reason2 AmountLimitExceeded = new("amountLimitExceeded");

    public static readonly Reason2 ApprovalExpired = new("approvalExpired");

    public static readonly Reason2 Approved = new("approved");

    public static readonly Reason2 AvsDeclined = new("avsDeclined");

    public static readonly Reason2 BalanceAccountTemporarilyBlockedByTransactionRule = new(
        "balanceAccountTemporarilyBlockedByTransactionRule");

    public static readonly Reason2 BlockCard = new("blockCard");

    public static readonly Reason2 CallReferral = new("callReferral");

    public static readonly Reason2 Cancelled = new("cancelled");

    public static readonly Reason2 CaptureCard = new("captureCard");

    public static readonly Reason2 CardExpired = new("cardExpired");

    public static readonly Reason2 CardholderAuthenticationRequired = new("cardholderAuthenticationRequired");

    public static readonly Reason2 CashbackAmountExceedsLimit = new("cashbackAmountExceedsLimit");

    public static readonly Reason2 CavvDeclined = new("cavvDeclined");

    public static readonly Reason2 ContactlessFallback = new("contactlessFallback");

    public static readonly Reason2 ContactlessLimitReached = new("contactlessLimitReached");

    public static readonly Reason2 CounterpartyAccountBlocked = new("counterpartyAccountBlocked");

    public static readonly Reason2 CounterpartyAccountClosed = new("counterpartyAccountClosed");

    public static readonly Reason2 CounterpartyAccountNotFound = new("counterpartyAccountNotFound");

    public static readonly Reason2 CounterpartyAddressRequired = new("counterpartyAddressRequired");

    public static readonly Reason2 CounterpartyBankTimedOut = new("counterpartyBankTimedOut");

    public static readonly Reason2 CounterpartyBankUnavailable = new("counterpartyBankUnavailable");

    public static readonly Reason2 CryptographicFailure = new("cryptographicFailure");

    public static readonly Reason2 CvcDeclined = new("cvcDeclined");

    public static readonly Reason2 Declined = new("declined");

    public static readonly Reason2 DeclinedByBapValidation = new("declinedByBapValidation");

    public static readonly Reason2 DeclinedByTransactionRule = new("declinedByTransactionRule");

    public static readonly Reason2 DeclinedNonGeneric = new("declinedNonGeneric");

    public static readonly Reason2 DirectDebitNotSupported = new("directDebitNotSupported");

    public static readonly Reason2 DoNotHonor = new("doNotHonor");

    public static readonly Reason2 DomesticDebitTransactionNotAllowed = new("domesticDebitTransactionNotAllowed");

    public static readonly Reason2 DuplicateTransmissionDetected = new("duplicateTransmissionDetected");

    public static readonly Reason2 Error = new("error");

    public static readonly Reason2 FormatError = new("formatError");

    public static readonly Reason2 Fraud = new("fraud");

    public static readonly Reason2 FraudCancelled = new("fraudCancelled");

    public static readonly Reason2 HonorWithId = new("honorWithId");

    public static readonly Reason2 InternalTimeout = new("internalTimeout");

    public static readonly Reason2 InvalidAccount = new("invalidAccount");

    public static readonly Reason2 InvalidAmount = new("invalidAmount");

    public static readonly Reason2 InvalidAuthorizationLifeCycle = new("invalidAuthorizationLifeCycle");

    public static readonly Reason2 InvalidCard = new("invalidCard");

    public static readonly Reason2 InvalidExpiryDate = new("invalidExpiryDate");

    public static readonly Reason2 InvalidFromAccount = new("invalidFromAccount");

    public static readonly Reason2 InvalidIssuer = new("invalidIssuer");

    public static readonly Reason2 InvalidMerchant = new("invalidMerchant");

    public static readonly Reason2 InvalidPin = new("invalidPin");

    public static readonly Reason2 InvalidToAccount = new("invalidToAccount");

    public static readonly Reason2 InvalidTransaction = new("invalidTransaction");

    public static readonly Reason2 IssuerSuspectedFraud = new("issuerSuspectedFraud");

    public static readonly Reason2 LostCard = new("lostCard");

    public static readonly Reason2 MobilePinRequired = new("mobilePinRequired");

    public static readonly Reason2 NoCheckingAccount = new("noCheckingAccount");

    public static readonly Reason2 NoSavingsAccount = new("noSavingsAccount");

    public static readonly Reason2 Not3DAuthenticated = new("not3dAuthenticated");

    public static readonly Reason2 NotEnoughBalance = new("notEnoughBalance");

    public static readonly Reason2 NotSubmitted = new("notSubmitted");

    public static readonly Reason2 NotSupported = new("notSupported");

    public static readonly Reason2 PartiallyApproved = new("partiallyApproved");

    public static readonly Reason2 Pending = new("pending");

    public static readonly Reason2 PendingApproval = new("pendingApproval");

    public static readonly Reason2 PendingExecution = new("pendingExecution");

    public static readonly Reason2 PinNotChanged = new("pinNotChanged");

    public static readonly Reason2 PinRequired = new("pinRequired");

    public static readonly Reason2 PinTriesExceeded = new("pinTriesExceeded");

    public static readonly Reason2 PinValidationNotPossible = new("pinValidationNotPossible");

    public static readonly Reason2 PurchaseAmountOnlyNoCashBack = new("purchaseAmountOnlyNoCashBack");

    public static readonly Reason2 RefusedByCounterpartyBank = new("refusedByCounterpartyBank");

    public static readonly Reason2 RefusedByCustomer = new("refusedByCustomer");

    public static readonly Reason2 RestrictedCard = new("restrictedCard");

    public static readonly Reason2 RevocationOfAuth = new("revocationOfAuth");

    public static readonly Reason2 RouteNotFound = new("routeNotFound");

    public static readonly Reason2 ScaAuthenticationRequired = new("scaAuthenticationRequired");

    public static readonly Reason2 ScaFailed = new("scaFailed");

    public static readonly Reason2 SchemeAdvice = new("schemeAdvice");

    public static readonly Reason2 SecurityViolation = new("securityViolation");

    public static readonly Reason2 ShopperCancelled = new("shopperCancelled");

    public static readonly Reason2 StolenCard = new("stolenCard");

    public static readonly Reason2 ThreedsDynamicLinkingMismatch = new("threedsDynamicLinkingMismatch");

    public static readonly Reason2 TransactionNotPermitted = new("transactionNotPermitted");

    public static readonly Reason2 TransferInstrumentDoesNotExist = new("transferInstrumentDoesNotExist");

    public static readonly Reason2 UnableToRouteTransaction = new("unableToRouteTransaction");

    public static readonly Reason2 Unknown = new("unknown");

    public static readonly Reason2 WithdrawalAmountExceeded = new("withdrawalAmountExceeded");

    public static readonly Reason2 WithdrawalCountExceeded = new("withdrawalCountExceeded");

    public TResult Match<TResult>(Func<TResult> onAccountHierarchyNotActive,
        Func<TResult> onAmountLimitExceeded,
        Func<TResult> onApprovalExpired,
        Func<TResult> onApproved,
        Func<TResult> onAvsDeclined,
        Func<TResult> onBalanceAccountTemporarilyBlockedByTransactionRule,
        Func<TResult> onBlockCard,
        Func<TResult> onCallReferral,
        Func<TResult> onCancelled,
        Func<TResult> onCaptureCard,
        Func<TResult> onCardExpired,
        Func<TResult> onCardholderAuthenticationRequired,
        Func<TResult> onCashbackAmountExceedsLimit,
        Func<TResult> onCavvDeclined,
        Func<TResult> onContactlessFallback,
        Func<TResult> onContactlessLimitReached,
        Func<TResult> onCounterpartyAccountBlocked,
        Func<TResult> onCounterpartyAccountClosed,
        Func<TResult> onCounterpartyAccountNotFound,
        Func<TResult> onCounterpartyAddressRequired,
        Func<TResult> onCounterpartyBankTimedOut,
        Func<TResult> onCounterpartyBankUnavailable,
        Func<TResult> onCryptographicFailure,
        Func<TResult> onCvcDeclined,
        Func<TResult> onDeclined,
        Func<TResult> onDeclinedByBapValidation,
        Func<TResult> onDeclinedByTransactionRule,
        Func<TResult> onDeclinedNonGeneric,
        Func<TResult> onDirectDebitNotSupported,
        Func<TResult> onDoNotHonor,
        Func<TResult> onDomesticDebitTransactionNotAllowed,
        Func<TResult> onDuplicateTransmissionDetected,
        Func<TResult> onError,
        Func<TResult> onFormatError,
        Func<TResult> onFraud,
        Func<TResult> onFraudCancelled,
        Func<TResult> onHonorWithId,
        Func<TResult> onInternalTimeout,
        Func<TResult> onInvalidAccount,
        Func<TResult> onInvalidAmount,
        Func<TResult> onInvalidAuthorizationLifeCycle,
        Func<TResult> onInvalidCard,
        Func<TResult> onInvalidExpiryDate,
        Func<TResult> onInvalidFromAccount,
        Func<TResult> onInvalidIssuer,
        Func<TResult> onInvalidMerchant,
        Func<TResult> onInvalidPin,
        Func<TResult> onInvalidToAccount,
        Func<TResult> onInvalidTransaction,
        Func<TResult> onIssuerSuspectedFraud,
        Func<TResult> onLostCard,
        Func<TResult> onMobilePinRequired,
        Func<TResult> onNoCheckingAccount,
        Func<TResult> onNoSavingsAccount,
        Func<TResult> onNot3DAuthenticated,
        Func<TResult> onNotEnoughBalance,
        Func<TResult> onNotSubmitted,
        Func<TResult> onNotSupported,
        Func<TResult> onPartiallyApproved,
        Func<TResult> onPending,
        Func<TResult> onPendingApproval,
        Func<TResult> onPendingExecution,
        Func<TResult> onPinNotChanged,
        Func<TResult> onPinRequired,
        Func<TResult> onPinTriesExceeded,
        Func<TResult> onPinValidationNotPossible,
        Func<TResult> onPurchaseAmountOnlyNoCashBack,
        Func<TResult> onRefusedByCounterpartyBank,
        Func<TResult> onRefusedByCustomer,
        Func<TResult> onRestrictedCard,
        Func<TResult> onRevocationOfAuth,
        Func<TResult> onRouteNotFound,
        Func<TResult> onScaAuthenticationRequired,
        Func<TResult> onScaFailed,
        Func<TResult> onSchemeAdvice,
        Func<TResult> onSecurityViolation,
        Func<TResult> onShopperCancelled,
        Func<TResult> onStolenCard,
        Func<TResult> onThreedsDynamicLinkingMismatch,
        Func<TResult> onTransactionNotPermitted,
        Func<TResult> onTransferInstrumentDoesNotExist,
        Func<TResult> onUnableToRouteTransaction,
        Func<TResult> onUnknown,
        Func<TResult> onWithdrawalAmountExceeded,
        Func<TResult> onWithdrawalCountExceeded,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AccountHierarchyNotActive => onAccountHierarchyNotActive(),
            _ when this == AmountLimitExceeded => onAmountLimitExceeded(),
            _ when this == ApprovalExpired => onApprovalExpired(),
            _ when this == Approved => onApproved(),
            _ when this == AvsDeclined => onAvsDeclined(),
            _ when this ==
                BalanceAccountTemporarilyBlockedByTransactionRule => onBalanceAccountTemporarilyBlockedByTransactionRule(),
            _ when this == BlockCard => onBlockCard(),
            _ when this == CallReferral => onCallReferral(),
            _ when this == Cancelled => onCancelled(),
            _ when this == CaptureCard => onCaptureCard(),
            _ when this == CardExpired => onCardExpired(),
            _ when this == CardholderAuthenticationRequired => onCardholderAuthenticationRequired(),
            _ when this == CashbackAmountExceedsLimit => onCashbackAmountExceedsLimit(),
            _ when this == CavvDeclined => onCavvDeclined(),
            _ when this == ContactlessFallback => onContactlessFallback(),
            _ when this == ContactlessLimitReached => onContactlessLimitReached(),
            _ when this == CounterpartyAccountBlocked => onCounterpartyAccountBlocked(),
            _ when this == CounterpartyAccountClosed => onCounterpartyAccountClosed(),
            _ when this == CounterpartyAccountNotFound => onCounterpartyAccountNotFound(),
            _ when this == CounterpartyAddressRequired => onCounterpartyAddressRequired(),
            _ when this == CounterpartyBankTimedOut => onCounterpartyBankTimedOut(),
            _ when this == CounterpartyBankUnavailable => onCounterpartyBankUnavailable(),
            _ when this == CryptographicFailure => onCryptographicFailure(),
            _ when this == CvcDeclined => onCvcDeclined(),
            _ when this == Declined => onDeclined(),
            _ when this == DeclinedByBapValidation => onDeclinedByBapValidation(),
            _ when this == DeclinedByTransactionRule => onDeclinedByTransactionRule(),
            _ when this == DeclinedNonGeneric => onDeclinedNonGeneric(),
            _ when this == DirectDebitNotSupported => onDirectDebitNotSupported(),
            _ when this == DoNotHonor => onDoNotHonor(),
            _ when this == DomesticDebitTransactionNotAllowed => onDomesticDebitTransactionNotAllowed(),
            _ when this == DuplicateTransmissionDetected => onDuplicateTransmissionDetected(),
            _ when this == Error => onError(),
            _ when this == FormatError => onFormatError(),
            _ when this == Fraud => onFraud(),
            _ when this == FraudCancelled => onFraudCancelled(),
            _ when this == HonorWithId => onHonorWithId(),
            _ when this == InternalTimeout => onInternalTimeout(),
            _ when this == InvalidAccount => onInvalidAccount(),
            _ when this == InvalidAmount => onInvalidAmount(),
            _ when this == InvalidAuthorizationLifeCycle => onInvalidAuthorizationLifeCycle(),
            _ when this == InvalidCard => onInvalidCard(),
            _ when this == InvalidExpiryDate => onInvalidExpiryDate(),
            _ when this == InvalidFromAccount => onInvalidFromAccount(),
            _ when this == InvalidIssuer => onInvalidIssuer(),
            _ when this == InvalidMerchant => onInvalidMerchant(),
            _ when this == InvalidPin => onInvalidPin(),
            _ when this == InvalidToAccount => onInvalidToAccount(),
            _ when this == InvalidTransaction => onInvalidTransaction(),
            _ when this == IssuerSuspectedFraud => onIssuerSuspectedFraud(),
            _ when this == LostCard => onLostCard(),
            _ when this == MobilePinRequired => onMobilePinRequired(),
            _ when this == NoCheckingAccount => onNoCheckingAccount(),
            _ when this == NoSavingsAccount => onNoSavingsAccount(),
            _ when this == Not3DAuthenticated => onNot3DAuthenticated(),
            _ when this == NotEnoughBalance => onNotEnoughBalance(),
            _ when this == NotSubmitted => onNotSubmitted(),
            _ when this == NotSupported => onNotSupported(),
            _ when this == PartiallyApproved => onPartiallyApproved(),
            _ when this == Pending => onPending(),
            _ when this == PendingApproval => onPendingApproval(),
            _ when this == PendingExecution => onPendingExecution(),
            _ when this == PinNotChanged => onPinNotChanged(),
            _ when this == PinRequired => onPinRequired(),
            _ when this == PinTriesExceeded => onPinTriesExceeded(),
            _ when this == PinValidationNotPossible => onPinValidationNotPossible(),
            _ when this == PurchaseAmountOnlyNoCashBack => onPurchaseAmountOnlyNoCashBack(),
            _ when this == RefusedByCounterpartyBank => onRefusedByCounterpartyBank(),
            _ when this == RefusedByCustomer => onRefusedByCustomer(),
            _ when this == RestrictedCard => onRestrictedCard(),
            _ when this == RevocationOfAuth => onRevocationOfAuth(),
            _ when this == RouteNotFound => onRouteNotFound(),
            _ when this == ScaAuthenticationRequired => onScaAuthenticationRequired(),
            _ when this == ScaFailed => onScaFailed(),
            _ when this == SchemeAdvice => onSchemeAdvice(),
            _ when this == SecurityViolation => onSecurityViolation(),
            _ when this == ShopperCancelled => onShopperCancelled(),
            _ when this == StolenCard => onStolenCard(),
            _ when this == ThreedsDynamicLinkingMismatch => onThreedsDynamicLinkingMismatch(),
            _ when this == TransactionNotPermitted => onTransactionNotPermitted(),
            _ when this == TransferInstrumentDoesNotExist => onTransferInstrumentDoesNotExist(),
            _ when this == UnableToRouteTransaction => onUnableToRouteTransaction(),
            _ when this == Unknown => onUnknown(),
            _ when this == WithdrawalAmountExceeded => onWithdrawalAmountExceeded(),
            _ when this == WithdrawalCountExceeded => onWithdrawalCountExceeded(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccountHierarchyNotActive,
        Action onAmountLimitExceeded,
        Action onApprovalExpired,
        Action onApproved,
        Action onAvsDeclined,
        Action onBalanceAccountTemporarilyBlockedByTransactionRule,
        Action onBlockCard,
        Action onCallReferral,
        Action onCancelled,
        Action onCaptureCard,
        Action onCardExpired,
        Action onCardholderAuthenticationRequired,
        Action onCashbackAmountExceedsLimit,
        Action onCavvDeclined,
        Action onContactlessFallback,
        Action onContactlessLimitReached,
        Action onCounterpartyAccountBlocked,
        Action onCounterpartyAccountClosed,
        Action onCounterpartyAccountNotFound,
        Action onCounterpartyAddressRequired,
        Action onCounterpartyBankTimedOut,
        Action onCounterpartyBankUnavailable,
        Action onCryptographicFailure,
        Action onCvcDeclined,
        Action onDeclined,
        Action onDeclinedByBapValidation,
        Action onDeclinedByTransactionRule,
        Action onDeclinedNonGeneric,
        Action onDirectDebitNotSupported,
        Action onDoNotHonor,
        Action onDomesticDebitTransactionNotAllowed,
        Action onDuplicateTransmissionDetected,
        Action onError,
        Action onFormatError,
        Action onFraud,
        Action onFraudCancelled,
        Action onHonorWithId,
        Action onInternalTimeout,
        Action onInvalidAccount,
        Action onInvalidAmount,
        Action onInvalidAuthorizationLifeCycle,
        Action onInvalidCard,
        Action onInvalidExpiryDate,
        Action onInvalidFromAccount,
        Action onInvalidIssuer,
        Action onInvalidMerchant,
        Action onInvalidPin,
        Action onInvalidToAccount,
        Action onInvalidTransaction,
        Action onIssuerSuspectedFraud,
        Action onLostCard,
        Action onMobilePinRequired,
        Action onNoCheckingAccount,
        Action onNoSavingsAccount,
        Action onNot3DAuthenticated,
        Action onNotEnoughBalance,
        Action onNotSubmitted,
        Action onNotSupported,
        Action onPartiallyApproved,
        Action onPending,
        Action onPendingApproval,
        Action onPendingExecution,
        Action onPinNotChanged,
        Action onPinRequired,
        Action onPinTriesExceeded,
        Action onPinValidationNotPossible,
        Action onPurchaseAmountOnlyNoCashBack,
        Action onRefusedByCounterpartyBank,
        Action onRefusedByCustomer,
        Action onRestrictedCard,
        Action onRevocationOfAuth,
        Action onRouteNotFound,
        Action onScaAuthenticationRequired,
        Action onScaFailed,
        Action onSchemeAdvice,
        Action onSecurityViolation,
        Action onShopperCancelled,
        Action onStolenCard,
        Action onThreedsDynamicLinkingMismatch,
        Action onTransactionNotPermitted,
        Action onTransferInstrumentDoesNotExist,
        Action onUnableToRouteTransaction,
        Action onUnknown,
        Action onWithdrawalAmountExceeded,
        Action onWithdrawalCountExceeded,
        Action<string> otherwise)
    {
        if (this == AccountHierarchyNotActive) onAccountHierarchyNotActive();
        else if (this == AmountLimitExceeded) onAmountLimitExceeded();
        else if (this == ApprovalExpired) onApprovalExpired();
        else if (this == Approved) onApproved();
        else if (this == AvsDeclined) onAvsDeclined();
        else if (this ==
            BalanceAccountTemporarilyBlockedByTransactionRule) onBalanceAccountTemporarilyBlockedByTransactionRule();
        else if (this == BlockCard) onBlockCard();
        else if (this == CallReferral) onCallReferral();
        else if (this == Cancelled) onCancelled();
        else if (this == CaptureCard) onCaptureCard();
        else if (this == CardExpired) onCardExpired();
        else if (this == CardholderAuthenticationRequired) onCardholderAuthenticationRequired();
        else if (this == CashbackAmountExceedsLimit) onCashbackAmountExceedsLimit();
        else if (this == CavvDeclined) onCavvDeclined();
        else if (this == ContactlessFallback) onContactlessFallback();
        else if (this == ContactlessLimitReached) onContactlessLimitReached();
        else if (this == CounterpartyAccountBlocked) onCounterpartyAccountBlocked();
        else if (this == CounterpartyAccountClosed) onCounterpartyAccountClosed();
        else if (this == CounterpartyAccountNotFound) onCounterpartyAccountNotFound();
        else if (this == CounterpartyAddressRequired) onCounterpartyAddressRequired();
        else if (this == CounterpartyBankTimedOut) onCounterpartyBankTimedOut();
        else if (this == CounterpartyBankUnavailable) onCounterpartyBankUnavailable();
        else if (this == CryptographicFailure) onCryptographicFailure();
        else if (this == CvcDeclined) onCvcDeclined();
        else if (this == Declined) onDeclined();
        else if (this == DeclinedByBapValidation) onDeclinedByBapValidation();
        else if (this == DeclinedByTransactionRule) onDeclinedByTransactionRule();
        else if (this == DeclinedNonGeneric) onDeclinedNonGeneric();
        else if (this == DirectDebitNotSupported) onDirectDebitNotSupported();
        else if (this == DoNotHonor) onDoNotHonor();
        else if (this == DomesticDebitTransactionNotAllowed) onDomesticDebitTransactionNotAllowed();
        else if (this == DuplicateTransmissionDetected) onDuplicateTransmissionDetected();
        else if (this == Error) onError();
        else if (this == FormatError) onFormatError();
        else if (this == Fraud) onFraud();
        else if (this == FraudCancelled) onFraudCancelled();
        else if (this == HonorWithId) onHonorWithId();
        else if (this == InternalTimeout) onInternalTimeout();
        else if (this == InvalidAccount) onInvalidAccount();
        else if (this == InvalidAmount) onInvalidAmount();
        else if (this == InvalidAuthorizationLifeCycle) onInvalidAuthorizationLifeCycle();
        else if (this == InvalidCard) onInvalidCard();
        else if (this == InvalidExpiryDate) onInvalidExpiryDate();
        else if (this == InvalidFromAccount) onInvalidFromAccount();
        else if (this == InvalidIssuer) onInvalidIssuer();
        else if (this == InvalidMerchant) onInvalidMerchant();
        else if (this == InvalidPin) onInvalidPin();
        else if (this == InvalidToAccount) onInvalidToAccount();
        else if (this == InvalidTransaction) onInvalidTransaction();
        else if (this == IssuerSuspectedFraud) onIssuerSuspectedFraud();
        else if (this == LostCard) onLostCard();
        else if (this == MobilePinRequired) onMobilePinRequired();
        else if (this == NoCheckingAccount) onNoCheckingAccount();
        else if (this == NoSavingsAccount) onNoSavingsAccount();
        else if (this == Not3DAuthenticated) onNot3DAuthenticated();
        else if (this == NotEnoughBalance) onNotEnoughBalance();
        else if (this == NotSubmitted) onNotSubmitted();
        else if (this == NotSupported) onNotSupported();
        else if (this == PartiallyApproved) onPartiallyApproved();
        else if (this == Pending) onPending();
        else if (this == PendingApproval) onPendingApproval();
        else if (this == PendingExecution) onPendingExecution();
        else if (this == PinNotChanged) onPinNotChanged();
        else if (this == PinRequired) onPinRequired();
        else if (this == PinTriesExceeded) onPinTriesExceeded();
        else if (this == PinValidationNotPossible) onPinValidationNotPossible();
        else if (this == PurchaseAmountOnlyNoCashBack) onPurchaseAmountOnlyNoCashBack();
        else if (this == RefusedByCounterpartyBank) onRefusedByCounterpartyBank();
        else if (this == RefusedByCustomer) onRefusedByCustomer();
        else if (this == RestrictedCard) onRestrictedCard();
        else if (this == RevocationOfAuth) onRevocationOfAuth();
        else if (this == RouteNotFound) onRouteNotFound();
        else if (this == ScaAuthenticationRequired) onScaAuthenticationRequired();
        else if (this == ScaFailed) onScaFailed();
        else if (this == SchemeAdvice) onSchemeAdvice();
        else if (this == SecurityViolation) onSecurityViolation();
        else if (this == ShopperCancelled) onShopperCancelled();
        else if (this == StolenCard) onStolenCard();
        else if (this == ThreedsDynamicLinkingMismatch) onThreedsDynamicLinkingMismatch();
        else if (this == TransactionNotPermitted) onTransactionNotPermitted();
        else if (this == TransferInstrumentDoesNotExist) onTransferInstrumentDoesNotExist();
        else if (this == UnableToRouteTransaction) onUnableToRouteTransaction();
        else if (this == Unknown) onUnknown();
        else if (this == WithdrawalAmountExceeded) onWithdrawalAmountExceeded();
        else if (this == WithdrawalCountExceeded) onWithdrawalCountExceeded();
        else otherwise(Value);
    }
}
