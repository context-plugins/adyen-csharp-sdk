using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// In 3D Secure 2, this is the <c>transStatus</c> from the <c>ARes</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DirectoryResponse>))]
public sealed record DirectoryResponse : StringEnum<DirectoryResponse>
{
    private DirectoryResponse(string value) : base(value)
    {
    }

    public static readonly DirectoryResponse A = new("A");

    public static readonly DirectoryResponse C = new("C");

    public static readonly DirectoryResponse D = new("D");

    public static readonly DirectoryResponse I = new("I");

    public static readonly DirectoryResponse N = new("N");

    public static readonly DirectoryResponse R = new("R");

    public static readonly DirectoryResponse U = new("U");

    public static readonly DirectoryResponse Y = new("Y");

    public static DirectoryResponse FromValue(string value) => FromValueCore(value);
}
