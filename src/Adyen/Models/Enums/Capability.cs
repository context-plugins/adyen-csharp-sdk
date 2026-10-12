using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Capability>))]
public sealed record Capability : OpenStringEnum<Capability>
{
    private Capability(string value) : base(value)
    {
    }

    public static readonly Capability AcceptExternalFunding = new("acceptExternalFunding");

    public static readonly Capability AcceptPspFunding = new("acceptPspFunding");

    public static readonly Capability AcceptTransactionInRestrictedCountries = new(
        "acceptTransactionInRestrictedCountries");

    public static readonly Capability AcceptTransactionInRestrictedCountriesCommercial = new(
        "acceptTransactionInRestrictedCountriesCommercial");

    public static readonly Capability AcceptTransactionInRestrictedCountriesConsumer = new(
        "acceptTransactionInRestrictedCountriesConsumer");

    public static readonly Capability AcceptTransactionInRestrictedIndustries = new(
        "acceptTransactionInRestrictedIndustries");

    public static readonly Capability AcceptTransactionInRestrictedIndustriesCommercial = new(
        "acceptTransactionInRestrictedIndustriesCommercial");

    public static readonly Capability AcceptTransactionInRestrictedIndustriesConsumer = new(
        "acceptTransactionInRestrictedIndustriesConsumer");

    public static readonly Capability Acquiring = new("acquiring");

    public static readonly Capability AtmWithdrawal = new("atmWithdrawal");

    public static readonly Capability AtmWithdrawalCommercial = new("atmWithdrawalCommercial");

    public static readonly Capability AtmWithdrawalConsumer = new("atmWithdrawalConsumer");

    public static readonly Capability AtmWithdrawalInRestrictedCountries = new("atmWithdrawalInRestrictedCountries");

    public static readonly Capability AtmWithdrawalInRestrictedCountriesCommercial = new(
        "atmWithdrawalInRestrictedCountriesCommercial");

    public static readonly Capability AtmWithdrawalInRestrictedCountriesConsumer = new(
        "atmWithdrawalInRestrictedCountriesConsumer");

    public static readonly Capability AuthorisedPaymentInstrumentUser = new("authorisedPaymentInstrumentUser");

    public static readonly Capability GetGrantOffers = new("getGrantOffers");

    public static readonly Capability IssueBankAccount = new("issueBankAccount");

    public static readonly Capability IssueCard = new("issueCard");

    public static readonly Capability IssueCardCommercial = new("issueCardCommercial");

    public static readonly Capability IssueCardConsumer = new("issueCardConsumer");

    public static readonly Capability IssueChargeCard = new("issueChargeCard");

    public static readonly Capability IssueChargeCardCommercial = new("issueChargeCardCommercial");

    public static readonly Capability IssueCreditLimit = new("issueCreditLimit");

    public static readonly Capability LocalAcceptance = new("localAcceptance");

    public static readonly Capability Payout = new("payout");

    public static readonly Capability PayoutToTransferInstrument = new("payoutToTransferInstrument");

    public static readonly Capability Processing = new("processing");

    public static readonly Capability ReceiveFromBalanceAccount = new("receiveFromBalanceAccount");

    public static readonly Capability ReceiveFromPlatformPayments = new("receiveFromPlatformPayments");

    public static readonly Capability ReceiveFromThirdParty = new("receiveFromThirdParty");

    public static readonly Capability ReceiveFromTransferInstrument = new("receiveFromTransferInstrument");

    public static readonly Capability ReceiveGrants = new("receiveGrants");

    public static readonly Capability ReceivePayments = new("receivePayments");

    public static readonly Capability SendToBalanceAccount = new("sendToBalanceAccount");

    public static readonly Capability SendToThirdParty = new("sendToThirdParty");

    public static readonly Capability SendToTransferInstrument = new("sendToTransferInstrument");

    public static readonly Capability ThirdPartyFunding = new("thirdPartyFunding");

    public static readonly Capability UseCard = new("useCard");

    public static readonly Capability UseCardCommercial = new("useCardCommercial");

    public static readonly Capability UseCardConsumer = new("useCardConsumer");

    public static readonly Capability UseCardInRestrictedCountries = new("useCardInRestrictedCountries");

    public static readonly Capability UseCardInRestrictedCountriesCommercial = new(
        "useCardInRestrictedCountriesCommercial");

    public static readonly Capability UseCardInRestrictedCountriesConsumer = new(
        "useCardInRestrictedCountriesConsumer");

    public static readonly Capability UseCardInRestrictedIndustries = new("useCardInRestrictedIndustries");

    public static readonly Capability UseCardInRestrictedIndustriesCommercial = new(
        "useCardInRestrictedIndustriesCommercial");

    public static readonly Capability UseCardInRestrictedIndustriesConsumer = new(
        "useCardInRestrictedIndustriesConsumer");

    public static readonly Capability UseChargeCard = new("useChargeCard");

    public static readonly Capability UseChargeCardCommercial = new("useChargeCardCommercial");

    public static readonly Capability WithdrawFromAtm = new("withdrawFromAtm");

    public static readonly Capability WithdrawFromAtmCommercial = new("withdrawFromAtmCommercial");

    public static readonly Capability WithdrawFromAtmConsumer = new("withdrawFromAtmConsumer");

    public static readonly Capability WithdrawFromAtmInRestrictedCountries = new(
        "withdrawFromAtmInRestrictedCountries");

    public static readonly Capability WithdrawFromAtmInRestrictedCountriesCommercial = new(
        "withdrawFromAtmInRestrictedCountriesCommercial");

    public static readonly Capability WithdrawFromAtmInRestrictedCountriesConsumer = new(
        "withdrawFromAtmInRestrictedCountriesConsumer");

    public TResult Match<TResult>(Func<TResult> onAcceptExternalFunding,
        Func<TResult> onAcceptPspFunding,
        Func<TResult> onAcceptTransactionInRestrictedCountries,
        Func<TResult> onAcceptTransactionInRestrictedCountriesCommercial,
        Func<TResult> onAcceptTransactionInRestrictedCountriesConsumer,
        Func<TResult> onAcceptTransactionInRestrictedIndustries,
        Func<TResult> onAcceptTransactionInRestrictedIndustriesCommercial,
        Func<TResult> onAcceptTransactionInRestrictedIndustriesConsumer,
        Func<TResult> onAcquiring,
        Func<TResult> onAtmWithdrawal,
        Func<TResult> onAtmWithdrawalCommercial,
        Func<TResult> onAtmWithdrawalConsumer,
        Func<TResult> onAtmWithdrawalInRestrictedCountries,
        Func<TResult> onAtmWithdrawalInRestrictedCountriesCommercial,
        Func<TResult> onAtmWithdrawalInRestrictedCountriesConsumer,
        Func<TResult> onAuthorisedPaymentInstrumentUser,
        Func<TResult> onGetGrantOffers,
        Func<TResult> onIssueBankAccount,
        Func<TResult> onIssueCard,
        Func<TResult> onIssueCardCommercial,
        Func<TResult> onIssueCardConsumer,
        Func<TResult> onIssueChargeCard,
        Func<TResult> onIssueChargeCardCommercial,
        Func<TResult> onIssueCreditLimit,
        Func<TResult> onLocalAcceptance,
        Func<TResult> onPayout,
        Func<TResult> onPayoutToTransferInstrument,
        Func<TResult> onProcessing,
        Func<TResult> onReceiveFromBalanceAccount,
        Func<TResult> onReceiveFromPlatformPayments,
        Func<TResult> onReceiveFromThirdParty,
        Func<TResult> onReceiveFromTransferInstrument,
        Func<TResult> onReceiveGrants,
        Func<TResult> onReceivePayments,
        Func<TResult> onSendToBalanceAccount,
        Func<TResult> onSendToThirdParty,
        Func<TResult> onSendToTransferInstrument,
        Func<TResult> onThirdPartyFunding,
        Func<TResult> onUseCard,
        Func<TResult> onUseCardCommercial,
        Func<TResult> onUseCardConsumer,
        Func<TResult> onUseCardInRestrictedCountries,
        Func<TResult> onUseCardInRestrictedCountriesCommercial,
        Func<TResult> onUseCardInRestrictedCountriesConsumer,
        Func<TResult> onUseCardInRestrictedIndustries,
        Func<TResult> onUseCardInRestrictedIndustriesCommercial,
        Func<TResult> onUseCardInRestrictedIndustriesConsumer,
        Func<TResult> onUseChargeCard,
        Func<TResult> onUseChargeCardCommercial,
        Func<TResult> onWithdrawFromAtm,
        Func<TResult> onWithdrawFromAtmCommercial,
        Func<TResult> onWithdrawFromAtmConsumer,
        Func<TResult> onWithdrawFromAtmInRestrictedCountries,
        Func<TResult> onWithdrawFromAtmInRestrictedCountriesCommercial,
        Func<TResult> onWithdrawFromAtmInRestrictedCountriesConsumer,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AcceptExternalFunding => onAcceptExternalFunding(),
            _ when this == AcceptPspFunding => onAcceptPspFunding(),
            _ when this == AcceptTransactionInRestrictedCountries => onAcceptTransactionInRestrictedCountries(),
            _ when this ==
                AcceptTransactionInRestrictedCountriesCommercial => onAcceptTransactionInRestrictedCountriesCommercial(),
            _ when this ==
                AcceptTransactionInRestrictedCountriesConsumer => onAcceptTransactionInRestrictedCountriesConsumer(),
            _ when this == AcceptTransactionInRestrictedIndustries => onAcceptTransactionInRestrictedIndustries(),
            _ when this ==
                AcceptTransactionInRestrictedIndustriesCommercial => onAcceptTransactionInRestrictedIndustriesCommercial(),
            _ when this ==
                AcceptTransactionInRestrictedIndustriesConsumer => onAcceptTransactionInRestrictedIndustriesConsumer(),
            _ when this == Acquiring => onAcquiring(),
            _ when this == AtmWithdrawal => onAtmWithdrawal(),
            _ when this == AtmWithdrawalCommercial => onAtmWithdrawalCommercial(),
            _ when this == AtmWithdrawalConsumer => onAtmWithdrawalConsumer(),
            _ when this == AtmWithdrawalInRestrictedCountries => onAtmWithdrawalInRestrictedCountries(),
            _ when this ==
                AtmWithdrawalInRestrictedCountriesCommercial => onAtmWithdrawalInRestrictedCountriesCommercial(),
            _ when this == AtmWithdrawalInRestrictedCountriesConsumer => onAtmWithdrawalInRestrictedCountriesConsumer(),
            _ when this == AuthorisedPaymentInstrumentUser => onAuthorisedPaymentInstrumentUser(),
            _ when this == GetGrantOffers => onGetGrantOffers(),
            _ when this == IssueBankAccount => onIssueBankAccount(),
            _ when this == IssueCard => onIssueCard(),
            _ when this == IssueCardCommercial => onIssueCardCommercial(),
            _ when this == IssueCardConsumer => onIssueCardConsumer(),
            _ when this == IssueChargeCard => onIssueChargeCard(),
            _ when this == IssueChargeCardCommercial => onIssueChargeCardCommercial(),
            _ when this == IssueCreditLimit => onIssueCreditLimit(),
            _ when this == LocalAcceptance => onLocalAcceptance(),
            _ when this == Payout => onPayout(),
            _ when this == PayoutToTransferInstrument => onPayoutToTransferInstrument(),
            _ when this == Processing => onProcessing(),
            _ when this == ReceiveFromBalanceAccount => onReceiveFromBalanceAccount(),
            _ when this == ReceiveFromPlatformPayments => onReceiveFromPlatformPayments(),
            _ when this == ReceiveFromThirdParty => onReceiveFromThirdParty(),
            _ when this == ReceiveFromTransferInstrument => onReceiveFromTransferInstrument(),
            _ when this == ReceiveGrants => onReceiveGrants(),
            _ when this == ReceivePayments => onReceivePayments(),
            _ when this == SendToBalanceAccount => onSendToBalanceAccount(),
            _ when this == SendToThirdParty => onSendToThirdParty(),
            _ when this == SendToTransferInstrument => onSendToTransferInstrument(),
            _ when this == ThirdPartyFunding => onThirdPartyFunding(),
            _ when this == UseCard => onUseCard(),
            _ when this == UseCardCommercial => onUseCardCommercial(),
            _ when this == UseCardConsumer => onUseCardConsumer(),
            _ when this == UseCardInRestrictedCountries => onUseCardInRestrictedCountries(),
            _ when this == UseCardInRestrictedCountriesCommercial => onUseCardInRestrictedCountriesCommercial(),
            _ when this == UseCardInRestrictedCountriesConsumer => onUseCardInRestrictedCountriesConsumer(),
            _ when this == UseCardInRestrictedIndustries => onUseCardInRestrictedIndustries(),
            _ when this == UseCardInRestrictedIndustriesCommercial => onUseCardInRestrictedIndustriesCommercial(),
            _ when this == UseCardInRestrictedIndustriesConsumer => onUseCardInRestrictedIndustriesConsumer(),
            _ when this == UseChargeCard => onUseChargeCard(),
            _ when this == UseChargeCardCommercial => onUseChargeCardCommercial(),
            _ when this == WithdrawFromAtm => onWithdrawFromAtm(),
            _ when this == WithdrawFromAtmCommercial => onWithdrawFromAtmCommercial(),
            _ when this == WithdrawFromAtmConsumer => onWithdrawFromAtmConsumer(),
            _ when this == WithdrawFromAtmInRestrictedCountries => onWithdrawFromAtmInRestrictedCountries(),
            _ when this ==
                WithdrawFromAtmInRestrictedCountriesCommercial => onWithdrawFromAtmInRestrictedCountriesCommercial(),
            _ when this ==
                WithdrawFromAtmInRestrictedCountriesConsumer => onWithdrawFromAtmInRestrictedCountriesConsumer(),
            _ => otherwise(Value)
        };

    public void Match(Action onAcceptExternalFunding,
        Action onAcceptPspFunding,
        Action onAcceptTransactionInRestrictedCountries,
        Action onAcceptTransactionInRestrictedCountriesCommercial,
        Action onAcceptTransactionInRestrictedCountriesConsumer,
        Action onAcceptTransactionInRestrictedIndustries,
        Action onAcceptTransactionInRestrictedIndustriesCommercial,
        Action onAcceptTransactionInRestrictedIndustriesConsumer,
        Action onAcquiring,
        Action onAtmWithdrawal,
        Action onAtmWithdrawalCommercial,
        Action onAtmWithdrawalConsumer,
        Action onAtmWithdrawalInRestrictedCountries,
        Action onAtmWithdrawalInRestrictedCountriesCommercial,
        Action onAtmWithdrawalInRestrictedCountriesConsumer,
        Action onAuthorisedPaymentInstrumentUser,
        Action onGetGrantOffers,
        Action onIssueBankAccount,
        Action onIssueCard,
        Action onIssueCardCommercial,
        Action onIssueCardConsumer,
        Action onIssueChargeCard,
        Action onIssueChargeCardCommercial,
        Action onIssueCreditLimit,
        Action onLocalAcceptance,
        Action onPayout,
        Action onPayoutToTransferInstrument,
        Action onProcessing,
        Action onReceiveFromBalanceAccount,
        Action onReceiveFromPlatformPayments,
        Action onReceiveFromThirdParty,
        Action onReceiveFromTransferInstrument,
        Action onReceiveGrants,
        Action onReceivePayments,
        Action onSendToBalanceAccount,
        Action onSendToThirdParty,
        Action onSendToTransferInstrument,
        Action onThirdPartyFunding,
        Action onUseCard,
        Action onUseCardCommercial,
        Action onUseCardConsumer,
        Action onUseCardInRestrictedCountries,
        Action onUseCardInRestrictedCountriesCommercial,
        Action onUseCardInRestrictedCountriesConsumer,
        Action onUseCardInRestrictedIndustries,
        Action onUseCardInRestrictedIndustriesCommercial,
        Action onUseCardInRestrictedIndustriesConsumer,
        Action onUseChargeCard,
        Action onUseChargeCardCommercial,
        Action onWithdrawFromAtm,
        Action onWithdrawFromAtmCommercial,
        Action onWithdrawFromAtmConsumer,
        Action onWithdrawFromAtmInRestrictedCountries,
        Action onWithdrawFromAtmInRestrictedCountriesCommercial,
        Action onWithdrawFromAtmInRestrictedCountriesConsumer,
        Action<string> otherwise)
    {
        if (this == AcceptExternalFunding) onAcceptExternalFunding();
        else if (this == AcceptPspFunding) onAcceptPspFunding();
        else if (this == AcceptTransactionInRestrictedCountries) onAcceptTransactionInRestrictedCountries();
        else if (this ==
            AcceptTransactionInRestrictedCountriesCommercial) onAcceptTransactionInRestrictedCountriesCommercial();
        else if (this ==
            AcceptTransactionInRestrictedCountriesConsumer) onAcceptTransactionInRestrictedCountriesConsumer();
        else if (this == AcceptTransactionInRestrictedIndustries) onAcceptTransactionInRestrictedIndustries();
        else if (this ==
            AcceptTransactionInRestrictedIndustriesCommercial) onAcceptTransactionInRestrictedIndustriesCommercial();
        else if (this ==
            AcceptTransactionInRestrictedIndustriesConsumer) onAcceptTransactionInRestrictedIndustriesConsumer();
        else if (this == Acquiring) onAcquiring();
        else if (this == AtmWithdrawal) onAtmWithdrawal();
        else if (this == AtmWithdrawalCommercial) onAtmWithdrawalCommercial();
        else if (this == AtmWithdrawalConsumer) onAtmWithdrawalConsumer();
        else if (this == AtmWithdrawalInRestrictedCountries) onAtmWithdrawalInRestrictedCountries();
        else if (this == AtmWithdrawalInRestrictedCountriesCommercial) onAtmWithdrawalInRestrictedCountriesCommercial();
        else if (this == AtmWithdrawalInRestrictedCountriesConsumer) onAtmWithdrawalInRestrictedCountriesConsumer();
        else if (this == AuthorisedPaymentInstrumentUser) onAuthorisedPaymentInstrumentUser();
        else if (this == GetGrantOffers) onGetGrantOffers();
        else if (this == IssueBankAccount) onIssueBankAccount();
        else if (this == IssueCard) onIssueCard();
        else if (this == IssueCardCommercial) onIssueCardCommercial();
        else if (this == IssueCardConsumer) onIssueCardConsumer();
        else if (this == IssueChargeCard) onIssueChargeCard();
        else if (this == IssueChargeCardCommercial) onIssueChargeCardCommercial();
        else if (this == IssueCreditLimit) onIssueCreditLimit();
        else if (this == LocalAcceptance) onLocalAcceptance();
        else if (this == Payout) onPayout();
        else if (this == PayoutToTransferInstrument) onPayoutToTransferInstrument();
        else if (this == Processing) onProcessing();
        else if (this == ReceiveFromBalanceAccount) onReceiveFromBalanceAccount();
        else if (this == ReceiveFromPlatformPayments) onReceiveFromPlatformPayments();
        else if (this == ReceiveFromThirdParty) onReceiveFromThirdParty();
        else if (this == ReceiveFromTransferInstrument) onReceiveFromTransferInstrument();
        else if (this == ReceiveGrants) onReceiveGrants();
        else if (this == ReceivePayments) onReceivePayments();
        else if (this == SendToBalanceAccount) onSendToBalanceAccount();
        else if (this == SendToThirdParty) onSendToThirdParty();
        else if (this == SendToTransferInstrument) onSendToTransferInstrument();
        else if (this == ThirdPartyFunding) onThirdPartyFunding();
        else if (this == UseCard) onUseCard();
        else if (this == UseCardCommercial) onUseCardCommercial();
        else if (this == UseCardConsumer) onUseCardConsumer();
        else if (this == UseCardInRestrictedCountries) onUseCardInRestrictedCountries();
        else if (this == UseCardInRestrictedCountriesCommercial) onUseCardInRestrictedCountriesCommercial();
        else if (this == UseCardInRestrictedCountriesConsumer) onUseCardInRestrictedCountriesConsumer();
        else if (this == UseCardInRestrictedIndustries) onUseCardInRestrictedIndustries();
        else if (this == UseCardInRestrictedIndustriesCommercial) onUseCardInRestrictedIndustriesCommercial();
        else if (this == UseCardInRestrictedIndustriesConsumer) onUseCardInRestrictedIndustriesConsumer();
        else if (this == UseChargeCard) onUseChargeCard();
        else if (this == UseChargeCardCommercial) onUseChargeCardCommercial();
        else if (this == WithdrawFromAtm) onWithdrawFromAtm();
        else if (this == WithdrawFromAtmCommercial) onWithdrawFromAtmCommercial();
        else if (this == WithdrawFromAtmConsumer) onWithdrawFromAtmConsumer();
        else if (this == WithdrawFromAtmInRestrictedCountries) onWithdrawFromAtmInRestrictedCountries();
        else if (this ==
            WithdrawFromAtmInRestrictedCountriesCommercial) onWithdrawFromAtmInRestrictedCountriesCommercial();
        else if (this == WithdrawFromAtmInRestrictedCountriesConsumer) onWithdrawFromAtmInRestrictedCountriesConsumer();
        else otherwise(Value);
    }
}
