<!-- Generated file — do not edit; regenerated with the SDK. -->

# GrantOffersApi — operations

Accessor: `client.GrantOffersApi` · Source: `src/Adyen/Api/GrantOffersApi.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetGrantOffers

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetGrantOffers(GetGrantOffersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountHolderId`
- **Query params (wire ← C#)**: `accountHolderId` ← `AccountHolderId`
- **Returns**: `GrantOffers`
- **Error**: `ApiException<GetGrantOffersError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetGrantOffersRequest` | `src/Adyen/Requests/GrantOffersApi/GetGrantOffersRequest.cs` |
| `GrantOffers` | `src/Adyen/Models/GrantOffers.cs` |
| `GetGrantOffersError` | `src/Adyen/Errors/GetGrantOffersError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetGrantOffers1

- **Server group**: `Default15`
- **Signature**: `GetGrantOffers1(GetGrantOffers1Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountHolderId`
- **Query params (wire ← C#)**: `accountHolderId` ← `AccountHolderId`
- **Returns**: `GrantOffers`
- **Error**: `ApiException<GetGrantOffers1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetGrantOffers1Request` | `src/Adyen/Requests/GrantOffersApi/GetGrantOffers1Request.cs` |
| `GrantOffers` | `src/Adyen/Models/GrantOffers.cs` |
| `GetGrantOffers1Error` | `src/Adyen/Errors/GetGrantOffers1Error.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetGrantOffersGrantOfferId

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetGrantOffersGrantOfferId(GetGrantOffersGrantOfferIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `GrantOfferId`
- **Returns**: `GrantOffer`
- **Error**: `ApiException<GetGrantOffersGrantOfferIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetGrantOffersGrantOfferIdRequest` | `src/Adyen/Requests/GrantOffersApi/GetGrantOffersGrantOfferIdRequest.cs` |
| `GrantOffer` | `src/Adyen/Models/GrantOffer.cs` |
| `GetGrantOffersGrantOfferIdError` | `src/Adyen/Errors/GetGrantOffersGrantOfferIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetGrantOffersId

- **Server group**: `Default15`
- **Signature**: `GetGrantOffersId(GetGrantOffersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `GrantOffer1`
- **Error**: `ApiException<GetGrantOffersIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetGrantOffersIdRequest` | `src/Adyen/Requests/GrantOffersApi/GetGrantOffersIdRequest.cs` |
| `GrantOffer1` | `src/Adyen/Models/GrantOffer1.cs` |
| `GetGrantOffersIdError` | `src/Adyen/Errors/GetGrantOffersIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

