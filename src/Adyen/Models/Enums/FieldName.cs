using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the field.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FieldName>))]
public sealed record FieldName : OpenStringEnum<FieldName>
{
    private FieldName(string value) : base(value)
    {
    }

    public static readonly FieldName AccountCode = new("accountCode");

    public static readonly FieldName AccountHolderCode = new("accountHolderCode");

    public static readonly FieldName AccountHolderDetails = new("accountHolderDetails");

    public static readonly FieldName AccountNumber = new("accountNumber");

    public static readonly FieldName AccountStateType = new("accountStateType");

    public static readonly FieldName AccountStatus = new("accountStatus");

    public static readonly FieldName AccountType = new("accountType");

    public static readonly FieldName Address = new("address");

    public static readonly FieldName BalanceAccount = new("balanceAccount");

    public static readonly FieldName BalanceAccountActive = new("balanceAccountActive");

    public static readonly FieldName BalanceAccountCode = new("balanceAccountCode");

    public static readonly FieldName BalanceAccountId = new("balanceAccountId");

    public static readonly FieldName BankAccount = new("bankAccount");

    public static readonly FieldName BankAccountCode = new("bankAccountCode");

    public static readonly FieldName BankAccountName = new("bankAccountName");

    public static readonly FieldName BankAccountUuid = new("bankAccountUUID");

    public static readonly FieldName BankBicSwift = new("bankBicSwift");

    public static readonly FieldName BankCity = new("bankCity");

    public static readonly FieldName BankCode = new("bankCode");

    public static readonly FieldName BankName = new("bankName");

    public static readonly FieldName BankStatement = new("bankStatement");

    public static readonly FieldName BranchCode = new("branchCode");

    public static readonly FieldName BusinessContact = new("businessContact");

    public static readonly FieldName CardToken = new("cardToken");

    public static readonly FieldName CheckCode = new("checkCode");

    public static readonly FieldName City = new("city");

    public static readonly FieldName CompanyRegistration = new("companyRegistration");

    public static readonly FieldName ConstitutionalDocument = new("constitutionalDocument");

    public static readonly FieldName Controller = new("controller");

    public static readonly FieldName Country = new("country");

    public static readonly FieldName CountryCode = new("countryCode");

    public static readonly FieldName Currency = new("currency");

    public static readonly FieldName CurrencyCode = new("currencyCode");

    public static readonly FieldName DateOfBirth = new("dateOfBirth");

    public static readonly FieldName Description = new("description");

    public static readonly FieldName DestinationAccountCode = new("destinationAccountCode");

    public static readonly FieldName Document = new("document");

    public static readonly FieldName DocumentContent = new("documentContent");

    public static readonly FieldName DocumentExpirationDate = new("documentExpirationDate");

    public static readonly FieldName DocumentIssuerCountry = new("documentIssuerCountry");

    public static readonly FieldName DocumentIssuerState = new("documentIssuerState");

    public static readonly FieldName DocumentName = new("documentName");

    public static readonly FieldName DocumentNumber = new("documentNumber");

    public static readonly FieldName DocumentType = new("documentType");

    public static readonly FieldName DoingBusinessAs = new("doingBusinessAs");

    public static readonly FieldName DrivingLicence = new("drivingLicence");

    public static readonly FieldName DrivingLicenceBack = new("drivingLicenceBack");

    public static readonly FieldName DrivingLicenceFront = new("drivingLicenceFront");

    public static readonly FieldName DrivingLicense = new("drivingLicense");

    public static readonly FieldName Email = new("email");

    public static readonly FieldName FirstName = new("firstName");

    public static readonly FieldName FormType = new("formType");

    public static readonly FieldName FullPhoneNumber = new("fullPhoneNumber");

    public static readonly FieldName Gender = new("gender");

    public static readonly FieldName HopWebserviceUser = new("hopWebserviceUser");

    public static readonly FieldName HouseNumberOrName = new("houseNumberOrName");

    public static readonly FieldName Iban = new("iban");

    public static readonly FieldName IdCard = new("idCard");

    public static readonly FieldName IdCardBack = new("idCardBack");

    public static readonly FieldName IdCardFront = new("idCardFront");

    public static readonly FieldName IdNumber = new("idNumber");

    public static readonly FieldName IdentityDocument = new("identityDocument");

    public static readonly FieldName IndividualDetails = new("individualDetails");

    public static readonly FieldName Infix = new("infix");

    public static readonly FieldName JobTitle = new("jobTitle");

    public static readonly FieldName LastName = new("lastName");

    public static readonly FieldName LastReviewDate = new("lastReviewDate");

    public static readonly FieldName LegalArrangement = new("legalArrangement");

    public static readonly FieldName LegalArrangementCode = new("legalArrangementCode");

    public static readonly FieldName LegalArrangementEntity = new("legalArrangementEntity");

    public static readonly FieldName LegalArrangementEntityCode = new("legalArrangementEntityCode");

    public static readonly FieldName LegalArrangementLegalForm = new("legalArrangementLegalForm");

    public static readonly FieldName LegalArrangementMember = new("legalArrangementMember");

    public static readonly FieldName LegalArrangementMembers = new("legalArrangementMembers");

    public static readonly FieldName LegalArrangementName = new("legalArrangementName");

    public static readonly FieldName LegalArrangementReference = new("legalArrangementReference");

    public static readonly FieldName LegalArrangementRegistrationNumber = new("legalArrangementRegistrationNumber");

    public static readonly FieldName LegalArrangementTaxNumber = new("legalArrangementTaxNumber");

    public static readonly FieldName LegalArrangementType = new("legalArrangementType");

    public static readonly FieldName LegalBusinessName = new("legalBusinessName");

    public static readonly FieldName LegalEntity = new("legalEntity");

    public static readonly FieldName LegalEntityType = new("legalEntityType");

    public static readonly FieldName LinkedViasVirtualAccount = new("linkedViasVirtualAccount");

    public static readonly FieldName Logo = new("logo");

    public static readonly FieldName MerchantAccount = new("merchantAccount");

    public static readonly FieldName MerchantCategoryCode = new("merchantCategoryCode");

    public static readonly FieldName MerchantHouseNumber = new("merchantHouseNumber");

    public static readonly FieldName MerchantReference = new("merchantReference");

    public static readonly FieldName MicroDeposit = new("microDeposit");

    public static readonly FieldName Name = new("name");

    public static readonly FieldName Nationality = new("nationality");

    public static readonly FieldName OriginalReference = new("originalReference");

    public static readonly FieldName OwnerCity = new("ownerCity");

    public static readonly FieldName OwnerCountryCode = new("ownerCountryCode");

    public static readonly FieldName OwnerDateOfBirth = new("ownerDateOfBirth");

    public static readonly FieldName OwnerHouseNumberOrName = new("ownerHouseNumberOrName");

    public static readonly FieldName OwnerName = new("ownerName");

    public static readonly FieldName OwnerPostalCode = new("ownerPostalCode");

    public static readonly FieldName OwnerState = new("ownerState");

    public static readonly FieldName OwnerStreet = new("ownerStreet");

    public static readonly FieldName Passport = new("passport");

    public static readonly FieldName PassportNumber = new("passportNumber");

    public static readonly FieldName PayoutMethod = new("payoutMethod");

    public static readonly FieldName PayoutMethodCode = new("payoutMethodCode");

    public static readonly FieldName PayoutSchedule = new("payoutSchedule");

    public static readonly FieldName PciSelfAssessment = new("pciSelfAssessment");

    public static readonly FieldName PersonalData = new("personalData");

    public static readonly FieldName PhoneCountryCode = new("phoneCountryCode");

    public static readonly FieldName PhoneNumber = new("phoneNumber");

    public static readonly FieldName PostalCode = new("postalCode");

    public static readonly FieldName PrimaryCurrency = new("primaryCurrency");

    public static readonly FieldName Reason = new("reason");

    public static readonly FieldName RegistrationNumber = new("registrationNumber");

    public static readonly FieldName ReturnUrl = new("returnUrl");

    public static readonly FieldName Schedule = new("schedule");

    public static readonly FieldName Shareholder = new("shareholder");

    public static readonly FieldName ShareholderCode = new("shareholderCode");

    public static readonly FieldName ShareholderCodeAndSignatoryCode = new("shareholderCodeAndSignatoryCode");

    public static readonly FieldName ShareholderCodeOrSignatoryCode = new("shareholderCodeOrSignatoryCode");

    public static readonly FieldName ShareholderType = new("shareholderType");

    public static readonly FieldName ShareholderTypes = new("shareholderTypes");

    public static readonly FieldName ShopperInteraction = new("shopperInteraction");

    public static readonly FieldName Signatory = new("signatory");

    public static readonly FieldName SignatoryCode = new("signatoryCode");

    public static readonly FieldName SocialSecurityNumber = new("socialSecurityNumber");

    public static readonly FieldName SourceAccountCode = new("sourceAccountCode");

    public static readonly FieldName SplitAccount = new("splitAccount");

    public static readonly FieldName SplitConfigurationUuid = new("splitConfigurationUUID");

    public static readonly FieldName SplitCurrency = new("splitCurrency");

    public static readonly FieldName SplitValue = new("splitValue");

    public static readonly FieldName Splits = new("splits");

    public static readonly FieldName StateOrProvince = new("stateOrProvince");

    public static readonly FieldName Status = new("status");

    public static readonly FieldName StockExchange = new("stockExchange");

    public static readonly FieldName StockNumber = new("stockNumber");

    public static readonly FieldName StockTicker = new("stockTicker");

    public static readonly FieldName Store = new("store");

    public static readonly FieldName StoreDetail = new("storeDetail");

    public static readonly FieldName StoreName = new("storeName");

    public static readonly FieldName StoreReference = new("storeReference");

    public static readonly FieldName Street = new("street");

    public static readonly FieldName TaxId = new("taxId");

    public static readonly FieldName Tier = new("tier");

    public static readonly FieldName TierNumber = new("tierNumber");

    public static readonly FieldName TransferCode = new("transferCode");

    public static readonly FieldName UltimateParentCompany = new("ultimateParentCompany");

    public static readonly FieldName UltimateParentCompanyAddressDetails = new("ultimateParentCompanyAddressDetails");

    public static readonly FieldName UltimateParentCompanyAddressDetailsCountry = new(
        "ultimateParentCompanyAddressDetailsCountry");

    public static readonly FieldName UltimateParentCompanyBusinessDetails = new("ultimateParentCompanyBusinessDetails");

    public static readonly FieldName UltimateParentCompanyBusinessDetailsLegalBusinessName = new(
        "ultimateParentCompanyBusinessDetailsLegalBusinessName");

    public static readonly FieldName UltimateParentCompanyBusinessDetailsRegistrationNumber = new(
        "ultimateParentCompanyBusinessDetailsRegistrationNumber");

    public static readonly FieldName UltimateParentCompanyCode = new("ultimateParentCompanyCode");

    public static readonly FieldName UltimateParentCompanyStockExchange = new("ultimateParentCompanyStockExchange");

    public static readonly FieldName UltimateParentCompanyStockNumber = new("ultimateParentCompanyStockNumber");

    public static readonly FieldName UltimateParentCompanyStockNumberOrStockTicker = new(
        "ultimateParentCompanyStockNumberOrStockTicker");

    public static readonly FieldName UltimateParentCompanyStockTicker = new("ultimateParentCompanyStockTicker");

    public static readonly FieldName Unknown = new("unknown");

    public static readonly FieldName ValueMember = new("value");

    public static readonly FieldName VerificationType = new("verificationType");

    public static readonly FieldName VirtualAccount = new("virtualAccount");

    public static readonly FieldName VisaNumber = new("visaNumber");

    public static readonly FieldName WebAddress = new("webAddress");

    public static readonly FieldName Year = new("year");

    public TResult Match<TResult>(Func<TResult> onAccountCode,
        Func<TResult> onAccountHolderCode,
        Func<TResult> onAccountHolderDetails,
        Func<TResult> onAccountNumber,
        Func<TResult> onAccountStateType,
        Func<TResult> onAccountStatus,
        Func<TResult> onAccountType,
        Func<TResult> onAddress,
        Func<TResult> onBalanceAccount,
        Func<TResult> onBalanceAccountActive,
        Func<TResult> onBalanceAccountCode,
        Func<TResult> onBalanceAccountId,
        Func<TResult> onBankAccount,
        Func<TResult> onBankAccountCode,
        Func<TResult> onBankAccountName,
        Func<TResult> onBankAccountUuid,
        Func<TResult> onBankBicSwift,
        Func<TResult> onBankCity,
        Func<TResult> onBankCode,
        Func<TResult> onBankName,
        Func<TResult> onBankStatement,
        Func<TResult> onBranchCode,
        Func<TResult> onBusinessContact,
        Func<TResult> onCardToken,
        Func<TResult> onCheckCode,
        Func<TResult> onCity,
        Func<TResult> onCompanyRegistration,
        Func<TResult> onConstitutionalDocument,
        Func<TResult> onController,
        Func<TResult> onCountry,
        Func<TResult> onCountryCode,
        Func<TResult> onCurrency,
        Func<TResult> onCurrencyCode,
        Func<TResult> onDateOfBirth,
        Func<TResult> onDescription,
        Func<TResult> onDestinationAccountCode,
        Func<TResult> onDocument,
        Func<TResult> onDocumentContent,
        Func<TResult> onDocumentExpirationDate,
        Func<TResult> onDocumentIssuerCountry,
        Func<TResult> onDocumentIssuerState,
        Func<TResult> onDocumentName,
        Func<TResult> onDocumentNumber,
        Func<TResult> onDocumentType,
        Func<TResult> onDoingBusinessAs,
        Func<TResult> onDrivingLicence,
        Func<TResult> onDrivingLicenceBack,
        Func<TResult> onDrivingLicenceFront,
        Func<TResult> onDrivingLicense,
        Func<TResult> onEmail,
        Func<TResult> onFirstName,
        Func<TResult> onFormType,
        Func<TResult> onFullPhoneNumber,
        Func<TResult> onGender,
        Func<TResult> onHopWebserviceUser,
        Func<TResult> onHouseNumberOrName,
        Func<TResult> onIban,
        Func<TResult> onIdCard,
        Func<TResult> onIdCardBack,
        Func<TResult> onIdCardFront,
        Func<TResult> onIdNumber,
        Func<TResult> onIdentityDocument,
        Func<TResult> onIndividualDetails,
        Func<TResult> onInfix,
        Func<TResult> onJobTitle,
        Func<TResult> onLastName,
        Func<TResult> onLastReviewDate,
        Func<TResult> onLegalArrangement,
        Func<TResult> onLegalArrangementCode,
        Func<TResult> onLegalArrangementEntity,
        Func<TResult> onLegalArrangementEntityCode,
        Func<TResult> onLegalArrangementLegalForm,
        Func<TResult> onLegalArrangementMember,
        Func<TResult> onLegalArrangementMembers,
        Func<TResult> onLegalArrangementName,
        Func<TResult> onLegalArrangementReference,
        Func<TResult> onLegalArrangementRegistrationNumber,
        Func<TResult> onLegalArrangementTaxNumber,
        Func<TResult> onLegalArrangementType,
        Func<TResult> onLegalBusinessName,
        Func<TResult> onLegalEntity,
        Func<TResult> onLegalEntityType,
        Func<TResult> onLinkedViasVirtualAccount,
        Func<TResult> onLogo,
        Func<TResult> onMerchantAccount,
        Func<TResult> onMerchantCategoryCode,
        Func<TResult> onMerchantHouseNumber,
        Func<TResult> onMerchantReference,
        Func<TResult> onMicroDeposit,
        Func<TResult> onName,
        Func<TResult> onNationality,
        Func<TResult> onOriginalReference,
        Func<TResult> onOwnerCity,
        Func<TResult> onOwnerCountryCode,
        Func<TResult> onOwnerDateOfBirth,
        Func<TResult> onOwnerHouseNumberOrName,
        Func<TResult> onOwnerName,
        Func<TResult> onOwnerPostalCode,
        Func<TResult> onOwnerState,
        Func<TResult> onOwnerStreet,
        Func<TResult> onPassport,
        Func<TResult> onPassportNumber,
        Func<TResult> onPayoutMethod,
        Func<TResult> onPayoutMethodCode,
        Func<TResult> onPayoutSchedule,
        Func<TResult> onPciSelfAssessment,
        Func<TResult> onPersonalData,
        Func<TResult> onPhoneCountryCode,
        Func<TResult> onPhoneNumber,
        Func<TResult> onPostalCode,
        Func<TResult> onPrimaryCurrency,
        Func<TResult> onReason,
        Func<TResult> onRegistrationNumber,
        Func<TResult> onReturnUrl,
        Func<TResult> onSchedule,
        Func<TResult> onShareholder,
        Func<TResult> onShareholderCode,
        Func<TResult> onShareholderCodeAndSignatoryCode,
        Func<TResult> onShareholderCodeOrSignatoryCode,
        Func<TResult> onShareholderType,
        Func<TResult> onShareholderTypes,
        Func<TResult> onShopperInteraction,
        Func<TResult> onSignatory,
        Func<TResult> onSignatoryCode,
        Func<TResult> onSocialSecurityNumber,
        Func<TResult> onSourceAccountCode,
        Func<TResult> onSplitAccount,
        Func<TResult> onSplitConfigurationUuid,
        Func<TResult> onSplitCurrency,
        Func<TResult> onSplitValue,
        Func<TResult> onSplits,
        Func<TResult> onStateOrProvince,
        Func<TResult> onStatus,
        Func<TResult> onStockExchange,
        Func<TResult> onStockNumber,
        Func<TResult> onStockTicker,
        Func<TResult> onStore,
        Func<TResult> onStoreDetail,
        Func<TResult> onStoreName,
        Func<TResult> onStoreReference,
        Func<TResult> onStreet,
        Func<TResult> onTaxId,
        Func<TResult> onTier,
        Func<TResult> onTierNumber,
        Func<TResult> onTransferCode,
        Func<TResult> onUltimateParentCompany,
        Func<TResult> onUltimateParentCompanyAddressDetails,
        Func<TResult> onUltimateParentCompanyAddressDetailsCountry,
        Func<TResult> onUltimateParentCompanyBusinessDetails,
        Func<TResult> onUltimateParentCompanyBusinessDetailsLegalBusinessName,
        Func<TResult> onUltimateParentCompanyBusinessDetailsRegistrationNumber,
        Func<TResult> onUltimateParentCompanyCode,
        Func<TResult> onUltimateParentCompanyStockExchange,
        Func<TResult> onUltimateParentCompanyStockNumber,
        Func<TResult> onUltimateParentCompanyStockNumberOrStockTicker,
        Func<TResult> onUltimateParentCompanyStockTicker,
        Func<TResult> onUnknown,
        Func<TResult> onValueMember,
        Func<TResult> onVerificationType,
        Func<TResult> onVirtualAccount,
        Func<TResult> onVisaNumber,
        Func<TResult> onWebAddress,
        Func<TResult> onYear,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AccountCode => onAccountCode(),
            _ when this == AccountHolderCode => onAccountHolderCode(),
            _ when this == AccountHolderDetails => onAccountHolderDetails(),
            _ when this == AccountNumber => onAccountNumber(),
            _ when this == AccountStateType => onAccountStateType(),
            _ when this == AccountStatus => onAccountStatus(),
            _ when this == AccountType => onAccountType(),
            _ when this == Address => onAddress(),
            _ when this == BalanceAccount => onBalanceAccount(),
            _ when this == BalanceAccountActive => onBalanceAccountActive(),
            _ when this == BalanceAccountCode => onBalanceAccountCode(),
            _ when this == BalanceAccountId => onBalanceAccountId(),
            _ when this == BankAccount => onBankAccount(),
            _ when this == BankAccountCode => onBankAccountCode(),
            _ when this == BankAccountName => onBankAccountName(),
            _ when this == BankAccountUuid => onBankAccountUuid(),
            _ when this == BankBicSwift => onBankBicSwift(),
            _ when this == BankCity => onBankCity(),
            _ when this == BankCode => onBankCode(),
            _ when this == BankName => onBankName(),
            _ when this == BankStatement => onBankStatement(),
            _ when this == BranchCode => onBranchCode(),
            _ when this == BusinessContact => onBusinessContact(),
            _ when this == CardToken => onCardToken(),
            _ when this == CheckCode => onCheckCode(),
            _ when this == City => onCity(),
            _ when this == CompanyRegistration => onCompanyRegistration(),
            _ when this == ConstitutionalDocument => onConstitutionalDocument(),
            _ when this == Controller => onController(),
            _ when this == Country => onCountry(),
            _ when this == CountryCode => onCountryCode(),
            _ when this == Currency => onCurrency(),
            _ when this == CurrencyCode => onCurrencyCode(),
            _ when this == DateOfBirth => onDateOfBirth(),
            _ when this == Description => onDescription(),
            _ when this == DestinationAccountCode => onDestinationAccountCode(),
            _ when this == Document => onDocument(),
            _ when this == DocumentContent => onDocumentContent(),
            _ when this == DocumentExpirationDate => onDocumentExpirationDate(),
            _ when this == DocumentIssuerCountry => onDocumentIssuerCountry(),
            _ when this == DocumentIssuerState => onDocumentIssuerState(),
            _ when this == DocumentName => onDocumentName(),
            _ when this == DocumentNumber => onDocumentNumber(),
            _ when this == DocumentType => onDocumentType(),
            _ when this == DoingBusinessAs => onDoingBusinessAs(),
            _ when this == DrivingLicence => onDrivingLicence(),
            _ when this == DrivingLicenceBack => onDrivingLicenceBack(),
            _ when this == DrivingLicenceFront => onDrivingLicenceFront(),
            _ when this == DrivingLicense => onDrivingLicense(),
            _ when this == Email => onEmail(),
            _ when this == FirstName => onFirstName(),
            _ when this == FormType => onFormType(),
            _ when this == FullPhoneNumber => onFullPhoneNumber(),
            _ when this == Gender => onGender(),
            _ when this == HopWebserviceUser => onHopWebserviceUser(),
            _ when this == HouseNumberOrName => onHouseNumberOrName(),
            _ when this == Iban => onIban(),
            _ when this == IdCard => onIdCard(),
            _ when this == IdCardBack => onIdCardBack(),
            _ when this == IdCardFront => onIdCardFront(),
            _ when this == IdNumber => onIdNumber(),
            _ when this == IdentityDocument => onIdentityDocument(),
            _ when this == IndividualDetails => onIndividualDetails(),
            _ when this == Infix => onInfix(),
            _ when this == JobTitle => onJobTitle(),
            _ when this == LastName => onLastName(),
            _ when this == LastReviewDate => onLastReviewDate(),
            _ when this == LegalArrangement => onLegalArrangement(),
            _ when this == LegalArrangementCode => onLegalArrangementCode(),
            _ when this == LegalArrangementEntity => onLegalArrangementEntity(),
            _ when this == LegalArrangementEntityCode => onLegalArrangementEntityCode(),
            _ when this == LegalArrangementLegalForm => onLegalArrangementLegalForm(),
            _ when this == LegalArrangementMember => onLegalArrangementMember(),
            _ when this == LegalArrangementMembers => onLegalArrangementMembers(),
            _ when this == LegalArrangementName => onLegalArrangementName(),
            _ when this == LegalArrangementReference => onLegalArrangementReference(),
            _ when this == LegalArrangementRegistrationNumber => onLegalArrangementRegistrationNumber(),
            _ when this == LegalArrangementTaxNumber => onLegalArrangementTaxNumber(),
            _ when this == LegalArrangementType => onLegalArrangementType(),
            _ when this == LegalBusinessName => onLegalBusinessName(),
            _ when this == LegalEntity => onLegalEntity(),
            _ when this == LegalEntityType => onLegalEntityType(),
            _ when this == LinkedViasVirtualAccount => onLinkedViasVirtualAccount(),
            _ when this == Logo => onLogo(),
            _ when this == MerchantAccount => onMerchantAccount(),
            _ when this == MerchantCategoryCode => onMerchantCategoryCode(),
            _ when this == MerchantHouseNumber => onMerchantHouseNumber(),
            _ when this == MerchantReference => onMerchantReference(),
            _ when this == MicroDeposit => onMicroDeposit(),
            _ when this == Name => onName(),
            _ when this == Nationality => onNationality(),
            _ when this == OriginalReference => onOriginalReference(),
            _ when this == OwnerCity => onOwnerCity(),
            _ when this == OwnerCountryCode => onOwnerCountryCode(),
            _ when this == OwnerDateOfBirth => onOwnerDateOfBirth(),
            _ when this == OwnerHouseNumberOrName => onOwnerHouseNumberOrName(),
            _ when this == OwnerName => onOwnerName(),
            _ when this == OwnerPostalCode => onOwnerPostalCode(),
            _ when this == OwnerState => onOwnerState(),
            _ when this == OwnerStreet => onOwnerStreet(),
            _ when this == Passport => onPassport(),
            _ when this == PassportNumber => onPassportNumber(),
            _ when this == PayoutMethod => onPayoutMethod(),
            _ when this == PayoutMethodCode => onPayoutMethodCode(),
            _ when this == PayoutSchedule => onPayoutSchedule(),
            _ when this == PciSelfAssessment => onPciSelfAssessment(),
            _ when this == PersonalData => onPersonalData(),
            _ when this == PhoneCountryCode => onPhoneCountryCode(),
            _ when this == PhoneNumber => onPhoneNumber(),
            _ when this == PostalCode => onPostalCode(),
            _ when this == PrimaryCurrency => onPrimaryCurrency(),
            _ when this == Reason => onReason(),
            _ when this == RegistrationNumber => onRegistrationNumber(),
            _ when this == ReturnUrl => onReturnUrl(),
            _ when this == Schedule => onSchedule(),
            _ when this == Shareholder => onShareholder(),
            _ when this == ShareholderCode => onShareholderCode(),
            _ when this == ShareholderCodeAndSignatoryCode => onShareholderCodeAndSignatoryCode(),
            _ when this == ShareholderCodeOrSignatoryCode => onShareholderCodeOrSignatoryCode(),
            _ when this == ShareholderType => onShareholderType(),
            _ when this == ShareholderTypes => onShareholderTypes(),
            _ when this == ShopperInteraction => onShopperInteraction(),
            _ when this == Signatory => onSignatory(),
            _ when this == SignatoryCode => onSignatoryCode(),
            _ when this == SocialSecurityNumber => onSocialSecurityNumber(),
            _ when this == SourceAccountCode => onSourceAccountCode(),
            _ when this == SplitAccount => onSplitAccount(),
            _ when this == SplitConfigurationUuid => onSplitConfigurationUuid(),
            _ when this == SplitCurrency => onSplitCurrency(),
            _ when this == SplitValue => onSplitValue(),
            _ when this == Splits => onSplits(),
            _ when this == StateOrProvince => onStateOrProvince(),
            _ when this == Status => onStatus(),
            _ when this == StockExchange => onStockExchange(),
            _ when this == StockNumber => onStockNumber(),
            _ when this == StockTicker => onStockTicker(),
            _ when this == Store => onStore(),
            _ when this == StoreDetail => onStoreDetail(),
            _ when this == StoreName => onStoreName(),
            _ when this == StoreReference => onStoreReference(),
            _ when this == Street => onStreet(),
            _ when this == TaxId => onTaxId(),
            _ when this == Tier => onTier(),
            _ when this == TierNumber => onTierNumber(),
            _ when this == TransferCode => onTransferCode(),
            _ when this == UltimateParentCompany => onUltimateParentCompany(),
            _ when this == UltimateParentCompanyAddressDetails => onUltimateParentCompanyAddressDetails(),
            _ when this == UltimateParentCompanyAddressDetailsCountry => onUltimateParentCompanyAddressDetailsCountry(),
            _ when this == UltimateParentCompanyBusinessDetails => onUltimateParentCompanyBusinessDetails(),
            _ when this ==
                UltimateParentCompanyBusinessDetailsLegalBusinessName => onUltimateParentCompanyBusinessDetailsLegalBusinessName(),
            _ when this ==
                UltimateParentCompanyBusinessDetailsRegistrationNumber => onUltimateParentCompanyBusinessDetailsRegistrationNumber(),
            _ when this == UltimateParentCompanyCode => onUltimateParentCompanyCode(),
            _ when this == UltimateParentCompanyStockExchange => onUltimateParentCompanyStockExchange(),
            _ when this == UltimateParentCompanyStockNumber => onUltimateParentCompanyStockNumber(),
            _ when this ==
                UltimateParentCompanyStockNumberOrStockTicker => onUltimateParentCompanyStockNumberOrStockTicker(),
            _ when this == UltimateParentCompanyStockTicker => onUltimateParentCompanyStockTicker(),
            _ when this == Unknown => onUnknown(),
            _ when this == ValueMember => onValueMember(),
            _ when this == VerificationType => onVerificationType(),
            _ when this == VirtualAccount => onVirtualAccount(),
            _ when this == VisaNumber => onVisaNumber(),
            _ when this == WebAddress => onWebAddress(),
            _ when this == Year => onYear(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccountCode,
        Action onAccountHolderCode,
        Action onAccountHolderDetails,
        Action onAccountNumber,
        Action onAccountStateType,
        Action onAccountStatus,
        Action onAccountType,
        Action onAddress,
        Action onBalanceAccount,
        Action onBalanceAccountActive,
        Action onBalanceAccountCode,
        Action onBalanceAccountId,
        Action onBankAccount,
        Action onBankAccountCode,
        Action onBankAccountName,
        Action onBankAccountUuid,
        Action onBankBicSwift,
        Action onBankCity,
        Action onBankCode,
        Action onBankName,
        Action onBankStatement,
        Action onBranchCode,
        Action onBusinessContact,
        Action onCardToken,
        Action onCheckCode,
        Action onCity,
        Action onCompanyRegistration,
        Action onConstitutionalDocument,
        Action onController,
        Action onCountry,
        Action onCountryCode,
        Action onCurrency,
        Action onCurrencyCode,
        Action onDateOfBirth,
        Action onDescription,
        Action onDestinationAccountCode,
        Action onDocument,
        Action onDocumentContent,
        Action onDocumentExpirationDate,
        Action onDocumentIssuerCountry,
        Action onDocumentIssuerState,
        Action onDocumentName,
        Action onDocumentNumber,
        Action onDocumentType,
        Action onDoingBusinessAs,
        Action onDrivingLicence,
        Action onDrivingLicenceBack,
        Action onDrivingLicenceFront,
        Action onDrivingLicense,
        Action onEmail,
        Action onFirstName,
        Action onFormType,
        Action onFullPhoneNumber,
        Action onGender,
        Action onHopWebserviceUser,
        Action onHouseNumberOrName,
        Action onIban,
        Action onIdCard,
        Action onIdCardBack,
        Action onIdCardFront,
        Action onIdNumber,
        Action onIdentityDocument,
        Action onIndividualDetails,
        Action onInfix,
        Action onJobTitle,
        Action onLastName,
        Action onLastReviewDate,
        Action onLegalArrangement,
        Action onLegalArrangementCode,
        Action onLegalArrangementEntity,
        Action onLegalArrangementEntityCode,
        Action onLegalArrangementLegalForm,
        Action onLegalArrangementMember,
        Action onLegalArrangementMembers,
        Action onLegalArrangementName,
        Action onLegalArrangementReference,
        Action onLegalArrangementRegistrationNumber,
        Action onLegalArrangementTaxNumber,
        Action onLegalArrangementType,
        Action onLegalBusinessName,
        Action onLegalEntity,
        Action onLegalEntityType,
        Action onLinkedViasVirtualAccount,
        Action onLogo,
        Action onMerchantAccount,
        Action onMerchantCategoryCode,
        Action onMerchantHouseNumber,
        Action onMerchantReference,
        Action onMicroDeposit,
        Action onName,
        Action onNationality,
        Action onOriginalReference,
        Action onOwnerCity,
        Action onOwnerCountryCode,
        Action onOwnerDateOfBirth,
        Action onOwnerHouseNumberOrName,
        Action onOwnerName,
        Action onOwnerPostalCode,
        Action onOwnerState,
        Action onOwnerStreet,
        Action onPassport,
        Action onPassportNumber,
        Action onPayoutMethod,
        Action onPayoutMethodCode,
        Action onPayoutSchedule,
        Action onPciSelfAssessment,
        Action onPersonalData,
        Action onPhoneCountryCode,
        Action onPhoneNumber,
        Action onPostalCode,
        Action onPrimaryCurrency,
        Action onReason,
        Action onRegistrationNumber,
        Action onReturnUrl,
        Action onSchedule,
        Action onShareholder,
        Action onShareholderCode,
        Action onShareholderCodeAndSignatoryCode,
        Action onShareholderCodeOrSignatoryCode,
        Action onShareholderType,
        Action onShareholderTypes,
        Action onShopperInteraction,
        Action onSignatory,
        Action onSignatoryCode,
        Action onSocialSecurityNumber,
        Action onSourceAccountCode,
        Action onSplitAccount,
        Action onSplitConfigurationUuid,
        Action onSplitCurrency,
        Action onSplitValue,
        Action onSplits,
        Action onStateOrProvince,
        Action onStatus,
        Action onStockExchange,
        Action onStockNumber,
        Action onStockTicker,
        Action onStore,
        Action onStoreDetail,
        Action onStoreName,
        Action onStoreReference,
        Action onStreet,
        Action onTaxId,
        Action onTier,
        Action onTierNumber,
        Action onTransferCode,
        Action onUltimateParentCompany,
        Action onUltimateParentCompanyAddressDetails,
        Action onUltimateParentCompanyAddressDetailsCountry,
        Action onUltimateParentCompanyBusinessDetails,
        Action onUltimateParentCompanyBusinessDetailsLegalBusinessName,
        Action onUltimateParentCompanyBusinessDetailsRegistrationNumber,
        Action onUltimateParentCompanyCode,
        Action onUltimateParentCompanyStockExchange,
        Action onUltimateParentCompanyStockNumber,
        Action onUltimateParentCompanyStockNumberOrStockTicker,
        Action onUltimateParentCompanyStockTicker,
        Action onUnknown,
        Action onValueMember,
        Action onVerificationType,
        Action onVirtualAccount,
        Action onVisaNumber,
        Action onWebAddress,
        Action onYear,
        Action<string> otherwise)
    {
        if (this == AccountCode) onAccountCode();
        else if (this == AccountHolderCode) onAccountHolderCode();
        else if (this == AccountHolderDetails) onAccountHolderDetails();
        else if (this == AccountNumber) onAccountNumber();
        else if (this == AccountStateType) onAccountStateType();
        else if (this == AccountStatus) onAccountStatus();
        else if (this == AccountType) onAccountType();
        else if (this == Address) onAddress();
        else if (this == BalanceAccount) onBalanceAccount();
        else if (this == BalanceAccountActive) onBalanceAccountActive();
        else if (this == BalanceAccountCode) onBalanceAccountCode();
        else if (this == BalanceAccountId) onBalanceAccountId();
        else if (this == BankAccount) onBankAccount();
        else if (this == BankAccountCode) onBankAccountCode();
        else if (this == BankAccountName) onBankAccountName();
        else if (this == BankAccountUuid) onBankAccountUuid();
        else if (this == BankBicSwift) onBankBicSwift();
        else if (this == BankCity) onBankCity();
        else if (this == BankCode) onBankCode();
        else if (this == BankName) onBankName();
        else if (this == BankStatement) onBankStatement();
        else if (this == BranchCode) onBranchCode();
        else if (this == BusinessContact) onBusinessContact();
        else if (this == CardToken) onCardToken();
        else if (this == CheckCode) onCheckCode();
        else if (this == City) onCity();
        else if (this == CompanyRegistration) onCompanyRegistration();
        else if (this == ConstitutionalDocument) onConstitutionalDocument();
        else if (this == Controller) onController();
        else if (this == Country) onCountry();
        else if (this == CountryCode) onCountryCode();
        else if (this == Currency) onCurrency();
        else if (this == CurrencyCode) onCurrencyCode();
        else if (this == DateOfBirth) onDateOfBirth();
        else if (this == Description) onDescription();
        else if (this == DestinationAccountCode) onDestinationAccountCode();
        else if (this == Document) onDocument();
        else if (this == DocumentContent) onDocumentContent();
        else if (this == DocumentExpirationDate) onDocumentExpirationDate();
        else if (this == DocumentIssuerCountry) onDocumentIssuerCountry();
        else if (this == DocumentIssuerState) onDocumentIssuerState();
        else if (this == DocumentName) onDocumentName();
        else if (this == DocumentNumber) onDocumentNumber();
        else if (this == DocumentType) onDocumentType();
        else if (this == DoingBusinessAs) onDoingBusinessAs();
        else if (this == DrivingLicence) onDrivingLicence();
        else if (this == DrivingLicenceBack) onDrivingLicenceBack();
        else if (this == DrivingLicenceFront) onDrivingLicenceFront();
        else if (this == DrivingLicense) onDrivingLicense();
        else if (this == Email) onEmail();
        else if (this == FirstName) onFirstName();
        else if (this == FormType) onFormType();
        else if (this == FullPhoneNumber) onFullPhoneNumber();
        else if (this == Gender) onGender();
        else if (this == HopWebserviceUser) onHopWebserviceUser();
        else if (this == HouseNumberOrName) onHouseNumberOrName();
        else if (this == Iban) onIban();
        else if (this == IdCard) onIdCard();
        else if (this == IdCardBack) onIdCardBack();
        else if (this == IdCardFront) onIdCardFront();
        else if (this == IdNumber) onIdNumber();
        else if (this == IdentityDocument) onIdentityDocument();
        else if (this == IndividualDetails) onIndividualDetails();
        else if (this == Infix) onInfix();
        else if (this == JobTitle) onJobTitle();
        else if (this == LastName) onLastName();
        else if (this == LastReviewDate) onLastReviewDate();
        else if (this == LegalArrangement) onLegalArrangement();
        else if (this == LegalArrangementCode) onLegalArrangementCode();
        else if (this == LegalArrangementEntity) onLegalArrangementEntity();
        else if (this == LegalArrangementEntityCode) onLegalArrangementEntityCode();
        else if (this == LegalArrangementLegalForm) onLegalArrangementLegalForm();
        else if (this == LegalArrangementMember) onLegalArrangementMember();
        else if (this == LegalArrangementMembers) onLegalArrangementMembers();
        else if (this == LegalArrangementName) onLegalArrangementName();
        else if (this == LegalArrangementReference) onLegalArrangementReference();
        else if (this == LegalArrangementRegistrationNumber) onLegalArrangementRegistrationNumber();
        else if (this == LegalArrangementTaxNumber) onLegalArrangementTaxNumber();
        else if (this == LegalArrangementType) onLegalArrangementType();
        else if (this == LegalBusinessName) onLegalBusinessName();
        else if (this == LegalEntity) onLegalEntity();
        else if (this == LegalEntityType) onLegalEntityType();
        else if (this == LinkedViasVirtualAccount) onLinkedViasVirtualAccount();
        else if (this == Logo) onLogo();
        else if (this == MerchantAccount) onMerchantAccount();
        else if (this == MerchantCategoryCode) onMerchantCategoryCode();
        else if (this == MerchantHouseNumber) onMerchantHouseNumber();
        else if (this == MerchantReference) onMerchantReference();
        else if (this == MicroDeposit) onMicroDeposit();
        else if (this == Name) onName();
        else if (this == Nationality) onNationality();
        else if (this == OriginalReference) onOriginalReference();
        else if (this == OwnerCity) onOwnerCity();
        else if (this == OwnerCountryCode) onOwnerCountryCode();
        else if (this == OwnerDateOfBirth) onOwnerDateOfBirth();
        else if (this == OwnerHouseNumberOrName) onOwnerHouseNumberOrName();
        else if (this == OwnerName) onOwnerName();
        else if (this == OwnerPostalCode) onOwnerPostalCode();
        else if (this == OwnerState) onOwnerState();
        else if (this == OwnerStreet) onOwnerStreet();
        else if (this == Passport) onPassport();
        else if (this == PassportNumber) onPassportNumber();
        else if (this == PayoutMethod) onPayoutMethod();
        else if (this == PayoutMethodCode) onPayoutMethodCode();
        else if (this == PayoutSchedule) onPayoutSchedule();
        else if (this == PciSelfAssessment) onPciSelfAssessment();
        else if (this == PersonalData) onPersonalData();
        else if (this == PhoneCountryCode) onPhoneCountryCode();
        else if (this == PhoneNumber) onPhoneNumber();
        else if (this == PostalCode) onPostalCode();
        else if (this == PrimaryCurrency) onPrimaryCurrency();
        else if (this == Reason) onReason();
        else if (this == RegistrationNumber) onRegistrationNumber();
        else if (this == ReturnUrl) onReturnUrl();
        else if (this == Schedule) onSchedule();
        else if (this == Shareholder) onShareholder();
        else if (this == ShareholderCode) onShareholderCode();
        else if (this == ShareholderCodeAndSignatoryCode) onShareholderCodeAndSignatoryCode();
        else if (this == ShareholderCodeOrSignatoryCode) onShareholderCodeOrSignatoryCode();
        else if (this == ShareholderType) onShareholderType();
        else if (this == ShareholderTypes) onShareholderTypes();
        else if (this == ShopperInteraction) onShopperInteraction();
        else if (this == Signatory) onSignatory();
        else if (this == SignatoryCode) onSignatoryCode();
        else if (this == SocialSecurityNumber) onSocialSecurityNumber();
        else if (this == SourceAccountCode) onSourceAccountCode();
        else if (this == SplitAccount) onSplitAccount();
        else if (this == SplitConfigurationUuid) onSplitConfigurationUuid();
        else if (this == SplitCurrency) onSplitCurrency();
        else if (this == SplitValue) onSplitValue();
        else if (this == Splits) onSplits();
        else if (this == StateOrProvince) onStateOrProvince();
        else if (this == Status) onStatus();
        else if (this == StockExchange) onStockExchange();
        else if (this == StockNumber) onStockNumber();
        else if (this == StockTicker) onStockTicker();
        else if (this == Store) onStore();
        else if (this == StoreDetail) onStoreDetail();
        else if (this == StoreName) onStoreName();
        else if (this == StoreReference) onStoreReference();
        else if (this == Street) onStreet();
        else if (this == TaxId) onTaxId();
        else if (this == Tier) onTier();
        else if (this == TierNumber) onTierNumber();
        else if (this == TransferCode) onTransferCode();
        else if (this == UltimateParentCompany) onUltimateParentCompany();
        else if (this == UltimateParentCompanyAddressDetails) onUltimateParentCompanyAddressDetails();
        else if (this == UltimateParentCompanyAddressDetailsCountry) onUltimateParentCompanyAddressDetailsCountry();
        else if (this == UltimateParentCompanyBusinessDetails) onUltimateParentCompanyBusinessDetails();
        else if (this ==
            UltimateParentCompanyBusinessDetailsLegalBusinessName) onUltimateParentCompanyBusinessDetailsLegalBusinessName();
        else if (this ==
            UltimateParentCompanyBusinessDetailsRegistrationNumber) onUltimateParentCompanyBusinessDetailsRegistrationNumber();
        else if (this == UltimateParentCompanyCode) onUltimateParentCompanyCode();
        else if (this == UltimateParentCompanyStockExchange) onUltimateParentCompanyStockExchange();
        else if (this == UltimateParentCompanyStockNumber) onUltimateParentCompanyStockNumber();
        else if (this ==
            UltimateParentCompanyStockNumberOrStockTicker) onUltimateParentCompanyStockNumberOrStockTicker();
        else if (this == UltimateParentCompanyStockTicker) onUltimateParentCompanyStockTicker();
        else if (this == Unknown) onUnknown();
        else if (this == ValueMember) onValueMember();
        else if (this == VerificationType) onVerificationType();
        else if (this == VirtualAccount) onVirtualAccount();
        else if (this == VisaNumber) onVisaNumber();
        else if (this == WebAddress) onWebAddress();
        else if (this == Year) onYear();
        else otherwise(Value);
    }
}
