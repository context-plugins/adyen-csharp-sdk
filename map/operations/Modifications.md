<!-- Generated file — do not edit; regenerated with the SDK. -->

# Modifications — operations

Accessor: `client.Modifications` · Source: `src/Adyen/Api/Modifications.cs` · 14 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostAdjustAuthorisation

- **Server group**: `Default1`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostAdjustAuthorisation(PostAdjustAuthorisationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ModificationResult`
- **Error**: `ApiException<PostAdjustAuthorisationError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostAdjustAuthorisationRequest` | `src/Adyen/Requests/Modifications/PostAdjustAuthorisationRequest.cs` |
| `AdjustAuthorisationRequest` | `src/Adyen/Models/AdjustAuthorisationRequest.cs` |
| `ModificationResult` | `src/Adyen/Models/ModificationResult.cs` |
| `PostAdjustAuthorisationError` | `src/Adyen/Errors/PostAdjustAuthorisationError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostCancel

- **Server group**: `Default1`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCancel(PostCancelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ModificationResult`
- **Error**: `ApiException<PostCancelError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCancelRequest` | `src/Adyen/Requests/Modifications/PostCancelRequest.cs` |
| `CancelRequest` | `src/Adyen/Models/CancelRequest.cs` |
| `ModificationResult` | `src/Adyen/Models/ModificationResult.cs` |
| `PostCancelError` | `src/Adyen/Errors/PostCancelError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostCancelOrRefund

- **Server group**: `Default1`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCancelOrRefund(PostCancelOrRefundRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ModificationResult`
- **Error**: `ApiException<PostCancelOrRefundError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCancelOrRefundRequest` | `src/Adyen/Requests/Modifications/PostCancelOrRefundRequest.cs` |
| `CancelOrRefundRequest` | `src/Adyen/Models/CancelOrRefundRequest.cs` |
| `ModificationResult` | `src/Adyen/Models/ModificationResult.cs` |
| `PostCancelOrRefundError` | `src/Adyen/Errors/PostCancelOrRefundError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostCancels

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCancels(PostCancelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `StandalonePaymentCancelResponse`
- **Error**: `ApiException<PostCancelsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCancelsRequest` | `src/Adyen/Requests/Modifications/PostCancelsRequest.cs` |
| `StandalonePaymentCancelRequest` | `src/Adyen/Models/StandalonePaymentCancelRequest.cs` |
| `StandalonePaymentCancelResponse` | `src/Adyen/Models/StandalonePaymentCancelResponse.cs` |
| `PostCancelsError` | `src/Adyen/Errors/PostCancelsError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostCapture

- **Server group**: `Default1`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCapture(PostCaptureRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ModificationResult`
- **Error**: `ApiException<PostCaptureError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCaptureRequest` | `src/Adyen/Requests/Modifications/PostCaptureRequest.cs` |
| `CaptureRequest` | `src/Adyen/Models/CaptureRequest.cs` |
| `ModificationResult` | `src/Adyen/Models/ModificationResult.cs` |
| `PostCaptureError` | `src/Adyen/Errors/PostCaptureError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostDonate

- **Server group**: `Default1`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostDonate(PostDonateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ModificationResult`
- **Error**: `ApiException<PostDonateError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDonateRequest` | `src/Adyen/Requests/Modifications/PostDonateRequest.cs` |
| `DonationRequest` | `src/Adyen/Models/DonationRequest.cs` |
| `ModificationResult` | `src/Adyen/Models/ModificationResult.cs` |
| `PostDonateError` | `src/Adyen/Errors/PostDonateError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostPaymentsPaymentPspReferenceAmountUpdates

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostPaymentsPaymentPspReferenceAmountUpdates(PostPaymentsPaymentPspReferenceAmountUpdatesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentPspReference`
- **Returns**: `PaymentAmountUpdateResponse`
- **Error**: `ApiException<PostPaymentsPaymentPspReferenceAmountUpdatesError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPaymentsPaymentPspReferenceAmountUpdatesRequest` | `src/Adyen/Requests/Modifications/PostPaymentsPaymentPspReferenceAmountUpdatesRequest.cs` |
| `PaymentAmountUpdateRequest` | `src/Adyen/Models/PaymentAmountUpdateRequest.cs` |
| `PaymentAmountUpdateResponse` | `src/Adyen/Models/PaymentAmountUpdateResponse.cs` |
| `PostPaymentsPaymentPspReferenceAmountUpdatesError` | `src/Adyen/Errors/PostPaymentsPaymentPspReferenceAmountUpdatesError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostPaymentsPaymentPspReferenceCancels

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostPaymentsPaymentPspReferenceCancels(PostPaymentsPaymentPspReferenceCancelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentPspReference`
- **Returns**: `PaymentCancelResponse`
- **Error**: `ApiException<PostPaymentsPaymentPspReferenceCancelsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPaymentsPaymentPspReferenceCancelsRequest` | `src/Adyen/Requests/Modifications/PostPaymentsPaymentPspReferenceCancelsRequest.cs` |
| `PaymentCancelRequest` | `src/Adyen/Models/PaymentCancelRequest.cs` |
| `PaymentCancelResponse` | `src/Adyen/Models/PaymentCancelResponse.cs` |
| `PostPaymentsPaymentPspReferenceCancelsError` | `src/Adyen/Errors/PostPaymentsPaymentPspReferenceCancelsError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostPaymentsPaymentPspReferenceCaptures

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostPaymentsPaymentPspReferenceCaptures(PostPaymentsPaymentPspReferenceCapturesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentPspReference`
- **Returns**: `PaymentCaptureResponse`
- **Error**: `ApiException<PostPaymentsPaymentPspReferenceCapturesError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPaymentsPaymentPspReferenceCapturesRequest` | `src/Adyen/Requests/Modifications/PostPaymentsPaymentPspReferenceCapturesRequest.cs` |
| `PaymentCaptureRequest` | `src/Adyen/Models/PaymentCaptureRequest.cs` |
| `PaymentCaptureResponse` | `src/Adyen/Models/PaymentCaptureResponse.cs` |
| `PostPaymentsPaymentPspReferenceCapturesError` | `src/Adyen/Errors/PostPaymentsPaymentPspReferenceCapturesError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostPaymentsPaymentPspReferenceRefunds

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostPaymentsPaymentPspReferenceRefunds(PostPaymentsPaymentPspReferenceRefundsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentPspReference`
- **Returns**: `PaymentRefundResponse`
- **Error**: `ApiException<PostPaymentsPaymentPspReferenceRefundsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPaymentsPaymentPspReferenceRefundsRequest` | `src/Adyen/Requests/Modifications/PostPaymentsPaymentPspReferenceRefundsRequest.cs` |
| `PaymentRefundRequest` | `src/Adyen/Models/PaymentRefundRequest.cs` |
| `PaymentRefundResponse` | `src/Adyen/Models/PaymentRefundResponse.cs` |
| `PostPaymentsPaymentPspReferenceRefundsError` | `src/Adyen/Errors/PostPaymentsPaymentPspReferenceRefundsError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostPaymentsPaymentPspReferenceReversals

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostPaymentsPaymentPspReferenceReversals(PostPaymentsPaymentPspReferenceReversalsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentPspReference`
- **Returns**: `PaymentReversalResponse`
- **Error**: `ApiException<PostPaymentsPaymentPspReferenceReversalsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPaymentsPaymentPspReferenceReversalsRequest` | `src/Adyen/Requests/Modifications/PostPaymentsPaymentPspReferenceReversalsRequest.cs` |
| `PaymentReversalRequest` | `src/Adyen/Models/PaymentReversalRequest.cs` |
| `PaymentReversalResponse` | `src/Adyen/Models/PaymentReversalResponse.cs` |
| `PostPaymentsPaymentPspReferenceReversalsError` | `src/Adyen/Errors/PostPaymentsPaymentPspReferenceReversalsError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostRefund

- **Server group**: `Default1`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostRefund(PostRefundRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ModificationResult`
- **Error**: `ApiException<PostRefundError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostRefundRequest` | `src/Adyen/Requests/Modifications/PostRefundRequest.cs` |
| `RefundRequest` | `src/Adyen/Models/RefundRequest.cs` |
| `ModificationResult` | `src/Adyen/Models/ModificationResult.cs` |
| `PostRefundError` | `src/Adyen/Errors/PostRefundError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostTechnicalCancel

- **Server group**: `Default1`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostTechnicalCancel(PostTechnicalCancelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ModificationResult`
- **Error**: `ApiException<PostTechnicalCancelError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTechnicalCancelRequest` | `src/Adyen/Requests/Modifications/PostTechnicalCancelRequest.cs` |
| `TechnicalCancelRequest` | `src/Adyen/Models/TechnicalCancelRequest.cs` |
| `ModificationResult` | `src/Adyen/Models/ModificationResult.cs` |
| `PostTechnicalCancelError` | `src/Adyen/Errors/PostTechnicalCancelError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostVoidPendingRefund

- **Server group**: `Default1`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostVoidPendingRefund(PostVoidPendingRefundRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ModificationResult`
- **Error**: `ApiException<PostVoidPendingRefundError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostVoidPendingRefundRequest` | `src/Adyen/Requests/Modifications/PostVoidPendingRefundRequest.cs` |
| `VoidPendingRefundRequest` | `src/Adyen/Models/VoidPendingRefundRequest.cs` |
| `ModificationResult` | `src/Adyen/Models/ModificationResult.cs` |
| `PostVoidPendingRefundError` | `src/Adyen/Errors/PostVoidPendingRefundError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

