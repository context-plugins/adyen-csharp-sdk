using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Specifies how the person is associated with the account holder.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>Owner</b>: Individuals who directly or indirectly own 25% or more of a company.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>Controller</b>: Individuals who are members of senior management staff responsible for managing a company or organization.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ShareholderType>))]
public sealed record ShareholderType : StringEnum<ShareholderType>
{
    private ShareholderType(string value) : base(value)
    {
    }

    public static readonly ShareholderType Controller = new("Controller");

    public static readonly ShareholderType Owner = new("Owner");

    public static readonly ShareholderType Signatory = new("Signatory");

    public static ShareholderType FromValue(string value) => FromValueCore(value);
}
