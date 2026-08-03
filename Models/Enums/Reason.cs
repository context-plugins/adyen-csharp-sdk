using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The reason for disabling the sweep.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Reason>))]
public sealed record Reason : StringEnum<Reason>
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

    public static Reason FromValue(string value) => FromValueCore(value);
}
