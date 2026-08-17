using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ThreeDsRequestData
{
    /// <summary>
    /// Dimensions of the 3DS2 challenge window to be displayed to the cardholder.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>01</b> - size of 250x400</description></item>
    ///   <item><description><b>02</b> - size of 390x400</description></item>
    ///   <item><description><b>03</b> - size of 500x600</description></item>
    ///   <item><description><b>04</b> - size of 600x400</description></item>
    ///   <item><description><b>05</b> - Fullscreen</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("challengeWindowSize")]
    public ChallengeWindowSize? ChallengeWindowSize { get; init; }

    /// <summary>
    /// Required to trigger the <see href="https://docs.adyen.com/online-payments/3d-secure/data-only/">data-only flow</see>. When set to <b>true</b>, forces the 3D Secure 2 data-only flow for all transactions where it is possible.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataOnly")]
    public DataOnly? DataOnly { get; init; }

    /// <summary>
    /// Indicates if <see href="https://docs.adyen.com/online-payments/3d-secure/native-3ds2">native 3D Secure authentication</see> should be triggered when available. Adyen can still select to fallback to the redirect flow to optimize authorization rates and improve the shopper's experience.
    /// <para>
    /// Possible values:
    /// * <b>preferred</b>: Use native 3D Secure authentication when available.
    /// * <b>disabled</b>: Use the redirect 3D Secure authentication flow.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nativeThreeDS")]
    public NativeThreeDs? NativeThreeDs { get; init; }

    /// <summary>
    /// The version of 3D Secure to use.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>2.1.0</b></description></item>
    ///   <item><description><b>2.2.0</b></description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSVersion")]
    public ThreeDsVersion? ThreeDsVersion { get; init; }
}
