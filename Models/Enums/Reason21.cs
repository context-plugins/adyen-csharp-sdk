using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Additional information about the status of the transfer.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Reason21>))]
public sealed record Reason21 : StringEnum<Reason21>
{
    private Reason21(string value) : base(value)
    {
    }

    public static readonly Reason21 AccountHierarchyNotActive = new("accountHierarchyNotActive");

    public static readonly Reason21 AmountLimitExceeded = new("amountLimitExceeded");

    public static readonly Reason21 ApprovalExpired = new("approvalExpired");

    public static readonly Reason21 Approved = new("approved");

    public static readonly Reason21 AvsDeclined = new("avsDeclined");

    public static readonly Reason21 BalanceAccountTemporarilyBlockedByTransactionRule = new("balanceAccountTemporarilyBlockedByTransactionRule");

    public static readonly Reason21 BlockCard = new("blockCard");

    public static readonly Reason21 CallReferral = new("callReferral");

    public static readonly Reason21 Cancelled = new("cancelled");

    public static readonly Reason21 CaptureCard = new("captureCard");

    public static readonly Reason21 CardExpired = new("cardExpired");

    public static readonly Reason21 CardholderAuthenticationRequired = new("cardholderAuthenticationRequired");

    public static readonly Reason21 CashbackAmountExceedsLimit = new("cashbackAmountExceedsLimit");

    public static readonly Reason21 CavvDeclined = new("cavvDeclined");

    public static readonly Reason21 ContactlessFallback = new("contactlessFallback");

    public static readonly Reason21 ContactlessLimitReached = new("contactlessLimitReached");

    public static readonly Reason21 CounterpartyAccountBlocked = new("counterpartyAccountBlocked");

    public static readonly Reason21 CounterpartyAccountClosed = new("counterpartyAccountClosed");

    public static readonly Reason21 CounterpartyAccountNotFound = new("counterpartyAccountNotFound");

    public static readonly Reason21 CounterpartyAddressRequired = new("counterpartyAddressRequired");

    public static readonly Reason21 CounterpartyBankTimedOut = new("counterpartyBankTimedOut");

    public static readonly Reason21 CounterpartyBankUnavailable = new("counterpartyBankUnavailable");

    public static readonly Reason21 CryptographicFailure = new("cryptographicFailure");

    public static readonly Reason21 CvcDeclined = new("cvcDeclined");

    public static readonly Reason21 Declined = new("declined");

    public static readonly Reason21 DeclinedByBapValidation = new("declinedByBapValidation");

    public static readonly Reason21 DeclinedByTransactionRule = new("declinedByTransactionRule");

    public static readonly Reason21 DeclinedNonGeneric = new("declinedNonGeneric");

    public static readonly Reason21 DirectDebitNotSupported = new("directDebitNotSupported");

    public static readonly Reason21 DoNotHonor = new("doNotHonor");

    public static readonly Reason21 DomesticDebitTransactionNotAllowed = new("domesticDebitTransactionNotAllowed");

    public static readonly Reason21 DuplicateTransmissionDetected = new("duplicateTransmissionDetected");

    public static readonly Reason21 Error = new("error");

    public static readonly Reason21 FormatError = new("formatError");

    public static readonly Reason21 Fraud = new("fraud");

    public static readonly Reason21 FraudCancelled = new("fraudCancelled");

    public static readonly Reason21 HonorWithId = new("honorWithId");

    public static readonly Reason21 InternalTimeout = new("internalTimeout");

    public static readonly Reason21 InvalidAccount = new("invalidAccount");

    public static readonly Reason21 InvalidAmount = new("invalidAmount");

    public static readonly Reason21 InvalidAuthorizationLifeCycle = new("invalidAuthorizationLifeCycle");

    public static readonly Reason21 InvalidCard = new("invalidCard");

    public static readonly Reason21 InvalidExpiryDate = new("invalidExpiryDate");

    public static readonly Reason21 InvalidFromAccount = new("invalidFromAccount");

    public static readonly Reason21 InvalidIssuer = new("invalidIssuer");

    public static readonly Reason21 InvalidMerchant = new("invalidMerchant");

    public static readonly Reason21 InvalidPin = new("invalidPin");

    public static readonly Reason21 InvalidToAccount = new("invalidToAccount");

    public static readonly Reason21 InvalidTransaction = new("invalidTransaction");

    public static readonly Reason21 IssuerSuspectedFraud = new("issuerSuspectedFraud");

    public static readonly Reason21 LostCard = new("lostCard");

    public static readonly Reason21 MobilePinRequired = new("mobilePinRequired");

    public static readonly Reason21 NoCheckingAccount = new("noCheckingAccount");

    public static readonly Reason21 NoSavingsAccount = new("noSavingsAccount");

    public static readonly Reason21 Not3DAuthenticated = new("not3dAuthenticated");

    public static readonly Reason21 NotEnoughBalance = new("notEnoughBalance");

    public static readonly Reason21 NotSubmitted = new("notSubmitted");

    public static readonly Reason21 NotSupported = new("notSupported");

    public static readonly Reason21 PartiallyApproved = new("partiallyApproved");

    public static readonly Reason21 Pending = new("pending");

    public static readonly Reason21 PendingApproval = new("pendingApproval");

    public static readonly Reason21 PendingExecution = new("pendingExecution");

    public static readonly Reason21 PinNotChanged = new("pinNotChanged");

    public static readonly Reason21 PinRequired = new("pinRequired");

    public static readonly Reason21 PinTriesExceeded = new("pinTriesExceeded");

    public static readonly Reason21 PinValidationNotPossible = new("pinValidationNotPossible");

    public static readonly Reason21 PurchaseAmountOnlyNoCashBack = new("purchaseAmountOnlyNoCashBack");

    public static readonly Reason21 RefusedByCounterpartyBank = new("refusedByCounterpartyBank");

    public static readonly Reason21 RefusedByCustomer = new("refusedByCustomer");

    public static readonly Reason21 RestrictedCard = new("restrictedCard");

    public static readonly Reason21 RevocationOfAuth = new("revocationOfAuth");

    public static readonly Reason21 RouteNotFound = new("routeNotFound");

    public static readonly Reason21 ScaAuthenticationRequired = new("scaAuthenticationRequired");

    public static readonly Reason21 ScaFailed = new("scaFailed");

    public static readonly Reason21 SchemeAdvice = new("schemeAdvice");

    public static readonly Reason21 SecurityViolation = new("securityViolation");

    public static readonly Reason21 ShopperCancelled = new("shopperCancelled");

    public static readonly Reason21 StolenCard = new("stolenCard");

    public static readonly Reason21 ThreedsDynamicLinkingMismatch = new("threedsDynamicLinkingMismatch");

    public static readonly Reason21 TransactionNotPermitted = new("transactionNotPermitted");

    public static readonly Reason21 TransferInstrumentDoesNotExist = new("transferInstrumentDoesNotExist");

    public static readonly Reason21 UnableToRouteTransaction = new("unableToRouteTransaction");

    public static readonly Reason21 Unknown = new("unknown");

    public static readonly Reason21 WithdrawalAmountExceeded = new("withdrawalAmountExceeded");

    public static readonly Reason21 WithdrawalCountExceeded = new("withdrawalCountExceeded");

    public static Reason21 FromValue(string value) => FromValueCore(value);
}
