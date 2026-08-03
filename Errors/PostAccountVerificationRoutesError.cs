using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostAccountVerificationRoutesError : ApiError
{
    private readonly Optional<AccountVerificationRoutes400Error1> _accountVerificationRoutes400Error1Value;

    private readonly Optional<AccountVerificationRoutes401Error1> _accountVerificationRoutes401Error1Value;

    private readonly Optional<AccountVerificationRoutes422Error1> _accountVerificationRoutes422Error1Value;

    private readonly Optional<AccountVerificationRoutes429Error1> _accountVerificationRoutes429Error1Value;

    private readonly Optional<AccountVerificationRoutes500Error1> _accountVerificationRoutes500Error1Value;

    private PostAccountVerificationRoutesError(Optional<AccountVerificationRoutes400Error1> accountVerificationRoutes400Error1Value,
        Optional<AccountVerificationRoutes401Error1> accountVerificationRoutes401Error1Value,
        Optional<AccountVerificationRoutes422Error1> accountVerificationRoutes422Error1Value,
        Optional<AccountVerificationRoutes429Error1> accountVerificationRoutes429Error1Value,
        Optional<AccountVerificationRoutes500Error1> accountVerificationRoutes500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _accountVerificationRoutes400Error1Value = accountVerificationRoutes400Error1Value;
        _accountVerificationRoutes401Error1Value = accountVerificationRoutes401Error1Value;
        _accountVerificationRoutes422Error1Value = accountVerificationRoutes422Error1Value;
        _accountVerificationRoutes429Error1Value = accountVerificationRoutes429Error1Value;
        _accountVerificationRoutes500Error1Value = accountVerificationRoutes500Error1Value;
    }

    private static PostAccountVerificationRoutesError AsAccountVerificationRoutes400Error1(AccountVerificationRoutes400Error1 value) =>
        new(Optional<AccountVerificationRoutes400Error1>.Some(value), default, default, default, default, default);

    private static PostAccountVerificationRoutesError AsAccountVerificationRoutes401Error1(AccountVerificationRoutes401Error1 value) =>
        new(default, Optional<AccountVerificationRoutes401Error1>.Some(value), default, default, default, default);

    private static PostAccountVerificationRoutesError AsAccountVerificationRoutes422Error1(AccountVerificationRoutes422Error1 value) =>
        new(default, default, Optional<AccountVerificationRoutes422Error1>.Some(value), default, default, default);

    private static PostAccountVerificationRoutesError AsAccountVerificationRoutes429Error1(AccountVerificationRoutes429Error1 value) =>
        new(default, default, default, Optional<AccountVerificationRoutes429Error1>.Some(value), default, default);

    private static PostAccountVerificationRoutesError AsAccountVerificationRoutes500Error1(AccountVerificationRoutes500Error1 value) =>
        new(default, default, default, default, Optional<AccountVerificationRoutes500Error1>.Some(value), default);

    private static PostAccountVerificationRoutesError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetAccountVerificationRoutes400Error1(out AccountVerificationRoutes400Error1 value) =>
        _accountVerificationRoutes400Error1Value.TryGetValue(out value);

    public bool TryGetAccountVerificationRoutes401Error1(out AccountVerificationRoutes401Error1 value) =>
        _accountVerificationRoutes401Error1Value.TryGetValue(out value);

    public bool TryGetAccountVerificationRoutes422Error1(out AccountVerificationRoutes422Error1 value) =>
        _accountVerificationRoutes422Error1Value.TryGetValue(out value);

    public bool TryGetAccountVerificationRoutes429Error1(out AccountVerificationRoutes429Error1 value) =>
        _accountVerificationRoutes429Error1Value.TryGetValue(out value);

    public bool TryGetAccountVerificationRoutes500Error1(out AccountVerificationRoutes500Error1 value) =>
        _accountVerificationRoutes500Error1Value.TryGetValue(out value);

    internal static Task<PostAccountVerificationRoutesError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<AccountVerificationRoutes400Error1>(response, ct).As(AsAccountVerificationRoutes400Error1),
            401 => FromJson<AccountVerificationRoutes401Error1>(response, ct).As(AsAccountVerificationRoutes401Error1),
            422 => FromJson<AccountVerificationRoutes422Error1>(response, ct).As(AsAccountVerificationRoutes422Error1),
            429 => FromJson<AccountVerificationRoutes429Error1>(response, ct).As(AsAccountVerificationRoutes429Error1),
            500 => FromJson<AccountVerificationRoutes500Error1>(response, ct).As(AsAccountVerificationRoutes500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostAccountVerificationRoutesErrorResponse : IErrorResponse<PostAccountVerificationRoutesError>
{
    public static PostAccountVerificationRoutesErrorResponse Instance { get; } = new();

    private PostAccountVerificationRoutesErrorResponse()
    {
    }

    public Task<PostAccountVerificationRoutesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostAccountVerificationRoutesError.Create(response, ct);
}
