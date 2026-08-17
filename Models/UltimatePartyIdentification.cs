using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record UltimatePartyIdentification
{
    /// <summary>
    /// The address of the bank account or card owner.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public Address12? Address { get; init; }

    /// <summary>
    /// The date of birth of the individual in <see href="https://www.w3.org/TR/NOTE-datetime">ISO-8601</see> format. For example, <b>YYYY-MM-DD</b>.
    /// <para>
    /// Allowed only when <c>type</c> is <b>individual</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfBirth")]
    public DateTimeOffset? DateOfBirth { get; init; }

    /// <summary>
    /// The email address of the organization or individual. Maximum length: 254 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    [MaxLength(254)]
    public string? Email { get; init; }

    /// <summary>
    /// The first name of the individual.
    /// <para>
    /// Supported characters: [a-z] [A-Z] - . / — and space.
    /// </para>
    /// <para>
    /// This parameter is:
    /// - Allowed only when <c>type</c> is <b>individual</b>.
    /// - Required when <c>category</c> is <b>card</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstName")]
    public string? FirstName { get; init; }

    /// <summary>
    /// The full name of the entity that owns the bank account or card.
    /// <para>
    /// Supported characters: [a-z] [A-Z] [0-9] , . ; : - — / \ + &amp; ! ? @ ( ) " ' and space.
    /// </para>
    /// <para>
    /// Required when <c>category</c> is <b>bank</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fullName")]
    public string? FullName { get; init; }

    /// <summary>
    /// Details of the card or token used to fund the pay-in transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingInstrument")]
    public FundingInstrument2? FundingInstrument { get; init; }

    /// <summary>
    /// The last name of the individual.
    /// <para>
    /// Supported characters: [a-z] [A-Z] - . / — and space.
    /// </para>
    /// <para>
    /// This parameter is:
    /// - Allowed only when <c>type</c> is <b>individual</b>.
    /// - Required when <c>category</c> is <b>card</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastName")]
    public string? LastName { get; init; }

    /// <summary>
    /// A unique reference to identify the party or counterparty involved in the transfer. For example, your client's unique wallet or payee ID.
    /// <para>
    /// Required when you include <c>cardIdentification.storedPaymentMethodId</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    [MaxLength(150)]
    public string? Reference { get; init; }

    /// <summary>
    /// The type of entity that owns the bank account or card.
    /// <para>
    /// Possible values: <b>individual</b>, <b>organization</b>, or <b>unknown</b>.
    /// </para>
    /// <para>
    /// Required when <c>category</c> is <b>card</b>. In this case, the value must be <b>individual</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public Type112? Type { get; init; } = Type112.Unknown;

    /// <summary>
    /// The URL of the organization or individual. Maximum length: 255 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    [MaxLength(255)]
    public string? Url { get; init; }
}
