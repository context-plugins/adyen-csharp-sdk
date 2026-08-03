using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Capability>))]
public sealed record Capability : StringEnum<Capability>
{
    private Capability(string value) : base(value)
    {
    }

    public static readonly Capability AcceptExternalFunding = new("acceptExternalFunding");

    public static readonly Capability AcceptPspFunding = new("acceptPspFunding");

    public static readonly Capability AcceptTransactionInRestrictedCountries = new("acceptTransactionInRestrictedCountries");

    public static readonly Capability AcceptTransactionInRestrictedCountriesCommercial = new("acceptTransactionInRestrictedCountriesCommercial");

    public static readonly Capability AcceptTransactionInRestrictedCountriesConsumer = new("acceptTransactionInRestrictedCountriesConsumer");

    public static readonly Capability AcceptTransactionInRestrictedIndustries = new("acceptTransactionInRestrictedIndustries");

    public static readonly Capability AcceptTransactionInRestrictedIndustriesCommercial = new("acceptTransactionInRestrictedIndustriesCommercial");

    public static readonly Capability AcceptTransactionInRestrictedIndustriesConsumer = new("acceptTransactionInRestrictedIndustriesConsumer");

    public static readonly Capability Acquiring = new("acquiring");

    public static readonly Capability AtmWithdrawal = new("atmWithdrawal");

    public static readonly Capability AtmWithdrawalCommercial = new("atmWithdrawalCommercial");

    public static readonly Capability AtmWithdrawalConsumer = new("atmWithdrawalConsumer");

    public static readonly Capability AtmWithdrawalInRestrictedCountries = new("atmWithdrawalInRestrictedCountries");

    public static readonly Capability AtmWithdrawalInRestrictedCountriesCommercial = new("atmWithdrawalInRestrictedCountriesCommercial");

    public static readonly Capability AtmWithdrawalInRestrictedCountriesConsumer = new("atmWithdrawalInRestrictedCountriesConsumer");

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

    public static readonly Capability UseCardInRestrictedCountriesCommercial = new("useCardInRestrictedCountriesCommercial");

    public static readonly Capability UseCardInRestrictedCountriesConsumer = new("useCardInRestrictedCountriesConsumer");

    public static readonly Capability UseCardInRestrictedIndustries = new("useCardInRestrictedIndustries");

    public static readonly Capability UseCardInRestrictedIndustriesCommercial = new("useCardInRestrictedIndustriesCommercial");

    public static readonly Capability UseCardInRestrictedIndustriesConsumer = new("useCardInRestrictedIndustriesConsumer");

    public static readonly Capability UseChargeCard = new("useChargeCard");

    public static readonly Capability UseChargeCardCommercial = new("useChargeCardCommercial");

    public static readonly Capability WithdrawFromAtm = new("withdrawFromAtm");

    public static readonly Capability WithdrawFromAtmCommercial = new("withdrawFromAtmCommercial");

    public static readonly Capability WithdrawFromAtmConsumer = new("withdrawFromAtmConsumer");

    public static readonly Capability WithdrawFromAtmInRestrictedCountries = new("withdrawFromAtmInRestrictedCountries");

    public static readonly Capability WithdrawFromAtmInRestrictedCountriesCommercial = new("withdrawFromAtmInRestrictedCountriesCommercial");

    public static readonly Capability WithdrawFromAtmInRestrictedCountriesConsumer = new("withdrawFromAtmInRestrictedCountriesConsumer");

    public static Capability FromValue(string value) => FromValueCore(value);
}
