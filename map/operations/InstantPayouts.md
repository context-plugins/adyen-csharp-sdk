<!-- Generated file — do not edit; regenerated with the SDK. -->

# InstantPayouts — operations

Accessor: `client.InstantPayouts` · Source: `src/Adyen/Api/InstantPayouts.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostPayout

- **Server group**: `Default3`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostPayout(PostPayoutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PayoutResponse`
- **Error**: `ApiException<PostPayoutError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPayoutRequest` | `src/Adyen/Requests/InstantPayouts/PostPayoutRequest.cs` |
| `PayoutRequest` | `src/Adyen/Models/PayoutRequest.cs` |
| `PayoutResponse` | `src/Adyen/Models/PayoutResponse.cs` |
| `PostPayoutError` | `src/Adyen/Errors/PostPayoutError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

