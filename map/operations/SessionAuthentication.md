<!-- Generated file — do not edit; regenerated with the SDK. -->

# SessionAuthentication — operations

Accessor: `client.SessionAuthentication` · Source: `src/Adyen/Api/SessionAuthentication.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostAuthCertificate

- **Server group**: `Default25`
- **Signature**: `PostAuthCertificate(PostAuthCertificateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CertificateLoadingResponse`
- **Error**: `ApiException<PostAuthCertificateError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostAuthCertificateRequest` | `src/Adyen/Requests/SessionAuthentication/PostAuthCertificateRequest.cs` |
| `CertificateLoadingRequest` | `src/Adyen/Models/CertificateLoadingRequest.cs` |
| `CertificateLoadingResponse` | `src/Adyen/Models/CertificateLoadingResponse.cs` |
| `PostAuthCertificateError` | `src/Adyen/Errors/PostAuthCertificateError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostSessions2

- **Server group**: `Default17`
- **Signature**: `PostSessions2(PostSessions2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AuthenticationSessionResponse`
- **Error**: `ApiException<PostSessions2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostSessions2Request` | `src/Adyen/Requests/SessionAuthentication/PostSessions2Request.cs` |
| `AuthenticationSessionRequest` | `src/Adyen/Models/AuthenticationSessionRequest.cs` |
| `AuthenticationSessionResponse` | `src/Adyen/Models/AuthenticationSessionResponse.cs` |
| `PostSessions2Error` | `src/Adyen/Errors/PostSessions2Error.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

