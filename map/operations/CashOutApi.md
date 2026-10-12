<!-- Generated file — do not edit; regenerated with the SDK. -->

# CashOutApi — operations

Accessor: `client.CashOutApi` · Source: `src/Adyen/Api/CashOutApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostCashouts

- **Server group**: `Default14`
- **Signature**: `PostCashouts(PostCashoutsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CashOut`
- **Error**: `ApiException<PostCashoutsError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 404, 422, 429, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCashoutsRequest` | `src/Adyen/Requests/CashOutApi/PostCashoutsRequest.cs` |
| `CashOutInfo` | `src/Adyen/Models/CashOutInfo.cs` |
| `CashOut` | `src/Adyen/Models/CashOut.cs` |
| `PostCashoutsError` | `src/Adyen/Errors/PostCashoutsError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

