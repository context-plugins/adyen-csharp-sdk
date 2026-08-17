using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Contains the business account details.
/// </summary>
public record BankAccountModel1
{
    /// <summary>
    /// Business accounts with a <c>formFactor</c> value of <b>physical</b> are business accounts issued under the central bank of that country. The default value is <b>physical</b> for NL, US, and UK business accounts.
    /// <para>
    /// Adyen creates a local IBAN for business accounts when the <c>formFactor</c> value is set to <b>virtual</b>. The local IBANs that are supported are for DE and FR, which reference a physical NL account, with funds being routed through the central bank of NL.
    /// </para>
    /// </summary>
    [JsonPropertyName("formFactor")]
    public FormFactor? FormFactor { get; init; } = FormFactor.Physical;
}
