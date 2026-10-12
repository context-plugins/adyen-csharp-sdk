<!-- Generated file — do not edit; regenerated with the SDK. -->

# IDealProfiles — operations

Accessor: `client.IDealProfiles` · Source: `src/Adyen/Api/IDealProfiles.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostIdealProfileAuthLink

- **Server group**: `Default20`
- **Signature**: `PostIdealProfileAuthLink(PostIdealProfileAuthLinkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IdealAuthLinkResponse`
- **Error**: `ApiException<PostIdealProfileAuthLinkError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostIdealProfileAuthLinkRequest` | `src/Adyen/Requests/IDealProfiles/PostIdealProfileAuthLinkRequest.cs` |
| `IdealAuthLinkRequest` | `src/Adyen/Models/IdealAuthLinkRequest.cs` |
| `IdealAuthLinkResponse` | `src/Adyen/Models/IdealAuthLinkResponse.cs` |
| `PostIdealProfileAuthLinkError` | `src/Adyen/Errors/PostIdealProfileAuthLinkError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostIdealProfileAuthenticate

- **Server group**: `Default20`
- **Signature**: `PostIdealProfileAuthenticate(PostIdealProfileAuthenticateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IdealAuthenticateResponse`
- **Error**: `ApiException<PostIdealProfileAuthenticateError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostIdealProfileAuthenticateRequest` | `src/Adyen/Requests/IDealProfiles/PostIdealProfileAuthenticateRequest.cs` |
| `IdealAuthenticateRequest` | `src/Adyen/Models/IdealAuthenticateRequest.cs` |
| `IdealAuthenticateResponse` | `src/Adyen/Models/IdealAuthenticateResponse.cs` |
| `PostIdealProfileAuthenticateError` | `src/Adyen/Errors/PostIdealProfileAuthenticateError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostIdealProfileRegister

- **Server group**: `Default20`
- **Signature**: `PostIdealProfileRegister(PostIdealProfileRegisterRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProfileRegistrationResponse`
- **Error**: `ApiException<PostIdealProfileRegisterError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostIdealProfileRegisterRequest` | `src/Adyen/Requests/IDealProfiles/PostIdealProfileRegisterRequest.cs` |
| `ProfileRegistrationRequest` | `src/Adyen/Models/ProfileRegistrationRequest.cs` |
| `ProfileRegistrationResponse` | `src/Adyen/Models/ProfileRegistrationResponse.cs` |
| `PostIdealProfileRegisterError` | `src/Adyen/Errors/PostIdealProfileRegisterError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

