<!-- Generated file — do not edit; regenerated with the SDK. -->

# Rates — operations

Accessor: `client.Rates` · Source: `src/Adyen/Api/Rates.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostRatesCalculate

- **Server group**: `Default7`
- **Signature**: `PostRatesCalculate(PostRatesCalculateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CalculateRateResponse`
- **Error**: `ApiException<PostRatesCalculateError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostRatesCalculateRequest` | `src/Adyen/Requests/Rates/PostRatesCalculateRequest.cs` |
| `CalculateRateRequest` | `src/Adyen/Models/CalculateRateRequest.cs` |
| `CalculateRateResponse` | `src/Adyen/Models/CalculateRateResponse.cs` |
| `PostRatesCalculateError` | `src/Adyen/Errors/PostRatesCalculateError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

