using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostIdealProfileRegisterError : ApiError
{
    private readonly Optional<IdealProfileRegister400Error1> _idealProfileRegister400Error1Value;

    private readonly Optional<IdealProfileRegister422Error1> _idealProfileRegister422Error1Value;

    private readonly Optional<IdealProfileRegister500Error1> _idealProfileRegister500Error1Value;

    private PostIdealProfileRegisterError(Optional<IdealProfileRegister400Error1> idealProfileRegister400Error1Value,
        Optional<IdealProfileRegister422Error1> idealProfileRegister422Error1Value,
        Optional<IdealProfileRegister500Error1> idealProfileRegister500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _idealProfileRegister400Error1Value = idealProfileRegister400Error1Value;
        _idealProfileRegister422Error1Value = idealProfileRegister422Error1Value;
        _idealProfileRegister500Error1Value = idealProfileRegister500Error1Value;
    }

    private static PostIdealProfileRegisterError AsIdealProfileRegister400Error1(IdealProfileRegister400Error1 value) =>
        new(Optional<IdealProfileRegister400Error1>.Some(value), default, default, default);

    private static PostIdealProfileRegisterError AsIdealProfileRegister422Error1(IdealProfileRegister422Error1 value) =>
        new(default, Optional<IdealProfileRegister422Error1>.Some(value), default, default);

    private static PostIdealProfileRegisterError AsIdealProfileRegister500Error1(IdealProfileRegister500Error1 value) =>
        new(default, default, Optional<IdealProfileRegister500Error1>.Some(value), default);

    private static PostIdealProfileRegisterError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetIdealProfileRegister400Error1(out IdealProfileRegister400Error1 value) =>
        _idealProfileRegister400Error1Value.TryGetValue(out value);

    public bool TryGetIdealProfileRegister422Error1(out IdealProfileRegister422Error1 value) =>
        _idealProfileRegister422Error1Value.TryGetValue(out value);

    public bool TryGetIdealProfileRegister500Error1(out IdealProfileRegister500Error1 value) =>
        _idealProfileRegister500Error1Value.TryGetValue(out value);

    internal static Task<PostIdealProfileRegisterError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<IdealProfileRegister400Error1>(response, ct).As(AsIdealProfileRegister400Error1),
            422 => FromJson<IdealProfileRegister422Error1>(response, ct).As(AsIdealProfileRegister422Error1),
            500 => FromJson<IdealProfileRegister500Error1>(response, ct).As(AsIdealProfileRegister500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostIdealProfileRegisterErrorResponse : IErrorResponse<PostIdealProfileRegisterError>
{
    public static PostIdealProfileRegisterErrorResponse Instance { get; } = new();

    private PostIdealProfileRegisterErrorResponse()
    {
    }

    public Task<PostIdealProfileRegisterError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostIdealProfileRegisterError.Create(response, ct);
}
