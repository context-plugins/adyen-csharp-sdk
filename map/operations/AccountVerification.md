<!-- Generated file — do not edit; regenerated with the SDK. -->

# AccountVerification — operations

Accessor: `client.AccountVerification` · Source: `src/Adyen/Api/AccountVerification.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAccountVerificationReportsCode

- **Server group**: `Default21`
- **Signature**: `GetAccountVerificationReportsCode(GetAccountVerificationReportsCodeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Code`
- **Returns**: `AccountVerificationReportResponse`
- **Error**: `ApiException<GetAccountVerificationReportsCodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 404, 422, 429, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAccountVerificationReportsCodeRequest` | `src/Adyen/Requests/AccountVerification/GetAccountVerificationReportsCodeRequest.cs` |
| `AccountVerificationReportResponse` | `src/Adyen/Models/AccountVerificationReportResponse.cs` |
| `GetAccountVerificationReportsCodeError` | `src/Adyen/Errors/GetAccountVerificationReportsCodeError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostAccountVerificationRoutes

- **Server group**: `Default21`
- **Signature**: `PostAccountVerificationRoutes(PostAccountVerificationRoutesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AccountVerificationRoutesResponse`
- **Error**: `ApiException<PostAccountVerificationRoutesError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 422, 429, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostAccountVerificationRoutesRequest` | `src/Adyen/Requests/AccountVerification/PostAccountVerificationRoutesRequest.cs` |
| `AccountVerificationRoutesRequest` | `src/Adyen/Models/AccountVerificationRoutesRequest.cs` |
| `AccountVerificationRoutesResponse` | `src/Adyen/Models/AccountVerificationRoutesResponse.cs` |
| `PostAccountVerificationRoutesError` | `src/Adyen/Errors/PostAccountVerificationRoutesError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

