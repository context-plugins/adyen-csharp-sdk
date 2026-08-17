using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The reason for the transfer status.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Reason1>))]
public sealed record Reason1 : StringEnum<Reason1>
{
    private Reason1(string value) : base(value)
    {
    }

    public static readonly Reason1 AccountHierarchyNotActive = new("accountHierarchyNotActive");

    public static readonly Reason1 AmountLimitExceeded = new("amountLimitExceeded");

    public static readonly Reason1 ApprovalExpired = new("approvalExpired");

    public static readonly Reason1 Approved = new("approved");

    public static readonly Reason1 AvsDeclined = new("avsDeclined");

    public static readonly Reason1 BalanceAccountTemporarilyBlockedByTransactionRule = new("balanceAccountTemporarilyBlockedByTransactionRule");

    public static readonly Reason1 BlockCard = new("blockCard");

    public static readonly Reason1 CallReferral = new("callReferral");

    public static readonly Reason1 Cancelled = new("cancelled");

    public static readonly Reason1 CaptureCard = new("captureCard");

    public static readonly Reason1 CardExpired = new("cardExpired");

    public static readonly Reason1 CardholderAuthenticationRequired = new("cardholderAuthenticationRequired");

    public static readonly Reason1 CashbackAmountExceedsLimit = new("cashbackAmountExceedsLimit");

    public static readonly Reason1 CavvDeclined = new("cavvDeclined");

    public static readonly Reason1 ContactlessFallback = new("contactlessFallback");

    public static readonly Reason1 ContactlessLimitReached = new("contactlessLimitReached");

    public static readonly Reason1 CounterpartyAccountBlocked = new("counterpartyAccountBlocked");

    public static readonly Reason1 CounterpartyAccountClosed = new("counterpartyAccountClosed");

    public static readonly Reason1 CounterpartyAccountNotFound = new("counterpartyAccountNotFound");

    public static readonly Reason1 CounterpartyAddressRequired = new("counterpartyAddressRequired");

    public static readonly Reason1 CounterpartyBankTimedOut = new("counterpartyBankTimedOut");

    public static readonly Reason1 CounterpartyBankUnavailable = new("counterpartyBankUnavailable");

    public static readonly Reason1 CryptographicFailure = new("cryptographicFailure");

    public static readonly Reason1 CvcDeclined = new("cvcDeclined");

    public static readonly Reason1 Declined = new("declined");

    public static readonly Reason1 DeclinedByBapValidation = new("declinedByBapValidation");

    public static readonly Reason1 DeclinedByTransactionRule = new("declinedByTransactionRule");

    public static readonly Reason1 DeclinedNonGeneric = new("declinedNonGeneric");

    public static readonly Reason1 DirectDebitNotSupported = new("directDebitNotSupported");

    public static readonly Reason1 DoNotHonor = new("doNotHonor");

    public static readonly Reason1 DomesticDebitTransactionNotAllowed = new("domesticDebitTransactionNotAllowed");

    public static readonly Reason1 DuplicateTransmissionDetected = new("duplicateTransmissionDetected");

    public static readonly Reason1 Error = new("error");

    public static readonly Reason1 FormatError = new("formatError");

    public static readonly Reason1 Fraud = new("fraud");

    public static readonly Reason1 FraudCancelled = new("fraudCancelled");

    public static readonly Reason1 HonorWithId = new("honorWithId");

    public static readonly Reason1 InternalTimeout = new("internalTimeout");

    public static readonly Reason1 InvalidAccount = new("invalidAccount");

    public static readonly Reason1 InvalidAmount = new("invalidAmount");

    public static readonly Reason1 InvalidAuthorizationLifeCycle = new("invalidAuthorizationLifeCycle");

    public static readonly Reason1 InvalidCard = new("invalidCard");

    public static readonly Reason1 InvalidExpiryDate = new("invalidExpiryDate");

    public static readonly Reason1 InvalidFromAccount = new("invalidFromAccount");

    public static readonly Reason1 InvalidIssuer = new("invalidIssuer");

    public static readonly Reason1 InvalidMerchant = new("invalidMerchant");

    public static readonly Reason1 InvalidPin = new("invalidPin");

    public static readonly Reason1 InvalidToAccount = new("invalidToAccount");

    public static readonly Reason1 InvalidTransaction = new("invalidTransaction");

    public static readonly Reason1 IssuerSuspectedFraud = new("issuerSuspectedFraud");

    public static readonly Reason1 LostCard = new("lostCard");

    public static readonly Reason1 MobilePinRequired = new("mobilePinRequired");

    public static readonly Reason1 NoCheckingAccount = new("noCheckingAccount");

    public static readonly Reason1 NoSavingsAccount = new("noSavingsAccount");

    public static readonly Reason1 Not3DAuthenticated = new("not3dAuthenticated");

    public static readonly Reason1 NotEnoughBalance = new("notEnoughBalance");

    public static readonly Reason1 NotSubmitted = new("notSubmitted");

    public static readonly Reason1 NotSupported = new("notSupported");

    public static readonly Reason1 PartiallyApproved = new("partiallyApproved");

    public static readonly Reason1 Pending = new("pending");

    public static readonly Reason1 PendingApproval = new("pendingApproval");

    public static readonly Reason1 PendingExecution = new("pendingExecution");

    public static readonly Reason1 PinNotChanged = new("pinNotChanged");

    public static readonly Reason1 PinRequired = new("pinRequired");

    public static readonly Reason1 PinTriesExceeded = new("pinTriesExceeded");

    public static readonly Reason1 PinValidationNotPossible = new("pinValidationNotPossible");

    public static readonly Reason1 PurchaseAmountOnlyNoCashBack = new("purchaseAmountOnlyNoCashBack");

    public static readonly Reason1 RefusedByCounterpartyBank = new("refusedByCounterpartyBank");

    public static readonly Reason1 RefusedByCustomer = new("refusedByCustomer");

    public static readonly Reason1 RestrictedCard = new("restrictedCard");

    public static readonly Reason1 RevocationOfAuth = new("revocationOfAuth");

    public static readonly Reason1 RouteNotFound = new("routeNotFound");

    public static readonly Reason1 ScaAuthenticationRequired = new("scaAuthenticationRequired");

    public static readonly Reason1 ScaFailed = new("scaFailed");

    public static readonly Reason1 SchemeAdvice = new("schemeAdvice");

    public static readonly Reason1 SecurityViolation = new("securityViolation");

    public static readonly Reason1 ShopperCancelled = new("shopperCancelled");

    public static readonly Reason1 StolenCard = new("stolenCard");

    public static readonly Reason1 ThreedsDynamicLinkingMismatch = new("threedsDynamicLinkingMismatch");

    public static readonly Reason1 TransactionNotPermitted = new("transactionNotPermitted");

    public static readonly Reason1 TransferInstrumentDoesNotExist = new("transferInstrumentDoesNotExist");

    public static readonly Reason1 UnableToRouteTransaction = new("unableToRouteTransaction");

    public static readonly Reason1 Unknown = new("unknown");

    public static readonly Reason1 WithdrawalAmountExceeded = new("withdrawalAmountExceeded");

    public static readonly Reason1 WithdrawalCountExceeded = new("withdrawalCountExceeded");

    public static Reason1 FromValue(string value) => FromValueCore(value);
}
