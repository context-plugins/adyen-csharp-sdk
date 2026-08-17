using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Additional information about the status of the transfer.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Reason2>))]
public sealed record Reason2 : StringEnum<Reason2>
{
    private Reason2(string value) : base(value)
    {
    }

    public static readonly Reason2 AccountHierarchyNotActive = new("accountHierarchyNotActive");

    public static readonly Reason2 AmountLimitExceeded = new("amountLimitExceeded");

    public static readonly Reason2 ApprovalExpired = new("approvalExpired");

    public static readonly Reason2 Approved = new("approved");

    public static readonly Reason2 AvsDeclined = new("avsDeclined");

    public static readonly Reason2 BalanceAccountTemporarilyBlockedByTransactionRule = new("balanceAccountTemporarilyBlockedByTransactionRule");

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

    public static Reason2 FromValue(string value) => FromValueCore(value);
}
