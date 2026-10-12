<!-- Generated file — do not edit; regenerated with the SDK. -->

# DynamicOffers — operations

Accessor: `client.DynamicOffers` · Source: `src/Adyen/Api/DynamicOffers.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetDynamicOffers

- **Server group**: `Default15`
- **Signature**: `GetDynamicOffers(GetDynamicOffersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountHolderId`
- **Query params (wire ← C#)**: `accountHolderId` ← `AccountHolderId`, `financingType` ← `FinancingType`
- **Returns**: `GetDynamicOffersResponse`
- **Error**: `ApiException<GetDynamicOffersError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDynamicOffersRequest` | `src/Adyen/Requests/DynamicOffers/GetDynamicOffersRequest.cs` |
| `FinancingType` | `src/Adyen/Models/Enums/FinancingType.cs` |
| `GetDynamicOffersResponse` | `src/Adyen/Models/GetDynamicOffersResponse.cs` |
| `GetDynamicOffersError` | `src/Adyen/Errors/GetDynamicOffersError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostDynamicOffersIdCalculate

- **Server group**: `Default15`
- **Signature**: `PostDynamicOffersIdCalculate(PostDynamicOffersIdCalculateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `CalculatedGrantOffer`
- **Error**: `ApiException<PostDynamicOffersIdCalculateError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDynamicOffersIdCalculateRequest` | `src/Adyen/Requests/DynamicOffers/PostDynamicOffersIdCalculateRequest.cs` |
| `CalculateGrantOfferRequest` | `src/Adyen/Models/CalculateGrantOfferRequest.cs` |
| `CalculatedGrantOffer` | `src/Adyen/Models/CalculatedGrantOffer.cs` |
| `PostDynamicOffersIdCalculateError` | `src/Adyen/Errors/PostDynamicOffersIdCalculateError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostDynamicOffersIdGrantOffer

- **Server group**: `Default15`
- **Signature**: `PostDynamicOffersIdGrantOffer(PostDynamicOffersIdGrantOfferRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `GrantOffer1`
- **Error**: `ApiException<PostDynamicOffersIdGrantOfferError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDynamicOffersIdGrantOfferRequest` | `src/Adyen/Requests/DynamicOffers/PostDynamicOffersIdGrantOfferRequest.cs` |
| `CreateGrantOfferRequest` | `src/Adyen/Models/CreateGrantOfferRequest.cs` |
| `GrantOffer1` | `src/Adyen/Models/GrantOffer1.cs` |
| `PostDynamicOffersIdGrantOfferError` | `src/Adyen/Errors/PostDynamicOffersIdGrantOfferError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

