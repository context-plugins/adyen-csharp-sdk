using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Shows the status of the Strong Customer Authentication (SCA) process.
/// <para>
/// Possible values: <b>required</b>, <b>notApplicable</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScaOnApproval>))]
public sealed record ScaOnApproval : StringEnum<ScaOnApproval>
{
    private ScaOnApproval(string value) : base(value)
    {
    }

    public static readonly ScaOnApproval Completed = new("completed");

    public static readonly ScaOnApproval NotApplicable = new("notApplicable");

    public static readonly ScaOnApproval Required = new("required");

    public static ScaOnApproval FromValue(string value) => FromValueCore(value);
}
