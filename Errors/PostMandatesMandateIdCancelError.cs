using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostMandatesMandateIdCancelError : ApiError
{
    private readonly Optional<MandatesCancel401Error1> _mandatesCancel401Error1Value;

    private readonly Optional<MandatesCancel403Error1> _mandatesCancel403Error1Value;

    private readonly Optional<MandatesCancel404Error1> _mandatesCancel404Error1Value;

    private readonly Optional<MandatesCancel422Error1> _mandatesCancel422Error1Value;

    private readonly Optional<MandatesCancel500Error1> _mandatesCancel500Error1Value;

    private PostMandatesMandateIdCancelError(Optional<MandatesCancel401Error1> mandatesCancel401Error1Value,
        Optional<MandatesCancel403Error1> mandatesCancel403Error1Value,
        Optional<MandatesCancel404Error1> mandatesCancel404Error1Value,
        Optional<MandatesCancel422Error1> mandatesCancel422Error1Value,
        Optional<MandatesCancel500Error1> mandatesCancel500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _mandatesCancel401Error1Value = mandatesCancel401Error1Value;
        _mandatesCancel403Error1Value = mandatesCancel403Error1Value;
        _mandatesCancel404Error1Value = mandatesCancel404Error1Value;
        _mandatesCancel422Error1Value = mandatesCancel422Error1Value;
        _mandatesCancel500Error1Value = mandatesCancel500Error1Value;
    }

    private static PostMandatesMandateIdCancelError AsMandatesCancel401Error1(MandatesCancel401Error1 value) =>
        new(Optional<MandatesCancel401Error1>.Some(value), default, default, default, default, default);

    private static PostMandatesMandateIdCancelError AsMandatesCancel403Error1(MandatesCancel403Error1 value) =>
        new(default, Optional<MandatesCancel403Error1>.Some(value), default, default, default, default);

    private static PostMandatesMandateIdCancelError AsMandatesCancel404Error1(MandatesCancel404Error1 value) =>
        new(default, default, Optional<MandatesCancel404Error1>.Some(value), default, default, default);

    private static PostMandatesMandateIdCancelError AsMandatesCancel422Error1(MandatesCancel422Error1 value) =>
        new(default, default, default, Optional<MandatesCancel422Error1>.Some(value), default, default);

    private static PostMandatesMandateIdCancelError AsMandatesCancel500Error1(MandatesCancel500Error1 value) =>
        new(default, default, default, default, Optional<MandatesCancel500Error1>.Some(value), default);

    private static PostMandatesMandateIdCancelError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetMandatesCancel401Error1(out MandatesCancel401Error1 value) =>
        _mandatesCancel401Error1Value.TryGetValue(out value);

    public bool TryGetMandatesCancel403Error1(out MandatesCancel403Error1 value) =>
        _mandatesCancel403Error1Value.TryGetValue(out value);

    public bool TryGetMandatesCancel404Error1(out MandatesCancel404Error1 value) =>
        _mandatesCancel404Error1Value.TryGetValue(out value);

    public bool TryGetMandatesCancel422Error1(out MandatesCancel422Error1 value) =>
        _mandatesCancel422Error1Value.TryGetValue(out value);

    public bool TryGetMandatesCancel500Error1(out MandatesCancel500Error1 value) =>
        _mandatesCancel500Error1Value.TryGetValue(out value);

    internal static Task<PostMandatesMandateIdCancelError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<MandatesCancel401Error1>(response, ct).As(AsMandatesCancel401Error1),
            403 => FromJson<MandatesCancel403Error1>(response, ct).As(AsMandatesCancel403Error1),
            404 => FromJson<MandatesCancel404Error1>(response, ct).As(AsMandatesCancel404Error1),
            422 => FromJson<MandatesCancel422Error1>(response, ct).As(AsMandatesCancel422Error1),
            500 => FromJson<MandatesCancel500Error1>(response, ct).As(AsMandatesCancel500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostMandatesMandateIdCancelErrorResponse : IErrorResponse<PostMandatesMandateIdCancelError>
{
    public static PostMandatesMandateIdCancelErrorResponse Instance { get; } = new();

    private PostMandatesMandateIdCancelErrorResponse()
    {
    }

    public Task<PostMandatesMandateIdCancelError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostMandatesMandateIdCancelError.Create(response, ct);
}
