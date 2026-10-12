using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The key you share with Adyen to secure local communications when using Terminal API.
/// </summary>
public record Key1
{
    /// <summary>
    /// The unique identifier of the shared key.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("identifier")]
    public string? Identifier { get; init; }

    /// <summary>
    /// The secure passphrase to protect the shared key. Must consist of:
    /// <list type="bullet">
    ///   <item><description>At least 12 characters.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>At least 1 uppercase letter: <c>[A-Z]</c>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>At least 1 lowercase letter: <c>[a-z]</c>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>At least 1 digit: <c>[0-9]</c>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>At least 1 special character. Limited to the following: <c>~</c>, <c>!</c>, <c>@</c>, <c>#</c>, <c>$</c>, <c>%</c>, <c>^</c>, <c>&amp;</c>, <c>*</c>, <c>(</c>, <c>)</c>, <c>_</c>, <c>+</c>, <c>=</c>, <c>}</c>, <c>{</c>, <c>]</c>, <c>[</c>, <c>;</c>, <c>:</c>, <c>?</c>, <c>.</c>, <c>,</c>, <c>&gt;</c>, <c>&lt;</c>.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("passphrase")]
    public string? Passphrase { get; init; }

    /// <summary>
    /// The version number of the shared key.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }
}
