using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record DocumentDetail
{
    /// <summary>
    /// The code of account holder, to which the document applies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolderCode")]
    public string? AccountHolderCode { get; init; }

    /// <summary>
    /// The Adyen-generated <see href="https://docs.adyen.com/api-explorer/#/Account/latest/post/createAccountHolder__resParam_accountHolderDetails-bankAccountDetails-bankAccountUUID"><c>bankAccountUUID</c></see> to which the document must be linked. Refer to <see href="https://docs.adyen.com/classic-platforms/verification-checks/bank-account-check#uploading-a-bank-statement">Bank account check</see> for details on when a document should be submitted.
    /// &gt;Required if the <c>documentType</c> is <b>BANK_STATEMENT</b>, where a document is being submitted in order to verify a bank account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccountUUID")]
    public string? BankAccountUuid { get; init; }

    /// <summary>
    /// Description of the document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

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
    [JsonPropertyName("documentType")]
    public required DocumentType DocumentType { get; init; }

    /// <summary>
    /// Filename of the document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filename")]
    public string? Filename { get; init; }

    /// <summary>
    /// The Adyen-generated <see href="https://docs.adyen.com/api-explorer/#/Account/latest/post/createAccountHolder__resParam_accountHolderDetails-legalArrangements-legalArrangementCode"><c>legalArrangementCode</c></see> to which the document must be linked.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangementCode")]
    public string? LegalArrangementCode { get; init; }

    /// <summary>
    /// The Adyen-generated <see href="https://docs.adyen.com/api-explorer/#/Account/v6/post/createAccountHolder__resParam_accountHolderDetails-legalArrangements-legalArrangementEntities-legalArrangementEntityCode"><c>legalArrangementEntityCode</c></see>  to which the document must be linked.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangementEntityCode")]
    public string? LegalArrangementEntityCode { get; init; }

    /// <summary>
    /// The Adyen-generated <see href="https://docs.adyen.com/api-explorer/#/Account/latest/post/createAccountHolder__resParam_accountHolderDetails-businessDetails-shareholders-shareholderCode"><c>shareholderCode</c></see> to which the document must be linked. Refer to <see href="https://docs.adyen.com/classic-platforms/verification-checks">Verification checks</see> for details on when a document should be submitted.
    /// &gt;Required if the account holder has a <c>legalEntity</c> of type <b>Business</b> and the <c>documentType</c> is either <b>PASSPORT</b>, <b>ID_CARD_FRONT</b>, <b>ID_CARD_BACK</b>, <b>DRIVING_LICENCE_FRONT</b>, or <b>DRIVING_LICENCE_BACK</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shareholderCode")]
    public string? ShareholderCode { get; init; }

    /// <summary>
    /// The Adyen-generated <see href="https://docs.adyen.com/api-explorer/#/Account/v6/post/createAccountHolder__resParam_accountHolderDetails-businessDetails-signatories-signatoryCode"><c>signatoryCode</c></see> to which the document must be linked.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signatoryCode")]
    public string? SignatoryCode { get; init; }
}
