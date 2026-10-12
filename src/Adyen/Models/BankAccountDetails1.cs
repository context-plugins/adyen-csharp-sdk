using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains the business account details. Returned when you create a payment instrument with <c>type</c> <b>bankAccount</b>.
/// </summary>
public record BankAccountDetails1
{
    /// <summary>
    /// The bank account number, without separators or whitespace.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountNumber")]
    public string? AccountNumber { get; init; }

    /// <summary>
    /// The bank account type.
    /// <para>
    /// Possible values: <b>checking</b> or <b>savings</b>. Defaults to <b>checking</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountType")]
    public string? AccountType { get; init; } = "checking";

    /// <summary>
    /// The bank account branch number, without separators or whitespace
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("branchNumber")]
    public string? BranchNumber { get; init; }

    /// <summary>
    /// Business accounts with a <c>formFactor</c> value of <b>physical</b> are business accounts issued under the central bank of that country. The default value is <b>physical</b> for NL, US, and UK business accounts.
    /// <para>
    /// Adyen creates a local IBAN for business accounts when the <c>formFactor</c> value is set to <b>virtual</b>. The local IBANs that are supported are for DE and FR, which reference a physical NL account, with funds being routed through the central bank of NL.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("formFactor")]
    public string? FormFactor { get; init; } = "physical";

    /// <summary>
    /// The international bank account number as defined in the <see href="https://www.iso.org/standard/81090.html">ISO-13616</see> standard.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iban")]
    public string? Iban { get; init; }

    /// <summary>
    /// The <see href="https://en.wikipedia.org/wiki/ABA_routing_transit_number">routing number</see>, without separators or whitespace.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("routingNumber")]
    public string? RoutingNumber { get; init; }

    /// <summary>
    /// The <see href="https://en.wikipedia.org/wiki/Sort_code">sort code</see>, without separators or whitespace.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sortCode")]
    public string? SortCode { get; init; }

    /// <summary>
    /// <b>iban</b> or <b>usLocal</b> or <b>ukLocal</b>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "iban";
}
