using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the document. Refer to <see href="https://docs.adyen.com/classic-platforms/verification-checks">Verification checks</see> for details on when each document type should be submitted and for the accepted file formats.
/// <para>
/// Permitted values:
/// * <b>BANK_STATEMENT</b>: A file containing a bank statement or other document proving ownership of a specific bank account.
/// * <b>COMPANY_REGISTRATION_SCREENING</b> (Supported from v5 and later): A file containing a company registration document.
/// * <b>CONSTITUTIONAL_DOCUMENT</b>: A file containing information about the account holder's legal arrangement.
/// * <b>PASSPORT</b>: A file containing the identity page(s) of a passport.
/// * <b>ID_CARD_FRONT</b>: A file containing only the front of the ID card. In order for a document to be usable, both the <b>ID_CARD_FRONT</b> and <b>ID_CARD_BACK</b> must be submitted.
/// * <b>ID_CARD_BACK</b>: A file containing only the back of the ID card. In order for a document to be usable, both the <b>ID_CARD_FRONT</b> and <b>ID_CARD_BACK</b> must be submitted.
/// * <b>DRIVING_LICENCE_FRONT</b>: A file containing only the front of the driving licence. In order for a document to be usable, both the <b>DRIVING_LICENCE_FRONT</b> and <b>DRIVING_LICENCE_BACK</b> must be submitted.
/// * <b>DRIVING_LICENCE_BACK</b>: A file containing only the back of the driving licence. In order for a document to be usable, both the <b>DRIVING_LICENCE_FRONT</b> and <b>DRIVING_LICENCE_FRONT</b> must be submitted.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DocumentType>))]
public sealed record DocumentType : StringEnum<DocumentType>
{
    private DocumentType(string value) : base(value)
    {
    }

    public static readonly DocumentType BankStatement = new("BANK_STATEMENT");

    public static readonly DocumentType Bsn = new("BSN");

    public static readonly DocumentType CompanyRegistrationScreening = new("COMPANY_REGISTRATION_SCREENING");

    public static readonly DocumentType ConstitutionalDocument = new("CONSTITUTIONAL_DOCUMENT");

    public static readonly DocumentType DrivingLicence = new("DRIVING_LICENCE");

    public static readonly DocumentType DrivingLicenceBack = new("DRIVING_LICENCE_BACK");

    public static readonly DocumentType DrivingLicenceFront = new("DRIVING_LICENCE_FRONT");

    public static readonly DocumentType IdCard = new("ID_CARD");

    public static readonly DocumentType IdCardBack = new("ID_CARD_BACK");

    public static readonly DocumentType IdCardFront = new("ID_CARD_FRONT");

    public static readonly DocumentType Passport = new("PASSPORT");

    public static readonly DocumentType ProofOfResidency = new("PROOF_OF_RESIDENCY");

    public static readonly DocumentType Ssn = new("SSN");

    public static readonly DocumentType SupportingDocuments = new("SUPPORTING_DOCUMENTS");

    public static DocumentType FromValue(string value) => FromValueCore(value);
}
