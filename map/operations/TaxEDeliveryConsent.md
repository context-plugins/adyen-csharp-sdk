<!-- Generated file — do not edit; regenerated with the SDK. -->

# TaxEDeliveryConsent — operations

Accessor: `client.TaxEDeliveryConsent` · Source: `src/Adyen/Api/TaxEDeliveryConsent.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostLegalEntitiesIdCheckTaxElectronicDeliveryConsent

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostLegalEntitiesIdCheckTaxElectronicDeliveryConsent(PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `CheckTaxElectronicDeliveryConsentResponse`
- **Error**: `ApiException<PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentRequest` | `src/Adyen/Requests/TaxEDeliveryConsent/PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentRequest.cs` |
| `CheckTaxElectronicDeliveryConsentResponse` | `src/Adyen/Models/CheckTaxElectronicDeliveryConsentResponse.cs` |
| `PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentError` | `src/Adyen/Errors/PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostLegalEntitiesIdSetTaxElectronicDeliveryConsent

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostLegalEntitiesIdSetTaxElectronicDeliveryConsent(PostLegalEntitiesIdSetTaxElectronicDeliveryConsentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<PostLegalEntitiesIdSetTaxElectronicDeliveryConsentError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostLegalEntitiesIdSetTaxElectronicDeliveryConsentRequest` | `src/Adyen/Requests/TaxEDeliveryConsent/PostLegalEntitiesIdSetTaxElectronicDeliveryConsentRequest.cs` |
| `SetTaxElectronicDeliveryConsentRequest` | `src/Adyen/Models/SetTaxElectronicDeliveryConsentRequest.cs` |
| `PostLegalEntitiesIdSetTaxElectronicDeliveryConsentError` | `src/Adyen/Errors/PostLegalEntitiesIdSetTaxElectronicDeliveryConsentError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

