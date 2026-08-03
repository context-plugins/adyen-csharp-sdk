using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostAuthCertificateError : ApiError
{
    private readonly Optional<AuthCertificate400Error1> _authCertificate400Error1Value;

    private readonly Optional<AuthCertificate401Error1> _authCertificate401Error1Value;

    private readonly Optional<AuthCertificate422Error1> _authCertificate422Error1Value;

    private readonly Optional<AuthCertificate500Error1> _authCertificate500Error1Value;

    private PostAuthCertificateError(Optional<AuthCertificate400Error1> authCertificate400Error1Value,
        Optional<AuthCertificate401Error1> authCertificate401Error1Value,
        Optional<AuthCertificate422Error1> authCertificate422Error1Value,
        Optional<AuthCertificate500Error1> authCertificate500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _authCertificate400Error1Value = authCertificate400Error1Value;
        _authCertificate401Error1Value = authCertificate401Error1Value;
        _authCertificate422Error1Value = authCertificate422Error1Value;
        _authCertificate500Error1Value = authCertificate500Error1Value;
    }

    private static PostAuthCertificateError AsAuthCertificate400Error1(AuthCertificate400Error1 value) =>
        new(Optional<AuthCertificate400Error1>.Some(value), default, default, default, default);

    private static PostAuthCertificateError AsAuthCertificate401Error1(AuthCertificate401Error1 value) =>
        new(default, Optional<AuthCertificate401Error1>.Some(value), default, default, default);

    private static PostAuthCertificateError AsAuthCertificate422Error1(AuthCertificate422Error1 value) =>
        new(default, default, Optional<AuthCertificate422Error1>.Some(value), default, default);

    private static PostAuthCertificateError AsAuthCertificate500Error1(AuthCertificate500Error1 value) =>
        new(default, default, default, Optional<AuthCertificate500Error1>.Some(value), default);

    private static PostAuthCertificateError AsFallback(RawError value) =>
        new(default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetAuthCertificate400Error1(out AuthCertificate400Error1 value) =>
        _authCertificate400Error1Value.TryGetValue(out value);

    public bool TryGetAuthCertificate401Error1(out AuthCertificate401Error1 value) =>
        _authCertificate401Error1Value.TryGetValue(out value);

    public bool TryGetAuthCertificate422Error1(out AuthCertificate422Error1 value) =>
        _authCertificate422Error1Value.TryGetValue(out value);

    public bool TryGetAuthCertificate500Error1(out AuthCertificate500Error1 value) =>
        _authCertificate500Error1Value.TryGetValue(out value);

    internal static Task<PostAuthCertificateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<AuthCertificate400Error1>(response, ct).As(AsAuthCertificate400Error1),
            401 => FromJson<AuthCertificate401Error1>(response, ct).As(AsAuthCertificate401Error1),
            422 => FromJson<AuthCertificate422Error1>(response, ct).As(AsAuthCertificate422Error1),
            500 => FromJson<AuthCertificate500Error1>(response, ct).As(AsAuthCertificate500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostAuthCertificateErrorResponse : IErrorResponse<PostAuthCertificateError>
{
    public static PostAuthCertificateErrorResponse Instance { get; } = new();

    private PostAuthCertificateErrorResponse()
    {
    }

    public Task<PostAuthCertificateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostAuthCertificateError.Create(response, ct);
}
