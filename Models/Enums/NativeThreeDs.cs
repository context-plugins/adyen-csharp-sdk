using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates if <see href="https://docs.adyen.com/online-payments/3d-secure/native-3ds2">native 3D Secure authentication</see> should be triggered when available. Adyen can still select to fallback to the redirect flow to optimize authorization rates and improve the shopper's experience.
/// <para>
/// Possible values:
/// * <b>preferred</b>: Use native 3D Secure authentication when available.
/// * <b>disabled</b>: Use the redirect 3D Secure authentication flow.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NativeThreeDs>))]
public sealed record NativeThreeDs : StringEnum<NativeThreeDs>
{
    private NativeThreeDs(string value) : base(value)
    {
    }

    public static readonly NativeThreeDs Preferred = new("preferred");

    public static readonly NativeThreeDs Disabled = new("disabled");

    public static NativeThreeDs FromValue(string value) => FromValueCore(value);
}
