using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the association.
/// <para>
/// Possible values: <b>active</b> or <b>pendingApproval</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssociationStatus1>))]
public sealed record AssociationStatus1 : StringEnum<AssociationStatus1>
{
    private AssociationStatus1(string value) : base(value)
    {
    }

    public static readonly AssociationStatus1 PendingApproval = new("pendingApproval");

    public static readonly AssociationStatus1 Active = new("active");

    public static AssociationStatus1 FromValue(string value) => FromValueCore(value);
}
