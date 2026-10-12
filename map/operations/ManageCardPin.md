<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageCardPin — operations

Accessor: `client.ManageCardPin` · Source: `src/Adyen/Api/ManageCardPin.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPublicKey

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetPublicKey(GetPublicKeyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `purpose` ← `Purpose`, `format` ← `Format`
- **Returns**: `PublicKeyResponse`
- **Error**: `ApiException<GetPublicKeyError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPublicKeyRequest` | `src/Adyen/Requests/ManageCardPin/GetPublicKeyRequest.cs` |
| `PublicKeyResponse` | `src/Adyen/Models/PublicKeyResponse.cs` |
| `GetPublicKeyError` | `src/Adyen/Errors/GetPublicKeyError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostPinsChange

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostPinsChange(PostPinsChangeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PinChangeResponse`
- **Error**: `ApiException<PostPinsChangeError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPinsChangeRequest` | `src/Adyen/Requests/ManageCardPin/PostPinsChangeRequest.cs` |
| `PinChangeRequest` | `src/Adyen/Models/PinChangeRequest.cs` |
| `PinChangeResponse` | `src/Adyen/Models/PinChangeResponse.cs` |
| `PostPinsChangeError` | `src/Adyen/Errors/PostPinsChangeError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostPinsReveal

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostPinsReveal(PostPinsRevealRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `RevealPinResponse`
- **Error**: `ApiException<PostPinsRevealError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPinsRevealRequest` | `src/Adyen/Requests/ManageCardPin/PostPinsRevealRequest.cs` |
| `RevealPinRequest` | `src/Adyen/Models/RevealPinRequest.cs` |
| `RevealPinResponse` | `src/Adyen/Models/RevealPinResponse.cs` |
| `PostPinsRevealError` | `src/Adyen/Errors/PostPinsRevealError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

