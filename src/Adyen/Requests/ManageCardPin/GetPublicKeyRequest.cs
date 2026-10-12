namespace Adyen.Requests.ManageCardPin;

/// <summary>
/// The inputs of the GetPublicKey operation.
/// </summary>
public sealed record GetPublicKeyRequest
{
    /// <summary>
    /// The purpose of the public key.
    /// <para>
    /// Possible values: <b>pinChange</b>, <b>pinReveal</b>, <b>panReveal</b>.
    /// </para>
    /// <para>
    /// Default value: <b>pinReveal</b>.
    /// </para>
    /// </summary>
    public string? Purpose { get; init; }

    /// <summary>
    /// The encoding format of public key.
    /// <para>
    /// Possible values: <b>jwk</b>, <b>pem</b>.
    /// </para>
    /// <para>
    /// Default value: <b>pem</b>.
    /// </para>
    /// </summary>
    public string? Format { get; init; }
}
