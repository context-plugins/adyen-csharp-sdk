using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of transfer.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>bankTransfer</b>: for push transfers to a transfer instrument or a bank account. The <c>category</c> must be <b>bank</b>.</description></item>
///   <item><description><b>internalTransfer</b>: for push transfers between balance accounts. The <c>category</c> must be <b>internal</b>.</description></item>
///   <item><description><b>internalDirectDebit</b>: for pull transfers (direct debits) between balance accounts. The <c>category</c> must be <b>internal</b>.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type112>))]
public sealed record Type112 : StringEnum<Type112>
{
    private Type112(string value) : base(value)
    {
    }

    public static readonly Type112 BankTransfer = new("bankTransfer");

    public static readonly Type112 InternalTransfer = new("internalTransfer");

    public static readonly Type112 InternalDirectDebit = new("internalDirectDebit");

    public static Type112 FromValue(string value) => FromValueCore(value);
}
