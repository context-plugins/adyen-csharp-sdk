using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AssociationStatus>))]
public sealed record AssociationStatus : StringEnum<AssociationStatus>
{
    private AssociationStatus(string value) : base(value)
    {
    }

    public static readonly AssociationStatus PendingApproval = new("pendingApproval");

    public static readonly AssociationStatus Active = new("active");

    public static AssociationStatus FromValue(string value) => FromValueCore(value);
}
