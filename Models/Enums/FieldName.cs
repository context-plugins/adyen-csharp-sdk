using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the field.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FieldName>))]
public sealed record FieldName : StringEnum<FieldName>
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

    public static readonly FieldName UltimateParentCompanyAddressDetailsCountry = new("ultimateParentCompanyAddressDetailsCountry");

    public static readonly FieldName UltimateParentCompanyBusinessDetails = new("ultimateParentCompanyBusinessDetails");

    public static readonly FieldName UltimateParentCompanyBusinessDetailsLegalBusinessName = new("ultimateParentCompanyBusinessDetailsLegalBusinessName");

    public static readonly FieldName UltimateParentCompanyBusinessDetailsRegistrationNumber = new("ultimateParentCompanyBusinessDetailsRegistrationNumber");

    public static readonly FieldName UltimateParentCompanyCode = new("ultimateParentCompanyCode");

    public static readonly FieldName UltimateParentCompanyStockExchange = new("ultimateParentCompanyStockExchange");

    public static readonly FieldName UltimateParentCompanyStockNumber = new("ultimateParentCompanyStockNumber");

    public static readonly FieldName UltimateParentCompanyStockNumberOrStockTicker = new("ultimateParentCompanyStockNumberOrStockTicker");

    public static readonly FieldName UltimateParentCompanyStockTicker = new("ultimateParentCompanyStockTicker");

    public static readonly FieldName Unknown = new("unknown");

    public static readonly FieldName ValueMember = new("value");

    public static readonly FieldName VerificationType = new("verificationType");

    public static readonly FieldName VirtualAccount = new("virtualAccount");

    public static readonly FieldName VisaNumber = new("visaNumber");

    public static readonly FieldName WebAddress = new("webAddress");

    public static readonly FieldName Year = new("year");

    public static FieldName FromValue(string value) => FromValueCore(value);
}
