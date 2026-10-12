<!-- Generated file — do not edit; regenerated with the SDK. -->

# LegalEntities — operations

Accessor: `client.LegalEntities` · Source: `src/Adyen/Api/LegalEntities.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetLegalEntitiesId

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetLegalEntitiesId(GetLegalEntitiesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `LegalEntity3`
- **Error**: `ApiException<GetLegalEntitiesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLegalEntitiesIdRequest` | `src/Adyen/Requests/LegalEntities/GetLegalEntitiesIdRequest.cs` |
| `LegalEntity3` | `src/Adyen/Models/LegalEntity3.cs` |
| `GetLegalEntitiesIdError` | `src/Adyen/Errors/GetLegalEntitiesIdError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### GetLegalEntitiesIdBusinessLines

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetLegalEntitiesIdBusinessLines(GetLegalEntitiesIdBusinessLinesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `BusinessLines`
- **Error**: `ApiException<GetLegalEntitiesIdBusinessLinesError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLegalEntitiesIdBusinessLinesRequest` | `src/Adyen/Requests/LegalEntities/GetLegalEntitiesIdBusinessLinesRequest.cs` |
| `BusinessLines` | `src/Adyen/Models/BusinessLines.cs` |
| `GetLegalEntitiesIdBusinessLinesError` | `src/Adyen/Errors/GetLegalEntitiesIdBusinessLinesError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PatchLegalEntitiesId

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchLegalEntitiesId(PatchLegalEntitiesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `LegalEntity3`
- **Error**: `ApiException<PatchLegalEntitiesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchLegalEntitiesIdRequest` | `src/Adyen/Requests/LegalEntities/PatchLegalEntitiesIdRequest.cs` |
| `LegalEntityInfo` | `src/Adyen/Models/LegalEntityInfo.cs` |
| `LegalEntity3` | `src/Adyen/Models/LegalEntity3.cs` |
| `PatchLegalEntitiesIdError` | `src/Adyen/Errors/PatchLegalEntitiesIdError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostLegalEntities

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostLegalEntities(PostLegalEntitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `LegalEntity3`
- **Error**: `ApiException<PostLegalEntitiesError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostLegalEntitiesRequest` | `src/Adyen/Requests/LegalEntities/PostLegalEntitiesRequest.cs` |
| `LegalEntityInfoRequiredType` | `src/Adyen/Models/LegalEntityInfoRequiredType.cs` |
| `LegalEntity3` | `src/Adyen/Models/LegalEntity3.cs` |
| `PostLegalEntitiesError` | `src/Adyen/Errors/PostLegalEntitiesError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostLegalEntitiesIdCheckVerificationErrors

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostLegalEntitiesIdCheckVerificationErrors(PostLegalEntitiesIdCheckVerificationErrorsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `VerificationErrors`
- **Error**: `ApiException<PostLegalEntitiesIdCheckVerificationErrorsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostLegalEntitiesIdCheckVerificationErrorsRequest` | `src/Adyen/Requests/LegalEntities/PostLegalEntitiesIdCheckVerificationErrorsRequest.cs` |
| `VerificationErrors` | `src/Adyen/Models/VerificationErrors.cs` |
| `PostLegalEntitiesIdCheckVerificationErrorsError` | `src/Adyen/Errors/PostLegalEntitiesIdCheckVerificationErrorsError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostLegalEntitiesIdConfirmDataReview

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostLegalEntitiesIdConfirmDataReview(PostLegalEntitiesIdConfirmDataReviewRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `DataReviewConfirmationResponse`
- **Error**: `ApiException<PostLegalEntitiesIdConfirmDataReviewError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostLegalEntitiesIdConfirmDataReviewRequest` | `src/Adyen/Requests/LegalEntities/PostLegalEntitiesIdConfirmDataReviewRequest.cs` |
| `DataReviewConfirmationResponse` | `src/Adyen/Models/DataReviewConfirmationResponse.cs` |
| `PostLegalEntitiesIdConfirmDataReviewError` | `src/Adyen/Errors/PostLegalEntitiesIdConfirmDataReviewError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostLegalEntitiesIdRequestPeriodicReview

- **Server group**: `Default18`
- **Signature**: `PostLegalEntitiesIdRequestPeriodicReview(PostLegalEntitiesIdRequestPeriodicReviewRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `JsonElement`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostLegalEntitiesIdRequestPeriodicReviewRequest` | `src/Adyen/Requests/LegalEntities/PostLegalEntitiesIdRequestPeriodicReviewRequest.cs` |

