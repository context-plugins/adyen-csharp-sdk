# Reference

> Source: [AdyenClient](AdyenClient.cs)

<details>
<summary><code>Task&lt;object&gt; AbortRequest(AbortRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Body of the Abort Request message.
It conveys Information requested for identification of the message request carrying the transaction to abort. A message to display on the CustomerError Device could be sent by the Sale System (DisplayOutput).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AbortRequest(body);
    // TODO: Handle 'response' of type object
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AbortRequest?](Models/AbortRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminResponse&gt; AdminRequest(AdminRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Empty.
Content of the Custom Admin Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminRequest(body);
    // TODO: Handle 'response' of type AdminResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AdminRequest?](Models/AdminRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminResponse](Models/AdminResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalanceInquiryResponse&gt; BalanceInquiryRequest(BalanceInquiryRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

It conveys Information related to the account for which a Balance Inquiry is requested.
Content of the Balance Inquiry Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BalanceInquiryRequest(body);
    // TODO: Handle 'response' of type BalanceInquiryResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[BalanceInquiryRequest?](Models/BalanceInquiryRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceInquiryResponse](Models/BalanceInquiryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CardAcquisitionResponse&gt; CardAcquisitionRequest(CardAcquisitionRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

It conveys Information related to the payment and loyalty cards to read and analyse. This message pair is usually followed by a message pair (e.g. payment or loyalty) which refers to this Card Acquisition message pair.
Content of the Card Acquisition Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CardAcquisitionRequest(body);
    // TODO: Handle 'response' of type CardAcquisitionResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CardAcquisitionRequest?](Models/CardAcquisitionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CardAcquisitionResponse](Models/CardAcquisitionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CardReaderApduResponse&gt; CardReaderApduRequest(CardReaderApduRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

It contains the APDU request to send to the chip of the card, and a possible invitation message to display on the CashierInterface or the CustomerInterface.
Content of the Card Reader APDU Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CardReaderApduRequest(body);
    // TODO: Handle 'response' of type CardReaderApduResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CardReaderApduRequest?](Models/CardReaderApduRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CardReaderApduResponse](Models/CardReaderApduResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DiagnosisResponse&gt; DiagnosisRequest(DiagnosisRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

It conveys Information related to the target POI for which the diagnosis is requested.
Content of the Diagnosis Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiagnosisRequest(body);
    // TODO: Handle 'response' of type DiagnosisResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DiagnosisRequest?](Models/DiagnosisRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DiagnosisResponse](Models/DiagnosisResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DisplayResponse&gt; DisplayRequest(DisplayRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

It conveys the data to display and the way to process the display. It contains the complete content to display. It might contain an operation (the DisplayOutput element) per Display Device type.
Content of the Display Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DisplayRequest(body);
    // TODO: Handle 'response' of type DisplayResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DisplayRequest?](Models/DisplayRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisplayResponse](Models/DisplayResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EnableServiceResponse&gt; EnableServiceRequest(EnableServiceRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

It conveys the services that will be enabled for the POI Terminal without the request of the Sale System, and a possible invitation for the Customer to start the services.
Content of the Enable Service Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EnableServiceRequest(body);
    // TODO: Handle 'response' of type EnableServiceResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[EnableServiceRequest?](Models/EnableServiceRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EnableServiceResponse](Models/EnableServiceResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTotalsResponse&gt; GetTotalsRequest(GetTotalsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

It conveys information from the Sale System related to the scope and the format of the totals to be computed by the POI System.
Content of the Get Totals Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GetTotalsRequest(body);
    // TODO: Handle 'response' of type GetTotalsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GetTotalsRequest?](Models/GetTotalsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTotalsResponse](Models/GetTotalsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InputResponse&gt; InputRequest(InputRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Content of the `InputRequest` message. It conveys the data to display and how to process it. In addition to the display on the Input Device, it might contain an operation (the `DisplayOutput` element) per Display Device type.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InputRequest(body);
    // TODO: Handle 'response' of type InputResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[InputRequest?](Models/InputRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InputResponse](Models/InputResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LoginResponse&gt; LoginRequest(LoginRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

It conveys information related to the session (period between a Login and the following Logout) to process.
Content of the `LoginRequest` message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LoginRequest(body);
    // TODO: Handle 'response' of type LoginResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[LoginRequest?](Models/LoginRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LoginResponse](Models/LoginResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LogoutResponse&gt; LogoutRequest(LogoutRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Empty.
Content of the Logout Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LogoutRequest(body);
    // TODO: Handle 'response' of type LogoutResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[LogoutRequest?](Models/LogoutRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LogoutResponse](Models/LogoutResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentResponse4&gt; PaymentRequest(PaymentRequest2? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Request sent to terminal to initiate payment.
It conveys Information related to the Payment transaction to process.
Content of the `PaymentRequest` message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentRequest(body);
    // TODO: Handle 'response' of type PaymentResponse4
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[PaymentRequest2?](Models/PaymentRequest2.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentResponse4](Models/PaymentResponse4.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PrintResponse&gt; PrintRequest(PrintRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Content of the Print Request message.
It conveys the complete data to print and how to process the print.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PrintRequest(body);
    // TODO: Handle 'response' of type PrintResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[PrintRequest?](Models/PrintRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PrintResponse](Models/PrintResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ReconciliationResponse&gt; ReconciliationRequest(ReconciliationRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Content of the Reconciliation Request message.
It conveys Information related to the Reconciliation requested by the Sale System.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ReconciliationRequest(body);
    // TODO: Handle 'response' of type ReconciliationResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ReconciliationRequest?](Models/ReconciliationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReconciliationResponse](Models/ReconciliationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ReversalResponse&gt; ReversalRequest(ReversalRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

It conveys Information related to the reversal of a previous payment or a loyalty transaction.
Content of the Reversal Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ReversalRequest(body);
    // TODO: Handle 'response' of type ReversalResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ReversalRequest?](Models/ReversalRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReversalResponse](Models/ReversalResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StoredValueResponse&gt; StoredValueRequest(StoredValueRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

It conveys Information related to the Stored Value transaction to process.
Content of the Stored Value Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.StoredValueRequest(body);
    // TODO: Handle 'response' of type StoredValueResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[StoredValueRequest?](Models/StoredValueRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StoredValueResponse](Models/StoredValueResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionStatusResponse&gt; TransactionStatusRequest(TransactionStatusRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Content of the TransactionStatus Request message.
It conveys Information requested for status of the last or current Payment, Loyalty or Reversal transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionStatusRequest(body);
    // TODO: Handle 'response' of type TransactionStatusResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[TransactionStatusRequest?](Models/TransactionStatusRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionStatusResponse](Models/TransactionStatusResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ApiCredentialsCompanyLevel

> Source: [ApiCredentialsCompanyLevel](Api/ApiCredentialsCompanyLevel.cs)

<details>
<summary><code>Task&lt;ListCompanyApiCredentialsResponse&gt; GetCompaniesCompanyIdApiCredentials(string companyId, int? pageNumber, int? pageSize, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of [API credentials](https://docs.adyen.com/development-resources/api-credentials) for the company account. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsCompanyLevel.GetCompaniesCompanyIdApiCredentials(companyId,
        pageNumber,
        pageSize);
    // TODO: Handle 'response' of type ListCompanyApiCredentialsResponse
}
catch (SdkException<GetCompaniesCompanyIdApiCredentialsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>pageNumber</code> | <code>int?</code> | The number of the page to fetch. |
| <code>pageSize</code> | <code>int?</code> | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCompanyApiCredentialsResponse](Models/ListCompanyApiCredentialsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdApiCredentialsError](Errors/GetCompaniesCompanyIdApiCredentialsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CompanyApiCredential&gt; GetCompaniesCompanyIdApiCredentialsApiCredentialId(string companyId, string apiCredentialId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the [API credential](https://docs.adyen.com/development-resources/api-credentials) identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsCompanyLevel.GetCompaniesCompanyIdApiCredentialsApiCredentialId(companyId,
        apiCredentialId);
    // TODO: Handle 'response' of type CompanyApiCredential
}
catch (SdkException<GetCompaniesCompanyIdApiCredentialsApiCredentialIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>apiCredentialId</code> | <code>string</code> | Unique identifier of the API credential. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CompanyApiCredential](Models/CompanyApiCredential.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdApiCredentialsApiCredentialIdError](Errors/GetCompaniesCompanyIdApiCredentialsApiCredentialIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CompanyApiCredential&gt; PatchCompaniesCompanyIdApiCredentialsApiCredentialId(string companyId, string apiCredentialId, UpdateCompanyApiCredentialRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the API credential's roles, merchant account access, or allowed origins. The request has the new values for the fields you want to change. The response contains the full updated API credential, including the new values from the request. 

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsCompanyLevel.PatchCompaniesCompanyIdApiCredentialsApiCredentialId(companyId,
        apiCredentialId,
        body);
    // TODO: Handle 'response' of type CompanyApiCredential
}
catch (SdkException<PatchCompaniesCompanyIdApiCredentialsApiCredentialIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>apiCredentialId</code> | <code>string</code> | Unique identifier of the API credential. |
| <code>body</code> | <code>[UpdateCompanyApiCredentialRequest?](Models/UpdateCompanyApiCredentialRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CompanyApiCredential](Models/CompanyApiCredential.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchCompaniesCompanyIdApiCredentialsApiCredentialIdError](Errors/PatchCompaniesCompanyIdApiCredentialsApiCredentialIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateCompanyApiCredentialResponse&gt; PostCompaniesCompanyIdApiCredentials(string companyId, CreateCompanyApiCredentialRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an [API credential](https://docs.adyen.com/development-resources/api-credentials) for the company account identified in the path. In the request, you can specify which merchant accounts the new API credential will have access to, as well as its roles and allowed origins.

The response includes several types of authentication details:
* [API key](https://docs.adyen.com/development-resources/api-authentication#api-key-authentication): used for API request authentication.
* [Client key](https://docs.adyen.com/development-resources/client-side-authentication#how-it-works): public key used for client-side authentication.
* [Username and password](https://docs.adyen.com/development-resources/api-authentication#using-basic-authentication): used for basic authentication.

> Make sure you store the API key securely in your system. You won't be able to retrieve it later.

If your API key is lost or compromised, you need to [generate a new API key](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/companies/{companyId}/apiCredentials/{apiCredentialId}/generateApiKey).

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsCompanyLevel.PostCompaniesCompanyIdApiCredentials(companyId, body);
    // TODO: Handle 'response' of type CreateCompanyApiCredentialResponse
}
catch (SdkException<PostCompaniesCompanyIdApiCredentialsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>body</code> | <code>[CreateCompanyApiCredentialRequest?](Models/CreateCompanyApiCredentialRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateCompanyApiCredentialResponse](Models/CreateCompanyApiCredentialResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCompaniesCompanyIdApiCredentialsError](Errors/PostCompaniesCompanyIdApiCredentialsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ApiCredentialsMerchantLevel

> Source: [ApiCredentialsMerchantLevel](Api/ApiCredentialsMerchantLevel.cs)

<details>
<summary><code>Task&lt;ListMerchantApiCredentialsResponse&gt; GetMerchantsMerchantIdApiCredentials(string merchantId, int? pageNumber, int? pageSize, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of [API credentials](https://docs.adyen.com/development-resources/api-credentials) for the merchant account. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsMerchantLevel.GetMerchantsMerchantIdApiCredentials(merchantId,
        pageNumber,
        pageSize);
    // TODO: Handle 'response' of type ListMerchantApiCredentialsResponse
}
catch (SdkException<GetMerchantsMerchantIdApiCredentialsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>pageNumber</code> | <code>int?</code> | The number of the page to fetch. |
| <code>pageSize</code> | <code>int?</code> | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListMerchantApiCredentialsResponse](Models/ListMerchantApiCredentialsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdApiCredentialsError](Errors/GetMerchantsMerchantIdApiCredentialsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiCredential&gt; GetMerchantsMerchantIdApiCredentialsApiCredentialId(string merchantId, string apiCredentialId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the [API credential](https://docs.adyen.com/development-resources/api-credentials) identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsMerchantLevel.GetMerchantsMerchantIdApiCredentialsApiCredentialId(merchantId,
        apiCredentialId);
    // TODO: Handle 'response' of type ApiCredential
}
catch (SdkException<GetMerchantsMerchantIdApiCredentialsApiCredentialIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>apiCredentialId</code> | <code>string</code> | Unique identifier of the API credential. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiCredential](Models/ApiCredential.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdApiCredentialsApiCredentialIdError](Errors/GetMerchantsMerchantIdApiCredentialsApiCredentialIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiCredential&gt; PatchMerchantsMerchantIdApiCredentialsApiCredentialId(string merchantId, string apiCredentialId, UpdateMerchantApiCredentialRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the API credential's roles, or allowed origins. The request has the new values for the fields you want to change. The response contains the full updated API credential, including the new values from the request. 

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsMerchantLevel.PatchMerchantsMerchantIdApiCredentialsApiCredentialId(merchantId,
        apiCredentialId,
        body);
    // TODO: Handle 'response' of type ApiCredential
}
catch (SdkException<PatchMerchantsMerchantIdApiCredentialsApiCredentialIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>apiCredentialId</code> | <code>string</code> | Unique identifier of the API credential. |
| <code>body</code> | <code>[UpdateMerchantApiCredentialRequest?](Models/UpdateMerchantApiCredentialRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiCredential](Models/ApiCredential.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchMerchantsMerchantIdApiCredentialsApiCredentialIdError](Errors/PatchMerchantsMerchantIdApiCredentialsApiCredentialIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateApiCredentialResponse&gt; PostMerchantsMerchantIdApiCredentials(string merchantId, CreateMerchantApiCredentialRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an [API credential](https://docs.adyen.com/development-resources/api-credentials) for the company account identified in the path. In the request, you can specify the roles and allowed origins for the new API credential.

The response includes the:
* [API key](https://docs.adyen.com/development-resources/api-authentication#api-key-authentication): used for API request authentication.
* [Client key](https://docs.adyen.com/development-resources/client-side-authentication#how-it-works): public key used for client-side authentication.
* [Username and password](https://docs.adyen.com/development-resources/api-authentication#using-basic-authentication): used for basic authentication.

> Make sure you store the API key securely in your system. You won't be able to retrieve it later.

If your API key is lost or compromised, you need to [generate a new API key](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/apiCredentials/{apiCredentialId}/generateApiKey).

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsMerchantLevel.PostMerchantsMerchantIdApiCredentials(merchantId, body);
    // TODO: Handle 'response' of type CreateApiCredentialResponse
}
catch (SdkException<PostMerchantsMerchantIdApiCredentialsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>body</code> | <code>[CreateMerchantApiCredentialRequest?](Models/CreateMerchantApiCredentialRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateApiCredentialResponse](Models/CreateApiCredentialResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsMerchantIdApiCredentialsError](Errors/PostMerchantsMerchantIdApiCredentialsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ApiKeyCompanyLevel

> Source: [ApiKeyCompanyLevel](Api/ApiKeyCompanyLevel.cs)

<details>
<summary><code>Task&lt;GenerateApiKeyResponse&gt; PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKey(string companyId, string apiCredentialId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a new API key for the API credential. You can use the new API key a few minutes after generating it. The old API key stops working 24 hours after generating a new one.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiKeyCompanyLevel.PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKey(companyId,
        apiCredentialId);
    // TODO: Handle 'response' of type GenerateApiKeyResponse
}
catch (SdkException<PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKeyError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>apiCredentialId</code> | <code>string</code> | Unique identifier of the API credential. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateApiKeyResponse](Models/GenerateApiKeyResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKeyError](Errors/PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKeyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ApiKeyMerchantLevel

> Source: [ApiKeyMerchantLevel](Api/ApiKeyMerchantLevel.cs)

<details>
<summary><code>Task&lt;GenerateApiKeyResponse&gt; PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKey(string merchantId, string apiCredentialId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a new API key for the API credential. You can use the new API key a few minutes after generating it. The old API key stops working 24 hours after generating a new one.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiKeyMerchantLevel.PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKey(merchantId,
        apiCredentialId);
    // TODO: Handle 'response' of type GenerateApiKeyResponse
}
catch (SdkException<PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKeyError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>apiCredentialId</code> | <code>string</code> | Unique identifier of the API credential. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateApiKeyResponse](Models/GenerateApiKeyResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKeyError](Errors/PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKeyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountCompanyLevel

> Source: [AccountCompanyLevel](Api/AccountCompanyLevel.cs)

<details>
<summary><code>Task&lt;ListCompanyResponse&gt; GetCompanies(int? pageNumber, int? pageSize, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of company accounts that your API credential has access to. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Account read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountCompanyLevel.GetCompanies(pageNumber, pageSize);
    // TODO: Handle 'response' of type ListCompanyResponse
}
catch (SdkException<GetCompaniesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>pageNumber</code> | <code>int?</code> | The number of the page to fetch. |
| <code>pageSize</code> | <code>int?</code> | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCompanyResponse](Models/ListCompanyResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesError](Errors/GetCompaniesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Company2&gt; GetCompaniesCompanyId(string companyId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the company account specified in the path. Your API credential must have access to the company account. 

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Account read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountCompanyLevel.GetCompaniesCompanyId(companyId);
    // TODO: Handle 'response' of type Company2
}
catch (SdkException<GetCompaniesCompanyIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Company2](Models/Company2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdError](Errors/GetCompaniesCompanyIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListMerchantResponse&gt; GetCompaniesCompanyIdMerchants(string companyId, int? pageNumber, int? pageSize, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of merchant accounts under the company account specified in the path. The list only includes merchant accounts that your API credential has access to. The list is grouped into pages as defined by the query parameters. 

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Account read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountCompanyLevel.GetCompaniesCompanyIdMerchants(companyId, pageNumber, pageSize);
    // TODO: Handle 'response' of type ListMerchantResponse
}
catch (SdkException<GetCompaniesCompanyIdMerchantsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>pageNumber</code> | <code>int?</code> | The number of the page to fetch. |
| <code>pageSize</code> | <code>int?</code> | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListMerchantResponse](Models/ListMerchantResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdMerchantsError](Errors/GetCompaniesCompanyIdMerchantsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountMerchantLevel

> Source: [AccountMerchantLevel](Api/AccountMerchantLevel.cs)

<details>
<summary><code>Task&lt;ListMerchantResponse&gt; GetMerchants(int? pageNumber, int? pageSize, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of merchant accounts that your API credential has access to. The list is grouped into pages as defined by the query parameters. 

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Account read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountMerchantLevel.GetMerchants(pageNumber, pageSize);
    // TODO: Handle 'response' of type ListMerchantResponse
}
catch (SdkException<GetMerchantsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>pageNumber</code> | <code>int?</code> | The number of the page to fetch. |
| <code>pageSize</code> | <code>int?</code> | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListMerchantResponse](Models/ListMerchantResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsError](Errors/GetMerchantsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Merchant&gt; GetMerchantsMerchantId(string merchantId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the merchant account specified in the path. Your API credential must have access to the merchant account.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Account read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountMerchantLevel.GetMerchantsMerchantId(merchantId);
    // TODO: Handle 'response' of type Merchant
}
catch (SdkException<GetMerchantsMerchantIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Merchant](Models/Merchant.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdError](Errors/GetMerchantsMerchantIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateMerchantResponse&gt; PostMerchants(CreateMerchantRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a merchant account for the company account specified in the request.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Accounts read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountMerchantLevel.PostMerchants(body);
    // TODO: Handle 'response' of type CreateMerchantResponse
}
catch (SdkException<PostMerchantsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateMerchantRequest?](Models/CreateMerchantRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateMerchantResponse](Models/CreateMerchantResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsError](Errors/PostMerchantsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RequestActivationResponse&gt; PostMerchantsMerchantIdActivate(string merchantId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends a request to activate the merchant account identified in the path.

You get the result of the activation asynchronously through a [`merchant.updated`](https://docs.adyen.com/api-explorer/ManagementNotification/latest/post/merchant.updated) webhook. Once the merchant account is activated, you can start using it to accept payments and payouts.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Accounts read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountMerchantLevel.PostMerchantsMerchantIdActivate(merchantId);
    // TODO: Handle 'response' of type RequestActivationResponse
}
catch (SdkException<PostMerchantsMerchantIdActivateError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestActivationResponse](Models/RequestActivationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsMerchantIdActivateError](Errors/PostMerchantsMerchantIdActivateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountStoreLevel

> Source: [AccountStoreLevel](Api/AccountStoreLevel.cs)

<details>
<summary><code>Task&lt;ListStoresResponse&gt; GetMerchantsMerchantIdStores(string merchantId, int? pageNumber, int? pageSize, string? reference, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of stores for the merchant account identified in the path. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.GetMerchantsMerchantIdStores(merchantId,
        pageNumber,
        pageSize,
        reference);
    // TODO: Handle 'response' of type ListStoresResponse
}
catch (SdkException<GetMerchantsMerchantIdStoresError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>pageNumber</code> | <code>int?</code> | The number of the page to fetch. |
| <code>pageSize</code> | <code>int?</code> | The number of items to have on a page, maximum 100. The default is 10 items on a page. |
| <code>reference</code> | <code>string?</code> | The reference of the store. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListStoresResponse](Models/ListStoresResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdStoresError](Errors/GetMerchantsMerchantIdStoresError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Store&gt; GetMerchantsMerchantIdStoresStoreId(string merchantId, string storeId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the store identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.GetMerchantsMerchantIdStoresStoreId(merchantId, storeId);
    // TODO: Handle 'response' of type Store
}
catch (SdkException<GetMerchantsMerchantIdStoresStoreIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>storeId</code> | <code>string</code> | The unique identifier of the store. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Store](Models/Store.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdStoresStoreIdError](Errors/GetMerchantsMerchantIdStoresStoreIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListStoresResponse&gt; GetStores(int? pageNumber, int? pageSize, string? reference, string? merchantId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of stores. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.GetStores(pageNumber, pageSize, reference, merchantId);
    // TODO: Handle 'response' of type ListStoresResponse
}
catch (SdkException<GetStoresError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>pageNumber</code> | <code>int?</code> | The number of the page to fetch. |
| <code>pageSize</code> | <code>int?</code> | The number of items to have on a page, maximum 100. The default is 10 items on a page. |
| <code>reference</code> | <code>string?</code> | The reference of the store. |
| <code>merchantId</code> | <code>string?</code> | The unique identifier of the merchant account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListStoresResponse](Models/ListStoresResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetStoresError](Errors/GetStoresError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Store&gt; GetStoresStoreId(string storeId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the store identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.GetStoresStoreId(storeId);
    // TODO: Handle 'response' of type Store
}
catch (SdkException<GetStoresStoreIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>storeId</code> | <code>string</code> | The unique identifier of the store. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Store](Models/Store.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetStoresStoreIdError](Errors/GetStoresStoreIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Store&gt; PatchMerchantsMerchantIdStoresStoreId(string merchantId, string storeId, UpdateStoreRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the store identified in the path. You can only update some store parameters.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.PatchMerchantsMerchantIdStoresStoreId(merchantId, storeId, body);
    // TODO: Handle 'response' of type Store
}
catch (SdkException<PatchMerchantsMerchantIdStoresStoreIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>storeId</code> | <code>string</code> | The unique identifier of the store. |
| <code>body</code> | <code>[UpdateStoreRequest?](Models/UpdateStoreRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Store](Models/Store.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchMerchantsMerchantIdStoresStoreIdError](Errors/PatchMerchantsMerchantIdStoresStoreIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Store&gt; PatchStoresStoreId(string storeId, UpdateStoreRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the store identified in the path.
You can only update some store parameters.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.PatchStoresStoreId(storeId, body);
    // TODO: Handle 'response' of type Store
}
catch (SdkException<PatchStoresStoreIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>storeId</code> | <code>string</code> | The unique identifier of the store. |
| <code>body</code> | <code>[UpdateStoreRequest?](Models/UpdateStoreRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Store](Models/Store.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchStoresStoreIdError](Errors/PatchStoresStoreIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Store&gt; PostMerchantsMerchantIdStores(string merchantId, StoreCreationRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a store for the merchant account identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.PostMerchantsMerchantIdStores(merchantId, body);
    // TODO: Handle 'response' of type Store
}
catch (SdkException<PostMerchantsMerchantIdStoresError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>body</code> | <code>[StoreCreationRequest?](Models/StoreCreationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Store](Models/Store.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsMerchantIdStoresError](Errors/PostMerchantsMerchantIdStoresError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Store&gt; PostStores(StoreCreationWithMerchantCodeRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a store for the merchant account specified in the request.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.PostStores(body);
    // TODO: Handle 'response' of type Store
}
catch (SdkException<PostStoresError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[StoreCreationWithMerchantCodeRequest?](Models/StoreCreationWithMerchantCodeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Store](Models/Store.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostStoresError](Errors/PostStoresError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountVerification

> Source: [AccountVerification](Api/AccountVerification.cs)

<details>
<summary><code>Task&lt;AccountVerificationReportResponse&gt; GetAccountVerificationReportsCode(string code, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the account verification report using a unique code from a successful open banking connection. This report provides identity verification and bank account details.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountVerification.GetAccountVerificationReportsCode(code);
    // TODO: Handle 'response' of type AccountVerificationReportResponse
}
catch (SdkException<GetAccountVerificationReportsCodeError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>code</code> | <code>string</code> | The unique code you receive after a successful open banking flow that is included as a query parameter in the `redirectUrl` callback. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountVerificationReportResponse](Models/AccountVerificationReportResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAccountVerificationReportsCodeError](Errors/GetAccountVerificationReportsCodeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountVerificationRoutesResponse&gt; PostAccountVerificationRoutes(AccountVerificationRoutesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a list of routes for verifying bank accounts of third-party individuals. Successful connections generate a unique code used for requesting bank reports and verifying identity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountVerification.PostAccountVerificationRoutes(body);
    // TODO: Handle 'response' of type AccountVerificationRoutesResponse
}
catch (SdkException<PostAccountVerificationRoutesError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AccountVerificationRoutesRequest](Models/AccountVerificationRoutesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountVerificationRoutesResponse](Models/AccountVerificationRoutesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostAccountVerificationRoutesError](Errors/PostAccountVerificationRoutesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountHolders

> Source: [AccountHolders](Api/AccountHolders.cs)

<details>
<summary><code>Task&lt;AccountHolder&gt; GetAccountHoldersId(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.GetAccountHoldersId(id);
    // TODO: Handle 'response' of type AccountHolder
}
catch (SdkException<GetAccountHoldersIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the account holder. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountHolder](Models/AccountHolder.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAccountHoldersIdError](Errors/GetAccountHoldersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedBalanceAccountsResponse&gt; GetAccountHoldersIdBalanceAccounts(string id, int? offset, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of the balance accounts associated with an account holder. To fetch multiple pages, use the query parameters. 

For example, to limit the page to 5 balance accounts and skip the first 10, use `/accountHolders/{id}/balanceAccounts?limit=5&offset=10`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.GetAccountHoldersIdBalanceAccounts(id, offset, limit);
    // TODO: Handle 'response' of type PaginatedBalanceAccountsResponse
}
catch (SdkException<GetAccountHoldersIdBalanceAccountsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the account holder. |
| <code>offset</code> | <code>int?</code> | The number of items that you want to skip. |
| <code>limit</code> | <code>int?</code> | The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedBalanceAccountsResponse](Models/PaginatedBalanceAccountsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAccountHoldersIdBalanceAccountsError](Errors/GetAccountHoldersIdBalanceAccountsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TaxFormSummaryResponse&gt; GetAccountHoldersIdTaxFormSummary(string id, string formType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a summary of all tax forms for an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.GetAccountHoldersIdTaxFormSummary(id, formType);
    // TODO: Handle 'response' of type TaxFormSummaryResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the account holder. |
| <code>formType</code> | <code>string</code> | The type of tax form you want a summary for. Accepted values are **US1099k** and **US1099nec**. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TaxFormSummaryResponse](Models/TaxFormSummaryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTaxFormResponse1&gt; GetAccountHoldersIdTaxForms(string id, FormType formType, int year, string? legalEntityId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generates a tax form for account holders operating in the US. For more information, refer to US tax forms for [marketplaces](https://docs.adyen.com/marketplaces/us-tax-forms/) or [platforms](https://docs.adyen.com/platforms/us-tax-forms/) .

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.GetAccountHoldersIdTaxForms(id, formType, year, legalEntityId);
    // TODO: Handle 'response' of type GetTaxFormResponse1
}
catch (SdkException<GetAccountHoldersIdTaxFormsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the account holder. |
| <code>formType</code> | <code>[FormType](Models/Enums/FormType.cs)</code> | The type of tax form you want to retrieve. Accepted values are **US1099k** and **US1099nec**. |
| <code>year</code> | <code>int</code> | The tax year in **YYYY** format for the tax form you want to retrieve. |
| <code>legalEntityId</code> | <code>string?</code> | The legal entity reference whose tax form you want to retrieve. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTaxFormResponse1](Models/GetTaxFormResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAccountHoldersIdTaxFormsError](Errors/GetAccountHoldersIdTaxFormsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionRulesResponse&gt; GetAccountHoldersIdTransactionRules(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of transaction rules associated with an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.GetAccountHoldersIdTransactionRules(id);
    // TODO: Handle 'response' of type TransactionRulesResponse
}
catch (SdkException<GetAccountHoldersIdTransactionRulesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the account holder. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionRulesResponse](Models/TransactionRulesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAccountHoldersIdTransactionRulesError](Errors/GetAccountHoldersIdTransactionRulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountHolder&gt; PatchAccountHoldersId(string id, AccountHolderUpdateRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an account holder. When updating an account holder resource, if a parameter is not provided in the request, it is left unchanged.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PatchAccountHoldersId(id, body);
    // TODO: Handle 'response' of type AccountHolder
}
catch (SdkException<PatchAccountHoldersIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the account holder. |
| <code>body</code> | <code>[AccountHolderUpdateRequest?](Models/AccountHolderUpdateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountHolder](Models/AccountHolder.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchAccountHoldersIdError](Errors/PatchAccountHoldersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountHolder&gt; PostAccountHolders(AccountHolderInfo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an account holder linked to a [legal entity](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities).



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PostAccountHolders(body);
    // TODO: Handle 'response' of type AccountHolder
}
catch (SdkException<PostAccountHoldersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AccountHolderInfo?](Models/AccountHolderInfo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountHolder](Models/AccountHolder.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostAccountHoldersError](Errors/PostAccountHoldersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CloseAccountHolderResponse&gt; PostCloseAccountHolder(CloseAccountHolderRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the [status of an account holder](https://docs.adyen.com/classic-platforms/account-holders-and-accounts#account-holder-statuses) to **Closed**. This state is final. If an account holder is closed, you can't process transactions, pay out funds, or reopen it. If payments are made to an account of an account holder with a **Closed** [`status`](https://docs.adyen.com/api-explorer/#/Account/latest/post/getAccountHolder__resParam_verification-accountHolder-checks-status), the payments are sent to your liable account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PostCloseAccountHolder(body);
    // TODO: Handle 'response' of type CloseAccountHolderResponse
}
catch (SdkException<PostCloseAccountHolderError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CloseAccountHolderRequest?](Models/CloseAccountHolderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CloseAccountHolderResponse](Models/CloseAccountHolderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCloseAccountHolderError](Errors/PostCloseAccountHolderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericResponse&gt; PostCloseStores(CloseStoresRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Closes stores associated with an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PostCloseStores(body);
    // TODO: Handle 'response' of type GenericResponse
}
catch (SdkException<PostCloseStoresError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CloseStoresRequest?](Models/CloseStoresRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericResponse](Models/GenericResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCloseStoresError](Errors/PostCloseStoresError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateAccountHolderResponse&gt; PostCreateAccountHolder(CreateAccountHolderRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an account holder that [represents the sub-merchant's entity](https://docs.adyen.com/classic-platforms/account-structure#your-platform) in your platform. The details that you need to provide in the request depend on the sub-merchant's legal entity type. For more information, refer to [Account holder and accounts](https://docs.adyen.com/classic-platforms/account-holders-and-accounts#legal-entity-types).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PostCreateAccountHolder(body);
    // TODO: Handle 'response' of type CreateAccountHolderResponse
}
catch (SdkException<PostCreateAccountHolderError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateAccountHolderRequest?](Models/CreateAccountHolderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateAccountHolderResponse](Models/CreateAccountHolderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCreateAccountHolderError](Errors/PostCreateAccountHolderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetAccountHolderResponse&gt; PostGetAccountHolder(GetAccountHolderRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PostGetAccountHolder(body);
    // TODO: Handle 'response' of type GetAccountHolderResponse
}
catch (SdkException<PostGetAccountHolderError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GetAccountHolderRequest?](Models/GetAccountHolderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetAccountHolderResponse](Models/GetAccountHolderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostGetAccountHolderError](Errors/PostGetAccountHolderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTaxFormResponse&gt; PostGetTaxForm(GetTaxFormRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generates a tax form for account holders operating in the US. For more information, refer to [Providing tax forms](https://docs.adyen.com/classic-platforms/tax-forms).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PostGetTaxForm(body);
    // TODO: Handle 'response' of type GetTaxFormResponse
}
catch (SdkException<PostGetTaxFormError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GetTaxFormRequest?](Models/GetTaxFormRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTaxFormResponse](Models/GetTaxFormResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostGetTaxFormError](Errors/PostGetTaxFormError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SuspendAccountHolderResponse&gt; PostSuspendAccountHolder(SuspendAccountHolderRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the [status of an account holder](https://docs.adyen.com/classic-platforms/account-holders-and-accounts#account-holder-statuses) to **Suspended**.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PostSuspendAccountHolder(body);
    // TODO: Handle 'response' of type SuspendAccountHolderResponse
}
catch (SdkException<PostSuspendAccountHolderError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SuspendAccountHolderRequest?](Models/SuspendAccountHolderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SuspendAccountHolderResponse](Models/SuspendAccountHolderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostSuspendAccountHolderError](Errors/PostSuspendAccountHolderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UnSuspendAccountHolderResponse&gt; PostUnSuspendAccountHolder(UnSuspendAccountHolderRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the [status of an account holder](https://docs.adyen.com/classic-platforms/account-holders-and-accounts#account-holder-statuses) from **Suspended** to **Inactive**. 
Account holders can have a **Suspended** [`status`](https://docs.adyen.com/api-explorer/#/Account/latest/post/getAccountHolder__resParam_verification-accountHolder-checks-status) if you suspend them through the [`/suspendAccountHolder`](https://docs.adyen.com/api-explorer/#/Account/v5/post/suspendAccountHolder) endpoint or if a verification deadline expires.

You can only unsuspend account holders if they do not have verification checks with a **FAILED** [`status`](https://docs.adyen.com/api-explorer/#/Account/latest/post/getAccountHolder__resParam_verification-accountHolder-checks-status).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PostUnSuspendAccountHolder(body);
    // TODO: Handle 'response' of type UnSuspendAccountHolderResponse
}
catch (SdkException<PostUnSuspendAccountHolderError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[UnSuspendAccountHolderRequest?](Models/UnSuspendAccountHolderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UnSuspendAccountHolderResponse](Models/UnSuspendAccountHolderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostUnSuspendAccountHolderError](Errors/PostUnSuspendAccountHolderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateAccountHolderResponse&gt; PostUpdateAccountHolder(UpdateAccountHolderRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the `accountHolderDetails` and `processingTier` of an account holder, and adds bank accounts and shareholders.

When updating `accountHolderDetails`, parameters that are not included in the request are left unchanged except for the following object:

* `metadata`: Updating the metadata replaces the entire object. This means that to update an existing key-value pair, you must provide the changes, as well as other existing key-value pairs.

When updating any field in the following objects, you must submit all the fields required for validation:

 * `address`

* `fullPhoneNumber`

* `bankAccountDetails.BankAccountDetail`

* `businessDetails.shareholders.ShareholderContact`

 For example, to update the `address.postalCode`, you must also submit the `address.country`, `.city`, `.street`, `.postalCode`, and possibly `.stateOrProvince` so that the address can be validated.

To add a bank account or shareholder, provide the bank account or shareholder details without a `bankAccountUUID` or a `shareholderCode`.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PostUpdateAccountHolder(body);
    // TODO: Handle 'response' of type UpdateAccountHolderResponse
}
catch (SdkException<PostUpdateAccountHolderError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[UpdateAccountHolderRequest?](Models/UpdateAccountHolderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateAccountHolderResponse](Models/UpdateAccountHolderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostUpdateAccountHolderError](Errors/PostUpdateAccountHolderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetAccountHolderStatusResponse&gt; PostUpdateAccountHolderState(UpdateAccountHolderStateRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disables or enables the processing or payout state of an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PostUpdateAccountHolderState(body);
    // TODO: Handle 'response' of type GetAccountHolderStatusResponse
}
catch (SdkException<PostUpdateAccountHolderStateError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[UpdateAccountHolderStateRequest?](Models/UpdateAccountHolderStateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetAccountHolderStatusResponse](Models/GetAccountHolderStatusResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostUpdateAccountHolderStateError](Errors/PostUpdateAccountHolderStateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Accounts

> Source: [Accounts](Api/Accounts.cs)

<details>
<summary><code>Task&lt;CloseAccountResponse&gt; PostCloseAccount(CloseAccountRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Closes an account. If an account is closed, you cannot process transactions, pay out its funds, or reopen it. If payments are made to a closed account, the payments are sent to your liable account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Accounts.PostCloseAccount(body);
    // TODO: Handle 'response' of type CloseAccountResponse
}
catch (SdkException<PostCloseAccountError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CloseAccountRequest?](Models/CloseAccountRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CloseAccountResponse](Models/CloseAccountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCloseAccountError](Errors/PostCloseAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateAccountResponse&gt; PostCreateAccount(CreateAccountRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an account under an account holder. An account holder can have [multiple accounts](https://docs.adyen.com/classic-platforms/account-holders-and-accounts#create-additional-accounts).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Accounts.PostCreateAccount(body);
    // TODO: Handle 'response' of type CreateAccountResponse
}
catch (SdkException<PostCreateAccountError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateAccountRequest?](Models/CreateAccountRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateAccountResponse](Models/CreateAccountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCreateAccountError](Errors/PostCreateAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateAccountResponse&gt; PostUpdateAccount(UpdateAccountRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the description or payout schedule of an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Accounts.PostUpdateAccount(body);
    // TODO: Handle 'response' of type UpdateAccountResponse
}
catch (SdkException<PostUpdateAccountError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[UpdateAccountRequest?](Models/UpdateAccountRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateAccountResponse](Models/UpdateAccountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostUpdateAccountError](Errors/PostUpdateAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AllowedOriginsCompanyLevel

> Source: [AllowedOriginsCompanyLevel](Api/AllowedOriginsCompanyLevel.cs)

<details>
<summary><code>Task DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(string companyId, string apiCredentialId, string originId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes the [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) identified in the path. As soon as an allowed origin is removed, we no longer accept client-side requests from that domain.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.AllowedOriginsCompanyLevel.DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(companyId,
        apiCredentialId,
        originId);
}
catch (SdkException<DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>apiCredentialId</code> | <code>string</code> | Unique identifier of the API credential. |
| <code>originId</code> | <code>string</code> | Unique identifier of the allowed origin. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError](Errors/DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOriginsResponse&gt; GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOrigins(string companyId, string apiCredentialId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) for the API credential identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AllowedOriginsCompanyLevel.GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOrigins(companyId,
        apiCredentialId);
    // TODO: Handle 'response' of type AllowedOriginsResponse
}
catch (SdkException<GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>apiCredentialId</code> | <code>string</code> | Unique identifier of the API credential. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOriginsResponse](Models/AllowedOriginsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsError](Errors/GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOrigin&gt; GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(string companyId, string apiCredentialId, string originId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AllowedOriginsCompanyLevel.GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(companyId,
        apiCredentialId,
        originId);
    // TODO: Handle 'response' of type AllowedOrigin
}
catch (SdkException<GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>apiCredentialId</code> | <code>string</code> | Unique identifier of the API credential. |
| <code>originId</code> | <code>string</code> | Unique identifier of the allowed origin. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOrigin](Models/AllowedOrigin.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError](Errors/GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOrigin&gt; PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOrigins(string companyId, string apiCredentialId, AllowedOrigin? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a new [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) to the API credential's list of allowed origins.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AllowedOriginsCompanyLevel.PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOrigins(companyId,
        apiCredentialId,
        body);
    // TODO: Handle 'response' of type AllowedOrigin
}
catch (SdkException<PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>apiCredentialId</code> | <code>string</code> | Unique identifier of the API credential. |
| <code>body</code> | <code>[AllowedOrigin?](Models/AllowedOrigin.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOrigin](Models/AllowedOrigin.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsError](Errors/PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AllowedOriginsMerchantLevel

> Source: [AllowedOriginsMerchantLevel](Api/AllowedOriginsMerchantLevel.cs)

<details>
<summary><code>Task DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(string merchantId, string apiCredentialId, string originId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes the [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) identified in the path. As soon as an allowed origin is removed, we no longer accept client-side requests from that domain.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.AllowedOriginsMerchantLevel.DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(merchantId,
        apiCredentialId,
        originId);
}
catch (SdkException<DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>apiCredentialId</code> | <code>string</code> | Unique identifier of the API credential. |
| <code>originId</code> | <code>string</code> | Unique identifier of the allowed origin. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError](Errors/DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOriginsResponse&gt; GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOrigins(string merchantId, string apiCredentialId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) for the API credential identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AllowedOriginsMerchantLevel.GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOrigins(merchantId,
        apiCredentialId);
    // TODO: Handle 'response' of type AllowedOriginsResponse
}
catch (SdkException<GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>apiCredentialId</code> | <code>string</code> | Unique identifier of the API credential. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOriginsResponse](Models/AllowedOriginsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsError](Errors/GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOrigin&gt; GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(string merchantId, string apiCredentialId, string originId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AllowedOriginsMerchantLevel.GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(merchantId,
        apiCredentialId,
        originId);
    // TODO: Handle 'response' of type AllowedOrigin
}
catch (SdkException<GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>apiCredentialId</code> | <code>string</code> | Unique identifier of the API credential. |
| <code>originId</code> | <code>string</code> | Unique identifier of the allowed origin. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOrigin](Models/AllowedOrigin.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError](Errors/GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOrigin&gt; PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOrigins(string merchantId, string apiCredentialId, AllowedOrigin? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a new [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) to the API credential's list of allowed origins.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AllowedOriginsMerchantLevel.PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOrigins(merchantId,
        apiCredentialId,
        body);
    // TODO: Handle 'response' of type AllowedOrigin
}
catch (SdkException<PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>apiCredentialId</code> | <code>string</code> | Unique identifier of the API credential. |
| <code>body</code> | <code>[AllowedOrigin?](Models/AllowedOrigin.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOrigin](Models/AllowedOrigin.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsError](Errors/PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AndroidFilesCompanyLevel

> Source: [AndroidFilesCompanyLevel](Api/AndroidFilesCompanyLevel.cs)

<details>
<summary><code>Task&lt;AndroidAppsResponse&gt; GetCompaniesCompanyIdAndroidApps(string companyId, int? pageNumber, int? pageSize, string? packageName, int? versionCode, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of the Android apps that are available for the company identified in the path. 
These apps have been uploaded to Adyen and can be installed or uninstalled on Android payment terminals through [terminal actions](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Android files read
* Management API—Android files read and write
* Management API—Terminal actions read
* Management API—Terminal actions read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AndroidFilesCompanyLevel.GetCompaniesCompanyIdAndroidApps(companyId,
        pageNumber,
        pageSize,
        packageName,
        versionCode);
    // TODO: Handle 'response' of type AndroidAppsResponse
}
catch (SdkException<GetCompaniesCompanyIdAndroidAppsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>pageNumber</code> | <code>int?</code> | The number of the page to fetch. |
| <code>pageSize</code> | <code>int?</code> | The number of items to have on a page, maximum 100. The default is 20 items on a page. |
| <code>packageName</code> | <code>string?</code> | The package name that uniquely identifies the Android app. |
| <code>versionCode</code> | <code>int?</code> | The version number of the app. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AndroidAppsResponse](Models/AndroidAppsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdAndroidAppsError](Errors/GetCompaniesCompanyIdAndroidAppsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AndroidApp&gt; GetCompaniesCompanyIdAndroidAppsId(string companyId, string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the Android app identified in the path. 
These apps have been uploaded to Adyen and can be installed or uninstalled on Android payment terminals through [terminal actions](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Android files read
* Management API—Android files read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AndroidFilesCompanyLevel.GetCompaniesCompanyIdAndroidAppsId(companyId, id);
    // TODO: Handle 'response' of type AndroidApp
}
catch (SdkException<GetCompaniesCompanyIdAndroidAppsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>id</code> | <code>string</code> | The unique identifier of the app. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AndroidApp](Models/AndroidApp.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdAndroidAppsIdError](Errors/GetCompaniesCompanyIdAndroidAppsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AndroidCertificatesResponse&gt; GetCompaniesCompanyIdAndroidCertificates(string companyId, int? pageNumber, int? pageSize, string? certificateName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of the Android certificates that are available for the company identified in the path.
Typically, these certificates enable running apps on Android payment terminals. The certificates in the list have been uploaded to Adyen and can be installed or uninstalled on Android terminals through [terminal actions](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Android files read
* Management API—Android files read and write
* Management API—Terminal actions read
* Management API—Terminal actions read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AndroidFilesCompanyLevel.GetCompaniesCompanyIdAndroidCertificates(companyId,
        pageNumber,
        pageSize,
        certificateName);
    // TODO: Handle 'response' of type AndroidCertificatesResponse
}
catch (SdkException<GetCompaniesCompanyIdAndroidCertificatesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>pageNumber</code> | <code>int?</code> | The number of the page to fetch. |
| <code>pageSize</code> | <code>int?</code> | The number of items to have on a page, maximum 100. The default is 20 items on a page. |
| <code>certificateName</code> | <code>string?</code> | The name of the certificate. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AndroidCertificatesResponse](Models/AndroidCertificatesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdAndroidCertificatesError](Errors/GetCompaniesCompanyIdAndroidCertificatesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ReprocessAndroidAppResponse&gt; PatchCompaniesCompanyIdAndroidAppsId(string companyId, string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Reuploads the Android app identified in the path. 
To make this request, your API credential must have this [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Android files read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).
>By choosing to upload, install, or run any third-party applications on an Adyen payment terminal, you accept full responsibility and liability for any consequences of uploading, installing, or running any such applications.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AndroidFilesCompanyLevel.PatchCompaniesCompanyIdAndroidAppsId(companyId, id);
    // TODO: Handle 'response' of type ReprocessAndroidAppResponse
}
catch (SdkException<PatchCompaniesCompanyIdAndroidAppsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>id</code> | <code>string</code> | The unique identifier of the app. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReprocessAndroidAppResponse](Models/ReprocessAndroidAppResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchCompaniesCompanyIdAndroidAppsIdError](Errors/PatchCompaniesCompanyIdAndroidAppsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadAndroidAppResponse&gt; PostCompaniesCompanyIdAndroidApps(string companyId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads an Android APK file to Adyen.
The maximum APK file size is 200 MB.
To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Android files read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).
>By choosing to upload, install, or run any third-party applications on an Adyen payment terminal, you accept full responsibility and liability for any consequences of uploading, installing, or running any such applications.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AndroidFilesCompanyLevel.PostCompaniesCompanyIdAndroidApps(companyId);
    // TODO: Handle 'response' of type UploadAndroidAppResponse
}
catch (SdkException<PostCompaniesCompanyIdAndroidAppsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadAndroidAppResponse](Models/UploadAndroidAppResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCompaniesCompanyIdAndroidAppsError](Errors/PostCompaniesCompanyIdAndroidAppsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadAndroidCertificateResponse&gt; PostCompaniesCompanyIdAndroidCertificates(string companyId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads an Android Certificate file to Adyen.

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AndroidFilesCompanyLevel.PostCompaniesCompanyIdAndroidCertificates(companyId);
    // TODO: Handle 'response' of type UploadAndroidCertificateResponse
}
catch (SdkException<PostCompaniesCompanyIdAndroidCertificatesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadAndroidCertificateResponse](Models/UploadAndroidCertificateResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCompaniesCompanyIdAndroidCertificatesError](Errors/PostCompaniesCompanyIdAndroidCertificatesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AuthorizedCardUsers

> Source: [AuthorizedCardUsers](Api/AuthorizedCardUsers.cs)

<details>
<summary><code>Task DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(string paymentInstrumentId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the list of authorized users assigned to a card.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.AuthorizedCardUsers.DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(paymentInstrumentId);
}
catch (SdkException<DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>paymentInstrumentId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError](Errors/DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AuthorisedCardUsers&gt; GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(string paymentInstrumentId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the authorized users for a card.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AuthorizedCardUsers.GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(paymentInstrumentId);
    // TODO: Handle 'response' of type AuthorisedCardUsers
}
catch (SdkException<GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>paymentInstrumentId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AuthorisedCardUsers](Models/AuthorisedCardUsers.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError](Errors/GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(string paymentInstrumentId, AuthorisedCardUsers body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the list of authorized users for a card.

>This request replaces all existing authorized users for the card.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.AuthorizedCardUsers.PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(paymentInstrumentId,
        body);
}
catch (SdkException<PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>paymentInstrumentId</code> | <code>string</code> | - |
| <code>body</code> | <code>[AuthorisedCardUsers](Models/AuthorisedCardUsers.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError](Errors/PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(string paymentInstrumentId, AuthorisedCardUsers body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Assigns authorized users to a card. Users must have the **authorisedPaymentInstrumentUser** capability to be able to use the card.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.AuthorizedCardUsers.PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(paymentInstrumentId,
        body);
}
catch (SdkException<PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>paymentInstrumentId</code> | <code>string</code> | - |
| <code>body</code> | <code>[AuthorisedCardUsers](Models/AuthorisedCardUsers.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError](Errors/PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## BalanceAccounts

> Source: [BalanceAccounts](Api/BalanceAccounts.cs)

<details>
<summary><code>Task&lt;BalanceAccount&gt; GetBalanceAccountsId(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a balance account and its balances for the default currency and other currencies with a non-zero balance.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BalanceAccounts.GetBalanceAccountsId(id);
    // TODO: Handle 'response' of type BalanceAccount
}
catch (SdkException<GetBalanceAccountsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the balance account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceAccount](Models/BalanceAccount.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalanceAccountsIdError](Errors/GetBalanceAccountsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedPaymentInstrumentsResponse&gt; GetBalanceAccountsIdPaymentInstruments(string id, int? offset, int? limit, string? status, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of the payment instruments associated with a balance account. 

To fetch multiple pages, use the query parameters.For example, to limit the page to 3 payment instruments which are in active status and to skip the first 6, use `/balanceAccounts/{id}/paymentInstruments?limit=3&offset=6&status=active`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BalanceAccounts.GetBalanceAccountsIdPaymentInstruments(id, offset, limit, status);
    // TODO: Handle 'response' of type PaginatedPaymentInstrumentsResponse
}
catch (SdkException<GetBalanceAccountsIdPaymentInstrumentsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>offset</code> | <code>int?</code> | The number of items that you want to skip. |
| <code>limit</code> | <code>int?</code> | The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page. |
| <code>status</code> | <code>string?</code> | The status of the payment instruments that you want to get. By default, the response includes payment instruments with any status. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedPaymentInstrumentsResponse](Models/PaginatedPaymentInstrumentsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalanceAccountsIdPaymentInstrumentsError](Errors/GetBalanceAccountsIdPaymentInstrumentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionRulesResponse&gt; GetBalanceAccountsIdTransactionRules(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of transaction rules associated with a balance account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BalanceAccounts.GetBalanceAccountsIdTransactionRules(id);
    // TODO: Handle 'response' of type TransactionRulesResponse
}
catch (SdkException<GetBalanceAccountsIdTransactionRulesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the balance account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionRulesResponse](Models/TransactionRulesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalanceAccountsIdTransactionRulesError](Errors/GetBalanceAccountsIdTransactionRulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalanceAccount&gt; PatchBalanceAccountsId(string id, BalanceAccountUpdateRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a balance account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BalanceAccounts.PatchBalanceAccountsId(id, body);
    // TODO: Handle 'response' of type BalanceAccount
}
catch (SdkException<PatchBalanceAccountsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>body</code> | <code>[BalanceAccountUpdateRequest?](Models/BalanceAccountUpdateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceAccount](Models/BalanceAccount.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchBalanceAccountsIdError](Errors/PatchBalanceAccountsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalanceAccount&gt; PostBalanceAccounts(BalanceAccountInfo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a balance account that holds the funds of the associated account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BalanceAccounts.PostBalanceAccounts(body);
    // TODO: Handle 'response' of type BalanceAccount
}
catch (SdkException<PostBalanceAccountsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[BalanceAccountInfo?](Models/BalanceAccountInfo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceAccount](Models/BalanceAccount.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostBalanceAccountsError](Errors/PostBalanceAccountsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## BalanceTransfers

> Source: [BalanceTransfers](Api/BalanceTransfers.cs)

<details>
<summary><code>Task&lt;BalanceTransferResponse&gt; PostBalanceTransfers(BalanceTransferRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Performs a balance transfer between merchant accounts. The following conditions must be met before you can successfully transfer balances:
* The source and destination merchant accounts must be under the same company account and legal entity.
* The source merchant account must have sufficient funds.
* The source and destination merchant accounts must have at least one common processing currency.\n\n
When sending multiple API requests with the same source and destination merchant accounts, send the requests sequentially and *not* in parallel. Some requests may not be processed if the requests are sent in parallel.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BalanceTransfers.PostBalanceTransfers(body);
    // TODO: Handle 'response' of type BalanceTransferResponse
}
catch (SdkException<PostBalanceTransfersError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[BalanceTransferRequest](Models/BalanceTransferRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceTransferResponse](Models/BalanceTransferResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostBalanceTransfersError](Errors/PostBalanceTransfersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Balances

> Source: [Balances](Api/Balances.cs)

<details>
<summary><code>Task&lt;JsonElement&gt; DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId(string balancePlatformId, string webhookId, string settingId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a balance webhook setting that contains the conditions for triggering [balance webhooks](https://docs.adyen.com/api-explorer/balance-webhooks/latest/post/balanceAccount.balance.updated).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Balances.DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId(balancePlatformId,
        webhookId,
        settingId);
    // TODO: Handle 'response' of type JsonElement
}
catch (SdkException<DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balancePlatformId</code> | <code>string</code> | The unique identifier of the balance platform. |
| <code>webhookId</code> | <code>string</code> | The unique identifier of the balance webhook. |
| <code>settingId</code> | <code>string</code> | The unique identifier of the balance webhook setting. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>JsonElement</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError](Errors/DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WebhookSettings&gt; GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettings(string balancePlatformId, string webhookId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns all balance webhook settings configured for triggering [balance webhooks](https://docs.adyen.com/api-explorer/balance-webhooks/latest/post/balanceAccount.balance.updated).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Balances.GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettings(balancePlatformId,
        webhookId);
    // TODO: Handle 'response' of type WebhookSettings
}
catch (SdkException<GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balancePlatformId</code> | <code>string</code> | The unique identifier of the balance platform. |
| <code>webhookId</code> | <code>string</code> | The unique identifier of the balance webhook. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WebhookSettings](Models/WebhookSettings.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError](Errors/GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WebhookSetting&gt; GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId(string balancePlatformId, string webhookId, string settingId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a specific balance webhook setting configured for triggering [balance webhooks](https://docs.adyen.com/api-explorer/balance-webhooks/latest/post/balanceAccount.balance.updated).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Balances.GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId(balancePlatformId,
        webhookId,
        settingId);
    // TODO: Handle 'response' of type WebhookSetting
}
catch (SdkException<GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balancePlatformId</code> | <code>string</code> | The unique identifier of the balance platform. |
| <code>webhookId</code> | <code>string</code> | The unique identifier of the balance webhook. |
| <code>settingId</code> | <code>string</code> | The unique identifier of the balance webhook setting. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WebhookSetting](Models/WebhookSetting.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError](Errors/GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WebhookSetting&gt; PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId(string balancePlatformId, string webhookId, string settingId, BalanceWebhookSettingInfoUpdate body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the conditions the balance change needs to meet for Adyen to send a [balance webhook](https://docs.adyen.com/api-explorer/balance-webhooks/latest/post/balanceAccount.balance.updated).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Balances.PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId(balancePlatformId,
        webhookId,
        settingId,
        body);
    // TODO: Handle 'response' of type WebhookSetting
}
catch (SdkException<PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balancePlatformId</code> | <code>string</code> | The unique identifier of the balance platform. |
| <code>webhookId</code> | <code>string</code> | The unique identifier of the balance webhook. |
| <code>settingId</code> | <code>string</code> | The unique identifier of the balance webhook setting. |
| <code>body</code> | <code>[BalanceWebhookSettingInfoUpdate](Models/BalanceWebhookSettingInfoUpdate.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WebhookSetting](Models/WebhookSetting.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError](Errors/PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WebhookSetting&gt; PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettings(string balancePlatformId, string webhookId, BalanceWebhookSettingInfo body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Configures the criteria for triggering [balance webhooks](https://docs.adyen.com/api-explorer/balance-webhooks/1/post/balancePlatform.balanceAccount.balance.updated).

Adyen sends balance webhooks to notify you of balance changes in your balance platform. They can be triggered when the balance reaches, exceeds, or drops below a specific value in a specific currency.

You can get notified about balance changes in your entire balance platform, in the balance accounts of a specific user, or a specific balance account. The hierarchy between the webhook settings are based on the following business logic:

* Settings on a higher level apply to all lower level resources (balance platform > account holder > balance acocunt).

* The most granular setting overrides higher level settings (balance account > account holder > balance platform).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Balances.PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettings(balancePlatformId,
        webhookId,
        body);
    // TODO: Handle 'response' of type WebhookSetting
}
catch (SdkException<PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balancePlatformId</code> | <code>string</code> | The unique identifier of the balance platform. |
| <code>webhookId</code> | <code>string</code> | The unique identifier of the balance webhook. |
| <code>body</code> | <code>[BalanceWebhookSettingInfo](Models/BalanceWebhookSettingInfo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WebhookSetting](Models/WebhookSetting.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError](Errors/PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## BalancesOverview

> Source: [BalancesOverview](Api/BalancesOverview.cs)

<details>
<summary><code>Task&lt;CompanyBalances&gt; GetBalanceOverviewCompaniesCompanyAccountCodeBalances(string companyAccountCode, string currency, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an array with details about the balances available for all merchant accounts under your company account. For each merchant account, the response returns the following:


* **Available funds**: The funds in the merchant account that have been settled and are available for use.


* **Pending balance**: The funds in the merchant account that have not been settled yet.


* **Next payout amount**: The amount that will be settled to your bank account with the next payout.


* **Reserve**: The available amount to cover refunds, payouts, chargebacks, and other operational expenses that cannot be covered by your in-process funds.


* **Deposit**: The amount withheld by Adyen to cover potential losses and liabilities due to payment processing.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BalancesOverview.GetBalanceOverviewCompaniesCompanyAccountCodeBalances(companyAccountCode,
        currency);
    // TODO: Handle 'response' of type CompanyBalances
}
catch (SdkException<GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyAccountCode</code> | <code>string</code> | The unique identifier of your company account. |
| <code>currency</code> | <code>string</code> | The currency for which you want a balances overview. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CompanyBalances](Models/CompanyBalances.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError](Errors/GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MerchantBalance&gt; GetBalanceOverviewMerchantsMerchantAccountCodeBalances(string merchantAccountCode, string currency, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an overview of the different balances available for the merchant account. This includes details about the following:


* **Available funds**: The funds in the merchant account that have been settled and are available for use.


* **Pending balance**: The funds in the merchant account that have not been settled yet.


* **Next payout amount**: The amount that will be settled to your bank account with the next payout.


* **Reserve**: The available amount to cover refunds, payouts, chargebacks, and other operational expenses that cannot be covered by your in-process funds.


* **Deposit**: The amount withheld by Adyen to cover potential losses and liabilities due to payment processing.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BalancesOverview.GetBalanceOverviewMerchantsMerchantAccountCodeBalances(merchantAccountCode,
        currency);
    // TODO: Handle 'response' of type MerchantBalance
}
catch (SdkException<GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantAccountCode</code> | <code>string</code> | The unique identifier of your merchant account. |
| <code>currency</code> | <code>string</code> | The currency for which you want a balances overview. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MerchantBalance](Models/MerchantBalance.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError](Errors/GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## BankAccountValidation

> Source: [BankAccountValidation](Api/BankAccountValidation.cs)

<details>
<summary><code>Task PostValidateBankAccountIdentification(BankAccountIdentificationValidationRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Validates bank account identification details. You can use this endpoint to validate bank account details before you [make a transfer](https://docs.adyen.com/api-explorer/transfers/latest/post/transfers) or [create a transfer instrument](https://docs.adyen.com/api-explorer/legalentity/latest/post/transferInstruments).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.BankAccountValidation.PostValidateBankAccountIdentification(body);
}
catch (SdkException<PostValidateBankAccountIdentificationError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[BankAccountIdentificationValidationRequest?](Models/BankAccountIdentificationValidationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostValidateBankAccountIdentificationError](Errors/PostValidateBankAccountIdentificationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## BusinessLinesApi

> Source: [BusinessLinesApi](Api/BusinessLinesApi.cs)

<details>
<summary><code>Task DeleteBusinessLinesId(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a business line.

 >If you delete a business line linked to a [payment method](https://docs.adyen.com/development-resources/paymentmethodvariant#management-api), it can affect your merchant account's ability to use the [payment method](https://docs.adyen.com/api-explorer/Management/latest/post/merchants/_merchantId_/paymentMethodSettings). The business line is removed from all linked merchant accounts.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.BusinessLinesApi.DeleteBusinessLinesId(id);
}
catch (SdkException<DeleteBusinessLinesIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the business line to be deleted. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteBusinessLinesIdError](Errors/DeleteBusinessLinesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BusinessLine&gt; GetBusinessLinesId(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the detail of a business line.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BusinessLinesApi.GetBusinessLinesId(id);
    // TODO: Handle 'response' of type BusinessLine
}
catch (SdkException<GetBusinessLinesIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the business line. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BusinessLine](Models/BusinessLine.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBusinessLinesIdError](Errors/GetBusinessLinesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BusinessLine&gt; PatchBusinessLinesId(string id, BusinessLineInfoUpdate? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a business line.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BusinessLinesApi.PatchBusinessLinesId(id, body);
    // TODO: Handle 'response' of type BusinessLine
}
catch (SdkException<PatchBusinessLinesIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the business line. |
| <code>body</code> | <code>[BusinessLineInfoUpdate?](Models/BusinessLineInfoUpdate.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BusinessLine](Models/BusinessLine.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchBusinessLinesIdError](Errors/PatchBusinessLinesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BusinessLine&gt; PostBusinessLines(BusinessLineInfo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a business line. 

This resource contains information about your user's line of business, including their industry and their source of funds. Adyen uses this information to verify your users as required by payment industry regulations.Adyen informs you of the verification results through webhooks or API responses.

You can create a maximum of 200 business lines per legal entity for payment processing.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BusinessLinesApi.PostBusinessLines(body);
    // TODO: Handle 'response' of type BusinessLine
}
catch (SdkException<PostBusinessLinesError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[BusinessLineInfo?](Models/BusinessLineInfo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BusinessLine](Models/BusinessLine.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostBusinessLinesError](Errors/PostBusinessLinesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Capital

> Source: [Capital](Api/Capital.cs)

<details>
<summary><code>Task&lt;CapitalGrants&gt; GetGrants(string? counterpartyAccountHolderId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of grants with status and outstanding balances.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Capital.GetGrants(counterpartyAccountHolderId);
    // TODO: Handle 'response' of type CapitalGrants
}
catch (SdkException<GetGrantsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>counterpartyAccountHolderId</code> | <code>string?</code> | The counterparty account holder id. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CapitalGrants](Models/CapitalGrants.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetGrantsError](Errors/GetGrantsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CapitalGrant&gt; GetGrantsId(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a capital account specified in the path.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Capital.GetGrantsId(id);
    // TODO: Handle 'response' of type CapitalGrant
}
catch (SdkException<GetGrantsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the grant. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CapitalGrant](Models/CapitalGrant.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetGrantsIdError](Errors/GetGrantsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CapitalGrant&gt; PostGrants(string? idempotencyKey, CapitalGrantInfo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Requests the payout of the selected grant offer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Capital.PostGrants(idempotencyKey, body);
    // TODO: Handle 'response' of type CapitalGrant
}
catch (SdkException<PostGrantsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[CapitalGrantInfo?](Models/CapitalGrantInfo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CapitalGrant](Models/CapitalGrant.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostGrantsError](Errors/PostGrantsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CardOrders

> Source: [CardOrders](Api/CardOrders.cs)

<details>
<summary><code>Task&lt;PaginatedGetCardOrderResponse&gt; GetCardorders(string? id, string? cardManufacturingProfileId, string? status, string? txVariantCode, DateTimeOffset? createdSince, DateTimeOffset? createdUntil, DateTimeOffset? lockedSince, DateTimeOffset? lockedUntil, string? serviceCenter, int? offset, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of card orders.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CardOrders.GetCardorders(id,
        cardManufacturingProfileId,
        status,
        txVariantCode,
        createdSince,
        createdUntil,
        lockedSince,
        lockedUntil,
        serviceCenter,
        offset,
        limit);
    // TODO: Handle 'response' of type PaginatedGetCardOrderResponse
}
catch (SdkException<GetCardordersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string?</code> | The unique identifier of the card order. |
| <code>cardManufacturingProfileId</code> | <code>string?</code> | The unique identifier of the card manufacturer profile. |
| <code>status</code> | <code>string?</code> | The status of the card order. |
| <code>txVariantCode</code> | <code>string?</code> | The unique code of the card manufacturer profile.<br><br>Possible values: **mcmaestro**, **mc**, **visa**, **mcdebit**. |
| <code>createdSince</code> | <code>DateTimeOffset?</code> | Only include card orders that have been created on or after this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**. |
| <code>createdUntil</code> | <code>DateTimeOffset?</code> | Only include card orders that have been created on or before this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**. |
| <code>lockedSince</code> | <code>DateTimeOffset?</code> | Only include card orders that have been locked on or after this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**. |
| <code>lockedUntil</code> | <code>DateTimeOffset?</code> | Only include card orders that have been locked on or before this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**. |
| <code>serviceCenter</code> | <code>string?</code> | The service center at which the card is issued. The value is case-sensitive. |
| <code>offset</code> | <code>int?</code> | Specifies the position of an element in a list of card orders. The response includes a list of card orders that starts at the specified offset.<br><br>**Default:** 0, which means that the response contains all the elements in the list of card orders. |
| <code>limit</code> | <code>int?</code> | The number of card orders returned per page. **Default:** 10. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedGetCardOrderResponse](Models/PaginatedGetCardOrderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCardordersError](Errors/GetCardordersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedGetCardOrderItemResponse&gt; GetCardordersIdItems(string id, int? offset, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the item list of a specific card order.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CardOrders.GetCardordersIdItems(id, offset, limit);
    // TODO: Handle 'response' of type PaginatedGetCardOrderItemResponse
}
catch (SdkException<GetCardordersIdItemsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the card order. |
| <code>offset</code> | <code>int?</code> | Specifies the position of an element in a list of card orders. The response includes a list of card order items that starts at the specified offset.<br><br>**Default:** 0, which means that the response contains all the elements in the list of card order items. |
| <code>limit</code> | <code>int?</code> | The number of card order items returned per page. **Default:** 10. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedGetCardOrderItemResponse](Models/PaginatedGetCardOrderItemResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCardordersIdItemsError](Errors/GetCardordersIdItemsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CashOutApi

> Source: [CashOutApi](Api/CashOutApi.cs)

<details>
<summary><code>Task&lt;CashOut&gt; PostCashouts(CashOutInfo body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Initiates a [cashout](https://docs.adyen.com/platforms/cash-out-instantly) request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CashOutApi.PostCashouts(body);
    // TODO: Handle 'response' of type CashOut
}
catch (SdkException<PostCashoutsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CashOutInfo](Models/CashOutInfo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CashOut](Models/CashOut.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCashoutsError](Errors/PostCashoutsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ClientKeyCompanyLevel

> Source: [ClientKeyCompanyLevel](Api/ClientKeyCompanyLevel.cs)

<details>
<summary><code>Task&lt;GenerateClientKeyResponse&gt; PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKey(string companyId, string apiCredentialId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a new [client key](https://docs.adyen.com/development-resources/client-side-authentication#how-it-works) for the API credential identified in the path. You can use the new client key a few minutes after generating it. The old client key stops working 24 hours after generating a new one.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClientKeyCompanyLevel.PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKey(companyId,
        apiCredentialId);
    // TODO: Handle 'response' of type GenerateClientKeyResponse
}
catch (SdkException<PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKeyError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>apiCredentialId</code> | <code>string</code> | Unique identifier of the API credential. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateClientKeyResponse](Models/GenerateClientKeyResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKeyError](Errors/PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKeyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ClientKeyMerchantLevel

> Source: [ClientKeyMerchantLevel](Api/ClientKeyMerchantLevel.cs)

<details>
<summary><code>Task&lt;GenerateClientKeyResponse&gt; PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKey(string merchantId, string apiCredentialId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a new [client key](https://docs.adyen.com/development-resources/client-side-authentication#how-it-works) for the API credential identified in the path. You can use the new client key a few minutes after generating it. The old client key stops working 24 hours after generating a new one.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClientKeyMerchantLevel.PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKey(merchantId,
        apiCredentialId);
    // TODO: Handle 'response' of type GenerateClientKeyResponse
}
catch (SdkException<PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKeyError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>apiCredentialId</code> | <code>string</code> | Unique identifier of the API credential. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateClientKeyResponse](Models/GenerateClientKeyResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKeyError](Errors/PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKeyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CustomPayoutSchedulesSweeps

> Source: [CustomPayoutSchedulesSweeps](Api/CustomPayoutSchedulesSweeps.cs)

<details>
<summary><code>Task DeleteBalanceAccountsBalanceAccountIdSweepsSweepId(string balanceAccountId, string sweepId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a sweep for a balance account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.CustomPayoutSchedulesSweeps.DeleteBalanceAccountsBalanceAccountIdSweepsSweepId(balanceAccountId,
        sweepId);
}
catch (SdkException<DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balanceAccountId</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>sweepId</code> | <code>string</code> | The unique identifier of the sweep. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdError](Errors/DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalanceSweepConfigurationsResponse&gt; GetBalanceAccountsBalanceAccountIdSweeps(string balanceAccountId, int? offset, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of the sweeps configured for a balance account.

To fetch multiple pages, use the query parameters. For example, to limit the page to 5 sweeps and to skip the first 10, use `/balanceAccounts/{balanceAccountId}/sweeps?limit=5&offset=10`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomPayoutSchedulesSweeps.GetBalanceAccountsBalanceAccountIdSweeps(balanceAccountId,
        offset,
        limit);
    // TODO: Handle 'response' of type BalanceSweepConfigurationsResponse
}
catch (SdkException<GetBalanceAccountsBalanceAccountIdSweepsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balanceAccountId</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>offset</code> | <code>int?</code> | The number of items that you want to skip. |
| <code>limit</code> | <code>int?</code> | The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceSweepConfigurationsResponse](Models/BalanceSweepConfigurationsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalanceAccountsBalanceAccountIdSweepsError](Errors/GetBalanceAccountsBalanceAccountIdSweepsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SweepConfigurationV2&gt; GetBalanceAccountsBalanceAccountIdSweepsSweepId(string balanceAccountId, string sweepId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a sweep.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomPayoutSchedulesSweeps.GetBalanceAccountsBalanceAccountIdSweepsSweepId(balanceAccountId,
        sweepId);
    // TODO: Handle 'response' of type SweepConfigurationV2
}
catch (SdkException<GetBalanceAccountsBalanceAccountIdSweepsSweepIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balanceAccountId</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>sweepId</code> | <code>string</code> | The unique identifier of the sweep. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SweepConfigurationV2](Models/SweepConfigurationV2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalanceAccountsBalanceAccountIdSweepsSweepIdError](Errors/GetBalanceAccountsBalanceAccountIdSweepsSweepIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SweepConfigurationV2&gt; PatchBalanceAccountsBalanceAccountIdSweepsSweepId(string balanceAccountId, string sweepId, UpdateSweepConfigurationV2? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a sweep. When updating a sweep resource, note that if a request parameter is not provided, the parameter is left unchanged.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomPayoutSchedulesSweeps.PatchBalanceAccountsBalanceAccountIdSweepsSweepId(balanceAccountId,
        sweepId,
        body);
    // TODO: Handle 'response' of type SweepConfigurationV2
}
catch (SdkException<PatchBalanceAccountsBalanceAccountIdSweepsSweepIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balanceAccountId</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>sweepId</code> | <code>string</code> | The unique identifier of the sweep. |
| <code>body</code> | <code>[UpdateSweepConfigurationV2?](Models/UpdateSweepConfigurationV2.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SweepConfigurationV2](Models/SweepConfigurationV2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchBalanceAccountsBalanceAccountIdSweepsSweepIdError](Errors/PatchBalanceAccountsBalanceAccountIdSweepsSweepIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SweepConfigurationV2&gt; PostBalanceAccountsBalanceAccountIdSweeps(string balanceAccountId, CreateSweepConfigurationV2? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a sweep that results in moving funds from or to a balance account.

A sweep pulls in or pushes out funds based on a defined schedule, amount, currency, and a source or a destination.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomPayoutSchedulesSweeps.PostBalanceAccountsBalanceAccountIdSweeps(balanceAccountId,
        body);
    // TODO: Handle 'response' of type SweepConfigurationV2
}
catch (SdkException<PostBalanceAccountsBalanceAccountIdSweepsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balanceAccountId</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>body</code> | <code>[CreateSweepConfigurationV2?](Models/CreateSweepConfigurationV2.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SweepConfigurationV2](Models/SweepConfigurationV2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostBalanceAccountsBalanceAccountIdSweepsError](Errors/PostBalanceAccountsBalanceAccountIdSweepsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DirectDebitMandates

> Source: [DirectDebitMandates](Api/DirectDebitMandates.cs)

<details>
<summary><code>Task&lt;ListMandatesResponse&gt; GetMandates(string? balanceAccountId, string? paymentInstrumentId, string? cursor, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all [direct debit mandates](https://docs.adyen.com/business-accounts/accept-direct-debits-uk) created for a business account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DirectDebitMandates.GetMandates(balanceAccountId, paymentInstrumentId, cursor);
    // TODO: Handle 'response' of type ListMandatesResponse
}
catch (SdkException<GetMandatesError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balanceAccountId</code> | <code>string?</code> | The unique identifier of the balance account linked to the payment instrument. |
| <code>paymentInstrumentId</code> | <code>string?</code> | The unique identifier of the payment instrument linked to the mandate. |
| <code>cursor</code> | <code>string?</code> | The pagination cursor returned in a previous GET `/mandates` request. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListMandatesResponse](Models/ListMandatesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMandatesError](Errors/GetMandatesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Mandate1&gt; GetMandatesMandateId(string mandateId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the specified [direct debit mandate](https://docs.adyen.com/business-accounts/accept-direct-debits-uk).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DirectDebitMandates.GetMandatesMandateId(mandateId);
    // TODO: Handle 'response' of type Mandate1
}
catch (SdkException<GetMandatesMandateIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>mandateId</code> | <code>string</code> | The unique identifier of the mandate. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Mandate1](Models/Mandate1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMandatesMandateIdError](Errors/GetMandatesMandateIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PatchMandatesMandateId(string mandateId, MandateUpdate body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Amend the specified [direct debit mandate](https://docs.adyen.com/business-accounts/accept-direct-debits-uk).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.DirectDebitMandates.PatchMandatesMandateId(mandateId, body);
}
catch (SdkException<PatchMandatesMandateIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>mandateId</code> | <code>string</code> | The unique identifier of the mandate. |
| <code>body</code> | <code>[MandateUpdate](Models/MandateUpdate.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchMandatesMandateIdError](Errors/PatchMandatesMandateIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PostMandatesMandateIdCancel(string mandateId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancel a specified [direct debit mandate](https://docs.adyen.com/business-accounts/accept-direct-debits-uk).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.DirectDebitMandates.PostMandatesMandateIdCancel(mandateId);
}
catch (SdkException<PostMandatesMandateIdCancelError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>mandateId</code> | <code>string</code> | The unique identifier of the mandate. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMandatesMandateIdCancelError](Errors/PostMandatesMandateIdCancelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DisputeAttachments

> Source: [DisputeAttachments](Api/DisputeAttachments.cs)

<details>
<summary><code>Task DeleteDisputesDisputeIdAttachmentsAttachmentId(string disputeId, string attachmentId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes the attachment from the raised dispute. Adyen may keep this file for compliance purposes.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.DisputeAttachments.DeleteDisputesDisputeIdAttachmentsAttachmentId(disputeId, attachmentId);
}
catch (SdkException<DeleteDisputesDisputeIdAttachmentsAttachmentIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>disputeId</code> | <code>string</code> | The unique identifier of the raised dispute. |
| <code>attachmentId</code> | <code>string</code> | The unique identifier of the attachment. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteDisputesDisputeIdAttachmentsAttachmentIdError](Errors/DeleteDisputesDisputeIdAttachmentsAttachmentIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DisputeAttachment&gt;&gt; GetDisputesDisputeIdAttachments(string disputeId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get a list of attachments associated with a dispute ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DisputeAttachments.GetDisputesDisputeIdAttachments(disputeId);
    // TODO: Handle 'response' of type IReadOnlyList<DisputeAttachment>
}
catch (SdkException<GetDisputesDisputeIdAttachmentsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>disputeId</code> | <code>string</code> | The unique identifier of the raised dispute. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DisputeAttachment](Models/DisputeAttachment.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetDisputesDisputeIdAttachmentsError](Errors/GetDisputesDisputeIdAttachmentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DisputeAttachment&gt; GetDisputesDisputeIdAttachmentsAttachmentId(string disputeId, string attachmentId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Search for a single attachment, providing the specific dispute ID and attachment ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DisputeAttachments.GetDisputesDisputeIdAttachmentsAttachmentId(disputeId, attachmentId);
    // TODO: Handle 'response' of type DisputeAttachment
}
catch (SdkException<GetDisputesDisputeIdAttachmentsAttachmentIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>disputeId</code> | <code>string</code> | The unique identifier of the raised dispute. |
| <code>attachmentId</code> | <code>string</code> | The unique identifier of the attachment. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisputeAttachment](Models/DisputeAttachment.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetDisputesDisputeIdAttachmentsAttachmentIdError](Errors/GetDisputesDisputeIdAttachmentsAttachmentIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AttachDocumentResponse&gt; PostDisputesDisputeIdAttachments(string disputeId, DisputeAttachment body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add supporting information as an attachment for the raised dispute. Upload receipts, communication, or any other documentation to support the dispute.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DisputeAttachments.PostDisputesDisputeIdAttachments(disputeId, body);
    // TODO: Handle 'response' of type AttachDocumentResponse
}
catch (SdkException<PostDisputesDisputeIdAttachmentsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>disputeId</code> | <code>string</code> | The unique identifier of the raised dispute. |
| <code>body</code> | <code>[DisputeAttachment](Models/DisputeAttachment.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AttachDocumentResponse](Models/AttachDocumentResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostDisputesDisputeIdAttachmentsError](Errors/PostDisputesDisputeIdAttachmentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Documents

> Source: [Documents](Api/Documents.cs)

<details>
<summary><code>Task DeleteDocumentsId(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a document.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Documents.DeleteDocumentsId(id);
}
catch (SdkException<DeleteDocumentsIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the document to be deleted. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteDocumentsIdError](Errors/DeleteDocumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Document&gt; GetDocumentsId(string id, bool? skipContent, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a document.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Documents.GetDocumentsId(id, skipContent);
    // TODO: Handle 'response' of type Document
}
catch (SdkException<GetDocumentsIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the document. |
| <code>skipContent</code> | <code>bool?</code> | Do not load document content while fetching the document. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Document](Models/Document.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetDocumentsIdError](Errors/GetDocumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Document&gt; PatchDocumentsId(string id, string? xRequestedVerificationCode, Document? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a document.

 >You can upload a maximum of 15 pages for photo IDs.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Documents.PatchDocumentsId(id, xRequestedVerificationCode, body);
    // TODO: Handle 'response' of type Document
}
catch (SdkException<PatchDocumentsIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the document to be updated. |
| <code>xRequestedVerificationCode</code> | <code>string?</code> | Use the requested verification code 0_0001 to resolve any suberrors associated with the document. Requested verification codes can only be used in your test environment. |
| <code>body</code> | <code>[Document?](Models/Document.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Document](Models/Document.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchDocumentsIdError](Errors/PatchDocumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Document&gt; PostDocuments(string? xRequestedVerificationCode, Document? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads a document for verification checks.

 Adyen uses the information from the [legal entity](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities) to run automated verification checks. If these checks fail, you will be notified to provide additional documents.

 You should only upload documents when Adyen requests additional information for the legal entity.

 >You can upload a maximum of 15 pages for photo IDs.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Documents.PostDocuments(xRequestedVerificationCode, body);
    // TODO: Handle 'response' of type Document
}
catch (SdkException<PostDocumentsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>xRequestedVerificationCode</code> | <code>string?</code> | Use a suberror code as your requested verification code. You can include one code at a time in your request header. Requested verification codes can only be used in your test environment. |
| <code>body</code> | <code>[Document?](Models/Document.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Document](Models/Document.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostDocumentsError](Errors/PostDocumentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DonationCampaigns

> Source: [DonationCampaigns](Api/DonationCampaigns.cs)

<details>
<summary><code>Task DeleteCompaniesCompanyIdCampaignManagementDonationCampaignId(string companyId, string donationCampaignId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes the donation campaign specified in the path. This request is only allowed if the campaign has the status **inactive**.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Campaign Management read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.DonationCampaigns.DeleteCompaniesCompanyIdCampaignManagementDonationCampaignId(companyId,
        donationCampaignId);
}
catch (SdkException<DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>donationCampaignId</code> | <code>string</code> | The unique identifier of the donation campaign to be deleted. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdError](Errors/DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListDonationCampaignsResponse&gt; GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderId(string companyId, string accountHolderId, string? status, int? pageNumber = 1, int? pageSize = 10, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of donation campaigns associated with the account holder specified in the path. You can filter the list by campaign status.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Campaign Management read
* Management API—Campaign Management read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DonationCampaigns.GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderId(companyId,
        accountHolderId,
        status);
    // TODO: Handle 'response' of type ListDonationCampaignsResponse
}
catch (SdkException<GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>accountHolderId</code> | <code>string</code> | The unique identifier of the account holder. |
| <code>status</code> | <code>string?</code> | The campaign status to return campaigns that match. Allowed values: **inactive**, **active**, or **ended**. |
| <code>pageNumber</code> | <code>int?</code> | The number of the page to fetch.<br>**Default**: 1 |
| <code>pageSize</code> | <code>int?</code> | The number of items to have on a page, maximum 100. The default is 10 items on a page.<br>**Default**: 10 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListDonationCampaignsResponse](Models/ListDonationCampaignsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError](Errors/GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DonationCampaign1&gt; PatchCompaniesCompanyIdCampaignManagementDonationCampaignId(string companyId, string donationCampaignId, DonationCampaignUpdate? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the properties of the donation campaign specified in the path. Note the following restrictions: 

* You cannot use a PATCH request to update the campaign status. To activate or end a campaign, make a POST request to the `/campaignManagement/{campaignId}/status/{status}` endpoint.
* You get a validation error if you add account holders that are not compatible with the nonprofit.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Campaign Management read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DonationCampaigns.PatchCompaniesCompanyIdCampaignManagementDonationCampaignId(companyId,
        donationCampaignId,
        body);
    // TODO: Handle 'response' of type DonationCampaign1
}
catch (SdkException<PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>donationCampaignId</code> | <code>string</code> | The unique identifier of the donation campaign to be updated. |
| <code>body</code> | <code>[DonationCampaignUpdate?](Models/DonationCampaignUpdate.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DonationCampaign1](Models/DonationCampaign1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdError](Errors/PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DonationCampaign1&gt; PostCompaniesCompanyIdCampaignManagement(string companyId, DonationCampaignRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new donation campaign, to give shoppers the option to donate to a nonprofit organization when making a payment. A campaign can be for online payments, in-person payments, or both online and in-person payments.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Campaign Management read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DonationCampaigns.PostCompaniesCompanyIdCampaignManagement(companyId, body);
    // TODO: Handle 'response' of type DonationCampaign1
}
catch (SdkException<PostCompaniesCompanyIdCampaignManagementError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>body</code> | <code>[DonationCampaignRequest?](Models/DonationCampaignRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DonationCampaign1](Models/DonationCampaign1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCompaniesCompanyIdCampaignManagementError](Errors/PostCompaniesCompanyIdCampaignManagementError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DonationCampaign1&gt; PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatus(string companyId, string donationCampaignId, CampaignStatusTransition status, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Starts or stops the donation campaign specified in the path, by providing a path parameter. 
Use the path parameter **activate** to start an inactive campaign, or **end** to stop an active campaign. Other status transitions are not allowed.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Campaign Management read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DonationCampaigns.PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatus(companyId,
        donationCampaignId,
        status);
    // TODO: Handle 'response' of type DonationCampaign1
}
catch (SdkException<PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>donationCampaignId</code> | <code>string</code> | The unique identifier of the donation campaign to activate or end. |
| <code>status</code> | <code>[CampaignStatusTransition](Models/Enums/CampaignStatusTransition.cs)</code> | The desired status change. Possible values: **activate** or **end**. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DonationCampaign1](Models/DonationCampaign1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError](Errors/PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListNonprofitsResponse&gt; PostCompaniesCompanyIdNonprofits(string companyId, string? searchTerm, int? pageNumber, IReadOnlyList&lt;string&gt;? goal, ListNonprofitsRequest? body, int? pageSize = 10, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of supported nonprofit organizations to choose from when creating a donation campaign. The list only contains nonprofits that are compatible with all the account holders specified in the request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DonationCampaigns.PostCompaniesCompanyIdNonprofits(companyId,
        searchTerm,
        pageNumber,
        goal,
        body);
    // TODO: Handle 'response' of type ListNonprofitsResponse
}
catch (SdkException<PostCompaniesCompanyIdNonprofitsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>searchTerm</code> | <code>string?</code> | A query to return nonprofit organizations for, maximum 100 characters. For example, `&searchTerm=clean%20water`. |
| <code>pageNumber</code> | <code>int?</code> | The number of the page to fetch. |
| <code>goal</code> | <code>IReadOnlyList&lt;string&gt;?</code> | One or more United Nations Sustainable Development Goals to return nonprofit organizations for. Format: `unsdg_<number>`, for example, `&goal=unsdg_6&goal=unsdg_2`. |
| <code>body</code> | <code>[ListNonprofitsRequest?](Models/ListNonprofitsRequest.cs)</code> | - |
| <code>pageSize</code> | <code>int?</code> | The number of items to have on a page, maximum 100. The default is 10 items on a page.<br>**Default**: 10 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListNonprofitsResponse](Models/ListNonprofitsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCompaniesCompanyIdNonprofitsError](Errors/PostCompaniesCompanyIdNonprofitsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Donations

> Source: [Donations](Api/Donations.cs)

<details>
<summary><code>Task&lt;DonationCampaignsResponse&gt; PostDonationCampaigns(string? idempotencyKey, DonationCampaignsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Queries the available donation campaigns for a donation based on the donation context (like merchant account, currency, and locale). The response contains active donation campaigns.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Donations.PostDonationCampaigns(idempotencyKey, body);
    // TODO: Handle 'response' of type DonationCampaignsResponse
}
catch (SdkException<PostDonationCampaignsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[DonationCampaignsRequest?](Models/DonationCampaignsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DonationCampaignsResponse](Models/DonationCampaignsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostDonationCampaignsError](Errors/PostDonationCampaignsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DonationPaymentResponse&gt; PostDonations(string? idempotencyKey, DonationPaymentRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Takes in the donation token generated by the `/payments` request and uses it to make the donation.

For more information, see [Donations](https://docs.adyen.com/online-payments/donations).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Donations.PostDonations(idempotencyKey, body);
    // TODO: Handle 'response' of type DonationPaymentResponse
}
catch (SdkException<PostDonationsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[DonationPaymentRequest?](Models/DonationPaymentRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DonationPaymentResponse](Models/DonationPaymentResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostDonationsError](Errors/PostDonationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DynamicOffers

> Source: [DynamicOffers](Api/DynamicOffers.cs)

<details>
<summary><code>Task&lt;GetDynamicOffersResponse&gt; GetDynamicOffers(string accountHolderId, FinancingType? financingType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all [dynamic offers](https://docs.adyen.com/capital/get-grant-offers/dynamic-offers/) available for `accountHolderId` specified as a query parameter.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DynamicOffers.GetDynamicOffers(accountHolderId, financingType);
    // TODO: Handle 'response' of type GetDynamicOffersResponse
}
catch (SdkException<GetDynamicOffersError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountHolderId</code> | <code>string</code> | The unique identifier of the account holder that the dynamic offer is for. |
| <code>financingType</code> | <code>[FinancingType?](Models/Enums/FinancingType.cs)</code> | The type of financing that the offer is for. If the value is not specified, returns all available types.<br><br>Possible values: **businessFinancing** |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetDynamicOffersResponse](Models/GetDynamicOffersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetDynamicOffersError](Errors/GetDynamicOffersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CalculatedGrantOffer&gt; PostDynamicOffersIdCalculate(string id, CalculateGrantOfferRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Calculates a preliminary offer for the financing amount that the user selected from a [dynamic offer](https://docs.adyen.com/capital/get-grant-offers/dynamic-offers/). The preliminary offer is for informational purposes only and cannot be used to initiate a grant.

Requests to this endpoint are subject to rate limits:

- Live environments: 120 requests per minute.

- Test environments: 120 requests per minute.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DynamicOffers.PostDynamicOffersIdCalculate(id, body);
    // TODO: Handle 'response' of type CalculatedGrantOffer
}
catch (SdkException<PostDynamicOffersIdCalculateError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the dynamic offer from which the user selected the financing amount. |
| <code>body</code> | <code>[CalculateGrantOfferRequest?](Models/CalculateGrantOfferRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CalculatedGrantOffer](Models/CalculatedGrantOffer.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostDynamicOffersIdCalculateError](Errors/PostDynamicOffersIdCalculateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GrantOffer1&gt; PostDynamicOffersIdGrantOffer(string id, CreateGrantOfferRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a static offer for the financing amount that the user selected from the [dynamic offer](https://docs.adyen.com/capital/get-grant-offers/dynamic-offers/).

Requests to this endpoint are subject to rate limits:

- Live environments: 30 requests per minute.

- Test environments: 30 requests per minute.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DynamicOffers.PostDynamicOffersIdGrantOffer(id, body);
    // TODO: Handle 'response' of type GrantOffer1
}
catch (SdkException<PostDynamicOffersIdGrantOfferError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the dynamic offer from which the user selected the financing amount. |
| <code>body</code> | <code>[CreateGrantOfferRequest?](Models/CreateGrantOfferRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GrantOffer1](Models/GrantOffer1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostDynamicOffersIdGrantOfferError](Errors/PostDynamicOffersIdGrantOfferError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## General

> Source: [General](Api/General.cs)

<details>
<summary><code>Task&lt;AcceptDisputeResponse&gt; PostAcceptDispute(AcceptDisputeRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Accepts a specific dispute.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostAcceptDispute(body);
    // TODO: Handle 'response' of type AcceptDisputeResponse
}
catch (SdkException<PostAcceptDisputeError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AcceptDisputeRequest?](Models/AcceptDisputeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AcceptDisputeResponse](Models/AcceptDisputeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostAcceptDisputeError](Errors/PostAcceptDisputeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountHolderBalanceResponse&gt; PostAccountHolderBalance(CloseAccountHolderRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the account balances of an account holder. An account's balances are organized according by currencies. This mean that an account may have multiple balances: one for each currency.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostAccountHolderBalance(body);
    // TODO: Handle 'response' of type AccountHolderBalanceResponse
}
catch (SdkException<PostAccountHolderBalanceError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CloseAccountHolderRequest?](Models/CloseAccountHolderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountHolderBalanceResponse](Models/AccountHolderBalanceResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostAccountHolderBalanceError](Errors/PostAccountHolderBalanceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountHolderTransactionListResponse&gt; PostAccountHolderTransactionList(AccountHolderTransactionListRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of transactions for an account holder's accounts. You can specify the accounts and transaction statuses to be included on the list. The call returns a maximum of 50 transactions for each account. To retrieve all transactions, you must make another call with the 'page' value incremented. Transactions are listed in chronological order, with the most recent transaction first.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostAccountHolderTransactionList(body);
    // TODO: Handle 'response' of type AccountHolderTransactionListResponse
}
catch (SdkException<PostAccountHolderTransactionListError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AccountHolderTransactionListRequest?](Models/AccountHolderTransactionListRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountHolderTransactionListResponse](Models/AccountHolderTransactionListResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostAccountHolderTransactionListError](Errors/PostAccountHolderTransactionListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssignTerminalsResponse&gt; PostAssignTerminals(AssignTerminalsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Assigns one or more payment terminals to a merchant account or a store. You can also use this endpoint to reassign terminals between merchant accounts or stores, and to unassign a terminal and return it to company inventory.

>From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our [Management API](https://docs.adyen.com/api-explorer/Management/latest/overview).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostAssignTerminals(body);
    // TODO: Handle 'response' of type AssignTerminalsResponse
}
catch (SdkException<PostAssignTerminalsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AssignTerminalsRequest?](Models/AssignTerminalsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssignTerminalsResponse](Models/AssignTerminalsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostAssignTerminalsError](Errors/PostAssignTerminalsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StoredValueStatusChangeResponse&gt; PostChangeStatus(StoredValueStatusChangeRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the status of the provided payment method to the specified status.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostChangeStatus(body);
    // TODO: Handle 'response' of type StoredValueStatusChangeResponse
}
catch (SdkException<PostChangeStatusError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[StoredValueStatusChangeRequest?](Models/StoredValueStatusChangeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StoredValueStatusChangeResponse](Models/StoredValueStatusChangeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostChangeStatusError](Errors/PostChangeStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StoredValueBalanceCheckResponse&gt; PostCheckBalance(StoredValueBalanceCheckRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Checks the balance of the provided payment method.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostCheckBalance(body);
    // TODO: Handle 'response' of type StoredValueBalanceCheckResponse
}
catch (SdkException<PostCheckBalanceError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[StoredValueBalanceCheckRequest?](Models/StoredValueBalanceCheckRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StoredValueBalanceCheckResponse](Models/StoredValueBalanceCheckResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCheckBalanceError](Errors/PostCheckBalanceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetNotificationConfigurationResponse&gt; PostCreateNotificationConfiguration(CreateNotificationConfigurationRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a subscription to notifications informing you of events on your platform. After the subscription is created, the events specified in the configuration will be sent to the URL specified in the configuration. Subscriptions must be configured on a per-event basis (as opposed to, for example, a per-account holder basis), so all event notifications of a marketplace and of a given type will be sent to the same endpoint(s). A marketplace may have multiple endpoints if desired; an event notification may be sent to as many or as few different endpoints as configured.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostCreateNotificationConfiguration(body);
    // TODO: Handle 'response' of type GetNotificationConfigurationResponse
}
catch (SdkException<PostCreateNotificationConfigurationError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateNotificationConfigurationRequest?](Models/CreateNotificationConfigurationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetNotificationConfigurationResponse](Models/GetNotificationConfigurationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCreateNotificationConfigurationError](Errors/PostCreateNotificationConfigurationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreatePermitResult&gt; PostCreatePermit(CreatePermitRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create permits for a recurring contract, including support for defining restrictions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostCreatePermit(body);
    // TODO: Handle 'response' of type CreatePermitResult
}
catch (SdkException<PostCreatePermitError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreatePermitRequest?](Models/CreatePermitRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreatePermitResult](Models/CreatePermitResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCreatePermitError](Errors/PostCreatePermitError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateTestCardRangesResult&gt; PostCreateTestCardRanges(CreateTestCardRangesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates one or more test card ranges.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostCreateTestCardRanges(body);
    // TODO: Handle 'response' of type CreateTestCardRangesResult
}
catch (SdkException<PostCreateTestCardRangesError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateTestCardRangesRequest?](Models/CreateTestCardRangesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateTestCardRangesResult](Models/CreateTestCardRangesResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCreateTestCardRangesError](Errors/PostCreateTestCardRangesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DebitAccountHolderResponse&gt; PostDebitAccountHolder(DebitAccountHolderRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends a direct debit request to an account holder's bank account. If the direct debit is successful, the funds are settled in the accounts specified in the split instructions. Adyen sends the result of the direct debit in a [`DIRECT_DEBIT_INITIATED`](https://docs.adyen.com/api-explorer/#/NotificationService/latest/post/DIRECT_DEBIT_INITIATED) notification webhook.

 To learn more about direct debits, see [Top up accounts](https://docs.adyen.com/classic-platforms/top-up-accounts).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostDebitAccountHolder(body);
    // TODO: Handle 'response' of type DebitAccountHolderResponse
}
catch (SdkException<PostDebitAccountHolderError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DebitAccountHolderRequest?](Models/DebitAccountHolderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DebitAccountHolderResponse](Models/DebitAccountHolderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostDebitAccountHolderError](Errors/PostDebitAccountHolderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DefendDisputeResponse&gt; PostDefendDispute(DefendDisputeRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Defends a specific dispute.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostDefendDispute(body);
    // TODO: Handle 'response' of type DefendDisputeResponse
}
catch (SdkException<PostDefendDisputeError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DefendDisputeRequest?](Models/DefendDisputeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DefendDisputeResponse](Models/DefendDisputeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostDefendDisputeError](Errors/PostDefendDisputeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteDefenseDocumentResponse&gt; PostDeleteDisputeDefenseDocument(DeleteDefenseDocumentRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a specific dispute defense document that was supplied earlier.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostDeleteDisputeDefenseDocument(body);
    // TODO: Handle 'response' of type DeleteDefenseDocumentResponse
}
catch (SdkException<PostDeleteDisputeDefenseDocumentError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeleteDefenseDocumentRequest?](Models/DeleteDefenseDocumentRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteDefenseDocumentResponse](Models/DeleteDefenseDocumentResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostDeleteDisputeDefenseDocumentError](Errors/PostDeleteDisputeDefenseDocumentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericResponse&gt; PostDeleteNotificationConfigurations(DeleteNotificationConfigurationRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes an existing notification subscription configuration. After the subscription is deleted, no further event notifications will be sent to the URL defined in the subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostDeleteNotificationConfigurations(body);
    // TODO: Handle 'response' of type GenericResponse
}
catch (SdkException<PostDeleteNotificationConfigurationsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeleteNotificationConfigurationRequest?](Models/DeleteNotificationConfigurationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericResponse](Models/GenericResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostDeleteNotificationConfigurationsError](Errors/PostDeleteNotificationConfigurationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DisableResult&gt; PostDisable(DisableRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disables stored payment details to stop charging a shopper with this particular recurring detail ID.

For more information, refer to [Disable stored details](https://docs.adyen.com/online-payments/classic-integrations/classic-api-integration/tokenization/disable-stored-details).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostDisable(body);
    // TODO: Handle 'response' of type DisableResult
}
catch (SdkException<PostDisableError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DisableRequest?](Models/DisableRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisableResult](Models/DisableResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostDisableError](Errors/PostDisableError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DisablePermitResult&gt; PostDisablePermit(DisablePermitRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disable a permit that was previously linked to a recurringDetailReference.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostDisablePermit(body);
    // TODO: Handle 'response' of type DisablePermitResult
}
catch (SdkException<PostDisablePermitError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DisablePermitRequest?](Models/DisablePermitRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisablePermitResult](Models/DisablePermitResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostDisablePermitError](Errors/PostDisablePermitError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FindTerminalResponse&gt; PostFindTerminal(FindTerminalRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the company account, merchant account, or store that a payment terminal is assigned to.

>From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our [Management API](https://docs.adyen.com/api-explorer/Management/latest/overview).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostFindTerminal(body);
    // TODO: Handle 'response' of type FindTerminalResponse
}
catch (SdkException<PostFindTerminalError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[FindTerminalRequest?](Models/FindTerminalRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FindTerminalResponse](Models/FindTerminalResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostFindTerminalError](Errors/PostFindTerminalError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ThreeDsAvailabilityResponse&gt; PostGet3DsAvailability(ThreeDsAvailabilityRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Verifies whether 3D Secure is available for the specified BIN or card brand. For 3D Secure 2, this endpoint also returns device fingerprinting keys.

For more information, refer to [3D Secure 2](https://docs.adyen.com/online-payments/3d-secure/native-3ds2).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostGet3DsAvailability(body);
    // TODO: Handle 'response' of type ThreeDsAvailabilityResponse
}
catch (SdkException<PostGet3DsAvailabilityError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ThreeDsAvailabilityRequest?](Models/ThreeDsAvailabilityRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ThreeDsAvailabilityResponse](Models/ThreeDsAvailabilityResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostGet3DsAvailabilityError](Errors/PostGet3DsAvailabilityError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CostEstimateResponse&gt; PostGetCostEstimate(CostEstimateRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

>This API is available only for merchants operating in Australia, the EU, and the UK.

Use the Adyen Cost Estimation API to pre-calculate interchange and scheme fee costs. Knowing these costs prior actual payment authorisation gives you an opportunity to charge those costs to the cardholder, if necessary.

To retrieve this information, make the call to the `/getCostEstimate` endpoint. The response to this call contains the amount of the interchange and scheme fees charged by the network for this transaction, and also which surcharging policy is possible (based on current regulations).

> Since not all information is known in advance (for example, if the cardholder will successfully authenticate via 3D Secure or if you also plan to provide additional Level 2/3 data), the returned amounts are based on a set of assumption criteria you define in the `assumptions` parameter.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostGetCostEstimate(body);
    // TODO: Handle 'response' of type CostEstimateResponse
}
catch (SdkException<PostGetCostEstimateError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CostEstimateRequest?](Models/CostEstimateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CostEstimateResponse](Models/CostEstimateResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostGetCostEstimateError](Errors/PostGetCostEstimateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetNotificationConfigurationResponse&gt; PostGetNotificationConfiguration(GetNotificationConfigurationRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the configuration of a notification subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostGetNotificationConfiguration(body);
    // TODO: Handle 'response' of type GetNotificationConfigurationResponse
}
catch (SdkException<PostGetNotificationConfigurationError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GetNotificationConfigurationRequest?](Models/GetNotificationConfigurationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetNotificationConfigurationResponse](Models/GetNotificationConfigurationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostGetNotificationConfigurationError](Errors/PostGetNotificationConfigurationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetNotificationConfigurationListResponse&gt; PostGetNotificationConfigurationList(object? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the configurations of all of the notification subscriptions in the platform of the executing user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostGetNotificationConfigurationList(body);
    // TODO: Handle 'response' of type GetNotificationConfigurationListResponse
}
catch (SdkException<PostGetNotificationConfigurationListError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>object?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetNotificationConfigurationListResponse](Models/GetNotificationConfigurationListResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostGetNotificationConfigurationListError](Errors/PostGetNotificationConfigurationListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetStoresUnderAccountResponse&gt; PostGetStoresUnderAccount(GetStoresUnderAccountRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of stores associated with a company account or a merchant account, including the status of each store.

>From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our [Management API](https://docs.adyen.com/api-explorer/Management/latest/overview).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostGetStoresUnderAccount(body);
    // TODO: Handle 'response' of type GetStoresUnderAccountResponse
}
catch (SdkException<PostGetStoresUnderAccountError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GetStoresUnderAccountRequest?](Models/GetStoresUnderAccountRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetStoresUnderAccountResponse](Models/GetStoresUnderAccountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostGetStoresUnderAccountError](Errors/PostGetStoresUnderAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTerminalDetailsResponse&gt; PostGetTerminalDetails(GetTerminalDetailsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a payment terminal, including where the terminal is assigned to. The response returns the same details that are provided in the terminal list in your Customer Area and in the Terminal Fleet report.

>From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our [Management API](https://docs.adyen.com/api-explorer/Management/latest/overview).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostGetTerminalDetails(body);
    // TODO: Handle 'response' of type GetTerminalDetailsResponse
}
catch (SdkException<PostGetTerminalDetailsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GetTerminalDetailsRequest?](Models/GetTerminalDetailsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTerminalDetailsResponse](Models/GetTerminalDetailsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostGetTerminalDetailsError](Errors/PostGetTerminalDetailsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTerminalsUnderAccountResponse&gt; PostGetTerminalsUnderAccount(GetTerminalsUnderAccountRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of payment terminals associated with a company account, merchant account, or store. The response shows whether the terminals are in the inventory, or in-store (ready for boarding or already boarded).

>From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our [Management API](https://docs.adyen.com/api-explorer/Management/latest/overview).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostGetTerminalsUnderAccount(body);
    // TODO: Handle 'response' of type GetTerminalsUnderAccountResponse
}
catch (SdkException<PostGetTerminalsUnderAccountError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GetTerminalsUnderAccountRequest?](Models/GetTerminalsUnderAccountRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTerminalsUnderAccountResponse](Models/GetTerminalsUnderAccountResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostGetTerminalsUnderAccountError](Errors/PostGetTerminalsUnderAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StoredValueIssueResponse&gt; PostIssue(StoredValueIssueRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Issues a new card of the given payment method.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostIssue(body);
    // TODO: Handle 'response' of type StoredValueIssueResponse
}
catch (SdkException<PostIssueError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[StoredValueIssueRequest?](Models/StoredValueIssueRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StoredValueIssueResponse](Models/StoredValueIssueResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostIssueError](Errors/PostIssueError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RecurringDetailsResult&gt; PostListRecurringDetails(RecurringDetailsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the stored payment details for a shopper, if there are any available. The recurring detail ID can be used with a regular authorisation request to charge the shopper. A summary of the payment detail is returned for presentation to the shopper.

For more information, refer to [Retrieve stored details](https://docs.adyen.com/classic-integration/recurring-payments/retrieve-stored-details/).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostListRecurringDetails(body);
    // TODO: Handle 'response' of type RecurringDetailsResult
}
catch (SdkException<PostListRecurringDetailsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[RecurringDetailsRequest?](Models/RecurringDetailsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RecurringDetailsResult](Models/RecurringDetailsResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostListRecurringDetailsError](Errors/PostListRecurringDetailsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StoredValueLoadResponse&gt; PostLoad(StoredValueLoadRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Loads the payment method with the specified funds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostLoad(body);
    // TODO: Handle 'response' of type StoredValueLoadResponse
}
catch (SdkException<PostLoadError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[StoredValueLoadRequest?](Models/StoredValueLoadRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StoredValueLoadResponse](Models/StoredValueLoadResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostLoadError](Errors/PostLoadError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StoredValueBalanceMergeResponse&gt; PostMergeBalance(StoredValueBalanceMergeRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Increases the balance of the paymentmethod by the full amount left on the source paymentmethod

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostMergeBalance(body);
    // TODO: Handle 'response' of type StoredValueBalanceMergeResponse
}
catch (SdkException<PostMergeBalanceError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[StoredValueBalanceMergeRequest?](Models/StoredValueBalanceMergeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StoredValueBalanceMergeResponse](Models/StoredValueBalanceMergeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMergeBalanceError](Errors/PostMergeBalanceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NotifyShopperResult&gt; PostNotifyShopper(NotifyShopperRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends a request to the issuer so they can inform the shopper about the upcoming recurring payment. This endpoint is used only for local acquiring in India. For more information, refer to [Recurring card payments in India](https://docs.adyen.com/payment-methods/cards/cards-recurring-india).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostNotifyShopper(body);
    // TODO: Handle 'response' of type NotifyShopperResult
}
catch (SdkException<PostNotifyShopperError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[NotifyShopperRequest?](Models/NotifyShopperRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NotifyShopperResult](Models/NotifyShopperResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostNotifyShopperError](Errors/PostNotifyShopperError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PayoutAccountHolderResponse&gt; PostPayoutAccountHolder(PayoutAccountHolderRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Pays out a specified amount from an account to the bank account of account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostPayoutAccountHolder(body);
    // TODO: Handle 'response' of type PayoutAccountHolderResponse
}
catch (SdkException<PostPayoutAccountHolderError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[PayoutAccountHolderRequest?](Models/PayoutAccountHolderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutAccountHolderResponse](Models/PayoutAccountHolderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPayoutAccountHolderError](Errors/PostPayoutAccountHolderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RefundFundsTransferResponse&gt; PostRefundFundsTransfer(RefundFundsTransferRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Refunds funds transferred from one account to another. Both accounts must be in the same platform, but can have different account holders. 

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostRefundFundsTransfer(body);
    // TODO: Handle 'response' of type RefundFundsTransferResponse
}
catch (SdkException<PostRefundFundsTransferError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[RefundFundsTransferRequest?](Models/RefundFundsTransferRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RefundFundsTransferResponse](Models/RefundFundsTransferResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostRefundFundsTransferError](Errors/PostRefundFundsTransferError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericResponse&gt; PostRefundNotPaidOutTransfers(RefundNotPaidOutTransfersRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Refunds all the transactions of an account that have taken place since the most recent payout. This request is on a account basis (as opposed to a payment basis), so only the portion of the payment that was made to the specified account is refunded. The commissions, fees, and payments to other accounts remain in the accounts to which they were sent as designated by the original payment's split details.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostRefundNotPaidOutTransfers(body);
    // TODO: Handle 'response' of type GenericResponse
}
catch (SdkException<PostRefundNotPaidOutTransfersError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[RefundNotPaidOutTransfersRequest?](Models/RefundNotPaidOutTransfersRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericResponse](Models/GenericResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostRefundNotPaidOutTransfersError](Errors/PostRefundNotPaidOutTransfersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SubjectErasureResponse&gt; PostRequestSubjectErasure(SubjectErasureByPspReferenceRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends the PSP reference containing the shopper data that should be deleted.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostRequestSubjectErasure(body);
    // TODO: Handle 'response' of type SubjectErasureResponse
}
catch (SdkException<PostRequestSubjectErasureError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SubjectErasureByPspReferenceRequest?](Models/SubjectErasureByPspReferenceRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SubjectErasureResponse](Models/SubjectErasureResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostRequestSubjectErasureError](Errors/PostRequestSubjectErasureError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DefenseReasonsResponse&gt; PostRetrieveApplicableDefenseReasons(DefenseReasonsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all applicable defense reasons to defend a specific dispute.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostRetrieveApplicableDefenseReasons(body);
    // TODO: Handle 'response' of type DefenseReasonsResponse
}
catch (SdkException<PostRetrieveApplicableDefenseReasonsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DefenseReasonsRequest?](Models/DefenseReasonsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DefenseReasonsResponse](Models/DefenseReasonsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostRetrieveApplicableDefenseReasonsError](Errors/PostRetrieveApplicableDefenseReasonsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ScheduleAccountUpdaterResult&gt; PostScheduleAccountUpdater(ScheduleAccountUpdaterRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

When making the API call, you can submit either the credit card information, or the recurring detail reference and the shopper reference:
* If the card information is provided, all the sub-fields for `card` are mandatory.
* If the recurring detail reference is provided, the fields for `shopperReference` and `selectedRecurringDetailReference` are mandatory.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostScheduleAccountUpdater(body);
    // TODO: Handle 'response' of type ScheduleAccountUpdaterResult
}
catch (SdkException<PostScheduleAccountUpdaterError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ScheduleAccountUpdaterRequest?](Models/ScheduleAccountUpdaterRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ScheduleAccountUpdaterResult](Models/ScheduleAccountUpdaterResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostScheduleAccountUpdaterError](Errors/PostScheduleAccountUpdaterError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CertificateLoadingResponse&gt; PostSessions3(CreateSessionRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Establishes a secure communications session between the POS Mobile SDK and the Adyen payments platform, through mutual authentication. 
The request sends a setup token that identifies the SDK and the device. The response returns a session token that the SDK can use to authenticate responses received from the Adyen payments platform.
>This request applies to **mobile in-person** transactions. You cannot use this request to create online payments sessions. 



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostSessions3(body);
    // TODO: Handle 'response' of type CertificateLoadingResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateSessionRequest?](Models/CreateSessionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CertificateLoadingResponse](Models/CertificateLoadingResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericResponse&gt; PostSetupBeneficiary(SetupBeneficiaryRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Defines a benefactor and a beneficiary relationship between two accounts. At the time of benefactor/beneficiary setup, the funds in the benefactor account are transferred to the beneficiary account, and any further payments to the benefactor account are automatically sent to the beneficiary account. A series of benefactor/beneficiaries may not exceed four beneficiaries and may not have a cycle in it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostSetupBeneficiary(body);
    // TODO: Handle 'response' of type GenericResponse
}
catch (SdkException<PostSetupBeneficiaryError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SetupBeneficiaryRequest?](Models/SetupBeneficiaryRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericResponse](Models/GenericResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostSetupBeneficiaryError](Errors/PostSetupBeneficiaryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SupplyDefenseDocumentResponse&gt; PostSupplyDefenseDocument(SupplyDefenseDocumentRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Supplies a specific dispute defense document.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostSupplyDefenseDocument(body);
    // TODO: Handle 'response' of type SupplyDefenseDocumentResponse
}
catch (SdkException<PostSupplyDefenseDocumentError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SupplyDefenseDocumentRequest?](Models/SupplyDefenseDocumentRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SupplyDefenseDocumentResponse](Models/SupplyDefenseDocumentResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostSupplyDefenseDocumentError](Errors/PostSupplyDefenseDocumentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TestNotificationConfigurationResponse&gt; PostTestNotificationConfiguration(TestNotificationConfigurationRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Tests an existing notification subscription configuration. For each event type specified, a test notification will be generated and sent to the URL configured in the subscription specified.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostTestNotificationConfiguration(body);
    // TODO: Handle 'response' of type TestNotificationConfigurationResponse
}
catch (SdkException<PostTestNotificationConfigurationError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[TestNotificationConfigurationRequest?](Models/TestNotificationConfigurationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TestNotificationConfigurationResponse](Models/TestNotificationConfigurationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostTestNotificationConfigurationError](Errors/PostTestNotificationConfigurationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferFundsResponse&gt; PostTransferFunds(TransferFundsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Transfers funds from one account to another account. Both accounts must be in the same platform, but can have different account holders. The transfer must include a transfer code, which should be determined by the platform, in compliance with local regulations.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostTransferFunds(body);
    // TODO: Handle 'response' of type TransferFundsResponse
}
catch (SdkException<PostTransferFundsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[TransferFundsRequest?](Models/TransferFundsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferFundsResponse](Models/TransferFundsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostTransferFundsError](Errors/PostTransferFundsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetNotificationConfigurationResponse&gt; PostUpdateNotificationConfiguration(UpdateNotificationConfigurationRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an existing notification subscription configuration. If you are updating the event types, you must provide all event types, otherwise the previous event type configuration will be overwritten.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostUpdateNotificationConfiguration(body);
    // TODO: Handle 'response' of type GetNotificationConfigurationResponse
}
catch (SdkException<PostUpdateNotificationConfigurationError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[UpdateNotificationConfigurationRequest?](Models/UpdateNotificationConfigurationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetNotificationConfigurationResponse](Models/GetNotificationConfigurationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostUpdateNotificationConfigurationError](Errors/PostUpdateNotificationConfigurationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StoredValueVoidResponse&gt; PostVoidTransaction(StoredValueVoidRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Voids the referenced stored value transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostVoidTransaction(body);
    // TODO: Handle 'response' of type StoredValueVoidResponse
}
catch (SdkException<PostVoidTransactionError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[StoredValueVoidRequest?](Models/StoredValueVoidRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StoredValueVoidResponse](Models/StoredValueVoidResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostVoidTransactionError](Errors/PostVoidTransactionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GrantAccounts

> Source: [GrantAccounts](Api/GrantAccounts.cs)

<details>
<summary><code>Task&lt;CapitalGrantAccount&gt; GetGrantAccountsId(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the [grant account](https://docs.adyen.com/platforms/capital#grant-account).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantAccounts.GetGrantAccountsId(id);
    // TODO: Handle 'response' of type CapitalGrantAccount
}
catch (SdkException<GetGrantAccountsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the grant account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CapitalGrantAccount](Models/CapitalGrantAccount.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetGrantAccountsIdError](Errors/GetGrantAccountsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GrantAccount&gt; GetGrantAccountsId1(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the specified grant account. This account tracks existing grants in your marketplace or platform.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantAccounts.GetGrantAccountsId1(id);
    // TODO: Handle 'response' of type GrantAccount
}
catch (SdkException<GetGrantAccountsId1Error> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the grant account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GrantAccount](Models/GrantAccount.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetGrantAccountsId1Error](Errors/GetGrantAccountsId1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GrantOffersApi

> Source: [GrantOffersApi](Api/GrantOffersApi.cs)

<details>
<summary><code>Task&lt;GrantOffers&gt; GetGrantOffers(string accountHolderId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all [grant offers](https://docs.adyen.com/platforms/capital#grant-offers) available for `accountHolderId` specified as a query parameter.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantOffersApi.GetGrantOffers(accountHolderId);
    // TODO: Handle 'response' of type GrantOffers
}
catch (SdkException<GetGrantOffersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountHolderId</code> | <code>string</code> | The unique identifier of the grant account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GrantOffers](Models/GrantOffers.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetGrantOffersError](Errors/GetGrantOffersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GrantOffer&gt; GetGrantOffersGrantOfferId(string grantOfferId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a single grant offer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantOffersApi.GetGrantOffersGrantOfferId(grantOfferId);
    // TODO: Handle 'response' of type GrantOffer
}
catch (SdkException<GetGrantOffersGrantOfferIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>grantOfferId</code> | <code>string</code> | The unique identifier of the grant offer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GrantOffer](Models/GrantOffer.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetGrantOffersGrantOfferIdError](Errors/GetGrantOffersGrantOfferIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GrantOffer1&gt; GetGrantOffersId(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the specified static offer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantOffersApi.GetGrantOffersId(id);
    // TODO: Handle 'response' of type GrantOffer1
}
catch (SdkException<GetGrantOffersIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the static offer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GrantOffer1](Models/GrantOffer1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetGrantOffersIdError](Errors/GetGrantOffersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GrantOffers&gt; GetGrantOffers1(string accountHolderId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all [static offers](https://docs.adyen.com/capital/get-grant-offers/static-offers) available for `accountHolderId` specified as a query parameter. This also includes static offers created for financing amounts that the user selected from [dynamic offers](https://docs.adyen.com/capital/get-grant-offers/dynamic-offers/).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantOffersApi.GetGrantOffers1(accountHolderId);
    // TODO: Handle 'response' of type GrantOffers
}
catch (SdkException<GetGrantOffers1Error> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountHolderId</code> | <code>string</code> | The unique identifier of the account holder for which you want to get the available static offers. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GrantOffers](Models/GrantOffers.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetGrantOffers1Error](Errors/GetGrantOffers1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GrantsApi

> Source: [GrantsApi](Api/GrantsApi.cs)

<details>
<summary><code>Task&lt;Grant&gt; GetGrantsGrantId(string grantId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the specified grant.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantsApi.GetGrantsGrantId(grantId);
    // TODO: Handle 'response' of type Grant
}
catch (SdkException<GetGrantsGrantIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>grantId</code> | <code>string</code> | The unique identifier of the grant reference. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Grant](Models/Grant.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetGrantsGrantIdError](Errors/GetGrantsGrantIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Disbursements&gt; GetGrantsGrantIdDisbursements(string grantId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the disbursements of a specified grant.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantsApi.GetGrantsGrantIdDisbursements(grantId);
    // TODO: Handle 'response' of type Disbursements
}
catch (SdkException<GetGrantsGrantIdDisbursementsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>grantId</code> | <code>string</code> | The unique identifier of the grant reference. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Disbursements](Models/Disbursements.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetGrantsGrantIdDisbursementsError](Errors/GetGrantsGrantIdDisbursementsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Disbursement&gt; GetGrantsGrantIdDisbursementsDisbursementId(string grantId, string disbursementId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a disbursement specified in the path.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantsApi.GetGrantsGrantIdDisbursementsDisbursementId(grantId, disbursementId);
    // TODO: Handle 'response' of type Disbursement
}
catch (SdkException<GetGrantsGrantIdDisbursementsDisbursementIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>grantId</code> | <code>string</code> | The unique identifier of the grant reference. |
| <code>disbursementId</code> | <code>string</code> | The unique identifier of the disbursement. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Disbursement](Models/Disbursement.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetGrantsGrantIdDisbursementsDisbursementIdError](Errors/GetGrantsGrantIdDisbursementsDisbursementIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Grants&gt; GetGrants2(string counterpartyAccountHolderId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all the grants of a specific account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantsApi.GetGrants2(counterpartyAccountHolderId);
    // TODO: Handle 'response' of type Grants
}
catch (SdkException<GetGrants2Error> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>counterpartyAccountHolderId</code> | <code>string</code> | The unique identifier of the account holder that received the grants. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Grants](Models/Grants.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetGrants2Error](Errors/GetGrants2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Disbursement&gt; PatchGrantsGrantIdDisbursementsDisbursementId(string grantId, string disbursementId, DisbursementInfoUpdate body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update the percentage of your user's net income that is deducted for repaying the grant.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantsApi.PatchGrantsGrantIdDisbursementsDisbursementId(grantId, disbursementId, body);
    // TODO: Handle 'response' of type Disbursement
}
catch (SdkException<PatchGrantsGrantIdDisbursementsDisbursementIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>grantId</code> | <code>string</code> | The unique identifier of the grant reference. |
| <code>disbursementId</code> | <code>string</code> | The unique identifier of the disbursement. |
| <code>body</code> | <code>[DisbursementInfoUpdate](Models/DisbursementInfoUpdate.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Disbursement](Models/Disbursement.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchGrantsGrantIdDisbursementsDisbursementIdError](Errors/PatchGrantsGrantIdDisbursementsDisbursementIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Grant&gt; PostGrants2(CapitalGrantInfo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Make a request for a grant on behalf of an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantsApi.PostGrants2(body);
    // TODO: Handle 'response' of type Grant
}
catch (SdkException<PostGrants2Error> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CapitalGrantInfo?](Models/CapitalGrantInfo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Grant](Models/Grant.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostGrants2Error](Errors/PostGrants2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## HostedOnboarding

> Source: [HostedOnboarding](Api/HostedOnboarding.cs)

<details>
<summary><code>Task&lt;OnboardingThemes&gt; GetThemes(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of hosted onboarding page themes.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.HostedOnboarding.GetThemes();
    // TODO: Handle 'response' of type OnboardingThemes
}
catch (SdkException<GetThemesError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnboardingThemes](Models/OnboardingThemes.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetThemesError](Errors/GetThemesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnboardingTheme&gt; GetThemesId(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the theme identified in the path.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.HostedOnboarding.GetThemesId(id);
    // TODO: Handle 'response' of type OnboardingTheme
}
catch (SdkException<GetThemesIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the theme |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnboardingTheme](Models/OnboardingTheme.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetThemesIdError](Errors/GetThemesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnboardingLink&gt; PostLegalEntitiesIdOnboardingLinks(string id, OnboardingLinkInfo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a link to an Adyen-hosted onboarding page where you need to redirect your user.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.HostedOnboarding.PostLegalEntitiesIdOnboardingLinks(id, body);
    // TODO: Handle 'response' of type OnboardingLink
}
catch (SdkException<PostLegalEntitiesIdOnboardingLinksError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the legal entity |
| <code>body</code> | <code>[OnboardingLinkInfo?](Models/OnboardingLinkInfo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnboardingLink](Models/OnboardingLink.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostLegalEntitiesIdOnboardingLinksError](Errors/PostLegalEntitiesIdOnboardingLinksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## HostedOnboardingPage

> Source: [HostedOnboardingPage](Api/HostedOnboardingPage.cs)

<details>
<summary><code>Task&lt;GetOnboardingUrlResponse&gt; PostGetOnboardingUrl(GetOnboardingUrlRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a link to an Adyen-hosted onboarding page (HOP) that you can send to your account holder. For more information on how to use HOP, refer to [Hosted onboarding](https://docs.adyen.com/classic-platforms/onboard-users/hosted-onboarding-page).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.HostedOnboardingPage.PostGetOnboardingUrl(body);
    // TODO: Handle 'response' of type GetOnboardingUrlResponse
}
catch (SdkException<PostGetOnboardingUrlError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GetOnboardingUrlRequest?](Models/GetOnboardingUrlRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetOnboardingUrlResponse](Models/GetOnboardingUrlResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostGetOnboardingUrlError](Errors/PostGetOnboardingUrlError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Initialization

> Source: [Initialization](Api/Initialization.cs)

<details>
<summary><code>Task&lt;StoreDetailResponse&gt; PostStoreDetail(StoreDetailRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

> This endpoint is **deprecated** and no longer supports new integrations. Do one of the following:
>- If you are building a new integration, use the [Transfers API](https://docs.adyen.com/api-explorer/transfers/latest/overview) instead.
> - If you are already using the Payout API, reach out to your Adyen contact to learn how to migrate to the Transfers API.
>
> With the Transfers API, you can:
> - Handle multiple payout use cases with a single API.
> - Use new payout functionalities, such as instant payouts to bank accounts.
> - Receive webhooks with more details and defined transfer states.
>
> For more information about the payout features of the Transfers API, see our [Payouts](https://docs.adyen.com/payouts/payout-service) documentation.


Stores payment details under the `PAYOUT` recurring contract. These payment details can be used later to submit a payout via the `/submitThirdParty` call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Initialization.PostStoreDetail(body);
    // TODO: Handle 'response' of type StoreDetailResponse
}
catch (SdkException<PostStoreDetailError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[StoreDetailRequest?](Models/StoreDetailRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StoreDetailResponse](Models/StoreDetailResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostStoreDetailError](Errors/PostStoreDetailError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StoreDetailAndSubmitResponse&gt; PostStoreDetailAndSubmitThirdParty(StoreDetailAndSubmitRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

> This endpoint is **deprecated** and no longer supports new integrations. Do one of the following:
>- If you are building a new integration, use the POST [/transfers](https://docs.adyen.com/api-explorer/transfers/latest/post/transfers) endpoint instead.
> - If you are already using the Payout API, reach out to your Adyen contact to learn how to migrate to the Transfers API.
>
> With the Transfers API, you can:
> - Handle multiple payout use cases with a single API.
> - Use new payout functionalities, such as instant payouts to bank accounts.
> - Receive webhooks with more details and defined transfer states.
>
> For more information about the payout features of the Transfers API, see our [Payouts](https://docs.adyen.com/payouts/payout-service) documentation.


Submits a payout and stores its details for subsequent payouts.

The submitted payout must be confirmed or declined either by a reviewer or via `/confirmThirdParty` or `/declineThirdParty` calls.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Initialization.PostStoreDetailAndSubmitThirdParty(body);
    // TODO: Handle 'response' of type StoreDetailAndSubmitResponse
}
catch (SdkException<PostStoreDetailAndSubmitThirdPartyError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[StoreDetailAndSubmitRequest?](Models/StoreDetailAndSubmitRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StoreDetailAndSubmitResponse](Models/StoreDetailAndSubmitResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostStoreDetailAndSubmitThirdPartyError](Errors/PostStoreDetailAndSubmitThirdPartyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SubmitResponse&gt; PostSubmitThirdParty(SubmitRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

> This endpoint is **deprecated** and no longer supports new integrations. Do one of the following:
>- If you are building a new integration, use the POST [/transfers](https://docs.adyen.com/api-explorer/transfers/latest/post/transfers) endpoint instead.
> - If you are already using the Payout API, reach out to your Adyen contact to learn how to migrate to the Transfers API.
>
> With the Transfers API, you can:
> - Handle multiple payout use cases with a single API.
> - Use new payout functionalities, such as instant payouts to bank accounts.
> - Receive webhooks with more details and defined transfer states.
>
> For more information about the payout features of the Transfers API, see our [Payouts](https://docs.adyen.com/payouts/payout-service) documentation.


Submits a payout using the previously stored payment details. To store payment details, use the `/storeDetail` API call.

The submitted payout must be confirmed or declined either by a reviewer or via `/confirmThirdParty` or `/declineThirdParty` calls.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Initialization.PostSubmitThirdParty(body);
    // TODO: Handle 'response' of type SubmitResponse
}
catch (SdkException<PostSubmitThirdPartyError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SubmitRequest?](Models/SubmitRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SubmitResponse](Models/SubmitResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostSubmitThirdPartyError](Errors/PostSubmitThirdPartyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## InstantPayouts

> Source: [InstantPayouts](Api/InstantPayouts.cs)

<details>
<summary><code>Task&lt;PayoutResponse&gt; PostPayout(PayoutRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

> This endpoint is **deprecated** and no longer supports new integrations. Do one of the following:
>- If you are building a new integration, use the POST [/transfers](https://docs.adyen.com/api-explorer/transfers/latest/post/transfers) endpoint instead.
> - If you are already using the Payout API, reach out to your Adyen contact to learn how to migrate to the Transfers API.
>
> With the Transfers API, you can:
> - Handle multiple payout use cases with a single API.
> - Use new payout functionalities, such as instant payouts to bank accounts.
> - Receive webhooks with more details and defined transfer states.
>
> For more information about the payout features of the Transfers API, see our [Payouts](https://docs.adyen.com/payouts/payout-service) documentation.


With this call, you can pay out to your customers, and funds will be made available within 30 minutes on the cardholder's bank account (this is dependent on whether the issuer supports this functionality). Instant card payouts are only supported for Visa and Mastercard cards.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InstantPayouts.PostPayout(body);
    // TODO: Handle 'response' of type PayoutResponse
}
catch (SdkException<PostPayoutError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[PayoutRequest?](Models/PayoutRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutResponse](Models/PayoutResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPayoutError](Errors/PostPayoutError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## LegalEntities

> Source: [LegalEntities](Api/LegalEntities.cs)

<details>
<summary><code>Task&lt;LegalEntity3&gt; GetLegalEntitiesId(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a legal entity.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LegalEntities.GetLegalEntitiesId(id);
    // TODO: Handle 'response' of type LegalEntity3
}
catch (SdkException<GetLegalEntitiesIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the legal entity. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LegalEntity3](Models/LegalEntity3.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLegalEntitiesIdError](Errors/GetLegalEntitiesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BusinessLines&gt; GetLegalEntitiesIdBusinessLines(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the business lines owned by a legal entity.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LegalEntities.GetLegalEntitiesIdBusinessLines(id);
    // TODO: Handle 'response' of type BusinessLines
}
catch (SdkException<GetLegalEntitiesIdBusinessLinesError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the legal entity. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BusinessLines](Models/BusinessLines.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLegalEntitiesIdBusinessLinesError](Errors/GetLegalEntitiesIdBusinessLinesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LegalEntity3&gt; PatchLegalEntitiesId(string id, string? xRequestedVerificationCode, LegalEntityInfo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a legal entity.

 >To change the legal entity type, include only the new `type` in your request.

If you need to update information for the legal entity, make a separate request. To update the `entityAssociations` array, you need to replace the entire array.For example, if the array has 3 entries and you want to remove 1 entry, you need to PATCH the resource with the remaining 2 entries.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LegalEntities.PatchLegalEntitiesId(id, xRequestedVerificationCode, body);
    // TODO: Handle 'response' of type LegalEntity3
}
catch (SdkException<PatchLegalEntitiesIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the legal entity. |
| <code>xRequestedVerificationCode</code> | <code>string?</code> | Use the requested verification code 0_0001 to resolve any suberrors associated with the legal entity. Requested verification codes can only be used in your test environment. |
| <code>body</code> | <code>[LegalEntityInfo?](Models/LegalEntityInfo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LegalEntity3](Models/LegalEntity3.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchLegalEntitiesIdError](Errors/PatchLegalEntitiesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LegalEntity3&gt; PostLegalEntities(string? xRequestedVerificationCode, LegalEntityInfoRequiredType? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a legal entity. 

This resource contains information about the user that will be onboarded in your platform. Adyen uses this information to perform verification checks as required by payment industry regulations. Adyen informs you of the verification results through webhooks or API responses.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LegalEntities.PostLegalEntities(xRequestedVerificationCode, body);
    // TODO: Handle 'response' of type LegalEntity3
}
catch (SdkException<PostLegalEntitiesError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>xRequestedVerificationCode</code> | <code>string?</code> | Use a suberror code as your requested verification code. You can include one code at a time in your request header. Requested verification codes can only be used in your test environment. |
| <code>body</code> | <code>[LegalEntityInfoRequiredType?](Models/LegalEntityInfoRequiredType.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LegalEntity3](Models/LegalEntity3.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostLegalEntitiesError](Errors/PostLegalEntitiesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VerificationErrors&gt; PostLegalEntitiesIdCheckVerificationErrors(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the verification errors for a legal entity and its supporting entities.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LegalEntities.PostLegalEntitiesIdCheckVerificationErrors(id);
    // TODO: Handle 'response' of type VerificationErrors
}
catch (SdkException<PostLegalEntitiesIdCheckVerificationErrorsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the legal entity. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VerificationErrors](Models/VerificationErrors.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostLegalEntitiesIdCheckVerificationErrorsError](Errors/PostLegalEntitiesIdCheckVerificationErrorsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DataReviewConfirmationResponse&gt; PostLegalEntitiesIdConfirmDataReview(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Confirms that your user has reviewed the data for the legal entity specified in the path. Call this endpoint to inform Adyen that your user reviewed and verified that the data is up-to-date. The endpoint returns the timestamp of when Adyen received the request.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LegalEntities.PostLegalEntitiesIdConfirmDataReview(id);
    // TODO: Handle 'response' of type DataReviewConfirmationResponse
}
catch (SdkException<PostLegalEntitiesIdConfirmDataReviewError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the legal entity. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DataReviewConfirmationResponse](Models/DataReviewConfirmationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostLegalEntitiesIdConfirmDataReviewError](Errors/PostLegalEntitiesIdConfirmDataReviewError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;JsonElement&gt; PostLegalEntitiesIdRequestPeriodicReview(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Requests a periodic data review for the legal entity of the user specified in the path.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LegalEntities.PostLegalEntitiesIdRequestPeriodicReview(id);
    // TODO: Handle 'response' of type JsonElement
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the legal entity. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>JsonElement</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageScaDevices

> Source: [ManageScaDevices](Api/ManageScaDevices.cs)

<details>
<summary><code>Task DeleteRegisteredDevicesId(string id, string paymentInstrumentId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes an SCA device from the list of registered devices of a specific payment instrument.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ManageScaDevices.DeleteRegisteredDevicesId(id, paymentInstrumentId);
}
catch (SdkException<DeleteRegisteredDevicesIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the SCA device. |
| <code>paymentInstrumentId</code> | <code>string</code> | The unique identifier of the payment instrument linked to the SCA device. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteRegisteredDevicesIdError](Errors/DeleteRegisteredDevicesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchRegisteredDevicesResponse&gt; GetRegisteredDevices(string paymentInstrumentId, int? pageNumber, int? pageSize, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get a paginated list of the SCA devices you have currently registered for a specific payment instrument.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageScaDevices.GetRegisteredDevices(paymentInstrumentId, pageNumber, pageSize);
    // TODO: Handle 'response' of type SearchRegisteredDevicesResponse
}
catch (SdkException<GetRegisteredDevicesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>paymentInstrumentId</code> | <code>string</code> | The unique identifier of a payment instrument. It limits the returned list to SCA devices associated to this payment instrument. |
| <code>pageNumber</code> | <code>int?</code> | The index of the page to retrieve. The index of the first page is 0 (zero).<br><br>Default: 0. |
| <code>pageSize</code> | <code>int?</code> | The number of items to have on a page.<br><br>Default: 20. Maximum: 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchRegisteredDevicesResponse](Models/SearchRegisteredDevicesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetRegisteredDevicesError](Errors/GetRegisteredDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssociationFinaliseResponse&gt; PatchRegisteredDevicesDeviceIdAssociations(string deviceId, AssociationFinaliseRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Completes an association between a user's registered SCA device and an Adyen resource. For example, you can associate an SCA device with additional [business accounts](https://docs.adyen.com/platforms/business-accounts/sca/register-devices) or [Adyen-issued cards](https://docs.adyen.com/issuing/3d-secure/oob-auth-sdk/register-devices).

To complete the association, this endpoint validates the authentication data of the registered device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageScaDevices.PatchRegisteredDevicesDeviceIdAssociations(deviceId, body);
    // TODO: Handle 'response' of type AssociationFinaliseResponse
}
catch (SdkException<PatchRegisteredDevicesDeviceIdAssociationsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>deviceId</code> | <code>string</code> | The unique identifier of the SCA device that you are associating with a resource. |
| <code>body</code> | <code>[AssociationFinaliseRequest?](Models/AssociationFinaliseRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssociationFinaliseResponse](Models/AssociationFinaliseResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchRegisteredDevicesDeviceIdAssociationsError](Errors/PatchRegisteredDevicesDeviceIdAssociationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RegisterScaFinalResponse&gt; PatchRegisteredDevicesId(string id, RegisterScaRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Completes the registration of an SCA device by validating the authentication data of the device. You can register SCA devices for [business accounts](https://docs.adyen.com/platforms/business-accounts/sca) or [Adyen-issued cards](https://docs.adyen.com/issuing/3d-secure/oob-auth-sdk).



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageScaDevices.PatchRegisteredDevicesId(id, body);
    // TODO: Handle 'response' of type RegisterScaFinalResponse
}
catch (SdkException<PatchRegisteredDevicesIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the SCA device. You obtain this `id` in the response of a POST&nbsp;[/registeredDevices](https://docs.adyen.com/api-explorer/balanceplatform/2/post/registeredDevices#responses-200-id) request. |
| <code>body</code> | <code>[RegisterScaRequest?](Models/RegisterScaRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RegisterScaFinalResponse](Models/RegisterScaFinalResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchRegisteredDevicesIdError](Errors/PatchRegisteredDevicesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RegisterScaResponse&gt; PostRegisteredDevices(RegisterScaRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Initiates the registration of a user's device for Strong Customer Authentication (SCA). You can register SCA devices for [business accounts](https://docs.adyen.com/platforms/business-accounts/sca/register-devices) or [Adyen-issued cards](https://docs.adyen.com/issuing/3d-secure/oob-auth-sdk/register-devices).

For a successful request, the device must be eligible for SCA.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageScaDevices.PostRegisteredDevices(body);
    // TODO: Handle 'response' of type RegisterScaResponse
}
catch (SdkException<PostRegisteredDevicesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[RegisterScaRequest?](Models/RegisterScaRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RegisterScaResponse](Models/RegisterScaResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostRegisteredDevicesError](Errors/PostRegisteredDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssociationInitiateResponse&gt; PostRegisteredDevicesDeviceIdAssociations(string deviceId, AssociationInitiateRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Initiates an association between a user's registered SCA device and an Adyen resource. For example, you can associate an SCA device with additional [business accounts](https://docs.adyen.com/platforms/business-accounts/sca/register-devices) or [Adyen-issued cards](https://docs.adyen.com/issuing/3d-secure/oob-auth-sdk/register-devices).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageScaDevices.PostRegisteredDevicesDeviceIdAssociations(deviceId, body);
    // TODO: Handle 'response' of type AssociationInitiateResponse
}
catch (SdkException<PostRegisteredDevicesDeviceIdAssociationsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>deviceId</code> | <code>string</code> | The unique identifier of the SCA device that you are associating with a resource. |
| <code>body</code> | <code>[AssociationInitiateRequest?](Models/AssociationInitiateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssociationInitiateResponse](Models/AssociationInitiateResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostRegisteredDevicesDeviceIdAssociationsError](Errors/PostRegisteredDevicesDeviceIdAssociationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageCardPin

> Source: [ManageCardPin](Api/ManageCardPin.cs)

<details>
<summary><code>Task&lt;PublicKeyResponse&gt; GetPublicKey(string? purpose, string? format, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get an [RSA](https://en.wikipedia.org/wiki/RSA_(cryptosystem)) public key to encrypt or decrypt card data.

 You need the RSA public key to generate the `encryptedKey` required to:
- [Change a PIN](https://docs.adyen.com/api-explorer/balanceplatform/2/post/pins/change).
- [Reveal a PIN](https://docs.adyen.com/api-explorer/balanceplatform/2/post/pins/reveal).
- [Reveal a PAN](https://docs.adyen.com/api-explorer/balanceplatform/2/post/paymentInstruments/reveal).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageCardPin.GetPublicKey(purpose, format);
    // TODO: Handle 'response' of type PublicKeyResponse
}
catch (SdkException<GetPublicKeyError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>purpose</code> | <code>string?</code> | The purpose of the public key.<br><br>Possible values: **pinChange**, **pinReveal**, **panReveal**.<br><br>Default value: **pinReveal**. |
| <code>format</code> | <code>string?</code> | The encoding format of public key.<br><br>Possible values: **jwk**, **pem**.<br><br>Default value: **pem**. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PublicKeyResponse](Models/PublicKeyResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetPublicKeyError](Errors/GetPublicKeyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PinChangeResponse&gt; PostPinsChange(PinChangeRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the personal identification number (PIN) of a specified card.

To make this request, your API credential must have the following role:
* Bank Issuing PIN Change Webservice role

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageCardPin.PostPinsChange(body);
    // TODO: Handle 'response' of type PinChangeResponse
}
catch (SdkException<PostPinsChangeError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[PinChangeRequest?](Models/PinChangeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PinChangeResponse](Models/PinChangeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPinsChangeError](Errors/PostPinsChangeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RevealPinResponse&gt; PostPinsReveal(RevealPinRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an encrypted PIN block that contains the PIN of a specified card. You can use the decrypted data to reveal the PIN in your user interface.

To make this request, your API credential must have the following role:
* Bank Issuing PIN Reveal Webservice role

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageCardPin.PostPinsReveal(body);
    // TODO: Handle 'response' of type RevealPinResponse
}
catch (SdkException<PostPinsRevealError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[RevealPinRequest?](Models/RevealPinRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RevealPinResponse](Models/RevealPinResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPinsRevealError](Errors/PostPinsRevealError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManagedPayoutSchedules

> Source: [ManagedPayoutSchedules](Api/ManagedPayoutSchedules.cs)

<details>
<summary><code>Task DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesId(string balanceAccountId, string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a payout schedule applied to a balance account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ManagedPayoutSchedules.DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesId(balanceAccountId, id);
}
catch (SdkException<DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balanceAccountId</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>id</code> | <code>string</code> | The unique identifier of the payout schedule applied to the balance account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdError](Errors/DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalanceAccountConfigurations&gt; GetBalanceAccountsBalanceAccountIdPayoutSchedules(string balanceAccountId, string? currency, string? cursor, int? limit = 10, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all managed payout schedules that are configured on a balance account. You can use query parameters to filter the elements that are returned in the list.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagedPayoutSchedules.GetBalanceAccountsBalanceAccountIdPayoutSchedules(balanceAccountId,
        currency,
        cursor);
    // TODO: Handle 'response' of type BalanceAccountConfigurations
}
catch (SdkException<GetBalanceAccountsBalanceAccountIdPayoutSchedulesError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balanceAccountId</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>currency</code> | <code>string?</code> | The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes) of the currency used in the payout schedule. |
| <code>cursor</code> | <code>string?</code> | The `cursor` returned in the links of the previous response. |
| <code>limit</code> | <code>int?</code> | The number of items returned per page, maximum of 100 items. By default, the response returns 10 items per page.<br>**Default**: 10 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceAccountConfigurations](Models/BalanceAccountConfigurations.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalanceAccountsBalanceAccountIdPayoutSchedulesError](Errors/GetBalanceAccountsBalanceAccountIdPayoutSchedulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalanceAccountConfiguration&gt; GetBalanceAccountsBalanceAccountIdPayoutSchedulesId(string balanceAccountId, string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the specified payout schedule.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagedPayoutSchedules.GetBalanceAccountsBalanceAccountIdPayoutSchedulesId(balanceAccountId,
        id);
    // TODO: Handle 'response' of type BalanceAccountConfiguration
}
catch (SdkException<GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balanceAccountId</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>id</code> | <code>string</code> | The unique identifier of the payout schedule for the balance account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceAccountConfiguration](Models/BalanceAccountConfiguration.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdError](Errors/GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PayoutScheduleExecutions&gt; GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutions(string balanceAccountId, string id, int offset, IReadOnlyList&lt;ExecutionResult&gt;? results, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

View information about the executions of a managed payout schedule on the specified balance account. An execution is an attempt to make a payout according to the payout schedule. 

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagedPayoutSchedules.GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutions(balanceAccountId,
        id,
        offset,
        results,
        limit);
    // TODO: Handle 'response' of type PayoutScheduleExecutions
}
catch (SdkException<GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balanceAccountId</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>id</code> | <code>string</code> | The unique identifier of the payout schedule on the balance account. |
| <code>offset</code> | <code>int</code> | The page number to be returned.<br><br>Default: **1** |
| <code>results</code> | <code>IReadOnlyList&lt;[ExecutionResult](Models/Enums/ExecutionResult.cs)&gt;?</code> | Contains a list of payout statuses. If included, the response returns only executed payouts that currently have one of the specified statuses.<br><br>Possible statuses:<br>- **succeeded**: The payout was sent successfully.<br>- **failed**: The payout was not sent due to an error.<br>- **skipped**: The payout was not triggered as expected. |
| <code>limit</code> | <code>int?</code> | The number of items returned per page.<br><br>Default: **10** |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutScheduleExecutions](Models/PayoutScheduleExecutions.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError](Errors/GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalancePlatformConfigurations&gt; GetBalancePlatformsBalancePlatformIdPayoutSchedules(string balancePlatformId, string? countryCode, string? currency, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all the payout schedules that are configured for your balance platform. You can use query parameters to filter the elements that are returned in the list.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagedPayoutSchedules.GetBalancePlatformsBalancePlatformIdPayoutSchedules(balancePlatformId,
        countryCode,
        currency);
    // TODO: Handle 'response' of type BalancePlatformConfigurations
}
catch (SdkException<GetBalancePlatformsBalancePlatformIdPayoutSchedulesError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balancePlatformId</code> | <code>string</code> | The unique identifier of the balance platform. |
| <code>countryCode</code> | <code>string?</code> | The two-letter [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the country to which the payout configuration applies. |
| <code>currency</code> | <code>string?</code> | The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes) of the currency used in the payout configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalancePlatformConfigurations](Models/BalancePlatformConfigurations.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalancePlatformsBalancePlatformIdPayoutSchedulesError](Errors/GetBalancePlatformsBalancePlatformIdPayoutSchedulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalancePlatformConfiguration&gt; GetBalancePlatformsBalancePlatformIdPayoutSchedulesId(string balancePlatformId, string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the specified managed payout schedule configured on your balance platform.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagedPayoutSchedules.GetBalancePlatformsBalancePlatformIdPayoutSchedulesId(balancePlatformId,
        id);
    // TODO: Handle 'response' of type BalancePlatformConfiguration
}
catch (SdkException<GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balancePlatformId</code> | <code>string</code> | The unique identifier of the balance platform. |
| <code>id</code> | <code>string</code> | The unique identifier of the payout configuration for your balance platform. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalancePlatformConfiguration](Models/BalancePlatformConfiguration.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError](Errors/GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalanceAccountConfiguration&gt; PatchBalanceAccountsBalanceAccountIdPayoutSchedulesId(string balanceAccountId, string id, BalanceAccountConfigurationUpdate body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a managed payout schedule applied to a balance account. If an optional parameter is not included in the request, it remains unchanged.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagedPayoutSchedules.PatchBalanceAccountsBalanceAccountIdPayoutSchedulesId(balanceAccountId,
        id,
        body);
    // TODO: Handle 'response' of type BalanceAccountConfiguration
}
catch (SdkException<PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balanceAccountId</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>id</code> | <code>string</code> | The unique identifier of the payout schedule applied to the balance account. |
| <code>body</code> | <code>[BalanceAccountConfigurationUpdate](Models/BalanceAccountConfigurationUpdate.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceAccountConfiguration](Models/BalanceAccountConfiguration.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError](Errors/PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalanceAccountConfiguration&gt; PostBalanceAccountsBalanceAccountIdPayoutSchedules(string balanceAccountId, BalanceAccountConfigurationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Apply a managed payout schedule to a balance account. This payout schedule is based on an existing payout schedule in your balance platform.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagedPayoutSchedules.PostBalanceAccountsBalanceAccountIdPayoutSchedules(balanceAccountId,
        body);
    // TODO: Handle 'response' of type BalanceAccountConfiguration
}
catch (SdkException<PostBalanceAccountsBalanceAccountIdPayoutSchedulesError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balanceAccountId</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>body</code> | <code>[BalanceAccountConfigurationRequest](Models/BalanceAccountConfigurationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceAccountConfiguration](Models/BalanceAccountConfiguration.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostBalanceAccountsBalanceAccountIdPayoutSchedulesError](Errors/PostBalanceAccountsBalanceAccountIdPayoutSchedulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Modifications

> Source: [Modifications](Api/Modifications.cs)

<details>
<summary><code>Task&lt;ModificationResult&gt; PostAdjustAuthorisation(AdjustAuthorisationRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Allows you to increase or decrease the authorised amount after the initial authorisation has taken place. This functionality enables for example tipping, improving the chances your authorisation will be valid, or charging the shopper when they have already left the merchant premises.

> This endpoint is [inactive](https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle) and is no longer supported for new integrations.
> * If you are building a new integration, use the Checkout API [`/payments/{paymentPspReference}/amountUpdates`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments/(paymentPspReference)/amountUpdates) endpoint instead.
> * If you have an existing integration using this endpoint, reach out to your Adyen contact and [migrate to the Checkout API](https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api).

>The Checkout API enables your [online payments](https://docs.adyen.com/online-payments) integration to accept all supported payment methods, use the latest features, and access more benefits.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostAdjustAuthorisation(body);
    // TODO: Handle 'response' of type ModificationResult
}
catch (SdkException<PostAdjustAuthorisationError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AdjustAuthorisationRequest?](Models/AdjustAuthorisationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModificationResult](Models/ModificationResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostAdjustAuthorisationError](Errors/PostAdjustAuthorisationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ModificationResult&gt; PostCancel(CancelRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels the authorisation hold on a payment, returning a unique reference for this request. You can cancel payments after authorisation only for payment methods that support distinct authorisations and captures.

For more information, refer to [Cancel](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/cancel).

> This endpoint is [inactive](https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle) and is no longer supported for new integrations.
> * If you are building a new integration, use the Checkout API [`/payments/{paymentPspReference}/cancels`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments/(paymentPspReference)/cancels) endpoint instead.
> * If you have an existing integration using this endpoint, reach out to your Adyen contact and [migrate to the Checkout API](https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api).

> The Checkout API enables your [online payments](https://docs.adyen.com/online-payments) integration to accept all supported payment methods, use the latest features, and access more benefits.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostCancel(body);
    // TODO: Handle 'response' of type ModificationResult
}
catch (SdkException<PostCancelError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CancelRequest?](Models/CancelRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModificationResult](Models/ModificationResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCancelError](Errors/PostCancelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ModificationResult&gt; PostCancelOrRefund(CancelOrRefundRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels a payment if it has not been captured yet, or refunds it if it has already been captured. This is useful when it is not certain if the payment has been captured or not (for example, when using auto-capture).

Do not use this endpoint for payments that involve:
 * [Multiple partial captures](https://docs.adyen.com/online-payments/capture).
 * [Split data](https://docs.adyen.com/classic-platforms/processing-payments#providing-split-information) either at time of payment or capture for Adyen for Platforms.

 Instead, check if the payment has been captured and make a corresponding [`/refund`](https://docs.adyen.com/api-explorer/#/Payment/refund) or [`/cancel`](https://docs.adyen.com/api-explorer/#/Payment/cancel) call.

For more information, refer to [Cancel or refund](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/cancel-or-refund).

> This endpoint is [inactive](https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle) and is no longer supported for new integrations.
> * If you are building a new integration, use the Checkout API [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments/(paymentPspReference)/reversals) endpoint instead.
> * If you have an existing integration using this endpoint, reach out to your Adyen contact and [migrate to the Checkout API](https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api).

> The Checkout API enables your [online payments](https://docs.adyen.com/online-payments) integration to accept all supported payment methods, use the latest features, and access more benefits.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostCancelOrRefund(body);
    // TODO: Handle 'response' of type ModificationResult
}
catch (SdkException<PostCancelOrRefundError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CancelOrRefundRequest?](Models/CancelOrRefundRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModificationResult](Models/ModificationResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCancelOrRefundError](Errors/PostCancelOrRefundError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StandalonePaymentCancelResponse&gt; PostCancels(string? idempotencyKey, StandalonePaymentCancelRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels the authorisation on a payment that has not yet been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures), and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**TECHNICAL_CANCEL** webhook](https://docs.adyen.com/online-payments/cancel#cancellation-webhook).

If you want to cancel a payment using the [`pspReference`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference), use the [`/payments/{paymentPspReference}/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/cancels) endpoint instead.

If you want to cancel a payment but are not sure whether it has been captured, use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals) endpoint instead.

For more information, refer to [Cancel](https://docs.adyen.com/online-payments/cancel).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostCancels(idempotencyKey, body);
    // TODO: Handle 'response' of type StandalonePaymentCancelResponse
}
catch (SdkException<PostCancelsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[StandalonePaymentCancelRequest?](Models/StandalonePaymentCancelRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StandalonePaymentCancelResponse](Models/StandalonePaymentCancelResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCancelsError](Errors/PostCancelsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ModificationResult&gt; PostCapture(CaptureRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Captures the authorisation hold on a payment, returning a unique reference for this request. Usually the full authorisation amount is captured, however it's also possible to capture a smaller amount, which results in cancelling the remaining authorisation balance.

Payment methods that are captured automatically after authorisation don't need to be captured. However, submitting a capture request on these transactions will not result in double charges. If immediate or delayed auto-capture is enabled, calling the capture method is not necessary.

For more information refer to [Capture](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/capture).

> This endpoint is [inactive](https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle) and is no longer supported for new integrations.
> * If you are building a new integration, use the Checkout API [`/payments/{paymentPspReference}/captures`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments/(paymentPspReference)/captures) endpoint instead.
> * If you have an existing integration using this endpoint, reach out to your Adyen contact and [migrate to the Checkout API](https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api).

> The Checkout API enables your [online payments](https://docs.adyen.com/online-payments) integration to accept all supported payment methods, use the latest features, and access more benefits.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostCapture(body);
    // TODO: Handle 'response' of type ModificationResult
}
catch (SdkException<PostCaptureError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CaptureRequest?](Models/CaptureRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModificationResult](Models/ModificationResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCaptureError](Errors/PostCaptureError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ModificationResult&gt; PostDonate(DonationRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Schedules a new payment to be created (including a new authorisation request) for the specified donation using the payment details of the original payment.

> This endpoint is [inactive](https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle) and is no longer supported for new integrations.
> * If you are building a new integration, use the Checkout API [`/donations`](https://docs.adyen.com/api-explorer/Checkout/latest/post/donations) endpoint instead.
> * If you have an existing integration using this endpoint, reach out to your Adyen contact and [migrate to the Checkout API](https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api).

> The Checkout API enables your [online payments](https://docs.adyen.com/online-payments) integration to accept all supported payment methods, use the latest features, and access more benefits.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostDonate(body);
    // TODO: Handle 'response' of type ModificationResult
}
catch (SdkException<PostDonateError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DonationRequest?](Models/DonationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModificationResult](Models/ModificationResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostDonateError](Errors/PostDonateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentAmountUpdateResponse&gt; PostPaymentsPaymentPspReferenceAmountUpdates(string paymentPspReference, string? idempotencyKey, PaymentAmountUpdateRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Increases or decreases the authorised payment amount and returns a unique reference for this request. You get the outcome of the request asynchronously, in an [**AUTHORISATION_ADJUSTMENT** webhook](https://docs.adyen.com/development-resources/webhooks/webhook-types/#event-codes).

You can only update authorised amounts that have not yet been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures).

The amount you specify in the request is the updated amount, which is larger or smaller than the initial authorised amount.

For more information, refer to [Authorisation adjustment](https://docs.adyen.com/online-payments/adjust-authorisation#use-cases).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostPaymentsPaymentPspReferenceAmountUpdates(paymentPspReference,
        idempotencyKey,
        body);
    // TODO: Handle 'response' of type PaymentAmountUpdateResponse
}
catch (SdkException<PostPaymentsPaymentPspReferenceAmountUpdatesError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>paymentPspReference</code> | <code>string</code> | The [`pspReference`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment. |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[PaymentAmountUpdateRequest?](Models/PaymentAmountUpdateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentAmountUpdateResponse](Models/PaymentAmountUpdateResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPaymentsPaymentPspReferenceAmountUpdatesError](Errors/PostPaymentsPaymentPspReferenceAmountUpdatesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentCancelResponse&gt; PostPaymentsPaymentPspReferenceCancels(string paymentPspReference, string? idempotencyKey, PaymentCancelRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels the authorisation on a payment that has not yet been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures), and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**CANCELLATION** webhook](https://docs.adyen.com/online-payments/cancel#cancellation-webhook).

If you want to cancel a payment but don't have the [`pspReference`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference), use the [`/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/cancels) endpoint instead.

If you want to cancel a payment but are not sure whether it has been captured, use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals) endpoint instead.

For more information, refer to [Cancel](https://docs.adyen.com/online-payments/cancel).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostPaymentsPaymentPspReferenceCancels(paymentPspReference,
        idempotencyKey,
        body);
    // TODO: Handle 'response' of type PaymentCancelResponse
}
catch (SdkException<PostPaymentsPaymentPspReferenceCancelsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>paymentPspReference</code> | <code>string</code> | The [`pspReference`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment that you want to cancel. |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[PaymentCancelRequest?](Models/PaymentCancelRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentCancelResponse](Models/PaymentCancelResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPaymentsPaymentPspReferenceCancelsError](Errors/PostPaymentsPaymentPspReferenceCancelsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentCaptureResponse&gt; PostPaymentsPaymentPspReferenceCaptures(string paymentPspReference, string? idempotencyKey, PaymentCaptureRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

 Captures an authorised payment and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**CAPTURE** webhook](https://docs.adyen.com/online-payments/capture#capture-notification).

You can capture either the full authorised amount or a part of the authorised amount. By default, any unclaimed amount after a partial capture gets cancelled. This does not apply if you enabled multiple partial captures on your account and the payment method supports multiple partial captures. 

[Automatic capture](https://docs.adyen.com/online-payments/capture#automatic-capture) is the default setting for most payment methods. In these cases, you don't need to make capture requests. However, making capture requests for payments that are captured automatically does not result in double charges.

For more information, refer to [Capture](https://docs.adyen.com/online-payments/capture).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostPaymentsPaymentPspReferenceCaptures(paymentPspReference,
        idempotencyKey,
        body);
    // TODO: Handle 'response' of type PaymentCaptureResponse
}
catch (SdkException<PostPaymentsPaymentPspReferenceCapturesError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>paymentPspReference</code> | <code>string</code> | The [`pspReference`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment that you want to capture. |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[PaymentCaptureRequest?](Models/PaymentCaptureRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentCaptureResponse](Models/PaymentCaptureResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPaymentsPaymentPspReferenceCapturesError](Errors/PostPaymentsPaymentPspReferenceCapturesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentRefundResponse&gt; PostPaymentsPaymentPspReferenceRefunds(string paymentPspReference, string? idempotencyKey, PaymentRefundRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Refunds a payment that has been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures), and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**REFUND** webhook](https://docs.adyen.com/online-payments/refund#refund-webhook).

You can refund either the full captured amount or a part of the captured amount. You can also perform multiple partial refunds, as long as their sum doesn't exceed the captured amount.

> Some payment methods do not support partial refunds. To learn if a payment method supports partial refunds, refer to the payment method page such as [cards](https://docs.adyen.com/payment-methods/cards#supported-cards), [iDEAL](https://docs.adyen.com/payment-methods/ideal), or [Klarna](https://docs.adyen.com/payment-methods/klarna). 

If you want to refund a payment but are not sure whether it has been captured, use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals) endpoint instead.

For more information, refer to [Refund](https://docs.adyen.com/online-payments/refund).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostPaymentsPaymentPspReferenceRefunds(paymentPspReference,
        idempotencyKey,
        body);
    // TODO: Handle 'response' of type PaymentRefundResponse
}
catch (SdkException<PostPaymentsPaymentPspReferenceRefundsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>paymentPspReference</code> | <code>string</code> | The [`pspReference`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment that you want to refund. |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[PaymentRefundRequest?](Models/PaymentRefundRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentRefundResponse](Models/PaymentRefundResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPaymentsPaymentPspReferenceRefundsError](Errors/PostPaymentsPaymentPspReferenceRefundsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentReversalResponse&gt; PostPaymentsPaymentPspReferenceReversals(string paymentPspReference, string? idempotencyKey, PaymentReversalRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

[Refunds](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/refunds) a payment if it has already been captured, and [cancels](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/cancels) a payment if it has not yet been captured. Returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**CANCEL_OR_REFUND** webhook](https://docs.adyen.com/online-payments/reversal/#cancel-or-refund-webhook).

The reversed amount is always the full payment amount.
> Do not use this request for payments that involve multiple partial captures.

For more information, refer to [Reversal](https://docs.adyen.com/online-payments/reversal).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostPaymentsPaymentPspReferenceReversals(paymentPspReference,
        idempotencyKey,
        body);
    // TODO: Handle 'response' of type PaymentReversalResponse
}
catch (SdkException<PostPaymentsPaymentPspReferenceReversalsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>paymentPspReference</code> | <code>string</code> | The [`pspReference`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment that you want to reverse. |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[PaymentReversalRequest?](Models/PaymentReversalRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentReversalResponse](Models/PaymentReversalResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPaymentsPaymentPspReferenceReversalsError](Errors/PostPaymentsPaymentPspReferenceReversalsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ModificationResult&gt; PostRefund(RefundRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Refunds a payment that has previously been captured, returning a unique reference for this request. Refunding can be done on the full captured amount or a partial amount. Multiple (partial) refunds will be accepted as long as their sum doesn't exceed the captured amount. Payments which have been authorised, but not captured, cannot be refunded, use the /cancel method instead.

Some payment methods/gateways do not support partial/multiple refunds.
A margin above the captured limit can be configured to cover shipping/handling costs.

For more information, refer to [Refund](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/refund).

> This endpoint is [inactive](https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle) and is no longer supported for new integrations.
> * If you are building a new integration, use the Checkout API [`/payments/{paymentPspReference}/refunds`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments/(paymentPspReference)/refunds) endpoint instead.
> * If you have an existing integration using this endpoint, reach out to your Adyen contact and [migrate to the Checkout API](https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api).

> The Checkout API enables your [online payments](https://docs.adyen.com/online-payments) integration to accept all supported payment methods, use the latest features, and access more benefits.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostRefund(body);
    // TODO: Handle 'response' of type ModificationResult
}
catch (SdkException<PostRefundError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[RefundRequest?](Models/RefundRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModificationResult](Models/ModificationResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostRefundError](Errors/PostRefundError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ModificationResult&gt; PostTechnicalCancel(TechnicalCancelRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows you to cancel a payment if you do not have the PSP reference of the original payment request available.

In your call, refer to the original payment by using the `reference` that you specified in your payment request.

For more information, see [Technical cancel](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/cancel#technical-cancel). 

> This endpoint is [inactive](https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle) and is no longer supported for new integrations.
> * If you are building a new integration, use the Checkout API [`/cancels`](https://docs.adyen.com/api-explorer/Checkout/latest/post/cancels) endpoint instead.
> * If you have an existing integration using this endpoint, reach out to your Adyen contact and [migrate to the Checkout API](https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api).

> The Checkout API enables your [online payments](https://docs.adyen.com/online-payments) integration to accept all supported payment methods, use the latest features, and access more benefits.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostTechnicalCancel(body);
    // TODO: Handle 'response' of type ModificationResult
}
catch (SdkException<PostTechnicalCancelError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[TechnicalCancelRequest?](Models/TechnicalCancelRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModificationResult](Models/ModificationResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostTechnicalCancelError](Errors/PostTechnicalCancelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ModificationResult&gt; PostVoidPendingRefund(VoidPendingRefundRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows you to cancel an unreferenced refund request before it has been completed.

In your call, you can refer to the original refund request either by using the `tenderReference`, or the `pspReference`. We recommend implementing based on the `tenderReference`, as this is generated for both offline and online transactions.

For more information, refer to [Cancel an unreferenced refund](https://docs.adyen.com/point-of-sale/basic-tapi-integration/refund-payment/cancel-unreferenced).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostVoidPendingRefund(body);
    // TODO: Handle 'response' of type ModificationResult
}
catch (SdkException<PostVoidPendingRefundError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[VoidPendingRefundRequest?](Models/VoidPendingRefundRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModificationResult](Models/ModificationResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostVoidPendingRefundError](Errors/PostVoidPendingRefundError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## MyApiCredential

> Source: [MyApiCredential](Api/MyApiCredential.cs)

<details>
<summary><code>Task DeleteMeAllowedOriginsOriginId(string originId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes the [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) specified in the path.
The API key from the request is used to identify the [API credential](https://docs.adyen.com/development-resources/api-credentials).

You can make this request with any of the Management API roles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.MyApiCredential.DeleteMeAllowedOriginsOriginId(originId);
}
catch (SdkException<DeleteMeAllowedOriginsOriginIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>originId</code> | <code>string</code> | Unique identifier of the allowed origin. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteMeAllowedOriginsOriginIdError](Errors/DeleteMeAllowedOriginsOriginIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MeApiCredential&gt; GetMe(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns your [API credential](https://docs.adyen.com/development-resources/api-credentials) details based on the API Key you used in the request.

You can make this request with any of the Management API roles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MyApiCredential.GetMe();
    // TODO: Handle 'response' of type MeApiCredential
}
catch (SdkException<GetMeError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MeApiCredential](Models/MeApiCredential.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMeError](Errors/GetMeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOriginsResponse&gt; GetMeAllowedOrigins(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) of your [API credential](https://docs.adyen.com/development-resources/api-credentials) based on the API key you used in the request.

You can make this request with any of the Management API roles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MyApiCredential.GetMeAllowedOrigins();
    // TODO: Handle 'response' of type AllowedOriginsResponse
}
catch (SdkException<GetMeAllowedOriginsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOriginsResponse](Models/AllowedOriginsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMeAllowedOriginsError](Errors/GetMeAllowedOriginsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOrigin&gt; GetMeAllowedOriginsOriginId(string originId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) specified in the path.
The API key from the request is used to identify the [API credential](https://docs.adyen.com/development-resources/api-credentials).

You can make this request with any of the Management API roles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MyApiCredential.GetMeAllowedOriginsOriginId(originId);
    // TODO: Handle 'response' of type AllowedOrigin
}
catch (SdkException<GetMeAllowedOriginsOriginIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>originId</code> | <code>string</code> | Unique identifier of the allowed origin. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOrigin](Models/AllowedOrigin.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMeAllowedOriginsOriginIdError](Errors/GetMeAllowedOriginsOriginIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOrigin&gt; PostMeAllowedOrigins(CreateAllowedOriginRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds an allowed origin to the list of [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) of your API credential.
The API key from the request is used to identify the [API credential](https://docs.adyen.com/development-resources/api-credentials).

You can make this request with any of the Management API roles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MyApiCredential.PostMeAllowedOrigins(body);
    // TODO: Handle 'response' of type AllowedOrigin
}
catch (SdkException<PostMeAllowedOriginsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateAllowedOriginRequest?](Models/CreateAllowedOriginRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOrigin](Models/AllowedOrigin.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMeAllowedOriginsError](Errors/PostMeAllowedOriginsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenerateClientKeyResponse&gt; PostMeGenerateClientKey(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generates a new [client key](https://docs.adyen.com/development-resources/client-side-authentication/) used to authenticate requests from your payment environment.
You can use the new client key a few minutes after generating it.
The old client key stops working 24 hours after generating a new one.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MyApiCredential.PostMeGenerateClientKey();
    // TODO: Handle 'response' of type GenerateClientKeyResponse
}
catch (SdkException<PostMeGenerateClientKeyError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateClientKeyResponse](Models/GenerateClientKeyResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMeGenerateClientKeyError](Errors/PostMeGenerateClientKeyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## NetworkTokens

> Source: [NetworkTokens](Api/NetworkTokens.cs)

<details>
<summary><code>Task&lt;GetNetworkTokenResponse&gt; GetNetworkTokensNetworkTokenId(string networkTokenId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a network token.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.NetworkTokens.GetNetworkTokensNetworkTokenId(networkTokenId);
    // TODO: Handle 'response' of type GetNetworkTokenResponse
}
catch (SdkException<GetNetworkTokensNetworkTokenIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>networkTokenId</code> | <code>string</code> | The unique identifier of the network token. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetNetworkTokenResponse](Models/GetNetworkTokenResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetNetworkTokensNetworkTokenIdError](Errors/GetNetworkTokensNetworkTokenIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PatchNetworkTokensNetworkTokenId(string networkTokenId, UpdateNetworkTokenRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the status of the network token.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.NetworkTokens.PatchNetworkTokensNetworkTokenId(networkTokenId, body);
}
catch (SdkException<PatchNetworkTokensNetworkTokenIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>networkTokenId</code> | <code>string</code> | The unique identifier of the network token. |
| <code>body</code> | <code>[UpdateNetworkTokenRequest?](Models/UpdateNetworkTokenRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchNetworkTokensNetworkTokenIdError](Errors/PatchNetworkTokensNetworkTokenIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Orders

> Source: [Orders](Api/Orders.cs)

<details>
<summary><code>Task&lt;CreateOrderResponse&gt; PostOrders(string? idempotencyKey, CreateOrderRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an order to be used for partial payments. Make a POST `/orders` call before making a `/payments` call when processing payments with different payment methods.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.PostOrders(idempotencyKey, body);
    // TODO: Handle 'response' of type CreateOrderResponse
}
catch (SdkException<PostOrdersError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[CreateOrderRequest?](Models/CreateOrderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateOrderResponse](Models/CreateOrderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostOrdersError](Errors/PostOrdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CancelOrderResponse&gt; PostOrdersCancel(string? idempotencyKey, CancelOrderRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels an order. Cancellation of an order results in an automatic rollback of all payments made in the order, either by canceling or refunding the payment, depending on the type of payment method.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.PostOrdersCancel(idempotencyKey, body);
    // TODO: Handle 'response' of type CancelOrderResponse
}
catch (SdkException<PostOrdersCancelError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[CancelOrderRequest?](Models/CancelOrderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelOrderResponse](Models/CancelOrderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostOrdersCancelError](Errors/PostOrdersCancelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalanceCheckResponse&gt; PostPaymentMethodsBalance(string? idempotencyKey, BalanceCheckRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the balance remaining on a shopper's gift card. To check a gift card's balance, make a POST `/paymentMethods/balance` call and include the gift card's details inside a `paymentMethod` object.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.PostPaymentMethodsBalance(idempotencyKey, body);
    // TODO: Handle 'response' of type BalanceCheckResponse
}
catch (SdkException<PostPaymentMethodsBalanceError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[BalanceCheckRequest?](Models/BalanceCheckRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceCheckResponse](Models/BalanceCheckResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPaymentMethodsBalanceError](Errors/PostPaymentMethodsBalanceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PciComplianceQuestionnairePage

> Source: [PciComplianceQuestionnairePage](Api/PciComplianceQuestionnairePage.cs)

<details>
<summary><code>Task&lt;GetPciUrlResponse&gt; PostGetPciQuestionnaireUrl(GetPciUrlRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a link to a PCI compliance questionnaire that you can send to your account holder.
 > You should only use this endpoint if you have a [partner platform setup](https://docs.adyen.com/classic-platforms/platforms-for-partners).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PciComplianceQuestionnairePage.PostGetPciQuestionnaireUrl(body);
    // TODO: Handle 'response' of type GetPciUrlResponse
}
catch (SdkException<PostGetPciQuestionnaireUrlError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GetPciUrlRequest?](Models/GetPciUrlRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetPciUrlResponse](Models/GetPciUrlResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostGetPciQuestionnaireUrlError](Errors/PostGetPciQuestionnaireUrlError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PciQuestionnaires

> Source: [PciQuestionnaires](Api/PciQuestionnaires.cs)

<details>
<summary><code>Task&lt;GetPciQuestionnaireInfosResponse&gt; GetLegalEntitiesIdPciQuestionnaires(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get a list of signed PCI questionnaires.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PciQuestionnaires.GetLegalEntitiesIdPciQuestionnaires(id);
    // TODO: Handle 'response' of type GetPciQuestionnaireInfosResponse
}
catch (SdkException<GetLegalEntitiesIdPciQuestionnairesError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the legal entity to get PCI questionnaire information. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetPciQuestionnaireInfosResponse](Models/GetPciQuestionnaireInfosResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLegalEntitiesIdPciQuestionnairesError](Errors/GetLegalEntitiesIdPciQuestionnairesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetPciQuestionnaireResponse&gt; GetLegalEntitiesIdPciQuestionnairesPciid(string id, string pciid, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the signed PCI questionnaire.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PciQuestionnaires.GetLegalEntitiesIdPciQuestionnairesPciid(id, pciid);
    // TODO: Handle 'response' of type GetPciQuestionnaireResponse
}
catch (SdkException<GetLegalEntitiesIdPciQuestionnairesPciidError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The legal entity ID of the individual who signed the PCI questionnaire. |
| <code>pciid</code> | <code>string</code> | The unique identifier of the signed PCI questionnaire. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetPciQuestionnaireResponse](Models/GetPciQuestionnaireResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLegalEntitiesIdPciQuestionnairesPciidError](Errors/GetLegalEntitiesIdPciQuestionnairesPciidError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GeneratePciDescriptionResponse&gt; PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplates(string id, GeneratePciDescriptionRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generates the required PCI questionnaires based on the user's [salesChannel](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/businessLines__reqParam_salesChannels).

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PciQuestionnaires.PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplates(id, body);
    // TODO: Handle 'response' of type GeneratePciDescriptionResponse
}
catch (SdkException<PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the legal entity to get PCI questionnaire information. |
| <code>body</code> | <code>[GeneratePciDescriptionRequest?](Models/GeneratePciDescriptionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GeneratePciDescriptionResponse](Models/GeneratePciDescriptionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesError](Errors/PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PciSigningResponse&gt; PostLegalEntitiesIdPciQuestionnairesSignPciTemplates(string id, PciSigningRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Signs the required PCI questionnaire.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PciQuestionnaires.PostLegalEntitiesIdPciQuestionnairesSignPciTemplates(id, body);
    // TODO: Handle 'response' of type PciSigningResponse
}
catch (SdkException<PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The legal entity ID of the user that has a contractual relationship with your platform. |
| <code>body</code> | <code>[PciSigningRequest?](Models/PciSigningRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PciSigningResponse](Models/PciSigningResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesError](Errors/PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CalculatePciStatusResponse&gt; PostLegalEntitiesIdPciQuestionnairesSigningRequired(string id, CalculatePciStatusRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Calculate PCI status of a legal entity.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PciQuestionnaires.PostLegalEntitiesIdPciQuestionnairesSigningRequired(id, body);
    // TODO: Handle 'response' of type CalculatePciStatusResponse
}
catch (SdkException<PostLegalEntitiesIdPciQuestionnairesSigningRequiredError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the legal entity to calculate PCI status. |
| <code>body</code> | <code>[CalculatePciStatusRequest?](Models/CalculatePciStatusRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CalculatePciStatusResponse](Models/CalculatePciStatusResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostLegalEntitiesIdPciQuestionnairesSigningRequiredError](Errors/PostLegalEntitiesIdPciQuestionnairesSigningRequiredError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PaymentInstrumentGroups

> Source: [PaymentInstrumentGroups](Api/PaymentInstrumentGroups.cs)

<details>
<summary><code>Task&lt;PaymentInstrumentGroup&gt; GetPaymentInstrumentGroupsId(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a payment instrument group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstrumentGroups.GetPaymentInstrumentGroupsId(id);
    // TODO: Handle 'response' of type PaymentInstrumentGroup
}
catch (SdkException<GetPaymentInstrumentGroupsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the payment instrument group. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInstrumentGroup](Models/PaymentInstrumentGroup.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetPaymentInstrumentGroupsIdError](Errors/GetPaymentInstrumentGroupsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionRulesResponse&gt; GetPaymentInstrumentGroupsIdTransactionRules(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all the transaction rules associated with a payment instrument group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstrumentGroups.GetPaymentInstrumentGroupsIdTransactionRules(id);
    // TODO: Handle 'response' of type TransactionRulesResponse
}
catch (SdkException<GetPaymentInstrumentGroupsIdTransactionRulesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the payment instrument group. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionRulesResponse](Models/TransactionRulesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetPaymentInstrumentGroupsIdTransactionRulesError](Errors/GetPaymentInstrumentGroupsIdTransactionRulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInstrumentGroup&gt; PostPaymentInstrumentGroups(PaymentInstrumentGroupInfo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a payment instrument group to associate and group payment instrument resources together. You can apply a transaction rule to a payment instrument group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstrumentGroups.PostPaymentInstrumentGroups(body);
    // TODO: Handle 'response' of type PaymentInstrumentGroup
}
catch (SdkException<PostPaymentInstrumentGroupsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[PaymentInstrumentGroupInfo?](Models/PaymentInstrumentGroupInfo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInstrumentGroup](Models/PaymentInstrumentGroup.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPaymentInstrumentGroupsError](Errors/PostPaymentInstrumentGroupsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PaymentInstruments

> Source: [PaymentInstruments](Api/PaymentInstruments.cs)

<details>
<summary><code>Task&lt;PaymentInstrument1&gt; GetPaymentInstrumentsId(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a payment instrument.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstruments.GetPaymentInstrumentsId(id);
    // TODO: Handle 'response' of type PaymentInstrument1
}
catch (SdkException<GetPaymentInstrumentsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the payment instrument. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInstrument1](Models/PaymentInstrument1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetPaymentInstrumentsIdError](Errors/GetPaymentInstrumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NetworkTokenActivationDataResponse&gt; GetPaymentInstrumentsIdNetworkTokenActivationData(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the network token activation data for a payment instrument.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstruments.GetPaymentInstrumentsIdNetworkTokenActivationData(id);
    // TODO: Handle 'response' of type NetworkTokenActivationDataResponse
}
catch (SdkException<GetPaymentInstrumentsIdNetworkTokenActivationDataError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the payment instrument. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NetworkTokenActivationDataResponse](Models/NetworkTokenActivationDataResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetPaymentInstrumentsIdNetworkTokenActivationDataError](Errors/GetPaymentInstrumentsIdNetworkTokenActivationDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListNetworkTokensResponse&gt; GetPaymentInstrumentsIdNetworkTokens(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List the network tokens connected to a payment instrument.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstruments.GetPaymentInstrumentsIdNetworkTokens(id);
    // TODO: Handle 'response' of type ListNetworkTokensResponse
}
catch (SdkException<GetPaymentInstrumentsIdNetworkTokensError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the payment instrument. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListNetworkTokensResponse](Models/ListNetworkTokensResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetPaymentInstrumentsIdNetworkTokensError](Errors/GetPaymentInstrumentsIdNetworkTokensError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInstrumentRevealInfo&gt; GetPaymentInstrumentsIdReveal(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the primary account number (PAN) of a payment instrument.

To make this request, your API credential must have the following [role](https://docs.adyen.com/issuing/manage-access/api-credentials-web-service#api-permissions):

* Balance Platform BCL PCI role

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstruments.GetPaymentInstrumentsIdReveal(id);
    // TODO: Handle 'response' of type PaymentInstrumentRevealInfo
}
catch (SdkException<GetPaymentInstrumentsIdRevealError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the payment instrument. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInstrumentRevealInfo](Models/PaymentInstrumentRevealInfo.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetPaymentInstrumentsIdRevealError](Errors/GetPaymentInstrumentsIdRevealError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionRulesResponse&gt; GetPaymentInstrumentsIdTransactionRules(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of transaction rules associated with a payment instrument.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstruments.GetPaymentInstrumentsIdTransactionRules(id);
    // TODO: Handle 'response' of type TransactionRulesResponse
}
catch (SdkException<GetPaymentInstrumentsIdTransactionRulesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the payment instrument. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionRulesResponse](Models/TransactionRulesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetPaymentInstrumentsIdTransactionRulesError](Errors/GetPaymentInstrumentsIdTransactionRulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdatePaymentInstrument&gt; PatchPaymentInstrumentsId(string id, PaymentInstrumentUpdateRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a payment instrument. Once a payment instrument is already active, you can only update its status. However, for cards created with **inactive** status, you can still update the balance account associated with the card.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstruments.PatchPaymentInstrumentsId(id, body);
    // TODO: Handle 'response' of type UpdatePaymentInstrument
}
catch (SdkException<PatchPaymentInstrumentsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the payment instrument. |
| <code>body</code> | <code>[PaymentInstrumentUpdateRequest?](Models/PaymentInstrumentUpdateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdatePaymentInstrument](Models/UpdatePaymentInstrument.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchPaymentInstrumentsIdError](Errors/PatchPaymentInstrumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInstrument1&gt; PostPaymentInstruments(PaymentInstrumentInfo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a payment instrument to issue a physical card, a virtual card, or a business account to your user.

 For more information, refer to [Issue cards](https://docs.adyen.com/issuing/create-cards) or [Issue business accounts](https://docs.adyen.com/platforms/business-accounts).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstruments.PostPaymentInstruments(body);
    // TODO: Handle 'response' of type PaymentInstrument1
}
catch (SdkException<PostPaymentInstrumentsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[PaymentInstrumentInfo?](Models/PaymentInstrumentInfo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInstrument1](Models/PaymentInstrument1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPaymentInstrumentsError](Errors/PostPaymentInstrumentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NetworkTokenActivationDataResponse&gt; PostPaymentInstrumentsIdNetworkTokenActivationData(string id, NetworkTokenActivationDataRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create provisioning data for a network token. Use the provisioning data to add a user's payment instrument to their digital wallet.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstruments.PostPaymentInstrumentsIdNetworkTokenActivationData(id, body);
    // TODO: Handle 'response' of type NetworkTokenActivationDataResponse
}
catch (SdkException<PostPaymentInstrumentsIdNetworkTokenActivationDataError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the payment instrument. |
| <code>body</code> | <code>[NetworkTokenActivationDataRequest?](Models/NetworkTokenActivationDataRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NetworkTokenActivationDataResponse](Models/NetworkTokenActivationDataResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPaymentInstrumentsIdNetworkTokenActivationDataError](Errors/PostPaymentInstrumentsIdNetworkTokenActivationDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInstrumentRevealResponse&gt; PostPaymentInstrumentsReveal(PaymentInstrumentRevealRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the encrypted data of a specified payment instrument. These data include:

- The primary account number (PAN)
- The card verification code (CVC)
- The expiry date

You can decrypt the data to reveal it in your user interface.

To make this request, your API credential must have the following role:
* Bank Issuing PAN Reveal Webservice role

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstruments.PostPaymentInstrumentsReveal(body);
    // TODO: Handle 'response' of type PaymentInstrumentRevealResponse
}
catch (SdkException<PostPaymentInstrumentsRevealError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[PaymentInstrumentRevealRequest?](Models/PaymentInstrumentRevealRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInstrumentRevealResponse](Models/PaymentInstrumentRevealResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPaymentInstrumentsRevealError](Errors/PostPaymentInstrumentsRevealError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PaymentLinks

> Source: [PaymentLinks](Api/PaymentLinks.cs)

<details>
<summary><code>Task&lt;PaymentLinkResponse&gt; GetPaymentLinksLinkId(string linkId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the payment link details using the payment link `id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentLinks.GetPaymentLinksLinkId(linkId);
    // TODO: Handle 'response' of type PaymentLinkResponse
}
catch (SdkException<GetPaymentLinksLinkIdError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>linkId</code> | <code>string</code> | Unique identifier of the payment link. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentLinkResponse](Models/PaymentLinkResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetPaymentLinksLinkIdError](Errors/GetPaymentLinksLinkIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentLinkResponse&gt; PatchPaymentLinksLinkId(string linkId, UpdatePaymentLinkRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the status of a payment link. Use this endpoint to [force the expiry of a payment link](https://docs.adyen.com/online-payments/pay-by-link#update-payment-link-status).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentLinks.PatchPaymentLinksLinkId(linkId, body);
    // TODO: Handle 'response' of type PaymentLinkResponse
}
catch (SdkException<PatchPaymentLinksLinkIdError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>linkId</code> | <code>string</code> | Unique identifier of the payment link. |
| <code>body</code> | <code>[UpdatePaymentLinkRequest?](Models/UpdatePaymentLinkRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentLinkResponse](Models/PaymentLinkResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchPaymentLinksLinkIdError](Errors/PatchPaymentLinksLinkIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentLinkResponse&gt; PostPaymentLinks(string? idempotencyKey, PaymentLinkRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a payment link to a [Pay by Link](https://docs.adyen.com/unified-commerce/pay-by-link/) page where the shopper can pay. The list of payment methods presented to the shopper depends on the `currency` and `country` parameters sent in the request.

For more information, refer to [Pay by Link documentation](https://docs.adyen.com/online-payments/pay-by-link#create-payment-links-through-api).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentLinks.PostPaymentLinks(idempotencyKey, body);
    // TODO: Handle 'response' of type PaymentLinkResponse
}
catch (SdkException<PostPaymentLinksError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[PaymentLinkRequest?](Models/PaymentLinkRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentLinkResponse](Models/PaymentLinkResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPaymentLinksError](Errors/PostPaymentLinksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PaymentMethodsMerchantLevel

> Source: [PaymentMethodsMerchantLevel](Api/PaymentMethodsMerchantLevel.cs)

<details>
<summary><code>Task&lt;PaymentMethodResponse&gt; GetMerchantsMerchantIdPaymentMethodSettings(string merchantId, string? storeId, string? businessLineId, int? pageSize, int? pageNumber, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns details for all payment methods of the merchant account identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payment methods read


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentMethodsMerchantLevel.GetMerchantsMerchantIdPaymentMethodSettings(merchantId,
        storeId,
        businessLineId,
        pageSize,
        pageNumber);
    // TODO: Handle 'response' of type PaymentMethodResponse
}
catch (SdkException<GetMerchantsMerchantIdPaymentMethodSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>storeId</code> | <code>string?</code> | The unique identifier of the store for which to return the payment methods. |
| <code>businessLineId</code> | <code>string?</code> | The unique identifier of the Business Line for which to return the payment methods. |
| <code>pageSize</code> | <code>int?</code> | The number of items to have on a page, maximum 100. The default is 10 items on a page. |
| <code>pageNumber</code> | <code>int?</code> | The number of the page to fetch. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentMethodResponse](Models/PaymentMethodResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdPaymentMethodSettingsError](Errors/GetMerchantsMerchantIdPaymentMethodSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ManagementPaymentMethod&gt; GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodId(string merchantId, string paymentMethodId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns details for the merchant account and the payment method identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payment methods read


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentMethodsMerchantLevel.GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodId(merchantId,
        paymentMethodId);
    // TODO: Handle 'response' of type ManagementPaymentMethod
}
catch (SdkException<GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>paymentMethodId</code> | <code>string</code> | The unique identifier of the payment method. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ManagementPaymentMethod](Models/ManagementPaymentMethod.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError](Errors/GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApplePayResponseInfo&gt; GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomains(string merchantId, string paymentMethodId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns all Apple Pay domains that are registered with the merchant account and the payment method identified in the path. For more information, see [Apple Pay documentation](https://docs.adyen.com/payment-methods/apple-pay/enable-apple-pay#register-merchant-domain).

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payment methods read


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentMethodsMerchantLevel.GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomains(merchantId,
        paymentMethodId);
    // TODO: Handle 'response' of type ApplePayResponseInfo
}
catch (SdkException<GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>paymentMethodId</code> | <code>string</code> | The unique identifier of the payment method. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApplePayResponseInfo](Models/ApplePayResponseInfo.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsError](Errors/GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ManagementPaymentMethod&gt; PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodId(string merchantId, string paymentMethodId, UpdatePaymentMethodInfo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates payment method details for the merchant account and the payment method identified in the path.
Depending the payment method [`type`](https://docs.adyen.com/api-explorer/Management/latest/patch/merchants/_merchantId_/paymentMethodSettings#request-type), you may need to send an additional object required for the payment method.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payment methods read and write


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentMethodsMerchantLevel.PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodId(merchantId,
        paymentMethodId,
        body);
    // TODO: Handle 'response' of type ManagementPaymentMethod
}
catch (SdkException<PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>paymentMethodId</code> | <code>string</code> | The unique identifier of the payment method. |
| <code>body</code> | <code>[UpdatePaymentMethodInfo?](Models/UpdatePaymentMethodInfo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ManagementPaymentMethod](Models/ManagementPaymentMethod.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError](Errors/PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ManagementPaymentMethod&gt; PostMerchantsMerchantIdPaymentMethodSettings(string merchantId, PaymentMethodSetupInfo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends a request to add a new payment method to the merchant account identified in the path.
Depending the payment method [`type`](https://docs.adyen.com/api-explorer/Management/latest/post/merchants/_merchantId_/paymentMethodSettings#request-type), you may need to send an additional object required for the payment method.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payment methods read and write


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentMethodsMerchantLevel.PostMerchantsMerchantIdPaymentMethodSettings(merchantId,
        body);
    // TODO: Handle 'response' of type ManagementPaymentMethod
}
catch (SdkException<PostMerchantsMerchantIdPaymentMethodSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>body</code> | <code>[PaymentMethodSetupInfo?](Models/PaymentMethodSetupInfo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ManagementPaymentMethod](Models/ManagementPaymentMethod.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsMerchantIdPaymentMethodSettingsError](Errors/PostMerchantsMerchantIdPaymentMethodSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomains(string merchantId, string paymentMethodId, ApplePayInfo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds the new domain to the list of Apple Pay domains that are registered with the merchant account and the payment method identified in the path. For more information, see [Apple Pay documentation](https://docs.adyen.com/payment-methods/apple-pay/web-drop-in/?tab=adyen-certificate-live_1#going-live).

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payment methods read and write


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PaymentMethodsMerchantLevel.PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomains(merchantId,
        paymentMethodId,
        body);
}
catch (SdkException<PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>paymentMethodId</code> | <code>string</code> | The unique identifier of the payment method. |
| <code>body</code> | <code>[ApplePayInfo?](Models/ApplePayInfo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsError](Errors/PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Payments

> Source: [Payments](Api/Payments.cs)

<details>
<summary><code>Task&lt;SessionResultResponse&gt; GetSessionsSessionId(string sessionId, string sessionResult, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the status of the payment session with the `sessionId` and `sessionResult` specified in the path.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.GetSessionsSessionId(sessionId, sessionResult);
    // TODO: Handle 'response' of type SessionResultResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>sessionId</code> | <code>string</code> | A unique identifier of the session. |
| <code>sessionResult</code> | <code>string</code> | The `sessionResult` value from the Drop-in or Component. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SessionResultResponse](Models/SessionResultResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentResult&gt; PostAuthorise(PaymentRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a payment with a unique reference (`pspReference`) and attempts to obtain an authorisation hold. For cards, this amount can be captured or cancelled later. Non-card payment methods typically don't support this and will automatically capture as part of the authorisation.

> This endpoint is [inactive](https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle) and is no longer supported for new integrations.
> * If you are building a new integration, use the Checkout API [`/payments`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments) endpoint instead.
> * If you have an existing integration using this endpoint, reach out to your Adyen contact and [migrate to the Checkout API](https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api).

>The Checkout API enables your [online payments](https://docs.adyen.com/online-payments) integration to accept all supported payment methods, use the latest features, and access more benefits.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostAuthorise(body);
    // TODO: Handle 'response' of type PaymentResult
}
catch (SdkException<PostAuthoriseError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[PaymentRequest1?](Models/PaymentRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentResult](Models/PaymentResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostAuthoriseError](Errors/PostAuthoriseError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentResult&gt; PostAuthorise3D(PaymentRequest3D? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

For an authenticated 3D Secure session, completes the payment authorisation. This endpoint must receive the `md` and `paResponse` parameters that you get from the card issuer after a shopper pays via 3D Secure.

> This endpoint is [inactive](https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle) and is no longer supported for new integrations.
> * If you are building a new integration, use the Checkout API [`/payments/details`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments/details) endpoint instead.
> * If you have an existing integration using this endpoint, reach out to your Adyen contact and [migrate to the Checkout API](https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api).

> The Checkout API enables your [online payments](https://docs.adyen.com/online-payments) integration to accept all supported payment methods, use the latest features, and access more benefits.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostAuthorise3D(body);
    // TODO: Handle 'response' of type PaymentResult
}
catch (SdkException<PostAuthorise3DError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[PaymentRequest3D?](Models/PaymentRequest3D.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentResult](Models/PaymentResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostAuthorise3DError](Errors/PostAuthorise3DError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentResult&gt; PostAuthorise3Ds2(PaymentRequest3Ds2? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

For an authenticated 3D Secure 2 session, completes the payment authorisation. This endpoint must receive the `threeDS2Token` and `threeDS2Result` parameters.

> This endpoint is [inactive](https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle) and is no longer supported for new integrations.
> * If you are building a new integration, use the Checkout API [`/payments/details`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments/details) endpoint instead.
> * If you have an existing integration using this endpoint, reach out to your Adyen contact and [migrate to the Checkout API](https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api).

>The Checkout API enables your [online payments](https://docs.adyen.com/online-payments) integration to accept all supported payment methods, use the latest features, and access more benefits.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostAuthorise3Ds2(body);
    // TODO: Handle 'response' of type PaymentResult
}
catch (SdkException<PostAuthorise3Ds2Error> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[PaymentRequest3Ds2?](Models/PaymentRequest3Ds2.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentResult](Models/PaymentResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostAuthorise3Ds2Error](Errors/PostAuthorise3Ds2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CardDetailsResponse&gt; PostCardDetails(string? idempotencyKey, CardDetailsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use this endpoint to get information about the card or network token that enables you to decide on the routing of the transaction and the eligibility of the card for the type of transaction.

If you include [your supported brands](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/cardDetails__reqParam_supportedBrands) in the request, the response also tells you if you support each [brand that was identified on the card](https://docs.adyen.com/api-explorer/Checkout/latest/post/cardDetails#responses-200-brands).

If you have an API-only integration and collect card data, use this endpoint to find out if the shopper's card is co-bad. For co-badged cards, you must let the shopper choose the brand to pay with  if you support both brands.

## Server-side API libraries
We provide open-source [server-side API libraries](https://docs.adyen.com/development-resources/libraries/) in several languages: 
- PHP
- Java
- Node.js
- .NET
- Go
- Python
- Ruby
- Apex (beta)

See our [integration examples](https://github.com/adyen-examples#%EF%B8%8F-official-integration-examples) for example uses of the libraries.

## Developer resources
BIN Lookup API is available through a Postman collection. Click the button below to create a fork, then set the environment variables at **Environments**&nbsp;>&nbsp;**Adyen&nbsp;APIs**. 

[![Run in Postman](https://run.pstmn.io/button.svg)](https://god.gw.postman.com/run-collection/25716737-677c7679-a695-4ebb-91da-68b4e7c9228a?action=collection%2Ffork&source=rip_markdown&collection-url=entityId%3D25716737-677c7679-a695-4ebb-91da-68b4e7c9228a%26entityType%3Dcollection%26workspaceId%3Da8d63f9f-cfc7-4810-90c5-9e0c60030d3e#?env%5BAdyen%20APIs%5D=W3sia2V5IjoiWC1BUEktS2V5IiwidmFsdWUiOiIiLCJlbmFibGVkIjp0cnVlLCJ0eXBlIjoic2VjcmV0In0seyJrZXkiOiJZT1VSX01FUkNIQU5UX0FDQ09VTlQiLCJ2YWx1ZSI6IiIsImVuYWJsZWQiOnRydWUsInR5cGUiOiJkZWZhdWx0In0seyJrZXkiOiJZT1VSX0NPTVBBTllfQUNDT1VOVCIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifSx7ImtleSI6IllPVVJfQkFMQU5DRV9QTEFURk9STSIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifV0=)




</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostCardDetails(idempotencyKey, body);
    // TODO: Handle 'response' of type CardDetailsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[CardDetailsRequest?](Models/CardDetailsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CardDetailsResponse](Models/CardDetailsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AuthenticationResultResponse&gt; PostGetAuthenticationResult(AuthenticationResultRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Return the authentication result after doing a 3D Secure authentication only.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostGetAuthenticationResult(body);
    // TODO: Handle 'response' of type AuthenticationResultResponse
}
catch (SdkException<PostGetAuthenticationResultError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AuthenticationResultRequest?](Models/AuthenticationResultRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AuthenticationResultResponse](Models/AuthenticationResultResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostGetAuthenticationResultError](Errors/PostGetAuthenticationResultError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentMethodsResponse&gt; PostPaymentMethods(string? idempotencyKey, PaymentMethodsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the list of available payment methods for the transaction, based on the transaction information like amount, country, and currency.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostPaymentMethods(idempotencyKey, body);
    // TODO: Handle 'response' of type PaymentMethodsResponse
}
catch (SdkException<PostPaymentMethodsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[PaymentMethodsRequest?](Models/PaymentMethodsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentMethodsResponse](Models/PaymentMethodsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPaymentMethodsError](Errors/PostPaymentMethodsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentResponse&gt; PostPayments(string? idempotencyKey, PaymentRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends payment parameters (like amount, country, and currency) together with other required input details collected from the shopper. To know more about required parameters for specific payment methods, refer to our [payment method guides](https://docs.adyen.com/payment-methods). 
The response depends on the [payment flow](https://docs.adyen.com/payment-methods#payment-flow):
* For a direct flow, the response includes a `pspReference` and a `resultCode` with the payment result, for example **Authorised** or **Refused**. 
* For a redirect or additional action, the response contains an `action` object. 

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostPayments(idempotencyKey, body);
    // TODO: Handle 'response' of type PaymentResponse
}
catch (SdkException<PostPaymentsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[PaymentRequest?](Models/PaymentRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentResponse](Models/PaymentResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPaymentsError](Errors/PostPaymentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CancelPaymentResponse&gt; PostPaymentsCancel(CancelPaymentRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels the payment. Returns a URL for user redirection.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostPaymentsCancel(body);
    // TODO: Handle 'response' of type CancelPaymentResponse
}
catch (SdkException<PostPaymentsCancelError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CancelPaymentRequest](Models/CancelPaymentRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelPaymentResponse](Models/CancelPaymentResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPaymentsCancelError](Errors/PostPaymentsCancelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConfirmPaymentResponse&gt; PostPaymentsConfirm(string? wwwAuthenticate, ConfirmPaymentRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

    Confirms the payment using Strong Customer Authentication (SCA).

    To confirm a payment you must make this request two times:

    1. Make this request to initiate SCA and receive the WWW-Authenticate header.
    2. After the user completes the SCA challenge, make this request again, including the updated WWW-Authenticate header.

    The second response provides a redirection URL that guides the user to a payment success or failure page.
For more information, see our [documentation](https://docs.adyen.com/business-accounts/send-funds-ideal-integration).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostPaymentsConfirm(wwwAuthenticate, body);
    // TODO: Handle 'response' of type ConfirmPaymentResponse
}
catch (SdkException<PostPaymentsConfirmError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>wwwAuthenticate</code> | <code>string?</code> | Header for authenticating through SCA: Contains information for an SCA challenge for A2A payments. |
| <code>body</code> | <code>[ConfirmPaymentRequest](Models/ConfirmPaymentRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConfirmPaymentResponse](Models/ConfirmPaymentResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPaymentsConfirmError](Errors/PostPaymentsConfirmError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentDetailsResponse&gt; PostPaymentsDetails(string? idempotencyKey, PaymentDetailsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Submits details for a payment created using `/payments`. This step is only needed when no final state has been reached on the `/payments` request, for example when the shopper was redirected to another page to complete the payment.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostPaymentsDetails(idempotencyKey, body);
    // TODO: Handle 'response' of type PaymentDetailsResponse
}
catch (SdkException<PostPaymentsDetailsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[PaymentDetailsRequest?](Models/PaymentDetailsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentDetailsResponse](Models/PaymentDetailsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPaymentsDetailsError](Errors/PostPaymentsDetailsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentDetailsResponse1&gt; PostPaymentsDetails1(IdealPaymentDetailsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of an open payment, which you must show to the user. Also provides a token required to [confirm](https://docs.adyen.com/api-explorer/a2a-payments/latest/post/payments/confirm) or [cancel](https://docs.adyen.com/api-explorer/a2a-payments/latest/post/payments/cancel) the payment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostPaymentsDetails1(body);
    // TODO: Handle 'response' of type PaymentDetailsResponse1
}
catch (SdkException<PostPaymentsDetails1Error> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[IdealPaymentDetailsRequest](Models/AllOf/IdealPaymentDetailsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentDetailsResponse1](Models/PaymentDetailsResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPaymentsDetails1Error](Errors/PostPaymentsDetails1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ThreeDs2ResultResponse&gt; PostRetrieve3Ds2Result(ThreeDs2ResultRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the `threeDS2Result` after doing a 3D Secure 2 authentication only.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostRetrieve3Ds2Result(body);
    // TODO: Handle 'response' of type ThreeDs2ResultResponse
}
catch (SdkException<PostRetrieve3Ds2ResultError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ThreeDs2ResultRequest?](Models/ThreeDs2ResultRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ThreeDs2ResultResponse](Models/ThreeDs2ResultResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostRetrieve3Ds2ResultError](Errors/PostRetrieve3Ds2ResultError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateCheckoutSessionResponse&gt; PostSessions(string? idempotencyKey, CreateCheckoutSessionRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a payment session for [Drop-in](https://docs.adyen.com/online-payments/build-your-integration/sessions-flow/?platform=Web&integration=Drop-in), [Components](https://docs.adyen.com/online-payments/build-your-integration/sessions-flow/?platform=Web&integration=Components), and [Hosted Checkout](https://docs.adyen.com/online-payments/build-your-integration/sessions-flow/?platform=Web&integration=Hosted+Checkout) integrations.

The response contains encrypted payment session data. The front end then uses the session data to make any required server-side calls for the payment flow.

You get the payment outcome asynchronously, in an [AUTHORISATION](https://docs.adyen.com/api-explorer/#/Webhooks/latest/post/AUTHORISATION) webhook.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostSessions(idempotencyKey, body);
    // TODO: Handle 'response' of type CreateCheckoutSessionResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[CreateCheckoutSessionRequest?](Models/CreateCheckoutSessionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateCheckoutSessionResponse](Models/CreateCheckoutSessionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PaymentsApp

> Source: [PaymentsApp](Api/PaymentsApp.cs)

<details>
<summary><code>Task&lt;PaymentsAppResponse&gt; GetMerchantsMerchantIdPaymentsApps(string merchantId, string? statuses, int? limit = 10, long? offset = 0L, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of Payments App instances for the merchant account identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Adyen Payments App role


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentsApp.GetMerchantsMerchantIdPaymentsApps(merchantId, statuses);
    // TODO: Handle 'response' of type PaymentsAppResponse
}
catch (SdkException<GetMerchantsMerchantIdPaymentsAppsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>statuses</code> | <code>string?</code> | The status of the Payments App. Comma-separated list of one or more values. If no value is provided, the list returns all statuses. <br><br>Possible values:<br><br>* **BOARDING**<br><br> * **BOARDED**<br><br> * **REVOKED** |
| <code>limit</code> | <code>int?</code> | The number of items to return.<br>**Default**: 10 |
| <code>offset</code> | <code>long?</code> | The number of items to skip.<br>**Default**: 0L |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentsAppResponse](Models/PaymentsAppResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdPaymentsAppsError](Errors/GetMerchantsMerchantIdPaymentsAppsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentsAppResponse&gt; GetMerchantsMerchantIdStoresStoreIdPaymentsApps(string merchantId, string storeId, string? statuses, int? limit = 10, long? offset = 0L, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of Payments App instances for the store identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Adyen Payments App role


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentsApp.GetMerchantsMerchantIdStoresStoreIdPaymentsApps(merchantId,
        storeId,
        statuses);
    // TODO: Handle 'response' of type PaymentsAppResponse
}
catch (SdkException<GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>storeId</code> | <code>string</code> | The unique identifier of the store. |
| <code>statuses</code> | <code>string?</code> | The status of the Payments App. Comma-separated list of one or more values. If no value is provided, the list returns all statuses. <br><br>Possible values:<br><br>* **BOARDING**<br><br> * **BOARDED**<br><br> * **REVOKED** |
| <code>limit</code> | <code>int?</code> | The number of items to return.<br>**Default**: 10 |
| <code>offset</code> | <code>long?</code> | The number of items to skip.<br>**Default**: 0L |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentsAppResponse](Models/PaymentsAppResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError](Errors/GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BoardingTokenResponse&gt; PostMerchantsMerchantIdGeneratePaymentsAppBoardingToken(string merchantId, BoardingTokenRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a boarding token used to authenticate the installation of a Payments App instance on an Android device. The boarding token is created for the `boardingRequestToken` of the Payments App for the merchant account identified in the path. 

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Adyen Payments App role


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentsApp.PostMerchantsMerchantIdGeneratePaymentsAppBoardingToken(merchantId, body);
    // TODO: Handle 'response' of type BoardingTokenResponse
}
catch (SdkException<PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>body</code> | <code>[BoardingTokenRequest](Models/BoardingTokenRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BoardingTokenResponse](Models/BoardingTokenResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError](Errors/PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;JsonElement&gt; PostMerchantsMerchantIdPaymentsAppsInstallationIdRevoke(string merchantId, string installationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Revokes the authentication of the Payments App instance for the `installationId` and merchant account identified in the path. This call revokes the authentication of the Payments App instance with the `installationId` identified in the path for both merchant accounts and stores.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Adyen Payments App role


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentsApp.PostMerchantsMerchantIdPaymentsAppsInstallationIdRevoke(merchantId,
        installationId);
    // TODO: Handle 'response' of type JsonElement
}
catch (SdkException<PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>installationId</code> | <code>string</code> | The unique identifier of the Payments App instance on a device. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>JsonElement</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError](Errors/PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BoardingTokenResponse&gt; PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingToken(string merchantId, string storeId, BoardingTokenRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a boarding token used to authenticate the installation of a Payments App instance on an Android device. The boarding token is created for the `boardingRequestToken` of the Payments App for the store identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Adyen Payments App role


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentsApp.PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingToken(merchantId,
        storeId,
        body);
    // TODO: Handle 'response' of type BoardingTokenResponse
}
catch (SdkException<PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>storeId</code> | <code>string</code> | The unique identifier of the store. |
| <code>body</code> | <code>[BoardingTokenRequest](Models/BoardingTokenRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BoardingTokenResponse](Models/BoardingTokenResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError](Errors/PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PayoutSettingsMerchantLevel

> Source: [PayoutSettingsMerchantLevel](Api/PayoutSettingsMerchantLevel.cs)

<details>
<summary><code>Task DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsId(string merchantId, string payoutSettingsId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the payout setting identified in the path.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Payout account settings read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PayoutSettingsMerchantLevel.DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsId(merchantId,
        payoutSettingsId);
}
catch (SdkException<DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>payoutSettingsId</code> | <code>string</code> | The unique identifier of the payout setting. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError](Errors/DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PayoutSettingsResponse&gt; GetMerchantsMerchantIdPayoutSettings(string merchantId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of payout settings for the merchant account identified in the path.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payout account settings read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PayoutSettingsMerchantLevel.GetMerchantsMerchantIdPayoutSettings(merchantId);
    // TODO: Handle 'response' of type PayoutSettingsResponse
}
catch (SdkException<GetMerchantsMerchantIdPayoutSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutSettingsResponse](Models/PayoutSettingsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdPayoutSettingsError](Errors/GetMerchantsMerchantIdPayoutSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PayoutSettings&gt; GetMerchantsMerchantIdPayoutSettingsPayoutSettingsId(string merchantId, string payoutSettingsId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the payout setting identified in the path.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payout account settings read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PayoutSettingsMerchantLevel.GetMerchantsMerchantIdPayoutSettingsPayoutSettingsId(merchantId,
        payoutSettingsId);
    // TODO: Handle 'response' of type PayoutSettings
}
catch (SdkException<GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>payoutSettingsId</code> | <code>string</code> | The unique identifier of the payout setting. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutSettings](Models/PayoutSettings.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError](Errors/GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PayoutSettings&gt; PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsId(string merchantId, string payoutSettingsId, UpdatePayoutSettingsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the payout setting identified in the path. You can enable or disable the payout setting.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Payout account settings read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PayoutSettingsMerchantLevel.PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsId(merchantId,
        payoutSettingsId,
        body);
    // TODO: Handle 'response' of type PayoutSettings
}
catch (SdkException<PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>payoutSettingsId</code> | <code>string</code> | The unique identifier of the payout setting. |
| <code>body</code> | <code>[UpdatePayoutSettingsRequest?](Models/UpdatePayoutSettingsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutSettings](Models/PayoutSettings.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError](Errors/PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PayoutSettings&gt; PostMerchantsMerchantIdPayoutSettings(string merchantId, PayoutSettingsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends a request to add a payout setting for the merchant account specified in the path. A payout setting links the merchant account to the [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments) that contains the details of the payout bank account. Adyen verifies the bank account before allowing and enabling the payout setting.

If you're accepting payments in multiple currencies, you may add multiple payout settings for the merchant account.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Payout account settings read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PayoutSettingsMerchantLevel.PostMerchantsMerchantIdPayoutSettings(merchantId, body);
    // TODO: Handle 'response' of type PayoutSettings
}
catch (SdkException<PostMerchantsMerchantIdPayoutSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>body</code> | <code>[PayoutSettingsRequest?](Models/PayoutSettingsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutSettings](Models/PayoutSettings.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsMerchantIdPayoutSettingsError](Errors/PostMerchantsMerchantIdPayoutSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Platform

> Source: [Platform](Api/Platform.cs)

<details>
<summary><code>Task&lt;BalancePlatform&gt; GetBalancePlatformsId(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a balance platform.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Platform.GetBalancePlatformsId(id);
    // TODO: Handle 'response' of type BalancePlatform
}
catch (SdkException<GetBalancePlatformsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the balance platform. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalancePlatform](Models/BalancePlatform.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalancePlatformsIdError](Errors/GetBalancePlatformsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedAccountHoldersResponse&gt; GetBalancePlatformsIdAccountHolders(string id, int? offset, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of all the account holders that belong to the balance platform. To fetch multiple pages, use the query parameters. 

For example, to limit the page to 5 account holders and to skip the first 20, use `/balancePlatforms/{id}/accountHolders?limit=5&offset=20`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Platform.GetBalancePlatformsIdAccountHolders(id, offset, limit);
    // TODO: Handle 'response' of type PaginatedAccountHoldersResponse
}
catch (SdkException<GetBalancePlatformsIdAccountHoldersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the balance platform. |
| <code>offset</code> | <code>int?</code> | The number of items that you want to skip. |
| <code>limit</code> | <code>int?</code> | The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedAccountHoldersResponse](Models/PaginatedAccountHoldersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalancePlatformsIdAccountHoldersError](Errors/GetBalancePlatformsIdAccountHoldersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionRulesResponse&gt; GetBalancePlatformsIdTransactionRules(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of transaction rules associated with a balance platform.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Platform.GetBalancePlatformsIdTransactionRules(id);
    // TODO: Handle 'response' of type TransactionRulesResponse
}
catch (SdkException<GetBalancePlatformsIdTransactionRulesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the balance platform. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionRulesResponse](Models/TransactionRulesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalancePlatformsIdTransactionRulesError](Errors/GetBalancePlatformsIdTransactionRulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RaiseDisputes

> Source: [RaiseDisputes](Api/RaiseDisputes.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;IReadOnlyList&lt;DisputeResponse&gt;&gt;&gt; GetDisputes(string? status, string? paymentInstrument, string? createdSince, string? createdUntil, string? offset, string? limit, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of raised disputes that match the query parameters.

This endpoint supports cursor-based pagination. The response returns the first page of results, and returns links to the next page when applicable. You can use the links to page through the results. The response also returns links to the previous page when applicable.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RaiseDisputes.GetDisputes(status,
        paymentInstrument,
        createdSince,
        createdUntil,
        offset,
        limit);
    // TODO: Handle 'response' of type IReadOnlyList<IReadOnlyList<DisputeResponse>>
}
catch (SdkException<GetDisputesError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>status</code> | <code>string?</code> | The current status of the dispute.<br><br>Possible values: **draft**, **submitted**, **closed**, **won**, **chargeback**, **secondPresentment**. |
| <code>paymentInstrument</code> | <code>string?</code> | The unique identifier of the payment instrument. |
| <code>createdSince</code> | <code>string?</code> | Only include disputes that have been created on or after this point in time. The value must be in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601\)  format. For example, 2021-05-30T15:07:40Z. |
| <code>createdUntil</code> | <code>string?</code> | Only include disputes that have been created on or before this point in time. The value must be in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601\) format. For example, **2021-05-30T15:07:40Z**. |
| <code>offset</code> | <code>string?</code> | The number of items that you want to skip. |
| <code>limit</code> | <code>string?</code> | The number of items returned per page, maximum of 500 items. By default, the response returns 100 items per page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;IReadOnlyList&lt;[DisputeResponse](Models/DisputeResponse.cs)&gt;&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetDisputesError](Errors/GetDisputesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DisputeResponse&gt; GetDisputesId(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get a raised dispute by ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RaiseDisputes.GetDisputesId(id);
    // TODO: Handle 'response' of type DisputeResponse
}
catch (SdkException<GetDisputesIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the raised dispute. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisputeResponse](Models/DisputeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetDisputesIdError](Errors/GetDisputesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DisputeResponse&gt; PatchDisputesId(string id, PatchableDisputeRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update information related to a raised dispute, or change a dispute's status from **draft** to **submitted** or **closed**.

**Note:** Changing the status of a dispute to **submitted** or **closed** is a final action. You cannot make updates to a **submitted** or **closed** dispute. Make sure to upload all supporting attachments using the `POST /disputes/{id}/attachments` endpoint before you submit a dispute. When you update a dispute to **submitted**, Adyen sends the raised dispute to the card scheme for review and acquirer defense. When you update a raised dispute to **closed**, Adyen closes the dispute, and the dispute is no longer eligible for review by the card scheme.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RaiseDisputes.PatchDisputesId(id, body);
    // TODO: Handle 'response' of type DisputeResponse
}
catch (SdkException<PatchDisputesIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the raised dispute. |
| <code>body</code> | <code>[PatchableDisputeRequest?](Models/PatchableDisputeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisputeResponse](Models/DisputeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchDisputesIdError](Errors/PatchDisputesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DisputeResponse&gt; PostDisputes(DisputeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Raise a dispute for an underlying transaction, providing a dispute type and the amount you want to dispute.

Raising a dispute returns a dispute ID, which you can use to update details about the dispute, provide supporting documentation, close the dispute, or submit the dispute for a chargeback. You can also use the dispute ID to view the status of the dispute.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RaiseDisputes.PostDisputes(body);
    // TODO: Handle 'response' of type DisputeResponse
}
catch (SdkException<PostDisputesError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DisputeRequest](Models/DisputeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisputeResponse](Models/DisputeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostDisputesError](Errors/PostDisputesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Rates

> Source: [Rates](Api/Rates.cs)

<details>
<summary><code>Task&lt;CalculateRateResponse&gt; PostRatesCalculate(CalculateRateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the calculated amounts and rates required to convert the currency of a transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rates.PostRatesCalculate(body);
    // TODO: Handle 'response' of type CalculateRateResponse
}
catch (SdkException<PostRatesCalculateError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CalculateRateRequest](Models/CalculateRateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CalculateRateResponse](Models/CalculateRateResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostRatesCalculateError](Errors/PostRatesCalculateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RecurringApi

> Source: [RecurringApi](Api/RecurringApi.cs)

<details>
<summary><code>Task DeleteStoredPaymentMethodsStoredPaymentMethodId(string storedPaymentMethodId, string shopperReference, string merchantAccount, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the token identified in the path. The token can no longer be used with payment requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.RecurringApi.DeleteStoredPaymentMethodsStoredPaymentMethodId(storedPaymentMethodId,
        shopperReference,
        merchantAccount);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>storedPaymentMethodId</code> | <code>string</code> | The unique identifier of the token. |
| <code>shopperReference</code> | <code>string</code> | Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters.<br>> Your reference must not include personally identifiable information (PII), for example name or email address. |
| <code>merchantAccount</code> | <code>string</code> | Your merchant account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListStoredPaymentMethodsResponse&gt; GetStoredPaymentMethods(string? shopperReference, string? merchantAccount, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the tokens for stored payment details for the shopper identified in the path, if there are any available. The token ID can be used with payment requests for the shopper's payment. A summary of the stored details is included.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RecurringApi.GetStoredPaymentMethods(shopperReference, merchantAccount);
    // TODO: Handle 'response' of type ListStoredPaymentMethodsResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>shopperReference</code> | <code>string?</code> | Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters.<br>> Your reference must not include personally identifiable information (PII), for example name or email address. |
| <code>merchantAccount</code> | <code>string?</code> | Your merchant account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListStoredPaymentMethodsResponse](Models/ListStoredPaymentMethodsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CheckoutForwardResponse&gt; PostForward(string? idempotencyKey, CheckoutForwardRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Forwards the payment details you stored with Adyen to a third-party that you specify and returns the response from the third-party. Supports forwarding stored card details or [network tokens](https://docs.adyen.com/online-payments/network-tokenization). For more information, see [Forward stored payment details](https://docs.adyen.com/online-payments/tokenization/forward-payment-details).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RecurringApi.PostForward(idempotencyKey, body);
    // TODO: Handle 'response' of type CheckoutForwardResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[CheckoutForwardRequest?](Models/CheckoutForwardRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CheckoutForwardResponse](Models/CheckoutForwardResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StoredPaymentMethodResource&gt; PostStoredPaymentMethods(string? idempotencyKey, StoredPaymentMethodRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a token to store the shopper's payment details. This token can be used for the shopper's future payments.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RecurringApi.PostStoredPaymentMethods(idempotencyKey, body);
    // TODO: Handle 'response' of type StoredPaymentMethodResource
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[StoredPaymentMethodRequest?](Models/StoredPaymentMethodRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StoredPaymentMethodResource](Models/StoredPaymentMethodResource.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RecurringTopUps

> Source: [RecurringTopUps](Api/RecurringTopUps.cs)

<details>
<summary><code>Task&lt;JsonElement&gt; DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpId(string balanceAccountId, string topUpId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a recurring top up configuration by `topUpId`.

For more information, refer to [Manage recurring top-ups](https://docs.adyen.com/issuing/add-manage-funds/top-ups/manage-recurring-top-ups).


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RecurringTopUps.DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpId(balanceAccountId,
        topUpId);
    // TODO: Handle 'response' of type JsonElement
}
catch (SdkException<DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balanceAccountId</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>topUpId</code> | <code>string</code> | The unique identifier of the recurring top-up you want to delete. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>JsonElement</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError](Errors/DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RecurringTopUpsResult&gt; GetBalanceAccountsBalanceAccountIdRecurringTopUps(string balanceAccountId, string? cursor, int? limit = 10, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

View all recurring top ups configured for a specific `balanceAccountId`.

For more information, refer to [Manage recurring top-ups](https://docs.adyen.com/issuing/add-manage-funds/top-ups/manage-recurring-top-ups).


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RecurringTopUps.GetBalanceAccountsBalanceAccountIdRecurringTopUps(balanceAccountId,
        cursor);
    // TODO: Handle 'response' of type RecurringTopUpsResult
}
catch (SdkException<GetBalanceAccountsBalanceAccountIdRecurringTopUpsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balanceAccountId</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>cursor</code> | <code>string?</code> | The cursor used for pagination. Required if you want to see the next or previous page of results. |
| <code>limit</code> | <code>int?</code> | The number of items to return per page. Value must be between 1 and 100.<br>**Default**: 10 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RecurringTopUpsResult](Models/RecurringTopUpsResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalanceAccountsBalanceAccountIdRecurringTopUpsError](Errors/GetBalanceAccountsBalanceAccountIdRecurringTopUpsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RecurringTopUp&gt; PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpId(string balanceAccountId, string topUpId, PatchableCreateRecurringTopUp body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update the configuration of an existing recurring top up.

For more information, refer to [Manage recurring top-ups](https://docs.adyen.com/issuing/add-manage-funds/top-ups/manage-recurring-top-ups).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RecurringTopUps.PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpId(balanceAccountId,
        topUpId,
        body);
    // TODO: Handle 'response' of type RecurringTopUp
}
catch (SdkException<PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balanceAccountId</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>topUpId</code> | <code>string</code> | The unique identifier of the recurring top-up you want to update. |
| <code>body</code> | <code>[PatchableCreateRecurringTopUp](Models/PatchableCreateRecurringTopUp.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RecurringTopUp](Models/RecurringTopUp.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError](Errors/PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RecurringTopUp&gt; PostBalanceAccountsBalanceAccountIdRecurringTopUps(string balanceAccountId, CreateRecurringTopUp body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a recurring top up configuration.

For more information, refer to [Create recurring top-ups](https://docs.adyen.com/issuing/add-manage-funds/top-ups/create-recurring-top-ups).


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RecurringTopUps.PostBalanceAccountsBalanceAccountIdRecurringTopUps(balanceAccountId,
        body);
    // TODO: Handle 'response' of type RecurringTopUp
}
catch (SdkException<PostBalanceAccountsBalanceAccountIdRecurringTopUpsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>balanceAccountId</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>body</code> | <code>[CreateRecurringTopUp](Models/CreateRecurringTopUp.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RecurringTopUp](Models/RecurringTopUp.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostBalanceAccountsBalanceAccountIdRecurringTopUpsError](Errors/PostBalanceAccountsBalanceAccountIdRecurringTopUpsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Reviewing

> Source: [Reviewing](Api/Reviewing.cs)

<details>
<summary><code>Task&lt;ModifyResponse&gt; PostConfirmThirdParty(ModifyRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

> This endpoint is **deprecated** and no longer supports new integrations. Do one of the following:
>- If you are building a new integration, use the [Transfers API](https://docs.adyen.com/api-explorer/transfers/latest/overview) instead.
> - If you are already using the Payout API, reach out to your Adyen contact to learn how to migrate to the Transfers API.
>
> With the Transfers API, you can:
> - Handle multiple payout use cases with a single API.
> - Use new payout functionalities, such as instant payouts to bank accounts.
> - Receive webhooks with more details and defined transfer states.
>
> For more information about the payout features of the Transfers API, see our [Payouts](https://docs.adyen.com/payouts/payout-service) documentation.


Confirms a previously submitted payout.

To cancel a payout, use the `/declineThirdParty` endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reviewing.PostConfirmThirdParty(body);
    // TODO: Handle 'response' of type ModifyResponse
}
catch (SdkException<PostConfirmThirdPartyError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ModifyRequest?](Models/ModifyRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModifyResponse](Models/ModifyResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostConfirmThirdPartyError](Errors/PostConfirmThirdPartyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ModifyResponse&gt; PostDeclineThirdParty(ModifyRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

> This endpoint is **deprecated** and no longer supports new integrations. Do one of the following:
>- If you are building a new integration, use the [Transfers API](https://docs.adyen.com/api-explorer/transfers/latest/overview) instead.
> - If you are already using the Payout API, reach out to your Adyen contact to learn how to migrate to the Transfers API.
>
> With the Transfers API, you can:
> - Handle multiple payout use cases with a single API.
> - Use new payout functionalities, such as instant payouts to bank accounts.
> - Receive webhooks with more details and defined transfer states.
>
> For more information about the payout features of the Transfers API, see our [Payouts](https://docs.adyen.com/payouts/payout-service) documentation.


Cancels a previously submitted payout.

To confirm and send a payout, use the `/confirmThirdParty` endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reviewing.PostDeclineThirdParty(body);
    // TODO: Handle 'response' of type ModifyResponse
}
catch (SdkException<PostDeclineThirdPartyError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ModifyRequest?](Models/ModifyRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModifyResponse](Models/ModifyResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostDeclineThirdPartyError](Errors/PostDeclineThirdPartyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ScaAssociationManagement

> Source: [ScaAssociationManagement](Api/ScaAssociationManagement.cs)

<details>
<summary><code>Task DeleteScaAssociations(string wwwAuthenticate, RemoveAssociationRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes one or more SCA associations for a device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ScaAssociationManagement.DeleteScaAssociations(wwwAuthenticate, body);
}
catch (SdkException<DeleteScaAssociationsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>wwwAuthenticate</code> | <code>string</code> | The header for authenticating through SCA. |
| <code>body</code> | <code>[RemoveAssociationRequest?](Models/RemoveAssociationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteScaAssociationsError](Errors/DeleteScaAssociationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListAssociationsResponse&gt; GetScaAssociations(ScaEntityType entityType, string entityId, int pageSize, int pageNumber, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of the SCA devices associated with a specific entity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ScaAssociationManagement.GetScaAssociations(entityType, entityId, pageSize, pageNumber);
    // TODO: Handle 'response' of type ListAssociationsResponse
}
catch (SdkException<GetScaAssociationsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>entityType</code> | <code>[ScaEntityType](Models/Enums/ScaEntityType.cs)</code> | The type of entity you want to retrieve a list of associations for. <br><br>Possible values: **accountHolder**, **legalEntity** or **paymentInstrument**. |
| <code>entityId</code> | <code>string</code> | The unique identifier of the entity. |
| <code>pageSize</code> | <code>int</code> | The number of items to have on a page. <br><br>Default: **5**. |
| <code>pageNumber</code> | <code>int</code> | The index of the page to retrieve. The index of the first page is **0** (zero). <br><br>Default:  **0**. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListAssociationsResponse](Models/ListAssociationsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetScaAssociationsError](Errors/GetScaAssociationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApproveAssociationResponse&gt; PatchScaAssociations(string wwwAuthenticate, ApproveAssociationRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Approves a previously created association that is in a pending state.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ScaAssociationManagement.PatchScaAssociations(wwwAuthenticate, body);
    // TODO: Handle 'response' of type ApproveAssociationResponse
}
catch (SdkException<PatchScaAssociationsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>wwwAuthenticate</code> | <code>string</code> | The header for authenticating through SCA. |
| <code>body</code> | <code>[ApproveAssociationRequest?](Models/ApproveAssociationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApproveAssociationResponse](Models/ApproveAssociationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchScaAssociationsError](Errors/PatchScaAssociationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ScaDeviceManagement

> Source: [ScaDeviceManagement](Api/ScaDeviceManagement.cs)

<details>
<summary><code>Task DeleteScaDevicesDeviceId(string deviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a Strong Customer Authentication (SCA) device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ScaDeviceManagement.DeleteScaDevicesDeviceId(deviceId);
}
catch (SdkException<DeleteScaDevicesDeviceIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>deviceId</code> | <code>string</code> | The unique identifier of the SCA device to delete. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteScaDevicesDeviceIdError](Errors/DeleteScaDevicesDeviceIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FinishScaDeviceRegistrationResponse&gt; PatchScaDevicesDeviceId(string deviceId, FinishScaDeviceRegistrationRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Finishes the registration process for a new Strong Customer Authentication (SCA) device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ScaDeviceManagement.PatchScaDevicesDeviceId(deviceId, body);
    // TODO: Handle 'response' of type FinishScaDeviceRegistrationResponse
}
catch (SdkException<PatchScaDevicesDeviceIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>deviceId</code> | <code>string</code> | The unique identifier of the SCA device that you are associating with a resource. |
| <code>body</code> | <code>[FinishScaDeviceRegistrationRequest?](Models/FinishScaDeviceRegistrationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FinishScaDeviceRegistrationResponse](Models/FinishScaDeviceRegistrationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchScaDevicesDeviceIdError](Errors/PatchScaDevicesDeviceIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BeginScaDeviceRegistrationResponse&gt; PostScaDevices(BeginScaDeviceRegistrationRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Begins the registration process for a new Strong Customer Authentication (SCA) device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ScaDeviceManagement.PostScaDevices(body);
    // TODO: Handle 'response' of type BeginScaDeviceRegistrationResponse
}
catch (SdkException<PostScaDevicesError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[BeginScaDeviceRegistrationRequest?](Models/BeginScaDeviceRegistrationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BeginScaDeviceRegistrationResponse](Models/BeginScaDeviceRegistrationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostScaDevicesError](Errors/PostScaDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SubmitScaAssociationResponse&gt; PostScaDevicesDeviceIdScaAssociations(string deviceId, SubmitScaAssociationRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an association between an SCA-enabled device and an entity, such as an account holder. This action does not guarantee the association is immediately ready for use; its status may be `pendingApproval` if the account holder has existing devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ScaDeviceManagement.PostScaDevicesDeviceIdScaAssociations(deviceId, body);
    // TODO: Handle 'response' of type SubmitScaAssociationResponse
}
catch (SdkException<PostScaDevicesDeviceIdScaAssociationsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>deviceId</code> | <code>string</code> | The unique identifier of the SCA device that you are associating with a resource. |
| <code>body</code> | <code>[SubmitScaAssociationRequest?](Models/SubmitScaAssociationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SubmitScaAssociationResponse](Models/SubmitScaAssociationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostScaDevicesDeviceIdScaAssociationsError](Errors/PostScaDevicesDeviceIdScaAssociationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SessionAuthentication

> Source: [SessionAuthentication](Api/SessionAuthentication.cs)

<details>
<summary><code>Task&lt;CertificateLoadingResponse&gt; PostAuthCertificate(string? xApiKey, CertificateLoadingRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Establishes a secure communication session between the Mobile SDK and the Adyen payments platform, through mutual authentication. The request sends a setup token that identifies the SDK and the device. The response returns a session token that the SDK can use to authenticate responses received from the Adyen payments platform.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SessionAuthentication.PostAuthCertificate(xApiKey, body);
    // TODO: Handle 'response' of type CertificateLoadingResponse
}
catch (SdkException<PostAuthCertificateError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>xApiKey</code> | <code>string?</code> | The API key to authenticate API requests. |
| <code>body</code> | <code>[CertificateLoadingRequest?](Models/CertificateLoadingRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CertificateLoadingResponse](Models/CertificateLoadingResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostAuthCertificateError](Errors/PostAuthCertificateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AuthenticationSessionResponse&gt; PostSessions2(AuthenticationSessionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a session token that is required to integrate [components](https://docs.adyen.com/platforms/components-overview).

The response contains encrypted session data. The front end then uses the session data to make the required server-side calls for the component.

To create a token, you must meet specific requirements. These requirements vary depending on the type of component. For more information, see the documentation for [Onboarding](https://docs.adyen.com/platforms/onboard-users/components) and [Platform Experience](https://docs.adyen.com/platforms/build-user-dashboards) components.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SessionAuthentication.PostSessions2(body);
    // TODO: Handle 'response' of type AuthenticationSessionResponse
}
catch (SdkException<PostSessions2Error> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AuthenticationSessionRequest](Models/AuthenticationSessionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AuthenticationSessionResponse](Models/AuthenticationSessionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostSessions2Error](Errors/PostSessions2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SplitConfigurationMerchantLevel

> Source: [SplitConfigurationMerchantLevel](Api/SplitConfigurationMerchantLevel.cs)

<details>
<summary><code>Task&lt;SplitConfiguration&gt; DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(string merchantId, string splitConfigurationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the split configuration profile specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(merchantId,
        splitConfigurationId);
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (SdkException<DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>splitConfigurationId</code> | <code>string</code> | The unique identifier of the split configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](Models/SplitConfiguration.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError](Errors/DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfiguration&gt; DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleId(string merchantId, string splitConfigurationId, string ruleId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the rule specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleId(merchantId,
        splitConfigurationId,
        ruleId);
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (SdkException<DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>splitConfigurationId</code> | <code>string</code> | The unique identifier of the split configuration. |
| <code>ruleId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](Models/SplitConfiguration.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdError](Errors/DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfigurationList&gt; GetMerchantsMerchantIdSplitConfigurations(string merchantId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of split configuration profiles for the merchant account.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.GetMerchantsMerchantIdSplitConfigurations(merchantId);
    // TODO: Handle 'response' of type SplitConfigurationList
}
catch (SdkException<GetMerchantsMerchantIdSplitConfigurationsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfigurationList](Models/SplitConfigurationList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdSplitConfigurationsError](Errors/GetMerchantsMerchantIdSplitConfigurationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfiguration&gt; GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(string merchantId, string splitConfigurationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the split configuration profile specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(merchantId,
        splitConfigurationId);
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (SdkException<GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>splitConfigurationId</code> | <code>string</code> | The unique identifier of the split configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](Models/SplitConfiguration.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError](Errors/GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfiguration&gt; PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(string merchantId, string splitConfigurationId, UpdateSplitConfigurationRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the description of the split configuration profile specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(merchantId,
        splitConfigurationId,
        body);
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (SdkException<PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>splitConfigurationId</code> | <code>string</code> | The unique identifier of the split configuration. |
| <code>body</code> | <code>[UpdateSplitConfigurationRequest?](Models/UpdateSplitConfigurationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](Models/SplitConfiguration.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError](Errors/PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfiguration&gt; PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleId(string merchantId, string splitConfigurationId, string ruleId, UpdateSplitConfigurationRuleRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the [split conditions of the rule](https://docs.adyen.com/platforms/automatic-split-configuration/manage-split-configurations/api/#update-condition) specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleId(merchantId,
        splitConfigurationId,
        ruleId,
        body);
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (SdkException<PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>splitConfigurationId</code> | <code>string</code> | The identifier of the split configuration. |
| <code>ruleId</code> | <code>string</code> | The unique identifier of the split configuration rule. |
| <code>body</code> | <code>[UpdateSplitConfigurationRuleRequest?](Models/UpdateSplitConfigurationRuleRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](Models/SplitConfiguration.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdError](Errors/PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfiguration&gt; PatchMerchantsSplitConfigurationsRulesSplitLogic(string merchantId, string splitConfigurationId, string ruleId, string splitLogicId, UpdateSplitConfigurationLogicRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the [split logic](https://docs.adyen.com/platforms/automatic-split-configuration/manage-split-configurations/api/#update-split-logic) specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.PatchMerchantsSplitConfigurationsRulesSplitLogic(merchantId,
        splitConfigurationId,
        ruleId,
        splitLogicId,
        body);
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (SdkException<PatchMerchantsSplitConfigurationsRulesSplitLogicError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>splitConfigurationId</code> | <code>string</code> | The unique identifier of the split configuration. |
| <code>ruleId</code> | <code>string</code> | The unique identifier of the split configuration rule. |
| <code>splitLogicId</code> | <code>string</code> | The unique identifier of the split configuration split. |
| <code>body</code> | <code>[UpdateSplitConfigurationLogicRequest?](Models/UpdateSplitConfigurationLogicRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](Models/SplitConfiguration.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchMerchantsSplitConfigurationsRulesSplitLogicError](Errors/PatchMerchantsSplitConfigurationsRulesSplitLogicError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfiguration&gt; PostMerchantsMerchantIdSplitConfigurations(string merchantId, SplitConfiguration? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a split configuration profile to [split payments automatically](https://docs.adyen.com/platforms/automatic-split-configuration/). After you [associate it with a store](https://docs.adyen.com/api-explorer/Management/latest/patch/merchants/(merchantId)/stores/(storeId)#request-splitConfiguration) in your merchant account, it splits the funds of all transactions processed through that store between your liable balance account and [your user's balance account](https://docs.adyen.com/api-explorer/Management/latest/patch/merchants/(merchantId)/stores/(storeId)#request-splitConfiguration-balanceAccountId).

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.PostMerchantsMerchantIdSplitConfigurations(merchantId,
        body);
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (SdkException<PostMerchantsMerchantIdSplitConfigurationsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>body</code> | <code>[SplitConfiguration?](Models/SplitConfiguration.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](Models/SplitConfiguration.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsMerchantIdSplitConfigurationsError](Errors/PostMerchantsMerchantIdSplitConfigurationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfiguration&gt; PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(string merchantId, string splitConfigurationId, SplitConfigurationRule? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

[Creates a rule](https://docs.adyen.com/platforms/automatic-split-configuration/manage-split-configurations/api/#create-rule) in the split configuration profile specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(merchantId,
        splitConfigurationId,
        body);
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (SdkException<PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>splitConfigurationId</code> | <code>string</code> | The unique identifier of the split configuration. |
| <code>body</code> | <code>[SplitConfigurationRule?](Models/SplitConfigurationRule.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](Models/SplitConfiguration.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError](Errors/PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TaxEDeliveryConsent

> Source: [TaxEDeliveryConsent](Api/TaxEDeliveryConsent.cs)

<details>
<summary><code>Task&lt;CheckTaxElectronicDeliveryConsentResponse&gt; PostLegalEntitiesIdCheckTaxElectronicDeliveryConsent(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the consent status for electronic delivery of tax forms.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TaxEDeliveryConsent.PostLegalEntitiesIdCheckTaxElectronicDeliveryConsent(id);
    // TODO: Handle 'response' of type CheckTaxElectronicDeliveryConsentResponse
}
catch (SdkException<PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CheckTaxElectronicDeliveryConsentResponse](Models/CheckTaxElectronicDeliveryConsentResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentError](Errors/PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PostLegalEntitiesIdSetTaxElectronicDeliveryConsent(string id, SetTaxElectronicDeliveryConsentRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the consent status for electronic delivery of tax forms.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TaxEDeliveryConsent.PostLegalEntitiesIdSetTaxElectronicDeliveryConsent(id, body);
}
catch (SdkException<PostLegalEntitiesIdSetTaxElectronicDeliveryConsentError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization. |
| <code>body</code> | <code>[SetTaxElectronicDeliveryConsentRequest?](Models/SetTaxElectronicDeliveryConsentRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostLegalEntitiesIdSetTaxElectronicDeliveryConsentError](Errors/PostLegalEntitiesIdSetTaxElectronicDeliveryConsentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalActionsCompanyLevel

> Source: [TerminalActionsCompanyLevel](Api/TerminalActionsCompanyLevel.cs)

<details>
<summary><code>Task&lt;ListExternalTerminalActionsResponse&gt; GetCompaniesCompanyIdTerminalActions(string companyId, int? pageNumber, int? pageSize, string? status, string? type, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the [terminal actions](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api) that have been scheduled for the company identified in the path.The response doesn't include actions that are scheduled by Adyen.
To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal actions read
* Management API—Terminal actions read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalActionsCompanyLevel.GetCompaniesCompanyIdTerminalActions(companyId,
        pageNumber,
        pageSize,
        status,
        type);
    // TODO: Handle 'response' of type ListExternalTerminalActionsResponse
}
catch (SdkException<GetCompaniesCompanyIdTerminalActionsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>pageNumber</code> | <code>int?</code> | The number of the page to fetch. |
| <code>pageSize</code> | <code>int?</code> | The number of items to have on a page, maximum 100. The default is 20 items on a page. |
| <code>status</code> | <code>string?</code> | Returns terminal actions with the specified status. <br>Allowed values: **pending**, **successful**, **failed**, **cancelled**, **tryLater**. |
| <code>type</code> | <code>string?</code> | Returns terminal actions of the specified type. <br>Allowed values: **InstallAndroidApp**, **UninstallAndroidApp**, **InstallAndroidCertificate**, **UninstallAndroidCertificate**. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListExternalTerminalActionsResponse](Models/ListExternalTerminalActionsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdTerminalActionsError](Errors/GetCompaniesCompanyIdTerminalActionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ExternalTerminalAction&gt; GetCompaniesCompanyIdTerminalActionsActionId(string companyId, string actionId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the [terminal action](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api) identified in the path.
To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal actions read
* Management API—Terminal actions read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalActionsCompanyLevel.GetCompaniesCompanyIdTerminalActionsActionId(companyId,
        actionId);
    // TODO: Handle 'response' of type ExternalTerminalAction
}
catch (SdkException<GetCompaniesCompanyIdTerminalActionsActionIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>actionId</code> | <code>string</code> | The unique identifier of the terminal action. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ExternalTerminalAction](Models/ExternalTerminalAction.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdTerminalActionsActionIdError](Errors/GetCompaniesCompanyIdTerminalActionsActionIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalActionsTerminalLevel

> Source: [TerminalActionsTerminalLevel](Api/TerminalActionsTerminalLevel.cs)

<details>
<summary><code>Task&lt;ScheduleTerminalActionsResponse&gt; PostTerminalsScheduleActions(ScheduleTerminalActionsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Schedules a [terminal action](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api) by specifying the action and the terminals that the action must be applied to. 

The following restrictions apply:
* You can schedule only one action at a time. For example, to install a new app version and remove an old app version, you have to make two API requests. 
* The maximum number of terminals in a request is **100**. For example, to apply an action to 250 terminals, you have to divide the terminals over three API requests. 
* If there is an error with one or more terminal IDs in the request, the action is scheduled for none of the terminals. You need to fix the error and try again. 

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal actions read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalActionsTerminalLevel.PostTerminalsScheduleActions(body);
    // TODO: Handle 'response' of type ScheduleTerminalActionsResponse
}
catch (SdkException<PostTerminalsScheduleActionsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ScheduleTerminalActionsRequest?](Models/ScheduleTerminalActionsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ScheduleTerminalActionsResponse](Models/ScheduleTerminalActionsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostTerminalsScheduleActionsError](Errors/PostTerminalsScheduleActionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalOrdersCompanyLevel

> Source: [TerminalOrdersCompanyLevel](Api/TerminalOrdersCompanyLevel.cs)

<details>
<summary><code>Task&lt;BillingEntitiesResponse&gt; GetCompaniesCompanyIdBillingEntities(string companyId, string? name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the billing entities of the company identified in the path and all merchant accounts belonging to the company.
A billing entity is a legal entity where we charge orders to. An order for terminal products must contain the ID of a billing entity.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.GetCompaniesCompanyIdBillingEntities(companyId, name);
    // TODO: Handle 'response' of type BillingEntitiesResponse
}
catch (SdkException<GetCompaniesCompanyIdBillingEntitiesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>name</code> | <code>string?</code> | The name of the billing entity. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BillingEntitiesResponse](Models/BillingEntitiesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdBillingEntitiesError](Errors/GetCompaniesCompanyIdBillingEntitiesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ShippingLocationsResponse&gt; GetCompaniesCompanyIdShippingLocations(string companyId, string? name, int? offset, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the shipping locations for the company identified in the path and all merchant accounts belonging to the company.
A shipping location includes the address where orders can be delivered, and an ID which you need to specify when ordering terminal products.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.GetCompaniesCompanyIdShippingLocations(companyId,
        name,
        offset,
        limit);
    // TODO: Handle 'response' of type ShippingLocationsResponse
}
catch (SdkException<GetCompaniesCompanyIdShippingLocationsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>name</code> | <code>string?</code> | The name of the shipping location. |
| <code>offset</code> | <code>int?</code> | The number of locations to skip. |
| <code>limit</code> | <code>int?</code> | The number of locations to return. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ShippingLocationsResponse](Models/ShippingLocationsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdShippingLocationsError](Errors/GetCompaniesCompanyIdShippingLocationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalModelsResponse&gt; GetCompaniesCompanyIdTerminalModels(string companyId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of payment terminal models that the company identified in the path has access to.
The response includes the terminal model ID, which can be used as a query parameter when getting a list of terminals or a list of products for ordering.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.GetCompaniesCompanyIdTerminalModels(companyId);
    // TODO: Handle 'response' of type TerminalModelsResponse
}
catch (SdkException<GetCompaniesCompanyIdTerminalModelsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalModelsResponse](Models/TerminalModelsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdTerminalModelsError](Errors/GetCompaniesCompanyIdTerminalModelsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrdersResponse&gt; GetCompaniesCompanyIdTerminalOrders(string companyId, string? customerOrderReference, string? status, int? offset, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a lists of terminal products orders for the company identified in the path.
To filter the list, use one or more of the query parameters.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.GetCompaniesCompanyIdTerminalOrders(companyId,
        customerOrderReference,
        status,
        offset,
        limit);
    // TODO: Handle 'response' of type TerminalOrdersResponse
}
catch (SdkException<GetCompaniesCompanyIdTerminalOrdersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>customerOrderReference</code> | <code>string?</code> | Your purchase order number. |
| <code>status</code> | <code>string?</code> | The order status. Possible values (not case-sensitive): Placed, Confirmed, Cancelled, Shipped, Delivered. |
| <code>offset</code> | <code>int?</code> | The number of orders to skip. |
| <code>limit</code> | <code>int?</code> | The number of orders to return. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrdersResponse](Models/TerminalOrdersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdTerminalOrdersError](Errors/GetCompaniesCompanyIdTerminalOrdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; GetCompaniesCompanyIdTerminalOrdersOrderId(string companyId, string orderId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the terminal products order identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.GetCompaniesCompanyIdTerminalOrdersOrderId(companyId,
        orderId);
    // TODO: Handle 'response' of type TerminalOrder
}
catch (SdkException<GetCompaniesCompanyIdTerminalOrdersOrderIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>orderId</code> | <code>string</code> | The unique identifier of the order. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](Models/TerminalOrder.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdTerminalOrdersOrderIdError](Errors/GetCompaniesCompanyIdTerminalOrdersOrderIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalProductsResponse&gt; GetCompaniesCompanyIdTerminalProducts(string companyId, string country, string? terminalModelId, int? offset, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a country-specific list of payment terminal packages and parts that the company identified in the path has access to.
 
To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.GetCompaniesCompanyIdTerminalProducts(companyId,
        country,
        terminalModelId,
        offset,
        limit);
    // TODO: Handle 'response' of type TerminalProductsResponse
}
catch (SdkException<GetCompaniesCompanyIdTerminalProductsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>country</code> | <code>string</code> | The country to return products for, in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. For example, **US** |
| <code>terminalModelId</code> | <code>string?</code> | The terminal model to return products for. Use the ID returned in the [GET `/terminalModels`](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/companies/{companyId}/terminalModels) response. For example, **Verifone.M400** |
| <code>offset</code> | <code>int?</code> | The number of products to skip. |
| <code>limit</code> | <code>int?</code> | The number of products to return. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalProductsResponse](Models/TerminalProductsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdTerminalProductsError](Errors/GetCompaniesCompanyIdTerminalProductsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; PatchCompaniesCompanyIdTerminalOrdersOrderId(string companyId, string orderId, TerminalOrderRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the terminal products order identified in the path.
Updating is only possible while the order has the status **Placed**.

The request body only needs to contain what you want to change. 
However, to update the products in the `items` array, you must provide the entire array. For example, if the array has three items:
 To remove one item, the array must include the remaining two items. Or to add one item, the array must include all four items.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.PatchCompaniesCompanyIdTerminalOrdersOrderId(companyId,
        orderId,
        body);
    // TODO: Handle 'response' of type TerminalOrder
}
catch (SdkException<PatchCompaniesCompanyIdTerminalOrdersOrderIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>orderId</code> | <code>string</code> | The unique identifier of the order. |
| <code>body</code> | <code>[TerminalOrderRequest?](Models/TerminalOrderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](Models/TerminalOrder.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchCompaniesCompanyIdTerminalOrdersOrderIdError](Errors/PatchCompaniesCompanyIdTerminalOrdersOrderIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ShippingLocation&gt; PostCompaniesCompanyIdShippingLocations(string companyId, ShippingLocation? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a shipping location for the company identified in the path. A shipping location defines an address where orders can be delivered.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.PostCompaniesCompanyIdShippingLocations(companyId, body);
    // TODO: Handle 'response' of type ShippingLocation
}
catch (SdkException<PostCompaniesCompanyIdShippingLocationsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>body</code> | <code>[ShippingLocation?](Models/ShippingLocation.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ShippingLocation](Models/ShippingLocation.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCompaniesCompanyIdShippingLocationsError](Errors/PostCompaniesCompanyIdShippingLocationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; PostCompaniesCompanyIdTerminalOrders(string companyId, TerminalOrderRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an order for payment terminal products for the company identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write
>Requests to the Management API test endpoint do not create actual orders for test terminals. To order test terminals, you need to [submit a sales order](https://docs.adyen.com/point-of-sale/managing-terminals/order-terminals/#sales-order-steps) in your Customer Area.

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.PostCompaniesCompanyIdTerminalOrders(companyId, body);
    // TODO: Handle 'response' of type TerminalOrder
}
catch (SdkException<PostCompaniesCompanyIdTerminalOrdersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>body</code> | <code>[TerminalOrderRequest?](Models/TerminalOrderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](Models/TerminalOrder.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCompaniesCompanyIdTerminalOrdersError](Errors/PostCompaniesCompanyIdTerminalOrdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; PostCompaniesCompanyIdTerminalOrdersOrderIdCancel(string companyId, string orderId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels the terminal products order identified in the path.
Cancelling is only possible while the order has the status **Placed**.
To cancel an order, make a POST call without a request body. The response returns the full order details, but with the status changed to **Cancelled**.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.PostCompaniesCompanyIdTerminalOrdersOrderIdCancel(companyId,
        orderId);
    // TODO: Handle 'response' of type TerminalOrder
}
catch (SdkException<PostCompaniesCompanyIdTerminalOrdersOrderIdCancelError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>orderId</code> | <code>string</code> | The unique identifier of the order. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](Models/TerminalOrder.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCompaniesCompanyIdTerminalOrdersOrderIdCancelError](Errors/PostCompaniesCompanyIdTerminalOrdersOrderIdCancelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalOrdersMerchantLevel

> Source: [TerminalOrdersMerchantLevel](Api/TerminalOrdersMerchantLevel.cs)

<details>
<summary><code>Task&lt;BillingEntitiesResponse&gt; GetMerchantsMerchantIdBillingEntities(string merchantId, string? name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the billing entities of the merchant account identified in the path.
A billing entity is a legal entity where we charge orders to. An order for terminal products must contain the ID of a billing entity.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.GetMerchantsMerchantIdBillingEntities(merchantId, name);
    // TODO: Handle 'response' of type BillingEntitiesResponse
}
catch (SdkException<GetMerchantsMerchantIdBillingEntitiesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>name</code> | <code>string?</code> | The name of the billing entity. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BillingEntitiesResponse](Models/BillingEntitiesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdBillingEntitiesError](Errors/GetMerchantsMerchantIdBillingEntitiesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ShippingLocationsResponse&gt; GetMerchantsMerchantIdShippingLocations(string merchantId, string? name, int? offset, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the shipping locations for the merchant account identified in the path.
A shipping location includes the address where orders can be delivered, and an ID which you need to specify when ordering terminal products.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.GetMerchantsMerchantIdShippingLocations(merchantId,
        name,
        offset,
        limit);
    // TODO: Handle 'response' of type ShippingLocationsResponse
}
catch (SdkException<GetMerchantsMerchantIdShippingLocationsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>name</code> | <code>string?</code> | The name of the shipping location. |
| <code>offset</code> | <code>int?</code> | The number of locations to skip. |
| <code>limit</code> | <code>int?</code> | The number of locations to return. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ShippingLocationsResponse](Models/ShippingLocationsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdShippingLocationsError](Errors/GetMerchantsMerchantIdShippingLocationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalModelsResponse&gt; GetMerchantsMerchantIdTerminalModels(string merchantId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the payment terminal models that the merchant account identified in the path has access to. The response includes the terminal model ID, which can be used as a query parameter when getting a list of terminals or a list of products for ordering.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.GetMerchantsMerchantIdTerminalModels(merchantId);
    // TODO: Handle 'response' of type TerminalModelsResponse
}
catch (SdkException<GetMerchantsMerchantIdTerminalModelsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalModelsResponse](Models/TerminalModelsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdTerminalModelsError](Errors/GetMerchantsMerchantIdTerminalModelsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrdersResponse&gt; GetMerchantsMerchantIdTerminalOrders(string merchantId, string? customerOrderReference, string? status, int? offset, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of terminal products orders for the merchant account identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.GetMerchantsMerchantIdTerminalOrders(merchantId,
        customerOrderReference,
        status,
        offset,
        limit);
    // TODO: Handle 'response' of type TerminalOrdersResponse
}
catch (SdkException<GetMerchantsMerchantIdTerminalOrdersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | - |
| <code>customerOrderReference</code> | <code>string?</code> | Your purchase order number. |
| <code>status</code> | <code>string?</code> | The order status. Possible values (not case-sensitive): Placed, Confirmed, Cancelled, Shipped, Delivered. |
| <code>offset</code> | <code>int?</code> | The number of orders to skip. |
| <code>limit</code> | <code>int?</code> | The number of orders to return. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrdersResponse](Models/TerminalOrdersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdTerminalOrdersError](Errors/GetMerchantsMerchantIdTerminalOrdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; GetMerchantsMerchantIdTerminalOrdersOrderId(string merchantId, string orderId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the terminal products order identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.GetMerchantsMerchantIdTerminalOrdersOrderId(merchantId,
        orderId);
    // TODO: Handle 'response' of type TerminalOrder
}
catch (SdkException<GetMerchantsMerchantIdTerminalOrdersOrderIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>orderId</code> | <code>string</code> | The unique identifier of the order. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](Models/TerminalOrder.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdTerminalOrdersOrderIdError](Errors/GetMerchantsMerchantIdTerminalOrdersOrderIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalProductsResponse&gt; GetMerchantsMerchantIdTerminalProducts(string merchantId, string country, string? terminalModelId, int? offset, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a country-specific list of payment terminal packages and parts that the merchant account identified in the path has access to.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.GetMerchantsMerchantIdTerminalProducts(merchantId,
        country,
        terminalModelId,
        offset,
        limit);
    // TODO: Handle 'response' of type TerminalProductsResponse
}
catch (SdkException<GetMerchantsMerchantIdTerminalProductsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>country</code> | <code>string</code> | The country to return products for, in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. For example, **US** |
| <code>terminalModelId</code> | <code>string?</code> | The terminal model to return products for. Use the ID returned in the [GET `/terminalModels`](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/merchants/{merchantId}/terminalModels) response. For example, **Verifone.M400** |
| <code>offset</code> | <code>int?</code> | The number of products to skip. |
| <code>limit</code> | <code>int?</code> | The number of products to return. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalProductsResponse](Models/TerminalProductsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdTerminalProductsError](Errors/GetMerchantsMerchantIdTerminalProductsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; PatchMerchantsMerchantIdTerminalOrdersOrderId(string merchantId, string orderId, TerminalOrderRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the terminal products order identified in the path.
Updating is only possible while the order has the status **Placed**.

The request body only needs to contain what you want to change. 
However, to update the products in the `items` array, you must provide the entire array. For example, if the array has three items:
 To remove one item, the array must include the remaining two items. Or to add one item, the array must include all four items.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.PatchMerchantsMerchantIdTerminalOrdersOrderId(merchantId,
        orderId,
        body);
    // TODO: Handle 'response' of type TerminalOrder
}
catch (SdkException<PatchMerchantsMerchantIdTerminalOrdersOrderIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>orderId</code> | <code>string</code> | The unique identifier of the order. |
| <code>body</code> | <code>[TerminalOrderRequest?](Models/TerminalOrderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](Models/TerminalOrder.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchMerchantsMerchantIdTerminalOrdersOrderIdError](Errors/PatchMerchantsMerchantIdTerminalOrdersOrderIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ShippingLocation&gt; PostMerchantsMerchantIdShippingLocations(string merchantId, ShippingLocation? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a shipping location for the merchant account identified in the path. A shipping location defines an address where orders can be shipped to. 

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.PostMerchantsMerchantIdShippingLocations(merchantId, body);
    // TODO: Handle 'response' of type ShippingLocation
}
catch (SdkException<PostMerchantsMerchantIdShippingLocationsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>body</code> | <code>[ShippingLocation?](Models/ShippingLocation.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ShippingLocation](Models/ShippingLocation.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsMerchantIdShippingLocationsError](Errors/PostMerchantsMerchantIdShippingLocationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; PostMerchantsMerchantIdTerminalOrders(string merchantId, TerminalOrderRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an order for payment terminal products for the merchant account identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write
>Requests to the Management API test endpoint do not create actual orders for test terminals. To order test terminals, you need to [submit a sales order](https://docs.adyen.com/point-of-sale/managing-terminals/order-terminals/#sales-order-steps) in your Customer Area.

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.PostMerchantsMerchantIdTerminalOrders(merchantId, body);
    // TODO: Handle 'response' of type TerminalOrder
}
catch (SdkException<PostMerchantsMerchantIdTerminalOrdersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>body</code> | <code>[TerminalOrderRequest?](Models/TerminalOrderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](Models/TerminalOrder.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsMerchantIdTerminalOrdersError](Errors/PostMerchantsMerchantIdTerminalOrdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; PostMerchantsMerchantIdTerminalOrdersOrderIdCancel(string merchantId, string orderId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels the terminal products order identified in the path.
Cancelling is only possible while the order has the status **Placed**.
To cancel an order, make a POST call without a request body. The response returns the full order details, but with the status changed to **Cancelled**.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.PostMerchantsMerchantIdTerminalOrdersOrderIdCancel(merchantId,
        orderId);
    // TODO: Handle 'response' of type TerminalOrder
}
catch (SdkException<PostMerchantsMerchantIdTerminalOrdersOrderIdCancelError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>orderId</code> | <code>string</code> | The unique identifier of the order. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](Models/TerminalOrder.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsMerchantIdTerminalOrdersOrderIdCancelError](Errors/PostMerchantsMerchantIdTerminalOrdersOrderIdCancelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalSettingsCompanyLevel

> Source: [TerminalSettingsCompanyLevel](Api/TerminalSettingsCompanyLevel.cs)

<details>
<summary><code>Task&lt;Logo&gt; GetCompaniesCompanyIdTerminalLogos(string companyId, string model, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the logo that is configured for a specific payment terminal model at the company identified in the path. 

The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file. 
This logo applies to all terminals of the specified model under the company, unless a different logo is configured at a lower level (merchant account, store, or individual terminal).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsCompanyLevel.GetCompaniesCompanyIdTerminalLogos(companyId, model);
    // TODO: Handle 'response' of type Logo
}
catch (SdkException<GetCompaniesCompanyIdTerminalLogosError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>model</code> | <code>string</code> | The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](Models/Logo.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdTerminalLogosError](Errors/GetCompaniesCompanyIdTerminalLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; GetCompaniesCompanyIdTerminalSettings(string companyId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the payment terminal settings that are configured for the company identified in the path. These settings apply to all terminals under the company, unless different values are configured at a lower level (merchant account, store, or individual terminal).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsCompanyLevel.GetCompaniesCompanyIdTerminalSettings(companyId);
    // TODO: Handle 'response' of type TerminalSettings
}
catch (SdkException<GetCompaniesCompanyIdTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](Models/TerminalSettings.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdTerminalSettingsError](Errors/GetCompaniesCompanyIdTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Logo&gt; PatchCompaniesCompanyIdTerminalLogos(string companyId, string model, Logo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the logo that is configured for a specific payment terminal model at the company identified in the path. You can update the logo for only one terminal model at a time.
This logo applies to all terminals of the specified model under the company, unless a different logo is configured at a lower level (merchant account, store, or individual terminal). 
* To change the logo, specify the image file as a Base64-encoded string.
* To restore the logo inherited from the Adyen PSP level, specify an empty logo value.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsCompanyLevel.PatchCompaniesCompanyIdTerminalLogos(companyId,
        model,
        body);
    // TODO: Handle 'response' of type Logo
}
catch (SdkException<PatchCompaniesCompanyIdTerminalLogosError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>model</code> | <code>string</code> | The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. |
| <code>body</code> | <code>[Logo?](Models/Logo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](Models/Logo.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchCompaniesCompanyIdTerminalLogosError](Errors/PatchCompaniesCompanyIdTerminalLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; PatchCompaniesCompanyIdTerminalSettings(string companyId, TerminalSettings? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates payment terminal settings for the company identified in the path. These settings apply to all terminals under the company, unless different values are configured at a lower level (merchant account, store, or individual terminal).

* To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object.
* To restore a parameter value inherited from the Adyen PSP level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter.
* Objects that are not included in the request are not updated.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsCompanyLevel.PatchCompaniesCompanyIdTerminalSettings(companyId, body);
    // TODO: Handle 'response' of type TerminalSettings
}
catch (SdkException<PatchCompaniesCompanyIdTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>body</code> | <code>[TerminalSettings?](Models/TerminalSettings.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](Models/TerminalSettings.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchCompaniesCompanyIdTerminalSettingsError](Errors/PatchCompaniesCompanyIdTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalSettingsMerchantLevel

> Source: [TerminalSettingsMerchantLevel](Api/TerminalSettingsMerchantLevel.cs)

<details>
<summary><code>Task&lt;Logo&gt; GetMerchantsMerchantIdTerminalLogos(string merchantId, string model, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the logo that is configured for a specific payment terminal model at the merchant account identified in the path. 
The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file. 
This logo applies to all terminals of the specified model under the merchant account, unless a different logo is configured at a lower level (store or individual terminal).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsMerchantLevel.GetMerchantsMerchantIdTerminalLogos(merchantId, model);
    // TODO: Handle 'response' of type Logo
}
catch (SdkException<GetMerchantsMerchantIdTerminalLogosError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>model</code> | <code>string</code> | The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](Models/Logo.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdTerminalLogosError](Errors/GetMerchantsMerchantIdTerminalLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; GetMerchantsMerchantIdTerminalSettings(string merchantId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the payment terminal settings that are configured for the merchant account identified in the path. These settings apply to all terminals under the merchant account unless different values are configured at a lower level (store or individual terminal).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsMerchantLevel.GetMerchantsMerchantIdTerminalSettings(merchantId);
    // TODO: Handle 'response' of type TerminalSettings
}
catch (SdkException<GetMerchantsMerchantIdTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](Models/TerminalSettings.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdTerminalSettingsError](Errors/GetMerchantsMerchantIdTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Logo&gt; PatchMerchantsMerchantIdTerminalLogos(string merchantId, string model, Logo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the logo for a specific payment terminal model at the merchant account identified in the path. You can update the logo for only one terminal model at a time. 
This logo applies to all terminals of the specified model under the merchant account, unless a different logo is configured at a lower level (store or individual terminal).

* To change the logo, specify the image file as a Base64-encoded string.
* To restore the logo inherited from the company account, specify an empty logo value.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsMerchantLevel.PatchMerchantsMerchantIdTerminalLogos(merchantId,
        model,
        body);
    // TODO: Handle 'response' of type Logo
}
catch (SdkException<PatchMerchantsMerchantIdTerminalLogosError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>model</code> | <code>string</code> | The terminal model. Allowed values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. |
| <code>body</code> | <code>[Logo?](Models/Logo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](Models/Logo.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchMerchantsMerchantIdTerminalLogosError](Errors/PatchMerchantsMerchantIdTerminalLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; PatchMerchantsMerchantIdTerminalSettings(string merchantId, TerminalSettings? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates payment terminal settings for the merchant account identified in the path.
These settings apply to all terminals under the merchant account, unless different values are configured at a lower level (store or individual terminal).

* To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object.
* To restore a parameter value inherited from a higher level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter.
* Objects that are not included in the request are not updated.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write



For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsMerchantLevel.PatchMerchantsMerchantIdTerminalSettings(merchantId,
        body);
    // TODO: Handle 'response' of type TerminalSettings
}
catch (SdkException<PatchMerchantsMerchantIdTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>body</code> | <code>[TerminalSettings?](Models/TerminalSettings.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](Models/TerminalSettings.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchMerchantsMerchantIdTerminalSettingsError](Errors/PatchMerchantsMerchantIdTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalSettingsStoreLevel

> Source: [TerminalSettingsStoreLevel](Api/TerminalSettingsStoreLevel.cs)

<details>
<summary><code>Task&lt;Logo&gt; GetMerchantsMerchantIdStoresReferenceTerminalLogos(string merchantId, string reference, string model, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the logo that is configured for a specific payment terminal model at the store identified in the path. 
The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file. 
This logo applies to all terminals of the specified model under the store, unless a different logo is configured for an individual terminal.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.GetMerchantsMerchantIdStoresReferenceTerminalLogos(merchantId,
        reference,
        model);
    // TODO: Handle 'response' of type Logo
}
catch (SdkException<GetMerchantsMerchantIdStoresReferenceTerminalLogosError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>reference</code> | <code>string</code> | The reference that identifies the store. |
| <code>model</code> | <code>string</code> | The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](Models/Logo.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdStoresReferenceTerminalLogosError](Errors/GetMerchantsMerchantIdStoresReferenceTerminalLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; GetMerchantsMerchantIdStoresReferenceTerminalSettings(string merchantId, string reference, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the payment terminal settings that are configured for the store identified in the path. These settings apply to all terminals under the store unless different values are configured for an individual terminal.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.GetMerchantsMerchantIdStoresReferenceTerminalSettings(merchantId,
        reference);
    // TODO: Handle 'response' of type TerminalSettings
}
catch (SdkException<GetMerchantsMerchantIdStoresReferenceTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>reference</code> | <code>string</code> | The reference that identifies the store. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](Models/TerminalSettings.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdStoresReferenceTerminalSettingsError](Errors/GetMerchantsMerchantIdStoresReferenceTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Logo&gt; GetStoresStoreIdTerminalLogos(string storeId, string model, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the logo that is configured for a specific payment terminal model at the store identified in the path. 
The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file. 
This logo applies to all terminals of that model under the store unless a different logo is configured for an individual terminal.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.GetStoresStoreIdTerminalLogos(storeId, model);
    // TODO: Handle 'response' of type Logo
}
catch (SdkException<GetStoresStoreIdTerminalLogosError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>storeId</code> | <code>string</code> | The unique identifier of the store. |
| <code>model</code> | <code>string</code> | The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](Models/Logo.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetStoresStoreIdTerminalLogosError](Errors/GetStoresStoreIdTerminalLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; GetStoresStoreIdTerminalSettings(string storeId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the payment terminal settings that are configured for the store identified in the path. These settings apply to all terminals under the store unless different values are configured for an individual terminal.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.GetStoresStoreIdTerminalSettings(storeId);
    // TODO: Handle 'response' of type TerminalSettings
}
catch (SdkException<GetStoresStoreIdTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>storeId</code> | <code>string</code> | The unique identifier of the store. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](Models/TerminalSettings.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetStoresStoreIdTerminalSettingsError](Errors/GetStoresStoreIdTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Logo&gt; PatchMerchantsMerchantIdStoresReferenceTerminalLogos(string merchantId, string reference, string model, Logo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the logo that is configured for a specific payment terminal model at the store identified in the path. You can update the logo for only one terminal model at a time.
This logo applies to all terminals of the specified model under the store, unless a different logo is configured for an individual terminal. 

* To change the logo, specify the image file as a Base64-encoded string.
* To restore the logo inherited from a higher level (merchant or company account), specify an empty logo value.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.PatchMerchantsMerchantIdStoresReferenceTerminalLogos(merchantId,
        reference,
        model,
        body);
    // TODO: Handle 'response' of type Logo
}
catch (SdkException<PatchMerchantsMerchantIdStoresReferenceTerminalLogosError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>reference</code> | <code>string</code> | The reference that identifies the store. |
| <code>model</code> | <code>string</code> | The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T |
| <code>body</code> | <code>[Logo?](Models/Logo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](Models/Logo.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchMerchantsMerchantIdStoresReferenceTerminalLogosError](Errors/PatchMerchantsMerchantIdStoresReferenceTerminalLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; PatchMerchantsMerchantIdStoresReferenceTerminalSettings(string merchantId, string reference, TerminalSettings? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates payment terminal settings for the store identified in the path. These settings apply to all terminals under the store, unless different values are configured for an individual terminal.

* To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object.
* To restore a parameter value inherited from a higher level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter.
* Objects that are not included in the request are not updated.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.PatchMerchantsMerchantIdStoresReferenceTerminalSettings(merchantId,
        reference,
        body);
    // TODO: Handle 'response' of type TerminalSettings
}
catch (SdkException<PatchMerchantsMerchantIdStoresReferenceTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>reference</code> | <code>string</code> | The reference that identifies the store. |
| <code>body</code> | <code>[TerminalSettings?](Models/TerminalSettings.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](Models/TerminalSettings.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchMerchantsMerchantIdStoresReferenceTerminalSettingsError](Errors/PatchMerchantsMerchantIdStoresReferenceTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Logo&gt; PatchStoresStoreIdTerminalLogos(string storeId, string model, Logo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the logo that is configured for a specific payment terminal model at the store identified in the path. You can update the logo for only one terminal model at a time.
This logo applies to all terminals of the specified model under the store, unless a different logo is configured for an individual terminal. 

* To change the logo, specify the image file as a Base64-encoded string.
* To restore the logo inherited from a higher level (merchant or company account), specify an empty logo value.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.PatchStoresStoreIdTerminalLogos(storeId, model, body);
    // TODO: Handle 'response' of type Logo
}
catch (SdkException<PatchStoresStoreIdTerminalLogosError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>storeId</code> | <code>string</code> | The unique identifier of the store. |
| <code>model</code> | <code>string</code> | The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T. |
| <code>body</code> | <code>[Logo?](Models/Logo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](Models/Logo.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchStoresStoreIdTerminalLogosError](Errors/PatchStoresStoreIdTerminalLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; PatchStoresStoreIdTerminalSettings(string storeId, TerminalSettings? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates payment terminal settings for the store identified in the path. These settings apply to all terminals under the store, unless different values are configured for an individual terminal.

* To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object.
* To restore a parameter value inherited from a higher level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter.
* Objects that are not included in the request are not updated.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.PatchStoresStoreIdTerminalSettings(storeId, body);
    // TODO: Handle 'response' of type TerminalSettings
}
catch (SdkException<PatchStoresStoreIdTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>storeId</code> | <code>string</code> | The unique identifier of the store. |
| <code>body</code> | <code>[TerminalSettings?](Models/TerminalSettings.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](Models/TerminalSettings.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchStoresStoreIdTerminalSettingsError](Errors/PatchStoresStoreIdTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalSettingsTerminalLevel

> Source: [TerminalSettingsTerminalLevel](Api/TerminalSettingsTerminalLevel.cs)

<details>
<summary><code>Task&lt;Logo&gt; GetTerminalsTerminalIdTerminalLogos(string terminalId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the logo that is configured for the payment terminal identified in the path.
The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsTerminalLevel.GetTerminalsTerminalIdTerminalLogos(terminalId);
    // TODO: Handle 'response' of type Logo
}
catch (SdkException<GetTerminalsTerminalIdTerminalLogosError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>terminalId</code> | <code>string</code> | The unique identifier of the payment terminal. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](Models/Logo.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTerminalsTerminalIdTerminalLogosError](Errors/GetTerminalsTerminalIdTerminalLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; GetTerminalsTerminalIdTerminalSettings(string terminalId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the settings that are configured for the payment terminal identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsTerminalLevel.GetTerminalsTerminalIdTerminalSettings(terminalId);
    // TODO: Handle 'response' of type TerminalSettings
}
catch (SdkException<GetTerminalsTerminalIdTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>terminalId</code> | <code>string</code> | The unique identifier of the payment terminal. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](Models/TerminalSettings.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTerminalsTerminalIdTerminalSettingsError](Errors/GetTerminalsTerminalIdTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Logo&gt; PatchTerminalsTerminalIdTerminalLogos(string terminalId, Logo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the logo for the payment terminal identified in the path.

* To change the logo, specify the image file as a Base64-encoded string.
* To restore the logo inherited from a higher level (store, merchant account, or company account), specify an empty logo value.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsTerminalLevel.PatchTerminalsTerminalIdTerminalLogos(terminalId, body);
    // TODO: Handle 'response' of type Logo
}
catch (SdkException<PatchTerminalsTerminalIdTerminalLogosError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>terminalId</code> | <code>string</code> | The unique identifier of the payment terminal. |
| <code>body</code> | <code>[Logo?](Models/Logo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](Models/Logo.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchTerminalsTerminalIdTerminalLogosError](Errors/PatchTerminalsTerminalIdTerminalLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; PatchTerminalsTerminalIdTerminalSettings(string terminalId, TerminalSettings? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the settings that are configured for the payment terminal identified in the path.

* To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object.
* To restore a parameter value inherited from a higher level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter.
* Objects that are not included in the request are not updated.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsTerminalLevel.PatchTerminalsTerminalIdTerminalSettings(terminalId,
        body);
    // TODO: Handle 'response' of type TerminalSettings
}
catch (SdkException<PatchTerminalsTerminalIdTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>terminalId</code> | <code>string</code> | The unique identifier of the payment terminal. |
| <code>body</code> | <code>[TerminalSettings?](Models/TerminalSettings.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](Models/TerminalSettings.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchTerminalsTerminalIdTerminalSettingsError](Errors/PatchTerminalsTerminalIdTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalsTerminalLevel

> Source: [TerminalsTerminalLevel](Api/TerminalsTerminalLevel.cs)

<details>
<summary><code>Task&lt;ListTerminalsResponse&gt; GetTerminals(string? searchQuery, string? otpQuery, string? countries, string? merchantIds, string? storeIds, string? brandModels, int? pageNumber, int? pageSize, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the payment terminals that the API credential has access to and that match the query parameters. 
To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API — Terminal actions read

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalsTerminalLevel.GetTerminals(searchQuery,
        otpQuery,
        countries,
        merchantIds,
        storeIds,
        brandModels,
        pageNumber,
        pageSize);
    // TODO: Handle 'response' of type ListTerminalsResponse
}
catch (SdkException<GetTerminalsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>searchQuery</code> | <code>string?</code> | Returns terminals with an ID that contains the specified string. If present, other query parameters are ignored. |
| <code>otpQuery</code> | <code>string?</code> | Returns one or more terminals associated with the one-time passwords specified in the request. If this query parameter is used, other query parameters are ignored. |
| <code>countries</code> | <code>string?</code> | Returns terminals located in the countries specified by their [two-letter country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2). |
| <code>merchantIds</code> | <code>string?</code> | Returns terminals that belong to the merchant accounts specified by their unique merchant account ID. |
| <code>storeIds</code> | <code>string?</code> | Returns terminals that are assigned to the [stores](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/stores) specified by their unique store ID. |
| <code>brandModels</code> | <code>string?</code> | Returns terminals of the [models](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/companies/{companyId}/terminalModels) specified in the format *brand.model*. |
| <code>pageNumber</code> | <code>int?</code> | The number of the page to fetch. |
| <code>pageSize</code> | <code>int?</code> | The number of items to have on a page, maximum 100. The default is 20 items on a page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListTerminalsResponse](Models/ListTerminalsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTerminalsError](Errors/GetTerminalsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PostTerminalsTerminalIdReassign(string terminalId, TerminalReassignmentRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Reassigns a payment terminal to a company account, merchant account, merchant account inventory, or a store.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Assign Terminal

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TerminalsTerminalLevel.PostTerminalsTerminalIdReassign(terminalId, body);
}
catch (SdkException<PostTerminalsTerminalIdReassignError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>terminalId</code> | <code>string</code> | The unique identifier of the payment terminal. |
| <code>body</code> | <code>[TerminalReassignmentRequest?](Models/TerminalReassignmentRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostTerminalsTerminalIdReassignError](Errors/PostTerminalsTerminalIdReassignError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TermsOfService

> Source: [TermsOfService](Api/TermsOfService.cs)

<details>
<summary><code>Task&lt;GetAcceptedTermsOfServiceDocumentResponse&gt; GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereference(string id, string termsofserviceacceptancereference, string? termsOfServiceDocumentFormat, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the accepted Terms of Service document for a legal entity.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TermsOfService.GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereference(id,
        termsofserviceacceptancereference,
        termsOfServiceDocumentFormat);
    // TODO: Handle 'response' of type GetAcceptedTermsOfServiceDocumentResponse
}
catch (SdkException<GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the legal entity. For sole proprietorship, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization. |
| <code>termsofserviceacceptancereference</code> | <code>string</code> | An Adyen-generated reference for the accepted Terms of Service. |
| <code>termsOfServiceDocumentFormat</code> | <code>string?</code> | The format of the Terms of Service document. Possible values: **JSON**, **PDF**, or **TXT** |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetAcceptedTermsOfServiceDocumentResponse](Models/GetAcceptedTermsOfServiceDocumentResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceError](Errors/GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTermsOfServiceAcceptanceInfosResponse&gt; GetLegalEntitiesIdTermsOfServiceAcceptanceInfos(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns Terms of Service information for a legal entity.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TermsOfService.GetLegalEntitiesIdTermsOfServiceAcceptanceInfos(id);
    // TODO: Handle 'response' of type GetTermsOfServiceAcceptanceInfosResponse
}
catch (SdkException<GetLegalEntitiesIdTermsOfServiceAcceptanceInfosError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTermsOfServiceAcceptanceInfosResponse](Models/GetTermsOfServiceAcceptanceInfosResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLegalEntitiesIdTermsOfServiceAcceptanceInfosError](Errors/GetLegalEntitiesIdTermsOfServiceAcceptanceInfosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CalculateTermsOfServiceStatusResponse&gt; GetLegalEntitiesIdTermsOfServiceStatus(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the required types of Terms of Service that need to be accepted by a legal entity.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TermsOfService.GetLegalEntitiesIdTermsOfServiceStatus(id);
    // TODO: Handle 'response' of type CalculateTermsOfServiceStatusResponse
}
catch (SdkException<GetLegalEntitiesIdTermsOfServiceStatusError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CalculateTermsOfServiceStatusResponse](Models/CalculateTermsOfServiceStatusResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLegalEntitiesIdTermsOfServiceStatusError](Errors/GetLegalEntitiesIdTermsOfServiceStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AcceptTermsOfServiceResponse&gt; PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentid(string id, string termsofservicedocumentid, AcceptTermsOfServiceRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Accepts Terms of Service.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TermsOfService.PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentid(id,
        termsofservicedocumentid,
        body);
    // TODO: Handle 'response' of type AcceptTermsOfServiceResponse
}
catch (SdkException<PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the legal entity.<br><br>For sole proprietorships, this is the individual legal entity ID of the owner.<br><br>For organizations, this is the ID of the organization.<br><br>For legal representatives of individuals, this is the ID of the individual. |
| <code>termsofservicedocumentid</code> | <code>string</code> | The unique identifier of the Terms of Service document. |
| <code>body</code> | <code>[AcceptTermsOfServiceRequest?](Models/AcceptTermsOfServiceRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AcceptTermsOfServiceResponse](Models/AcceptTermsOfServiceResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidError](Errors/PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTermsOfServiceDocumentResponse&gt; PostLegalEntitiesIdTermsOfService(string id, GetTermsOfServiceDocumentRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the Terms of Service document for a legal entity.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TermsOfService.PostLegalEntitiesIdTermsOfService(id, body);
    // TODO: Handle 'response' of type GetTermsOfServiceDocumentResponse
}
catch (SdkException<PostLegalEntitiesIdTermsOfServiceError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization. |
| <code>body</code> | <code>[GetTermsOfServiceDocumentRequest?](Models/GetTermsOfServiceDocumentRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTermsOfServiceDocumentResponse](Models/GetTermsOfServiceDocumentResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostLegalEntitiesIdTermsOfServiceError](Errors/PostLegalEntitiesIdTermsOfServiceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TransactionRules

> Source: [TransactionRules](Api/TransactionRules.cs)

<details>
<summary><code>Task&lt;TransactionRule&gt; DeleteTransactionRulesTransactionRuleId(string transactionRuleId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a transaction rule.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionRules.DeleteTransactionRulesTransactionRuleId(transactionRuleId);
    // TODO: Handle 'response' of type TransactionRule
}
catch (SdkException<DeleteTransactionRulesTransactionRuleIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>transactionRuleId</code> | <code>string</code> | The unique identifier of the transaction rule. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionRule](Models/TransactionRule.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteTransactionRulesTransactionRuleIdError](Errors/DeleteTransactionRulesTransactionRuleIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionRuleResponse&gt; GetTransactionRulesTransactionRuleId(string transactionRuleId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a transaction rule.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionRules.GetTransactionRulesTransactionRuleId(transactionRuleId);
    // TODO: Handle 'response' of type TransactionRuleResponse
}
catch (SdkException<GetTransactionRulesTransactionRuleIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>transactionRuleId</code> | <code>string</code> | The unique identifier of the transaction rule. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionRuleResponse](Models/TransactionRuleResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTransactionRulesTransactionRuleIdError](Errors/GetTransactionRulesTransactionRuleIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionRule&gt; PatchTransactionRulesTransactionRuleId(string transactionRuleId, TransactionRuleInfo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a transaction rule. 

* To update only the status of a transaction rule, send only the `status` parameter. All other parameters not provided in the request are left unchanged.

* When updating any other parameter, you need to send all existing resource parameters. If you omit a parameter in the request, that parameter is removed from the resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionRules.PatchTransactionRulesTransactionRuleId(transactionRuleId, body);
    // TODO: Handle 'response' of type TransactionRule
}
catch (SdkException<PatchTransactionRulesTransactionRuleIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>transactionRuleId</code> | <code>string</code> | The unique identifier of the transaction rule. |
| <code>body</code> | <code>[TransactionRuleInfo?](Models/TransactionRuleInfo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionRule](Models/TransactionRule.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchTransactionRulesTransactionRuleIdError](Errors/PatchTransactionRulesTransactionRuleIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionRule&gt; PostTransactionRules(TransactionRuleInfo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a [transaction rule](https://docs.adyen.com/issuing/transaction-rules). When your user makes a transaction with their Adyen-issued card, the transaction is allowed or declined based on the conditions and outcome defined in the transaction rule. You can apply the transaction rule to several cards, such as all the cards in your platform, or to a specific card. For use cases, see [examples](https://docs.adyen.com/issuing/transaction-rules/examples).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionRules.PostTransactionRules(body);
    // TODO: Handle 'response' of type TransactionRule
}
catch (SdkException<PostTransactionRulesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[TransactionRuleInfo?](Models/TransactionRuleInfo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionRule](Models/TransactionRule.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostTransactionRulesError](Errors/PostTransactionRulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Transactions

> Source: [Transactions](Api/Transactions.cs)

<details>
<summary><code>Task&lt;TransactionSearchResponse&gt; GetTransactions(DateTimeOffset createdSince, DateTimeOffset createdUntil, string? balancePlatform, string? paymentInstrumentId, string? accountHolderId, string? balanceAccountId, string? cursor, SortOrder? sortOrder, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

>Versions 1 and 2 of the Transfers API are deprecated. If you are just starting your implementation, use the latest version.

Returns all the transactions related to a balance account, account holder, or balance platform.

When making this request, you must include at least one of the following:
- `balanceAccountId`
- `accountHolderId`
- `balancePlatform`.

This endpoint supports cursor-based pagination. The response returns the first page of results, and returns links to the next and previous pages when applicable. You can use the links to page through the results.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transactions.GetTransactions(createdSince,
        createdUntil,
        balancePlatform,
        paymentInstrumentId,
        accountHolderId,
        balanceAccountId,
        cursor,
        sortOrder,
        limit);
    // TODO: Handle 'response' of type TransactionSearchResponse
}
catch (SdkException<GetTransactionsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>createdSince</code> | <code>DateTimeOffset</code> | Only include transactions that have been created on or after this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**. |
| <code>createdUntil</code> | <code>DateTimeOffset</code> | Only include transactions that have been created on or before this point in time. The value must be in ISO 8601 format. For example, **2021-05-30T15:07:40Z**. |
| <code>balancePlatform</code> | <code>string?</code> | The unique identifier of the [balance platform](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balancePlatforms/{id}__queryParam_id).<br><br>Required if you don't provide a `balanceAccountId` or `accountHolderId`. |
| <code>paymentInstrumentId</code> | <code>string?</code> | The unique identifier of the [payment instrument](https://docs.adyen.com/api-explorer/balanceplatform/latest/get/paymentInstruments/_id_).<br><br>To use this parameter, you must also provide a `balanceAccountId`, `accountHolderId`, or `balancePlatform`.<br><br>The `paymentInstrumentId` must be related to the `balanceAccountId` or `accountHolderId` that you provide. |
| <code>accountHolderId</code> | <code>string?</code> | The unique identifier of the [account holder](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/accountHolders/{id}__queryParam_id).<br><br>Required if you don't provide a `balanceAccountId` or `balancePlatform`.<br><br>If you provide a `balanceAccountId`, the `accountHolderId` must be related to the `balanceAccountId`. |
| <code>balanceAccountId</code> | <code>string?</code> | The unique identifier of the [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__queryParam_id).<br><br>Required if you don't provide an `accountHolderId` or `balancePlatform`.<br><br>If you provide an `accountHolderId`, the `balanceAccountId` must be related to the `accountHolderId`. |
| <code>cursor</code> | <code>string?</code> | The `cursor` returned in the links of the previous response. |
| <code>sortOrder</code> | <code>[SortOrder?](Models/Enums/SortOrder.cs)</code> | Determines the sort order of the returned transactions. The sort order is based on the creation date of the transaction.<br><br>Possible values:<br><br> - **asc**: Ascending order, from oldest to most recent.<br><br>- **desc**: Descending order, from most recent to oldest.<br><br>Default value: **asc**. |
| <code>limit</code> | <code>int?</code> | The number of items returned per page, maximum of 100 items. By default, the response returns 10 items per page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionSearchResponse](Models/TransactionSearchResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTransactionsError](Errors/GetTransactionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Transaction&gt; GetTransactionsId(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

>Versions 1 and 2 of the Transfers API are deprecated. If you are just starting your implementation, use the latest version.

Returns a transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transactions.GetTransactionsId(id);
    // TODO: Handle 'response' of type Transaction
}
catch (SdkException<GetTransactionsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the transaction. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Transaction](Models/Transaction.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTransactionsIdError](Errors/GetTransactionsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TransferInstruments

> Source: [TransferInstruments](Api/TransferInstruments.cs)

<details>
<summary><code>Task DeleteTransferInstrumentsId(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a transfer instrument.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TransferInstruments.DeleteTransferInstrumentsId(id);
}
catch (SdkException<DeleteTransferInstrumentsIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the transfer instrument to be deleted. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteTransferInstrumentsIdError](Errors/DeleteTransferInstrumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferInstrument&gt; GetTransferInstrumentsId(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a transfer instrument.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferInstruments.GetTransferInstrumentsId(id);
    // TODO: Handle 'response' of type TransferInstrument
}
catch (SdkException<GetTransferInstrumentsIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the transfer instrument. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferInstrument](Models/TransferInstrument.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTransferInstrumentsIdError](Errors/GetTransferInstrumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferInstrument&gt; PatchTransferInstrumentsId(string id, string? xRequestedVerificationCode, TransferInstrumentInfo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a transfer instrument.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferInstruments.PatchTransferInstrumentsId(id, xRequestedVerificationCode, body);
    // TODO: Handle 'response' of type TransferInstrument
}
catch (SdkException<PatchTransferInstrumentsIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the transfer instrument. |
| <code>xRequestedVerificationCode</code> | <code>string?</code> | Use the requested verification code 0_0001 to resolve any suberrors associated with the transfer instrument. Requested verification codes can only be used in your test environment. |
| <code>body</code> | <code>[TransferInstrumentInfo?](Models/TransferInstrumentInfo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferInstrument](Models/TransferInstrument.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchTransferInstrumentsIdError](Errors/PatchTransferInstrumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferInstrument&gt; PostTransferInstruments(string? xRequestedVerificationCode, TransferInstrumentInfo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a transfer instrument. 

A transfer instrument is a bank account that a legal entity owns. Adyen performs verification checks on the transfer instrument as required by payment industry regulations. We inform you of the verification results through webhooks or API responses.

When the transfer instrument passes the verification checks, you can start sending funds from the balance platform to the transfer instrument (such as payouts).

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferInstruments.PostTransferInstruments(xRequestedVerificationCode, body);
    // TODO: Handle 'response' of type TransferInstrument
}
catch (SdkException<PostTransferInstrumentsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>xRequestedVerificationCode</code> | <code>string?</code> | Use a suberror code as your requested verification code. You can include one code at a time in your request header. Requested verification codes can only be used in your test environment. |
| <code>body</code> | <code>[TransferInstrumentInfo?](Models/TransferInstrumentInfo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferInstrument](Models/TransferInstrument.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostTransferInstrumentsError](Errors/PostTransferInstrumentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TransferLimitsBalanceAccountLevel

> Source: [TransferLimitsBalanceAccountLevel](Api/TransferLimitsBalanceAccountLevel.cs)

<details>
<summary><code>Task DeleteBalanceAccountsIdTransferLimitsTransferLimitId(string id, string transferLimitId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a scheduled or pending transfer limit using its unique `transferLimitId`. You cannot delete an active limit.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TransferLimitsBalanceAccountLevel.DeleteBalanceAccountsIdTransferLimitsTransferLimitId(id,
        transferLimitId);
}
catch (SdkException<DeleteBalanceAccountsIdTransferLimitsTransferLimitIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>transferLimitId</code> | <code>string</code> | The unique identifier of the transfer limit. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteBalanceAccountsIdTransferLimitsTransferLimitIdError](Errors/DeleteBalanceAccountsIdTransferLimitsTransferLimitIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferLimitListResponse&gt; GetBalanceAccountsIdTransferLimits(string id, Scope? scope, TransferType? transferType, LimitStatus? status, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Filter and view the transfer limits configured for a balance account using the balance account's unique `id` and the available query parameters.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferLimitsBalanceAccountLevel.GetBalanceAccountsIdTransferLimits(id,
        scope,
        transferType,
        status);
    // TODO: Handle 'response' of type TransferLimitListResponse
}
catch (SdkException<GetBalanceAccountsIdTransferLimitsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>scope</code> | <code>[Scope?](Models/Enums/Scope.cs)</code> | The scope to which the transfer limit applies. Possible values:<br>* **perTransaction**: you set a maximum amount for each transfer made from the balance account or balance platform.<br>* **perDay**: you set a maximum total amount for all transfers made from the balance account or balance platform in a day. |
| <code>transferType</code> | <code>[TransferType?](Models/Enums/TransferType.cs)</code> | The type of transfer to which the limit applies. Possible values:<br>* **instant**: the limit applies to transfers with an **instant** priority.<br>* **all**: the limit applies to all transfers, regardless of priority. |
| <code>status</code> | <code>[LimitStatus?](Models/Enums/LimitStatus.cs)</code> | The status of the transfer limit. Possible values:   <br>* **active**: the limit is currently active.<br>* **inactive**: the limit is currently inactive.<br>* **pendingSCA**: the limit is pending until your user performs SCA.<br>* **scheduled**: the limit is scheduled to become active at a future date. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferLimitListResponse](Models/TransferLimitListResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalanceAccountsIdTransferLimitsError](Errors/GetBalanceAccountsIdTransferLimitsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferLimitListResponse&gt; GetBalanceAccountsIdTransferLimitsCurrent(string id, Scope? scope, TransferType? transferType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get all transfer limits that currently apply to a balance account using the unique `id` of the balance account.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferLimitsBalanceAccountLevel.GetBalanceAccountsIdTransferLimitsCurrent(id,
        scope,
        transferType);
    // TODO: Handle 'response' of type TransferLimitListResponse
}
catch (SdkException<GetBalanceAccountsIdTransferLimitsCurrentError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>scope</code> | <code>[Scope?](Models/Enums/Scope.cs)</code> | The scope to which the transfer limit applies. Possible values:<br>* **perTransaction**: you set a maximum amount for each transfer made from the balance account or balance platform.<br>* **perDay**: you set a maximum total amount for all transfers made from the balance account or balance platform in a day. |
| <code>transferType</code> | <code>[TransferType?](Models/Enums/TransferType.cs)</code> | The type of transfer to which the limit applies. Possible values:<br>* **instant**: the limit applies to transfers with an **instant** priority.<br>* **all**: the limit applies to all transfers, regardless of priority. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferLimitListResponse](Models/TransferLimitListResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalanceAccountsIdTransferLimitsCurrentError](Errors/GetBalanceAccountsIdTransferLimitsCurrentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferLimit&gt; GetBalanceAccountsIdTransferLimitsTransferLimitId(string id, string transferLimitId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the details of a transfer limit using its unique `transferLimitId`.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferLimitsBalanceAccountLevel.GetBalanceAccountsIdTransferLimitsTransferLimitId(id,
        transferLimitId);
    // TODO: Handle 'response' of type TransferLimit
}
catch (SdkException<GetBalanceAccountsIdTransferLimitsTransferLimitIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>transferLimitId</code> | <code>string</code> | The unique identifier of the transfer limit. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferLimit](Models/TransferLimit.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalanceAccountsIdTransferLimitsTransferLimitIdError](Errors/GetBalanceAccountsIdTransferLimitsTransferLimitIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferLimit&gt; PostBalanceAccountsIdTransferLimits(string id, string? wwwAuthenticate, CreateTransferLimitRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a transfer limit for your balance account using the unique `id` of your balance account.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferLimitsBalanceAccountLevel.PostBalanceAccountsIdTransferLimits(id,
        wwwAuthenticate,
        body);
    // TODO: Handle 'response' of type TransferLimit
}
catch (SdkException<PostBalanceAccountsIdTransferLimitsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>wwwAuthenticate</code> | <code>string?</code> | Header for authenticating through SCA |
| <code>body</code> | <code>[CreateTransferLimitRequest](Models/CreateTransferLimitRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferLimit](Models/TransferLimit.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostBalanceAccountsIdTransferLimitsError](Errors/PostBalanceAccountsIdTransferLimitsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PostBalanceAccountsIdTransferLimitsApprove(string id, string? wwwAuthenticate, ApproveTransferLimitRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Approve transfer limits that are pending SCA authentication.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TransferLimitsBalanceAccountLevel.PostBalanceAccountsIdTransferLimitsApprove(id,
        wwwAuthenticate,
        body);
}
catch (SdkException<PostBalanceAccountsIdTransferLimitsApproveError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the balance account. |
| <code>wwwAuthenticate</code> | <code>string?</code> | Header for authenticating using SCA. |
| <code>body</code> | <code>[ApproveTransferLimitRequest](Models/ApproveTransferLimitRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostBalanceAccountsIdTransferLimitsApproveError](Errors/PostBalanceAccountsIdTransferLimitsApproveError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TransferLimitsBalancePlatformLevel

> Source: [TransferLimitsBalancePlatformLevel](Api/TransferLimitsBalancePlatformLevel.cs)

<details>
<summary><code>Task DeleteBalancePlatformsIdTransferLimitsTransferLimitId(string id, string transferLimitId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a scheduled or pending transfer limit using its unique `transferLimitId`. You cannot delete an active limit.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TransferLimitsBalancePlatformLevel.DeleteBalancePlatformsIdTransferLimitsTransferLimitId(id,
        transferLimitId);
}
catch (SdkException<DeleteBalancePlatformsIdTransferLimitsTransferLimitIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the balance platform. |
| <code>transferLimitId</code> | <code>string</code> | The unique identifier of the transfer limit. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteBalancePlatformsIdTransferLimitsTransferLimitIdError](Errors/DeleteBalancePlatformsIdTransferLimitsTransferLimitIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferLimitListResponse&gt; GetBalancePlatformsIdTransferLimits(string id, Scope? scope, TransferType? transferType, LimitStatus? status, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Filter and view the transfer limits configured for your balance platform using the balance platform's unique `id` and the available query parameters.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferLimitsBalancePlatformLevel.GetBalancePlatformsIdTransferLimits(id,
        scope,
        transferType,
        status);
    // TODO: Handle 'response' of type TransferLimitListResponse
}
catch (SdkException<GetBalancePlatformsIdTransferLimitsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the balance platform. |
| <code>scope</code> | <code>[Scope?](Models/Enums/Scope.cs)</code> | The scope to which the transfer limit applies. Possible values:<br>* **perTransaction**: you set a maximum amount for each transfer made from the balance account or balance platform.<br>* **perDay**: you set a maximum total amount for all transfers made from the balance account or balance platform in a day. |
| <code>transferType</code> | <code>[TransferType?](Models/Enums/TransferType.cs)</code> | The type of transfer to which the limit applies. Possible values:<br>* **instant**: the limit applies to transfers with an **instant** priority.<br>* **all**: the limit applies to all transfers, regardless of priority. |
| <code>status</code> | <code>[LimitStatus?](Models/Enums/LimitStatus.cs)</code> | The status of the transfer limit. Possible values:   <br>* **active**: the limit is currently active.<br>* **inactive**: the limit is currently inactive.<br>* **pendingSCA**: the limit is pending until your user performs SCA.<br>* **scheduled**: the limit is scheduled to become active at a future date. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferLimitListResponse](Models/TransferLimitListResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalancePlatformsIdTransferLimitsError](Errors/GetBalancePlatformsIdTransferLimitsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferLimit&gt; GetBalancePlatformsIdTransferLimitsTransferLimitId(string id, string transferLimitId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the details of a transfer limit using its unique `transferLimitId`.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferLimitsBalancePlatformLevel.GetBalancePlatformsIdTransferLimitsTransferLimitId(id,
        transferLimitId);
    // TODO: Handle 'response' of type TransferLimit
}
catch (SdkException<GetBalancePlatformsIdTransferLimitsTransferLimitIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the balance platform. |
| <code>transferLimitId</code> | <code>string</code> | The unique identifier of the transfer limit. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferLimit](Models/TransferLimit.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetBalancePlatformsIdTransferLimitsTransferLimitIdError](Errors/GetBalancePlatformsIdTransferLimitsTransferLimitIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferLimit&gt; PostBalancePlatformsIdTransferLimits(string id, CreateTransferLimitRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a transfer limit for your balance platform using the unique `id` of your balance platform.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferLimitsBalancePlatformLevel.PostBalancePlatformsIdTransferLimits(id, body);
    // TODO: Handle 'response' of type TransferLimit
}
catch (SdkException<PostBalancePlatformsIdTransferLimitsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The unique identifier of the balance platform. |
| <code>body</code> | <code>[CreateTransferLimitRequest](Models/CreateTransferLimitRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferLimit](Models/TransferLimit.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostBalancePlatformsIdTransferLimitsError](Errors/PostBalancePlatformsIdTransferLimitsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TransferRoutes

> Source: [TransferRoutes](Api/TransferRoutes.cs)

<details>
<summary><code>Task&lt;TransferRouteResponse&gt; PostTransferRoutesCalculate(TransferRouteRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns available transfer routes based on a combination of transfer `country`, `currency`, `counterparty`, and `priorities`. Use this endpoint to find optimal transfer priorities and associated requirements before you [make a transfer](https://docs.adyen.com/api-explorer/transfers/latest/post/transfers).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferRoutes.PostTransferRoutesCalculate(body);
    // TODO: Handle 'response' of type TransferRouteResponse
}
catch (SdkException<PostTransferRoutesCalculateError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[TransferRouteRequest?](Models/TransferRouteRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferRouteResponse](Models/TransferRouteResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostTransferRoutesCalculateError](Errors/PostTransferRoutesCalculateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Transfers

> Source: [Transfers](Api/Transfers.cs)

<details>
<summary><code>Task&lt;FindTransfersResponse&gt; GetTransfers(DateTimeOffset createdSince, DateTimeOffset createdUntil, string? balancePlatform, string? accountHolderId, string? balanceAccountId, string? paymentInstrumentId, string? reference, Category2? category, SortOrder? sortOrder, string? cursor, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns all the transfers related to a balance account, account holder, or balance platform.

When making this request, you must include at least one of the following:
- `balanceAccountId`
- `accountHolderId`
- `balancePlatform`.

This endpoint supports cursor-based pagination. The response returns the first page of results, and returns links to the next and previous pages when applicable. You can use the links to page through the results.



</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transfers.GetTransfers(createdSince,
        createdUntil,
        balancePlatform,
        accountHolderId,
        balanceAccountId,
        paymentInstrumentId,
        reference,
        category,
        sortOrder,
        cursor,
        limit);
    // TODO: Handle 'response' of type FindTransfersResponse
}
catch (SdkException<GetTransfersError> ex)
{
    if (ex.Error.TryGetTransferServiceRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type TransferServiceRestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>createdSince</code> | <code>DateTimeOffset</code> | Only include transfers that have been created on or after this point in time. The value must be in ISO 8601 format and not earlier than 6 months before the `createdUntil` date. For example, **2021-05-30T15:07:40Z**. |
| <code>createdUntil</code> | <code>DateTimeOffset</code> | Only include transfers that have been created on or before this point in time. The value must be in ISO 8601 format and not later than 6 months after the `createdSince` date. For example, **2021-05-30T15:07:40Z**. |
| <code>balancePlatform</code> | <code>string?</code> | The unique identifier of the [balance platform](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balancePlatforms/{id}__queryParam_id).<br><br>Required if you don't provide a `balanceAccountId` or `accountHolderId`. |
| <code>accountHolderId</code> | <code>string?</code> | The unique identifier of the [account holder](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/accountHolders/{id}__queryParam_id).<br><br>Required if you don't provide a `balanceAccountId` or `balancePlatform`.<br><br>If you provide a `balanceAccountId`, the `accountHolderId` must be related to the `balanceAccountId`. |
| <code>balanceAccountId</code> | <code>string?</code> | The unique identifier of the [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__queryParam_id).<br><br>Required if you don't provide an `accountHolderId` or `balancePlatform`.<br><br>If you provide an `accountHolderId`, the `balanceAccountId` must be related to the `accountHolderId`. |
| <code>paymentInstrumentId</code> | <code>string?</code> | The unique identifier of the [payment instrument](https://docs.adyen.com/api-explorer/balanceplatform/latest/get/paymentInstruments/_id_).<br><br>To use this parameter, you must also provide a `balanceAccountId`, `accountHolderId`, or `balancePlatform`.<br><br>The `paymentInstrumentId` must be related to the `balanceAccountId` or `accountHolderId` that you provide. |
| <code>reference</code> | <code>string?</code> | The reference you provided in the POST [/transfers](https://docs.adyen.com/api-explorer/transfers/latest/post/transfers) request |
| <code>category</code> | <code>[Category2?](Models/Enums/Category2.cs)</code> | The category of the transfer.<br><br>Possible values:<br><br> - **bank**: A transfer involving a [transfer instrument](https://docs.adyen.com/api-explorer/legalentity/latest/post/transferInstruments#responses-200-id) or a bank account.<br><br>- **card**: A transfer involving a third-party card.<br><br>- **internal**: A transfer between [balance accounts](https://docs.adyen.com/api-explorer/balanceplatform/latest/post/balanceAccounts#responses-200-id) within your platform.<br><br>- **issuedCard**: A transfer initiated by an Adyen-issued card.<br><br>- **platformPayment**: Funds movements related to payments that are acquired for your users.<br><br>- **topUp**: An incoming transfer initiated by your user to top up their balance account. |
| <code>sortOrder</code> | <code>[SortOrder?](Models/Enums/SortOrder.cs)</code> | Determines the sort order of the returned transfers. The sort order is based on the creation date of the transfers.<br><br>Possible values:<br><br> - **asc**: Ascending order, from oldest to most recent.<br><br>- **desc**: Descending order, from most recent to oldest.<br><br>Default value: **asc**. |
| <code>cursor</code> | <code>string?</code> | The `cursor` returned in the links of the previous response. |
| <code>limit</code> | <code>int?</code> | The number of items returned per page, maximum of 100 items. By default, the response returns 10 items per page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FindTransfersResponse](Models/FindTransfersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTransfersError](Errors/GetTransfersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferData&gt; GetTransfersId(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a specified transfer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transfers.GetTransfersId(id);
    // TODO: Handle 'response' of type TransferData
}
catch (SdkException<GetTransfersIdError> ex)
{
    if (ex.Error.TryGetTransferServiceRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type TransferServiceRestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | Unique identifier of the transfer. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferData](Models/TransferData.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTransfersIdError](Errors/GetTransfersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Transfer&gt; PostTransfers(string? idempotencyKey, string? wwwAuthenticate, TransferInfo? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

>Versions 1 and 2 of the Transfers API are deprecated. If you are just starting your implementation, use the latest version.

Starts a request to transfer funds to:
- [Balance accounts](https://docs.adyen.com/api-explorer/balanceplatform/latest/post/balanceAccounts)
- [Transfer instruments](https://docs.adyen.com/api-explorer/legalentity/latest/post/transferInstruments)
- [Third-party bank accounts](https://docs.adyen.com/payouts/payout-service/pay-out-to-bank-accounts)
- [Third-party cards](https://docs.adyen.com/payouts/payout-service/pay-out-to-cards)

Adyen sends the outcome of the transfer request through webhooks.

To use this endpoint:
- Your API credential must have the **TransferService Webservice Initiate** [role](https://docs.adyen.com/platforms/manage-access/webservice-roles/?tab=transfers_3).
- The account holder must have the required [capabilities](https://docs.adyen.com/platforms/verification-overview/capabilities).

Reach out to your Adyen contact to set up these permissions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transfers.PostTransfers(idempotencyKey, wwwAuthenticate, body);
    // TODO: Handle 'response' of type Transfer
}
catch (SdkException<PostTransfersError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>wwwAuthenticate</code> | <code>string?</code> | Header for authenticating through SCA |
| <code>body</code> | <code>[TransferInfo?](Models/TransferInfo.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Transfer](Models/Transfer.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostTransfersError](Errors/PostTransfersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;JsonElement&gt; PostTransfersApprove(string? idempotencyKey, string? wwwAuthenticate, ApproveTransfersRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Initiates the approval of a list of transfers that triggered an additional [review](https://docs.adyen.com/api-explorer/transfers/latest/post/transfers#request-review). Adyen sends the outcome of the approval request through webhooks.

To use this endpoint:
- Your API credential must have the **TransferService Approve** [role](https://docs.adyen.com/platforms/manage-access/webservice-roles/?tab=transfers_3).
- The account holder must have the required [capabilities](https://docs.adyen.com/platforms/verification-overview/capabilities).

Reach out to your Adyen contact to set up these permissions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transfers.PostTransfersApprove(idempotencyKey, wwwAuthenticate, body);
    // TODO: Handle 'response' of type JsonElement
}
catch (SdkException<PostTransfersApproveError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>wwwAuthenticate</code> | <code>string?</code> | Header for authenticating through SCA |
| <code>body</code> | <code>[ApproveTransfersRequest?](Models/ApproveTransfersRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>JsonElement</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostTransfersApproveError](Errors/PostTransfersApproveError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;JsonElement&gt; PostTransfersCancel(string? idempotencyKey, CancelTransfersRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Initiates the cancellation of a list of transfers that triggered an additional [review](https://docs.adyen.com/api-explorer/transfers/latest/post/transfers#request-review). Adyen sends the outcome of the cancel request through webhooks.

To use this endpoint:
- Your API credential must have the **TransferService Approve** [role](https://docs.adyen.com/platforms/manage-access/webservice-roles/?tab=transfers_3).
- The account holder must have the required [capabilities](https://docs.adyen.com/platforms/verification-overview/capabilities).

Reach out to your Adyen contact to set up these permissions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transfers.PostTransfersCancel(idempotencyKey, body);
    // TODO: Handle 'response' of type JsonElement
}
catch (SdkException<PostTransfersCancelError> ex)
{
    if (ex.Error.TryGetTransferServiceRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type TransferServiceRestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[CancelTransfersRequest?](Models/CancelTransfersRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>JsonElement</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostTransfersCancelError](Errors/PostTransfersCancelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ReturnTransferResponse&gt; PostTransfersTransferIdReturns(string transferId, string? idempotencyKey, ReturnTransferRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Initiates the return of previously transferred funds without creating a new `transferId`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transfers.PostTransfersTransferIdReturns(transferId, idempotencyKey, body);
    // TODO: Handle 'response' of type ReturnTransferResponse
}
catch (SdkException<PostTransfersTransferIdReturnsError> ex)
{
    if (ex.Error.TryGetTransferServiceRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type TransferServiceRestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>transferId</code> | <code>string</code> | The unique identifier of the transfer to be returned. |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[ReturnTransferRequest?](Models/ReturnTransferRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReturnTransferResponse](Models/ReturnTransferResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostTransfersTransferIdReturnsError](Errors/PostTransfersTransferIdReturnsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UsersCompanyLevel

> Source: [UsersCompanyLevel](Api/UsersCompanyLevel.cs)

<details>
<summary><code>Task&lt;ListCompanyUsersResponse&gt; GetCompaniesCompanyIdUsers(string companyId, int? pageNumber, int? pageSize, string? username, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of users for the `companyId` identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersCompanyLevel.GetCompaniesCompanyIdUsers(companyId, pageNumber, pageSize, username);
    // TODO: Handle 'response' of type ListCompanyUsersResponse
}
catch (SdkException<GetCompaniesCompanyIdUsersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>pageNumber</code> | <code>int?</code> | The number of the page to return. |
| <code>pageSize</code> | <code>int?</code> | The number of items to have on a page. Maximum value is **100**. The default is **10** items on a page. |
| <code>username</code> | <code>string?</code> | The partial or complete username to select all users that match. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCompanyUsersResponse](Models/ListCompanyUsersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdUsersError](Errors/GetCompaniesCompanyIdUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CompanyUser&gt; GetCompaniesCompanyIdUsersUserId(string companyId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns user details for the `userId` and the `companyId` identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersCompanyLevel.GetCompaniesCompanyIdUsersUserId(companyId, userId);
    // TODO: Handle 'response' of type CompanyUser
}
catch (SdkException<GetCompaniesCompanyIdUsersUserIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>userId</code> | <code>string</code> | The unique identifier of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CompanyUser](Models/CompanyUser.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdUsersUserIdError](Errors/GetCompaniesCompanyIdUsersUserIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CompanyUser&gt; PatchCompaniesCompanyIdUsersUserId(string companyId, string userId, UpdateCompanyUserRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates user details for the `userId` and the `companyId` identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersCompanyLevel.PatchCompaniesCompanyIdUsersUserId(companyId, userId, body);
    // TODO: Handle 'response' of type CompanyUser
}
catch (SdkException<PatchCompaniesCompanyIdUsersUserIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>userId</code> | <code>string</code> | The unique identifier of the user. |
| <code>body</code> | <code>[UpdateCompanyUserRequest?](Models/UpdateCompanyUserRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CompanyUser](Models/CompanyUser.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchCompaniesCompanyIdUsersUserIdError](Errors/PatchCompaniesCompanyIdUsersUserIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateCompanyUserResponse&gt; PostCompaniesCompanyIdUsers(string companyId, CreateCompanyUserRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates the user for the `companyId` identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersCompanyLevel.PostCompaniesCompanyIdUsers(companyId, body);
    // TODO: Handle 'response' of type CreateCompanyUserResponse
}
catch (SdkException<PostCompaniesCompanyIdUsersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>body</code> | <code>[CreateCompanyUserRequest?](Models/CreateCompanyUserRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateCompanyUserResponse](Models/CreateCompanyUserResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCompaniesCompanyIdUsersError](Errors/PostCompaniesCompanyIdUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UsersMerchantLevel

> Source: [UsersMerchantLevel](Api/UsersMerchantLevel.cs)

<details>
<summary><code>Task&lt;ListMerchantUsersResponse&gt; GetMerchantsMerchantIdUsers(string merchantId, int? pageNumber, int? pageSize, string? username, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of users associated with the `merchantId` specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersMerchantLevel.GetMerchantsMerchantIdUsers(merchantId,
        pageNumber,
        pageSize,
        username);
    // TODO: Handle 'response' of type ListMerchantUsersResponse
}
catch (SdkException<GetMerchantsMerchantIdUsersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | Unique identifier of the merchant. |
| <code>pageNumber</code> | <code>int?</code> | The number of the page to fetch. |
| <code>pageSize</code> | <code>int?</code> | The number of items to have on a page. Maximum value is **100**. The default is **10** items on a page. |
| <code>username</code> | <code>string?</code> | The partial or complete username to select all users that match. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListMerchantUsersResponse](Models/ListMerchantUsersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdUsersError](Errors/GetMerchantsMerchantIdUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;User&gt; GetMerchantsMerchantIdUsersUserId(string merchantId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns user details for the `userId` and the `merchantId` specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersMerchantLevel.GetMerchantsMerchantIdUsersUserId(merchantId, userId);
    // TODO: Handle 'response' of type User
}
catch (SdkException<GetMerchantsMerchantIdUsersUserIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | Unique identifier of the merchant. |
| <code>userId</code> | <code>string</code> | Unique identifier of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[User](Models/User.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdUsersUserIdError](Errors/GetMerchantsMerchantIdUsersUserIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;User&gt; PatchMerchantsMerchantIdUsersUserId(string merchantId, string userId, UpdateMerchantUserRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates user details for the `userId` and the `merchantId` specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersMerchantLevel.PatchMerchantsMerchantIdUsersUserId(merchantId, userId, body);
    // TODO: Handle 'response' of type User
}
catch (SdkException<PatchMerchantsMerchantIdUsersUserIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | Unique identifier of the merchant. |
| <code>userId</code> | <code>string</code> | Unique identifier of the user. |
| <code>body</code> | <code>[UpdateMerchantUserRequest?](Models/UpdateMerchantUserRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[User](Models/User.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchMerchantsMerchantIdUsersUserIdError](Errors/PatchMerchantsMerchantIdUsersUserIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateUserResponse&gt; PostMerchantsMerchantIdUsers(string merchantId, CreateMerchantUserRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a user for the `merchantId` specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersMerchantLevel.PostMerchantsMerchantIdUsers(merchantId, body);
    // TODO: Handle 'response' of type CreateUserResponse
}
catch (SdkException<PostMerchantsMerchantIdUsersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | Unique identifier of the merchant. |
| <code>body</code> | <code>[CreateMerchantUserRequest?](Models/CreateMerchantUserRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateUserResponse](Models/CreateUserResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsMerchantIdUsersError](Errors/PostMerchantsMerchantIdUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Utility

> Source: [Utility](Api/Utility.cs)

<details>
<summary><code>Task&lt;ApplePaySessionResponse&gt; PostApplePaySessions(string? idempotencyKey, ApplePaySessionRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

You need to use this endpoint if you have an API-only integration with Apple Pay which uses Adyen's Apple Pay certificate.

The endpoint returns the Apple Pay session data which you need to complete the [Apple Pay session validation](https://docs.adyen.com/payment-methods/apple-pay/api-only?tab=adyen-certificate-validation_1#complete-apple-pay-session-validation).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Utility.PostApplePaySessions(idempotencyKey, body);
    // TODO: Handle 'response' of type ApplePaySessionResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[ApplePaySessionRequest?](Models/ApplePaySessionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApplePaySessionResponse](Models/ApplePaySessionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UtilityResponse&gt; PostOriginKeys(string? idempotencyKey, UtilityRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This operation takes the origin domains and returns a JSON object containing the corresponding origin keys for the domains. 
> If you're still using origin key for your Web Drop-in or Components integration, we recommend [switching to client key](https://docs.adyen.com/development-resources/client-side-authentication/migrate-from-origin-key-to-client-key). This allows you to use a single key for all origins, add or remove origins without generating a new key, and detect the card type from the number entered in your payment form. 

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Utility.PostOriginKeys(idempotencyKey, body);
    // TODO: Handle 'response' of type UtilityResponse
}
catch (SdkException<PostOriginKeysError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[UtilityRequest?](Models/UtilityRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UtilityResponse](Models/UtilityResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostOriginKeysError](Errors/PostOriginKeysError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaypalUpdateOrderResponse&gt; PostPaypalUpdateOrder(string? idempotencyKey, PaypalUpdateOrderRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the order for PayPal Express Checkout. This can be used to update the PayPal lightbox with an updated amount and delivery methods based on the delivery address.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Utility.PostPaypalUpdateOrder(idempotencyKey, body);
    // TODO: Handle 'response' of type PaypalUpdateOrderResponse
}
catch (SdkException<PostPaypalUpdateOrderError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>idempotencyKey</code> | <code>string?</code> | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| <code>body</code> | <code>[PaypalUpdateOrderRequest?](Models/PaypalUpdateOrderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaypalUpdateOrderResponse](Models/PaypalUpdateOrderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPaypalUpdateOrderError](Errors/PostPaypalUpdateOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ValidateShopperIdResponse&gt; PostValidateShopperId(ValidateShopperIdRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Validates the shopperId.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Utility.PostValidateShopperId(body);
    // TODO: Handle 'response' of type ValidateShopperIdResponse
}
catch (SdkException<PostValidateShopperIdError> ex)
{
    if (ex.Error.TryGetCheckoutErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type CheckoutErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ValidateShopperIdRequest](Models/ValidateShopperIdRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ValidateShopperIdResponse](Models/ValidateShopperIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostValidateShopperIdError](Errors/PostValidateShopperIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Verification

> Source: [Verification](Api/Verification.cs)

<details>
<summary><code>Task&lt;GenericResponse&gt; PostCheckAccountHolder(PerformVerificationRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Triggers the verification of an account holder even if the checks are not yet required for the volume that they are currently processing.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Verification.PostCheckAccountHolder(body);
    // TODO: Handle 'response' of type GenericResponse
}
catch (SdkException<PostCheckAccountHolderError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[PerformVerificationRequest?](Models/PerformVerificationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericResponse](Models/GenericResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCheckAccountHolderError](Errors/PostCheckAccountHolderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericResponse&gt; PostDeleteBankAccounts(DeleteBankAccountRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes bank accounts associated with an account holder. 

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Verification.PostDeleteBankAccounts(body);
    // TODO: Handle 'response' of type GenericResponse
}
catch (SdkException<PostDeleteBankAccountsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeleteBankAccountRequest?](Models/DeleteBankAccountRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericResponse](Models/GenericResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostDeleteBankAccountsError](Errors/PostDeleteBankAccountsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericResponse&gt; PostDeleteLegalArrangements(DeleteLegalArrangementRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes legal arrangements and/or legal arrangement entities associated with an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Verification.PostDeleteLegalArrangements(body);
    // TODO: Handle 'response' of type GenericResponse
}
catch (SdkException<PostDeleteLegalArrangementsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeleteLegalArrangementRequest?](Models/DeleteLegalArrangementRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericResponse](Models/GenericResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostDeleteLegalArrangementsError](Errors/PostDeleteLegalArrangementsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericResponse&gt; PostDeletePayoutMethods(DeletePayoutMethodRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes payout methods associated with an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Verification.PostDeletePayoutMethods(body);
    // TODO: Handle 'response' of type GenericResponse
}
catch (SdkException<PostDeletePayoutMethodsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeletePayoutMethodRequest?](Models/DeletePayoutMethodRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericResponse](Models/GenericResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostDeletePayoutMethodsError](Errors/PostDeletePayoutMethodsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericResponse&gt; PostDeleteShareholders(DeleteShareholderRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes shareholders associated with an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Verification.PostDeleteShareholders(body);
    // TODO: Handle 'response' of type GenericResponse
}
catch (SdkException<PostDeleteShareholdersError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeleteShareholderRequest?](Models/DeleteShareholderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericResponse](Models/GenericResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostDeleteShareholdersError](Errors/PostDeleteShareholdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericResponse&gt; PostDeleteSignatories(DeleteSignatoriesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes signatories associated with an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Verification.PostDeleteSignatories(body);
    // TODO: Handle 'response' of type GenericResponse
}
catch (SdkException<PostDeleteSignatoriesError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeleteSignatoriesRequest?](Models/DeleteSignatoriesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericResponse](Models/GenericResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostDeleteSignatoriesError](Errors/PostDeleteSignatoriesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetUploadedDocumentsResponse&gt; PostGetUploadedDocuments(GetUploadedDocumentsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns documents that were previously uploaded for an account holder. Adyen uses the documents during the [verification process](https://docs.adyen.com/classic-platforms/verification-process).


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Verification.PostGetUploadedDocuments(body);
    // TODO: Handle 'response' of type GetUploadedDocumentsResponse
}
catch (SdkException<PostGetUploadedDocumentsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GetUploadedDocumentsRequest?](Models/GetUploadedDocumentsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetUploadedDocumentsResponse](Models/GetUploadedDocumentsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostGetUploadedDocumentsError](Errors/PostGetUploadedDocumentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateAccountHolderResponse&gt; PostUploadDocument(UploadDocumentRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads a document for an account holder. Adyen uses the documents during the [verification process](https://docs.adyen.com/classic-platforms/verification-process).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Verification.PostUploadDocument(body);
    // TODO: Handle 'response' of type UpdateAccountHolderResponse
}
catch (SdkException<PostUploadDocumentError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[UploadDocumentRequest?](Models/UploadDocumentRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateAccountHolderResponse](Models/UpdateAccountHolderResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostUploadDocumentError](Errors/PostUploadDocumentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## WebhooksCompanyLevel

> Source: [WebhooksCompanyLevel](Api/WebhooksCompanyLevel.cs)

<details>
<summary><code>Task DeleteCompaniesCompanyIdWebhooksWebhookId(string companyId, string webhookId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove the configuration for the webhook identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.WebhooksCompanyLevel.DeleteCompaniesCompanyIdWebhooksWebhookId(companyId, webhookId);
}
catch (SdkException<DeleteCompaniesCompanyIdWebhooksWebhookIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>webhookId</code> | <code>string</code> | Unique identifier of the webhook configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteCompaniesCompanyIdWebhooksWebhookIdError](Errors/DeleteCompaniesCompanyIdWebhooksWebhookIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListWebhooksResponse&gt; GetCompaniesCompanyIdWebhooks(string companyId, int? pageNumber, int? pageSize, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all webhook configurations for the company account.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksCompanyLevel.GetCompaniesCompanyIdWebhooks(companyId, pageNumber, pageSize);
    // TODO: Handle 'response' of type ListWebhooksResponse
}
catch (SdkException<GetCompaniesCompanyIdWebhooksError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | Unique identifier of the [company account](https://docs.adyen.com/account/account-structure#company-account). |
| <code>pageNumber</code> | <code>int?</code> | The number of the page to fetch. |
| <code>pageSize</code> | <code>int?</code> | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListWebhooksResponse](Models/ListWebhooksResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdWebhooksError](Errors/GetCompaniesCompanyIdWebhooksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Webhook&gt; GetCompaniesCompanyIdWebhooksWebhookId(string companyId, string webhookId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the configuration for the webhook identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksCompanyLevel.GetCompaniesCompanyIdWebhooksWebhookId(companyId, webhookId);
    // TODO: Handle 'response' of type Webhook
}
catch (SdkException<GetCompaniesCompanyIdWebhooksWebhookIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | Unique identifier of the [company account](https://docs.adyen.com/account/account-structure#company-account). |
| <code>webhookId</code> | <code>string</code> | Unique identifier of the webhook configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Webhook](Models/Webhook.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCompaniesCompanyIdWebhooksWebhookIdError](Errors/GetCompaniesCompanyIdWebhooksWebhookIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Webhook&gt; PatchCompaniesCompanyIdWebhooksWebhookId(string companyId, string webhookId, UpdateCompanyWebhookRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Make changes to the configuration of the webhook identified in the path. The request contains the new values you want to have in the webhook configuration. The response contains the full configuration for the webhook, which includes the new values from the request.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksCompanyLevel.PatchCompaniesCompanyIdWebhooksWebhookId(companyId,
        webhookId,
        body);
    // TODO: Handle 'response' of type Webhook
}
catch (SdkException<PatchCompaniesCompanyIdWebhooksWebhookIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>webhookId</code> | <code>string</code> | Unique identifier of the webhook configuration. |
| <code>body</code> | <code>[UpdateCompanyWebhookRequest?](Models/UpdateCompanyWebhookRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Webhook](Models/Webhook.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchCompaniesCompanyIdWebhooksWebhookIdError](Errors/PatchCompaniesCompanyIdWebhooksWebhookIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Webhook&gt; PostCompaniesCompanyIdWebhooks(string companyId, CreateCompanyWebhookRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Subscribe to receive webhook notifications about events related to your company account. You can add basic authentication to make sure the data is secure.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksCompanyLevel.PostCompaniesCompanyIdWebhooks(companyId, body);
    // TODO: Handle 'response' of type Webhook
}
catch (SdkException<PostCompaniesCompanyIdWebhooksError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | Unique identifier of the [company account](https://docs.adyen.com/account/account-structure#company-account). |
| <code>body</code> | <code>[CreateCompanyWebhookRequest?](Models/CreateCompanyWebhookRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Webhook](Models/Webhook.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCompaniesCompanyIdWebhooksError](Errors/PostCompaniesCompanyIdWebhooksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenerateHmacKeyResponse&gt; PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmac(string companyId, string webhookId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an [HMAC key](https://en.wikipedia.org/wiki/HMAC) for the webhook identified in the path. This key allows you to check the integrity and the origin of the notifications you receive.By creating an HMAC key, you start receiving [HMAC-signed notifications](https://docs.adyen.com/development-resources/webhooks/verify-hmac-signatures#enable-hmac-signatures) from Adyen. Find out more about how to [verify HMAC signatures](https://docs.adyen.com/development-resources/webhooks/verify-hmac-signatures).

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksCompanyLevel.PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmac(companyId,
        webhookId);
    // TODO: Handle 'response' of type GenerateHmacKeyResponse
}
catch (SdkException<PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmacError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>webhookId</code> | <code>string</code> | Unique identifier of the webhook configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateHmacKeyResponse](Models/GenerateHmacKeyResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmacError](Errors/PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmacError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TestWebhookResponse&gt; PostCompaniesCompanyIdWebhooksWebhookIdTest(string companyId, string webhookId, TestCompanyWebhookRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends sample notifications to test if the webhook is set up correctly.

We send sample notifications for maximum 20 of the merchant accounts that the webhook is configured for. If the webhook is configured for more than 20 merchant accounts, use the `merchantIds` array to specify a subset of the merchant accounts for which to send test notifications.

We send four test notifications for each event code you choose. They cover success and failure scenarios for the hard-coded currencies EUR and GBP, regardless of the currencies configured in the merchant accounts. For custom notifications, we only send the specified custom notification.

The response describes the result of the test. The `status` field tells you if the test was successful or not. You can use the other response fields to troubleshoot unsuccessful tests.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksCompanyLevel.PostCompaniesCompanyIdWebhooksWebhookIdTest(companyId,
        webhookId,
        body);
    // TODO: Handle 'response' of type TestWebhookResponse
}
catch (SdkException<PostCompaniesCompanyIdWebhooksWebhookIdTestError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>companyId</code> | <code>string</code> | The unique identifier of the company account. |
| <code>webhookId</code> | <code>string</code> | Unique identifier of the webhook configuration. |
| <code>body</code> | <code>[TestCompanyWebhookRequest?](Models/TestCompanyWebhookRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TestWebhookResponse](Models/TestWebhookResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCompaniesCompanyIdWebhooksWebhookIdTestError](Errors/PostCompaniesCompanyIdWebhooksWebhookIdTestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## WebhooksMerchantLevel

> Source: [WebhooksMerchantLevel](Api/WebhooksMerchantLevel.cs)

<details>
<summary><code>Task DeleteMerchantsMerchantIdWebhooksWebhookId(string merchantId, string webhookId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove the configuration for the webhook identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.WebhooksMerchantLevel.DeleteMerchantsMerchantIdWebhooksWebhookId(merchantId, webhookId);
}
catch (SdkException<DeleteMerchantsMerchantIdWebhooksWebhookIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>webhookId</code> | <code>string</code> | Unique identifier of the webhook configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteMerchantsMerchantIdWebhooksWebhookIdError](Errors/DeleteMerchantsMerchantIdWebhooksWebhookIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListWebhooksResponse&gt; GetMerchantsMerchantIdWebhooks(string merchantId, int? pageNumber, int? pageSize, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all webhook configurations for the merchant account.

> This call does not return webhook configurations for the company account to which the specified merchant account belongs. You can see these in your Customer Area under **Developers** > **Webhooks**.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksMerchantLevel.GetMerchantsMerchantIdWebhooks(merchantId, pageNumber, pageSize);
    // TODO: Handle 'response' of type ListWebhooksResponse
}
catch (SdkException<GetMerchantsMerchantIdWebhooksError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>pageNumber</code> | <code>int?</code> | The number of the page to fetch. |
| <code>pageSize</code> | <code>int?</code> | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListWebhooksResponse](Models/ListWebhooksResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdWebhooksError](Errors/GetMerchantsMerchantIdWebhooksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Webhook&gt; GetMerchantsMerchantIdWebhooksWebhookId(string merchantId, string webhookId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the configuration for the webhook identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksMerchantLevel.GetMerchantsMerchantIdWebhooksWebhookId(merchantId, webhookId);
    // TODO: Handle 'response' of type Webhook
}
catch (SdkException<GetMerchantsMerchantIdWebhooksWebhookIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>webhookId</code> | <code>string</code> | Unique identifier of the webhook configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Webhook](Models/Webhook.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantsMerchantIdWebhooksWebhookIdError](Errors/GetMerchantsMerchantIdWebhooksWebhookIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Webhook&gt; PatchMerchantsMerchantIdWebhooksWebhookId(string merchantId, string webhookId, UpdateMerchantWebhookRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Make changes to the configuration of the webhook identified in the path. The request contains the new values you want to have in the webhook configuration. The response contains the full configuration for the webhook, which includes the new values from the request.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksMerchantLevel.PatchMerchantsMerchantIdWebhooksWebhookId(merchantId,
        webhookId,
        body);
    // TODO: Handle 'response' of type Webhook
}
catch (SdkException<PatchMerchantsMerchantIdWebhooksWebhookIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>webhookId</code> | <code>string</code> | Unique identifier of the webhook configuration. |
| <code>body</code> | <code>[UpdateMerchantWebhookRequest?](Models/UpdateMerchantWebhookRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Webhook](Models/Webhook.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchMerchantsMerchantIdWebhooksWebhookIdError](Errors/PatchMerchantsMerchantIdWebhooksWebhookIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Webhook&gt; PostMerchantsMerchantIdWebhooks(string merchantId, CreateMerchantWebhookRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Subscribe to receive webhook notifications about events related to your merchant account. You can add basic authentication to make sure the data is secure.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksMerchantLevel.PostMerchantsMerchantIdWebhooks(merchantId, body);
    // TODO: Handle 'response' of type Webhook
}
catch (SdkException<PostMerchantsMerchantIdWebhooksError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>body</code> | <code>[CreateMerchantWebhookRequest?](Models/CreateMerchantWebhookRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Webhook](Models/Webhook.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsMerchantIdWebhooksError](Errors/PostMerchantsMerchantIdWebhooksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenerateHmacKeyResponse&gt; PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmac(string merchantId, string webhookId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an [HMAC key](https://en.wikipedia.org/wiki/HMAC) for the webhook identified in the path. This key allows you to check the integrity and the origin of the notifications you receive.By creating an HMAC key, you start receiving [HMAC-signed notifications](https://docs.adyen.com/development-resources/webhooks/verify-hmac-signatures#enable-hmac-signatures) from Adyen. Find out more about how to [verify HMAC signatures](https://docs.adyen.com/development-resources/webhooks/verify-hmac-signatures).

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksMerchantLevel.PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmac(merchantId,
        webhookId);
    // TODO: Handle 'response' of type GenerateHmacKeyResponse
}
catch (SdkException<PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>webhookId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateHmacKeyResponse](Models/GenerateHmacKeyResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacError](Errors/PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TestWebhookResponse&gt; PostMerchantsMerchantIdWebhooksWebhookIdTest(string merchantId, string webhookId, TestWebhookRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends sample notifications to test if the webhook is set up correctly.

We send four test notifications for each event code you choose. They cover success and failure scenarios for the hard-coded currencies EUR and GBP, regardless of the currencies configured in the merchant accounts. For custom notifications, we only send the specified custom notification.

The response describes the result of the test. The `status` field tells you if the test was successful or not. You can use the other fields to troubleshoot unsuccessful tests.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksMerchantLevel.PostMerchantsMerchantIdWebhooksWebhookIdTest(merchantId,
        webhookId,
        body);
    // TODO: Handle 'response' of type TestWebhookResponse
}
catch (SdkException<PostMerchantsMerchantIdWebhooksWebhookIdTestError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>merchantId</code> | <code>string</code> | The unique identifier of the merchant account. |
| <code>webhookId</code> | <code>string</code> | Unique identifier of the webhook configuration. |
| <code>body</code> | <code>[TestWebhookRequest?](Models/TestWebhookRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TestWebhookResponse](Models/TestWebhookResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostMerchantsMerchantIdWebhooksWebhookIdTestError](Errors/PostMerchantsMerchantIdWebhooksWebhookIdTestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## IDealProfiles

> Source: [IDealProfiles](Api/IDealProfiles.cs)

<details>
<summary><code>Task&lt;IdealAuthLinkResponse&gt; PostIdealProfileAuthLink(IdealAuthLinkRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Manage an already registered iDEAL profile. Generates a redirection URL to manage the iDEAL profile linked to the account holder from the request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IDealProfiles.PostIdealProfileAuthLink(body);
    // TODO: Handle 'response' of type IdealAuthLinkResponse
}
catch (SdkException<PostIdealProfileAuthLinkError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[IdealAuthLinkRequest](Models/IdealAuthLinkRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IdealAuthLinkResponse](Models/IdealAuthLinkResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostIdealProfileAuthLinkError](Errors/PostIdealProfileAuthLinkError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IdealAuthenticateResponse&gt; PostIdealProfileAuthenticate(IdealAuthenticateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generates an redirection URL to finish the authentication flow when requested by iDEAL. Before calling this endpoint, make sure that your user has completed multi-factor authentication.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IDealProfiles.PostIdealProfileAuthenticate(body);
    // TODO: Handle 'response' of type IdealAuthenticateResponse
}
catch (SdkException<PostIdealProfileAuthenticateError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[IdealAuthenticateRequest](Models/IdealAuthenticateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IdealAuthenticateResponse](Models/IdealAuthenticateResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostIdealProfileAuthenticateError](Errors/PostIdealProfileAuthenticateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProfileRegistrationResponse&gt; PostIdealProfileRegister(ProfileRegistrationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Register a new iDEAL profile. The profile is linked to the account holder and payment instruments included in the request. The user must be redirected to the URL in the response to finish their IDEAL profile registration.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IDealProfiles.PostIdealProfileRegister(body);
    // TODO: Handle 'response' of type ProfileRegistrationResponse
}
catch (SdkException<PostIdealProfileRegisterError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ProfileRegistrationRequest](Models/ProfileRegistrationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProfileRegistrationResponse](Models/ProfileRegistrationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostIdealProfileRegisterError](Errors/PostIdealProfileRegisterError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

