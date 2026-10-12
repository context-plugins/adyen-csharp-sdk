using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Api;
using Adyen.Core;
using Adyen.Core.Authentication;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Exceptions;
using Adyen.Core.Logging;
using Adyen.Core.Models;
using Adyen.Core.Request;
using Adyen.Core.Response;
using Adyen.Models;
using Adyen.Requests;

namespace Adyen;

/// <summary>
/// Adyen Checkout API provides a simple and flexible way to initiate and authorise online payments. You can use the same integration for payments made with cards (including 3D Secure), mobile wallets, and local payment methods (for example, iDEAL and Sofort).
/// <para>
/// This API reference provides information on available endpoints and how to interact with them. To learn more about the API, visit <see href="https://docs.adyen.com/online-payments">online payments documentation</see>.
/// </para>
/// <para>
/// ## Authentication
/// Each request to Checkout API must be signed with an API key. For this, <see href="https://docs.adyen.com/development-resources/api-credentials#generate-api-key">get your API key</see> from your Customer Area, and set this key to the <c>X-API-Key</c> header value, for example:
/// </para>
/// <para>
/// <code>
/// curl
/// -H "Content-Type: application/json" \
/// -H "X-API-Key: YOUR_API_KEY" \
/// ...
/// </code>
/// ## Versioning
/// Checkout API supports <see href="https://docs.adyen.com/development-resources/versioning">versioning</see> using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.
/// </para>
/// <para>
/// For example:
/// <code>
/// https://checkout-test.adyen.com/v72/payments
/// </code>
/// </para>
/// <para>
/// ## Server-side API libraries
/// We provide open-source <see href="https://docs.adyen.com/development-resources/libraries/">server-side API libraries</see> in several languages:
/// - PHP
/// - Java
/// - Node.js
/// - .NET
/// - Go
/// - Python
/// - Ruby
/// - Apex (beta)
/// </para>
/// <para>
/// See our <see href="https://github.com/adyen-examples#%EF%B8%8F-official-integration-examples">integration examples</see> for example uses of the libraries.
/// </para>
/// <para>
/// ## Developer resources
/// Checkout API is available through a Postman collection. Click the button below to create a fork, then set the environment variables at <b>Environments</b>&amp;nbsp;&gt;&amp;nbsp;<b>Adyen&amp;nbsp;APIs</b>.
/// </para>
/// <para>
/// <see href="https://run.pstmn.io/button.svg">![Run in Postman</see>](https://god.gw.postman.com/run-collection/25716737-46ad970e-dc9e-4246-bac2-769c6083e7b5?action=collection%2Ffork&amp;source=rip_markdown&amp;collection-url=entityId%3D25716737-46ad970e-dc9e-4246-bac2-769c6083e7b5%26entityType%3Dcollection%26workspaceId%3Da8d63f9f-cfc7-4810-90c5-9e0c60030d3e#?env%5BAdyen%20APIs%5D=W3sia2V5IjoiWC1BUEktS2V5IiwidmFsdWUiOiIiLCJlbmFibGVkIjp0cnVlLCJ0eXBlIjoic2VjcmV0In0seyJrZXkiOiJZT1VSX01FUkNIQU5UX0FDQ09VTlQiLCJ2YWx1ZSI6IiIsImVuYWJsZWQiOnRydWUsInR5cGUiOiJkZWZhdWx0In0seyJrZXkiOiJZT1VSX0NPTVBBTllfQUNDT1VOVCIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifSx7ImtleSI6IllPVVJfQkFMQU5DRV9QTEFURk9STSIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifV0=)
/// </para>
/// <para>
///
/// ## Going live
/// </para>
/// <para>
/// To access the live endpoints, you need an API key from your live Customer Area.
/// </para>
/// <para>
/// The live endpoint URLs contain a prefix which is unique to your company account, for example:
/// <code>
/// https://{PREFIX}-checkout-live.adyenpayments.com/checkout/v72/payments
/// </code>
/// </para>
/// <para>
/// Get your <c>{PREFIX}</c> from your live Customer Area under <b>Developers</b> &gt; <b>API URLs</b> &gt; <b>Prefix</b>.
/// </para>
/// <para>
/// When preparing to do live transactions with Checkout API, follow the <see href="https://docs.adyen.com/online-payments/go-live-checklist">go-live checklist</see> to make sure you've got all the required configuration in place.
/// </para>
/// <para>
/// ## Release notes
/// Have a look at the <see href="https://docs.adyen.com/online-payments/release-notes?integration_type=api&amp;version=72">release notes</see> to find out what changed in this version!, A set of API endpoints that allow you to initiate, settle, and modify payments on the Adyen payments platform. You can use the API to accept card payments (including One-Click and 3D Secure), bank transfers, ewallets, and many other payment methods.
/// </para>
/// <para>
/// &gt; This API is <see href="https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle">inactive</see>.
/// &gt; * If you are building a new integration, use the <see href="https://docs.adyen.com/api-explorer/Checkout/latest/overview">Checkout API</see> instead.
/// &gt; * If you have an existing integration using this API, reach out to your Adyen contact and <see href="https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api">migrate to the Checkout API</see>.
/// &gt;The Checkout API enables your <see href="https://docs.adyen.com/online-payments">online payments</see> integration to accept all supported payment methods, use the latest features, and access more benefits.
/// </para>
/// <para>
/// To learn more about the API, visit <see href="https://docs.adyen.com/classic-integration">Classic integration</see>.
/// </para>
/// <para>
/// ## Authentication
/// You need an <see href="https://docs.adyen.com/development-resources/api-credentials">API credential</see> to authenticate to the API.
/// </para>
/// <para>
/// If using an API key, add an <c>X-API-Key</c> header with the API key as the value, for example:
/// </para>
/// <para>
///  ```
/// curl
/// -H "Content-Type: application/json" \
/// -H "X-API-Key: YOUR_API_KEY" \
/// ...
/// <code>
/// </para>
/// <para>
/// Alternatively, you can use the username and password to connect to the API using basic authentication, for example:
/// </para>
/// <code>
/// curl
/// -u "ws@Company.YOUR_COMPANY_ACCOUNT":"YOUR_BASIC_AUTHENTICATION_PASSWORD" \
/// -H "Content-Type: application/json" \
/// ...
/// </code>
/// <para>
/// ## Versioning
/// Payments API supports <see href="https://docs.adyen.com/development-resources/versioning">versioning</see> using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.
/// </para>
/// <para>
/// For example:
/// <code>
/// https://pal-test.adyen.com/pal/servlet/Payment/v68/authorise
/// </code>
/// </para>
/// <para>
/// ## Going live
/// </para>
/// <para>
/// To authenticate to the live endpoints, you need an <see href="https://docs.adyen.com/development-resources/api-credentials">API credential</see> from your live Customer Area.
/// </para>
/// <para>
/// The live endpoint URLs contain a prefix which is unique to your company account:
/// <code>
/// </para>
/// <para>
/// https://{PREFIX}-pal-live.adyenpayments.com/pal/servlet/Payment/v68/authorise
/// <code>
/// </para>
/// <para>
/// Get your <c>{PREFIX}</c> from your live Customer Area under <b>Developers</b> &gt; <b>API URLs</b> &gt; <b>Prefix</b>., &gt; The Recurring API is a legacy API for managing tokens. We strongly recommend to use <see href="https://docs.adyen.com/api-explorer/Checkout/71/post/storedPaymentMethods">Checkout API recurring endpoints</see> instead when possible.
/// </para>
/// <para>
/// The Recurring API allows you to manage and remove your tokens or stored payment details. Tokens should be created with validation during a payment request.
/// </para>
/// <para>
/// For more information, refer to our <see href="https://docs.adyen.com/online-payments/tokenization">Tokenization documentation</see>.
/// ## Authentication
/// You need an <see href="https://docs.adyen.com/development-resources/api-credentials">API credential</see> to authenticate to the API.
/// </para>
/// <para>
/// If using an API key, add an <c>X-API-Key</c> header with the API key as the value, for example:
/// </para>
/// <para>
///  ```
/// curl
/// -H "Content-Type: application/json" \
/// -H "X-API-Key: YOUR_API_KEY" \
/// ...
/// <code>
/// </para>
/// <para>
/// Alternatively, you can use the username and password to connect to the API using basic authentication, for example:
/// </para>
/// <code>
/// curl
/// -u "ws@Company.YOUR_COMPANY_ACCOUNT":"YOUR_BASIC_AUTHENTICATION_PASSWORD" \
/// -H "Content-Type: application/json" \
/// ...
/// </code>
/// <para>
/// ## Versioning
/// Recurring API supports <see href="https://docs.adyen.com/development-resources/versioning">versioning</see> using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.
/// </para>
/// <para>
/// For example:
/// <code>
/// https://pal-test.adyen.com/pal/servlet/Recurring/v68/disable
/// </code>
/// </para>
/// <para>
/// ## Server-side API libraries
/// We provide open-source <see href="https://docs.adyen.com/development-resources/libraries/">server-side API libraries</see> in several languages:
/// - PHP
/// - Java
/// - Node.js
/// - .NET
/// - Go
/// - Python
/// - Ruby
/// - Apex (beta)
/// </para>
/// <para>
/// See our <see href="https://github.com/adyen-examples#%EF%B8%8F-official-integration-examples">integration examples</see> for example uses of the libraries.
/// </para>
/// <para>
/// ## Developer resources
/// Recurring API is available through a Postman collection. Click the button below to create a fork, then set the environment variables at <b>Environments</b>&amp;nbsp;&gt;&amp;nbsp;<b>Adyen&amp;nbsp;APIs</b>.
/// </para>
/// <para>
/// <see href="https://run.pstmn.io/button.svg">![Run in Postman</see>](https://god.gw.postman.com/run-collection/25716737-0d1ef0da-f5a1-4004-b24a-c5152c51dc7b?action=collection%2Ffork&amp;source=rip_markdown&amp;collection-url=entityId%3D25716737-0d1ef0da-f5a1-4004-b24a-c5152c51dc7b%26entityType%3Dcollection%26workspaceId%3Da8d63f9f-cfc7-4810-90c5-9e0c60030d3e#?env%5BAdyen%20APIs%5D=W3sia2V5IjoiWC1BUEktS2V5IiwidmFsdWUiOiIiLCJlbmFibGVkIjp0cnVlLCJ0eXBlIjoic2VjcmV0In0seyJrZXkiOiJZT1VSX01FUkNIQU5UX0FDQ09VTlQiLCJ2YWx1ZSI6IiIsImVuYWJsZWQiOnRydWUsInR5cGUiOiJkZWZhdWx0In0seyJrZXkiOiJZT1VSX0NPTVBBTllfQUNDT1VOVCIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifSx7ImtleSI6IllPVVJfQkFMQU5DRV9QTEFURk9STSIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifV0=)
/// </para>
/// <para>
///
/// ## Going live
/// </para>
/// <para>
/// To authenticate to the live endpoints, you need an <see href="https://docs.adyen.com/development-resources/api-credentials">API credential</see> from your live Customer Area.
/// </para>
/// <para>
/// The live endpoint URLs contain a prefix which is unique to your company account:
/// <code>
/// </para>
/// <para>
/// https://{PREFIX}-pal-live.adyenpayments.com/pal/servlet/Recurring/v68/disable
/// <code>
/// </para>
/// <para>
/// Get your <c>{PREFIX}</c> from your live Customer Area under <b>Developers</b> &gt; <b>API URLs</b> &gt; <b>Prefix</b>., &gt; The <b>Payout API is deprecated</b> and no longer supports new integrations. Do one of the following:
/// &gt;- If you are building a new integration, use the <see href="https://docs.adyen.com/api-explorer/transfers/latest/overview">Transfers API</see> instead.
/// &gt; - If you are already using the Payout API, reach out to your Adyen contact to learn how to migrate to the Transfers API.
/// &gt;
/// &gt; With the Transfers API, you can:
/// &gt; - Handle multiple payout use cases with a single API.
/// &gt; - Use new payout functionalities, such as instant payouts to bank accounts.
/// &gt; - Receive webhooks with more details and defined transfer states.
/// &gt;
/// &gt; For more information about the payout features of the Transfers API, see our <see href="https://docs.adyen.com/payouts/payout-service">Payouts</see> documentation.
/// </para>
/// <para>
///
/// A set of API endpoints that allow you to store payout details, confirm, or decline a payout.
/// </para>
/// <para>
/// For more information, refer to <see href="https://docs.adyen.com/online-payments/online-payouts">Online payouts</see>.
/// ## Authentication
/// To use the Payout API, you need to have <see href="https://docs.adyen.com/online-payments/online-payouts#payouts-to-bank-accounts-and-wallets">two API credentials</see>: one for storing payout details and submitting payouts, and another one for confirming or declining payouts. If you don't have the required API credentials, contact our <see href="https://www.adyen.help/hc/en-us/requests/new">Support Team</see>.
/// </para>
/// <para>
/// If using an API key, add an <c>X-API-Key</c> header with the API key as the value, for example:
/// </para>
/// <para>
///  ```
/// curl
/// -H "Content-Type: application/json" \
/// -H "X-API-Key: YOUR_API_KEY" \
/// ...
/// <code>
/// </para>
/// <para>
/// Alternatively, you can use the username and password to connect to the API using <see href="https://docs.adyen.com/development-resources/api-credentials#basic-authentication">basic authentication</see>.
/// </para>
/// <para>
/// The following example shows how to authenticate your request with basic authentication when submitting a payout:
/// </para>
/// <code>
/// curl
/// -u "storePayout@Company.YOUR_COMPANY_ACCOUNT":"YOUR_BASIC_AUTHENTICATION_PASSWORD" \
/// -H "Content-Type: application/json" \
/// ...
/// </code>
/// <para>
/// ## Versioning
/// Payout API supports <see href="https://docs.adyen.com/development-resources/versioning">versioning</see> using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.
/// </para>
/// <para>
/// For example:
/// <code>
/// https://pal-test.adyen.com/pal/servlet/Payout/v68/payout
/// </code>
/// </para>
/// <para>
/// ## Going live
/// </para>
/// <para>
/// To authenticate to the live endpoints, you need <see href="https://docs.adyen.com/development-resources/api-credentials">API credentials</see> from your live Customer Area.
/// </para>
/// <para>
/// The live endpoint URLs contain a prefix which is unique to your company account:
/// <code>
/// </para>
/// <para>
/// https://{PREFIX}-pal-live.adyenpayments.com/pal/servlet/Payout/v68/payout
/// <code>
/// </para>
/// <para>
/// Get your <c>{PREFIX}</c> from your live Customer Area under <b>Developers</b> &gt; <b>API URLs</b> &gt; <b>Prefix</b>., The BIN Lookup API provides endpoints for retrieving information, such as cost estimates, and 3D Secure supported version based on a given BIN.
/// </para>
/// <para>
/// ## Authentication
/// You need an <see href="https://docs.adyen.com/development-resources/api-credentials">API credential</see> to authenticate to the API.
/// </para>
/// <para>
/// If using an API key, add an <c>X-API-Key</c> header with the API key as the value, for example:
/// </para>
/// <para>
///  ```
/// curl
/// -H "Content-Type: application/json" \
/// -H "X-API-Key: YOUR_API_KEY" \
/// ...
/// <code>
/// </para>
/// <para>
/// Alternatively, you can use the username and password to connect to the API using basic authentication, for example:
/// </para>
/// <code>
/// curl
/// -u "ws@Company.YOUR_COMPANY_ACCOUNT":"YOUR_BASIC_AUTHENTICATION_PASSWORD" \
/// -H "Content-Type: application/json" \
/// ...
/// </code>
/// <para>
/// ## Versioning
/// The BinLookup API supports <see href="https://docs.adyen.com/development-resources/versioning">versioning</see> using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.
/// </para>
/// <para>
/// For example:
/// <code>
/// https://pal-test.adyen.com/pal/servlet/BinLookup/v54/get3dsAvailability
/// </code>
/// </para>
/// <para>
/// ## Going live
/// </para>
/// <para>
/// To authenticate to the live endpoints, you need an <see href="https://docs.adyen.com/development-resources/api-credentials">API credential</see> from your live Customer Area.
/// </para>
/// <para>
/// The live endpoint URLs contain a prefix which is unique to your company account:
/// <code>
/// </para>
/// <para>
/// https://{PREFIX}-pal-live.adyenpayments.com/pal/servlet/BinLookup/v54/get3dsAvailability
/// <code>
/// </para>
/// <para>
/// Get your <c>{PREFIX}</c> from your live Customer Area under <b>Developers</b> &gt; <b>API URLs</b> &gt; <b>Prefix</b>., A set of API endpoints to manage stored value products., Adyen Data Protection API provides a way for you to process <see href="https://gdpr-info.eu/art-17-gdpr/">Subject Erasure Requests</see> as mandated in GDPR.
/// </para>
/// <para>
/// Use our API to submit a request to delete shopper's data, including payment details and other related information (for example, delivery address or shopper email).## Authentication
/// Each request to the Data Protection API must be signed with an API key. Get your API Key from your Customer Area, as described in <see href="https://docs.adyen.com/development-resources/api-credentials#generate-api-key">How to get the API key</see>. Then set this key to the <c>X-API-Key</c> header value, for example:
/// </para>
/// <para>
/// <code>
/// curl
/// -H "Content-Type: application/json" \
/// -H "X-API-Key: Your_API_key" \
/// ...
/// </code>
/// Note that when going live, you need to generate a new API Key to access the <see href="https://docs.adyen.com/development-resources/live-endpoints">live endpoints</see>.
/// </para>
/// <para>
/// ## Versioning
/// Data Protection Service API supports <see href="https://docs.adyen.com/development-resources/versioning">versioning</see> using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.
/// </para>
/// <para>
/// For example:
/// <code>
/// https://ca-test.adyen.com/ca/services/DataProtectionService/v1/requestSubjectErasure
/// </code>
/// ## Authentication
/// We recommend that you use an API key to connect to the Foreign Exchange API. You can generate an API key in your Customer Area. If you have an Adyen Issuing integration, generate an API key in your Balance Platform Customer Area.
/// ### Credential format
/// * For the <c>rates/calculate</c> endpoint: Generate an API key for the credential with the format <b>ws@BalancePlatform.[YourBalancePlatform]</b>.
/// </para>
/// <para>
/// ### Header format
/// To connect to the Foreign Exchange API, add an <c>X-API-Key</c> header with the API key as the value, for example:
/// </para>
/// <para>
///  ```
/// curl
/// -H 'Content-Type: application/json' \
/// -H 'X-API-Key: ADYEN_API_KEY' \
/// ...
/// <code>
/// </para>
/// <para>
/// ## Versioning
/// </para>
/// <para>
/// The Foreign Exchange API supports <see href="https://docs.adyen.com/development-resources/versioning">versioning</see> using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.
/// </para>
/// <para>
/// For example:
/// </para>
/// <para>
/// https://balanceplatform-api-test.adyen.com/fx/v1/rates/calculate
/// </para>
/// <para>
/// ## Going live
/// When going live, generate an API key in your <see href="https://ca-live.adyen.com/ca/">live Customer Area</see>. If you have an Adyen Issuing integration, <see href="https://docs.adyen.com/issuing/manage-access/api-credentials-web-service/#generate-api-key">generate an API key</see> in your <see href="https://balanceplatform-live.adyen.com/balanceplatform/">live Balance Platform Customer Area</see>. You can then use the API key to send requests to <c>https://balanceplatform-api-test.adyen.com/fx/v1</c>., The Test Cards API provides endpoints for generating custom test card numbers. For more information, refer to <see href="https://docs.adyen.com/development-resources/testing/create-test-cards">Custom test cards</see> documentation., Configure and manage your Adyen company and merchant accounts, stores, and payment terminals.
/// ## Authentication
/// Each request to the Management API must be signed with an API key. <see href="https://docs.adyen.com/development-resources/api-credentials#generate-api-key">Generate your API key</see> in the Customer Area and then set this key to the <c>X-API-Key</c> header value.
/// </para>
/// <para>
/// To access the live endpoints, you need to generate a new API key in your live Customer Area.
/// ## Versioning
/// </para>
/// <para>
/// Management API handles versioning as part of the endpoint URL. For example, to send a request to this version of the <c>/companies/{companyId}/webhooks</c> endpoint, use:
/// </para>
/// <code>
/// https://management-test.adyen.com/v3/companies/{companyId}/webhooks
/// </code>
/// <para>
/// ## Going live
/// </para>
/// <para>
/// To access the live endpoints, you need an API key from your live Customer Area. Use this API key to make requests to:
/// </para>
/// <code>
/// https://management-live.adyen.com/v3
/// </code>
/// <para>
/// ## Release notes
/// Have a look at the <see href="https://docs.adyen.com/release-notes/management-api">release notes</see> to find out what changed in this version!, This API is used for the classic integration. If you are just starting your implementation, refer to our <see href="https://docs.adyen.com/adyen-for-platforms-model">new integration guide</see> instead.
/// </para>
/// <para>
/// The Account API provides endpoints for managing account-related entities on your platform. These related entities include account holders, accounts, bank accounts, shareholders, and verification-related documents. The management operations include actions such as creation, retrieval, updating, and deletion of them.
/// </para>
/// <para>
/// For more information, refer to our <see href="https://docs.adyen.com/classic-platforms">documentation</see>.
/// ## Authentication
/// Your Adyen contact will provide your API credential and an API key. To connect to the API, add an <c>X-API-Key</c> header with the API key as the value, for example:
/// </para>
/// <para>
///  ```
/// curl
/// -H "Content-Type: application/json" \
/// -H "X-API-Key: YOUR_API_KEY" \
/// ...
/// <code>
/// </para>
/// <para>
/// Alternatively, you can use the username and password to connect to the API using basic authentication. For example:
/// </para>
/// <para>
/// <code>
/// curl
/// -U "ws@MarketPlace.YOUR_PLATFORM_ACCOUNT":"YOUR_WS_PASSWORD" \
/// -H "Content-Type: application/json" \
/// ...
/// </code>
/// When going live, you need to generate new web service user credentials to access the <see href="https://docs.adyen.com/development-resources/live-endpoints">live endpoints</see>.
/// </para>
/// <para>
/// ## Versioning
/// The Account API supports <see href="https://docs.adyen.com/development-resources/versioning">versioning</see> using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.
/// </para>
/// <para>
/// For example:
/// <code>
/// https://cal-test.adyen.com/cal/services/Account/v6/createAccountHolder
/// </code>
/// ## Authentication
/// We recommend that you use an API key to connect to the Balance Control API. You can <see href="https://docs.adyen.com/development-resources/api-credentials#generate-api-key">generate an API key</see> in your Customer Area.
/// ### Header format
/// To connect to the Balance Control API, add an <c>X-API-Key</c> header with the API key as the value. For example:
/// </para>
/// <para>
///  ```
/// curl
/// -H 'Content-Type: application/json' \
/// -H 'X-API-Key: ADYEN_API_KEY' \
/// ...
/// <code>
/// </para>
/// <para>
/// ## Versioning
/// </para>
/// <para>
/// The Balance Control API handles versioning as part of the endpoint URL. For example, to send a request to version 2 of the <c>/balanceOverview/companies/{companyId}/balances</c> endpoint, use:
/// </para>
/// <para>
/// https://balance-control-test.adyen.com/balance-control/api/v2/balanceOverview/companies/{companyId}/balances
/// </para>
/// <para>
/// ## Going live
/// When going live, generate an API key in your <see href="https://ca-live.adyen.com/ca/">live Customer Area</see>. You can then use the API key to send requests to <c>https://balance-control-live.adyen.com/api/v2</c>., This API is used for the classic integration. If you are just starting your implementation, refer to our <see href="https://docs.adyen.com/adyen-for-platforms-model">new integration guide</see> instead.
/// </para>
/// <para>
/// The Notification Configuration API provides endpoints for setting up and testing notifications that inform you of events on your platform, for example when a verification check or a payout has been completed.
/// </para>
/// <para>
/// For more information, refer to our <see href="https://docs.adyen.com/classic-platforms/notifications">documentation</see>.
/// ## Authentication
/// Your Adyen contact will provide your API credential and an API key. To connect to the API, add an <c>X-API-Key</c> header with the API key as the value, for example:
/// </para>
/// <para>
///  ```
/// curl
/// -H "Content-Type: application/json" \
/// -H "X-API-Key: YOUR_API_KEY" \
/// ...
/// <code>
/// </para>
/// <para>
/// Alternatively, you can use the username and password to connect to the API using basic authentication. For example:
/// </para>
/// <para>
/// <code>
/// curl
/// -U "ws@MarketPlace.YOUR_PLATFORM_ACCOUNT":"YOUR_WS_PASSWORD" \
/// -H "Content-Type: application/json" \
/// ...
/// </code>
/// When going live, you need to generate new web service user credentials to access the <see href="https://docs.adyen.com/development-resources/live-endpoints">live endpoints</see>.
/// </para>
/// <para>
/// ## Versioning
/// The Notification Configuration API supports <see href="https://docs.adyen.com/development-resources/versioning">versioning</see> using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.
/// </para>
/// <para>
/// For example:
/// <code>
/// https://cal-test.adyen.com/cal/services/Notification/v6/createNotificationConfiguration
/// </code>
/// </para>
/// <para>
/// ## Authentication
/// Each request to the Configuration API must be signed with an API key. Generate an API key in your Customer Area if you have a <see href="https://docs.adyen.com/platforms/manage-access/api-credentials-web-service/#generate-api-key">platform setup</see> or <see href="https://docs.adyen.com/marketplaces/manage-access/api-credentials-web-service/#generate-api-key">marketplace setup</see>.
/// </para>
/// <para>
///  If you have an Adyen Issuing integration, <see href="https://docs.adyen.com/issuing/manage-access/api-credentials-web-service/#generate-api-key">generate an API key</see> in your Balance Platform Customer Area.
/// </para>
/// <para>
/// To connect to the API, add an <c>X-API-Key</c> header with the API key as the value, for example:
/// </para>
/// <para>
///  ```
/// curl
/// -H "Content-Type: application/json" \
/// -H "X-API-Key: YOUR_API_KEY" \
/// ...
/// <code>
/// </para>
/// <para>
/// ## Versioning
/// The Configuration API supports <see href="https://docs.adyen.com/development-resources/versioning">versioning</see> using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.
/// </para>
/// <para>
/// For example:
/// <code>
/// https://balanceplatform-api-test.adyen.com/bcl/v2/accountHolders
/// </code>
/// ## Going live
/// When going live, generate an API key in your <see href="https://ca-live.adyen.com/ca/">live Customer Area</see> if you have an Adyen for Platforms integration or <see href="https://balanceplatform-live.adyen.com/balanceplatform/">live Balance Platform Customer Area</see> if you have an Adyen Issuing integration.You can then use the API key to send requests to <c>https://balanceplatform-api-live.adyen.com/bcl/v2</c>., &gt;Versions 1 and 2 of the Transfers API are deprecated. If you are just starting your implementation, use the latest version.
/// </para>
/// <para>
/// The Transfers API provides endpoints that you can use to transfer funds, whether when paying out to a transfer instrument for <see href="https://docs.adyen.com/marketplaces/payout-to-users/on-demand-payouts">marketplaces</see> or <see href="https://docs.adyen.com/platforms/payout-to-users/on-demand-payouts">platforms</see>, <see href="https://docs.adyen.com/platforms/business-accounts/send-receive-funds">sending funds to third parties</see> for users with business bank accounts, or to <see href="https://docs.adyen.com/platforms/capital">request a payout for a grant offer</see>. The API also supports use cases for <see href="https://docs.adyen.com/platforms/business-accounts/transactions-api">getting transactions for business bank accounts</see> and getting <see href="https://docs.adyen.com/platforms/capital#get-balances">outstanding balances</see> for one or more grants on your platform.
/// </para>
/// <para>
/// ## Authentication
/// Each request to the Transfers API must be signed with an API key. Generate an API key in your Customer Area if you have a <see href="https://docs.adyen.com/platforms/manage-access/api-credentials-web-service/#generate-api-key">platform setup</see> or <see href="https://docs.adyen.com/marketplaces/manage-access/api-credentials-web-service/#generate-api-key">marketplace setup</see>.
/// </para>
/// <para>
/// If you have an Adyen Issuing integration, <see href="https://docs.adyen.com/issuing/manage-access/api-credentials-web-service/#generate-api-key">generate an API key</see> in your Balance Platform Customer Area.
/// </para>
/// <para>
/// To connect to the API, add an <c>X-API-Key</c> header with the API key as the value, for example:
/// </para>
/// <para>
///  ```
/// curl
/// -H "Content-Type: application/json" \
/// -H "X-API-Key: YOUR_API_KEY" \
/// ...
/// <code>
/// </para>
/// <para>
/// ## Roles and permissions
/// To use the Transfers API, you need an additional role for your API credential. Transfers must also be enabled for the source balance account. Your Adyen contact will set up the roles and permissions for you.
/// ## Versioning
/// The Transfers API supports <see href="https://docs.adyen.com/development-resources/versioning">versioning</see> using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.
/// </para>
/// <para>
/// For example:
/// <code>
/// https://balanceplatform-api-test.adyen.com/btl/v4/transfers
/// </code>
/// ## Going live
/// When going live, generate an API key in your <see href="https://ca-live.adyen.com/ca/">live Customer Area</see> if you have an Adyen for Platforms integration or <see href="https://balanceplatform-live.adyen.com/balanceplatform/">live Balance Platform Customer Area</see> if you have an Adyen Issuing integration. You can then use the API key to send requests to <c>https://balanceplatform-api-live.adyen.com/btl/v4</c>., The Capital API provides endpoints for embedding <see href="https://docs.adyen.com/capital">Adyen Capital</see> into your marketplace or platform. With Capital, you can offer business financing to your users as grants. When a user receives a grant, they must repay the grant amount in a specified term, in addition to paying a fee for using this service.
/// </para>
/// <para>
/// With these endpoints, you can:
/// - <b>Get available financing offers</b>: You can get a list of offers with fixed amounts or a range of available financing for your users. Adyen configures the financing amount, the fee, and the repayment conditions for each offer. These configurations are based on proactive risk analyses that Adyen performs on your users.
/// - <b>Make requests for grants</b>: When a user selects a financing offer, you can make a request for the grant on their behalf.
/// - <b>Get information about your grant account</b>: Your grant account tracks the information of all grants in your marketplace or platform.
/// </para>
/// <para>
/// ## Authentication
/// Each request made to the Capital API must be signed with an API key. Generate an API key in your Customer Area.
/// </para>
/// <para>
/// To connect to the API, add an <c>X-API-Key</c> header with the API key as the value, for example:
/// </para>
/// <para>
///  ```
/// curl
/// -H "Content-Type: application/json" \
/// -H "X-API-Key: YOUR_API_KEY" \
/// ...
/// <code>
/// </para>
/// <para>
/// ## Roles and permissions
/// To use the Capital API, your API credential must have the following roles:
/// - <b>Balance_Platform_Capital_Configuration_Role</b>
/// - <b>Balance_Platform_Capital_Grant_Initiation_Role</b>
/// </para>
/// <para>
/// Reach out to your Adyen contact to set up these roles.
/// ## Going live
/// When going live, generate an API key in your <see href="https://ca-live.adyen.com/ca">live Customer Area</see>. You can then use the API key to send requests to <c>https://balanceplatform-api-live.adyen.com/capital/v{version}</c>., This API is used for the classic integration. If you are just starting your implementation, refer to our <see href="https://docs.adyen.com/adyen-for-platforms-model">new integration guide</see> instead.
/// </para>
/// <para>
/// The Fund API provides endpoints for managing the funds in the accounts on your platform. These management operations include, for example, the transfer of funds from one account to another, the payout of funds to an account holder, and the retrieval of balances in an account.
/// </para>
/// <para>
/// For more information, refer to our <see href="https://docs.adyen.com/classic-platforms">documentation</see>.
/// ## Authentication
/// Your Adyen contact will provide your API credential and an API key. To connect to the API, add an <c>X-API-Key</c> header with the API key as the value, for example:
/// </para>
/// <para>
///  ```
/// curl
/// -H "Content-Type: application/json" \
/// -H "X-API-Key: YOUR_API_KEY" \
/// ...
/// <code>
/// </para>
/// <para>
/// Alternatively, you can use the username and password to connect to the API using basic authentication. For example:
/// </para>
/// <para>
/// <code>
/// curl
/// -U "ws@MarketPlace.YOUR_PLATFORM_ACCOUNT":"YOUR_WS_PASSWORD" \
/// -H "Content-Type: application/json" \
/// ...
/// </code>
/// When going live, you need to generate new web service user credentials to access the <see href="https://docs.adyen.com/development-resources/live-endpoints">live endpoints</see>.
/// </para>
/// <para>
/// ## Versioning
/// The Fund API supports <see href="https://docs.adyen.com/development-resources/versioning">versioning</see> using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.
/// </para>
/// <para>
/// For example:
/// <code>
/// https://cal-test.adyen.com/cal/services/Fund/v6/accountHolderBalance
/// </code>
/// ## Authentication
/// We recommend that you use an API key to connect to the Session authentication API. Generate an API key in your Customer Area if you have a <see href="https://docs.adyen.com/platforms/manage-access/api-credentials-web-service/#generate-api-key">platform setup</see> or <see href="https://docs.adyen.com/marketplaces/manage-access/api-credentials-web-service/#generate-api-key">marketplace setup</see>. If you have an Adyen Issuing integration, <see href="https://docs.adyen.com/issuing/manage-access/api-credentials-web-service/#generate-api-key">generate an API key</see> in your Balance Platform Customer Area.
/// </para>
/// <para>
/// To connect to the Session authentication API, add an <c>X-API-Key</c> header with the API key as the value, for example:
/// </para>
/// <para>
///  ```
/// curl
/// -H 'Content-Type: application/json' \
/// -H 'X-API-Key: YOUR_API_KEY' \
/// ...
/// <code>
/// </para>
/// <para>
/// ## Roles and permissions
/// To create a token, you must meet specific requirements. These requirements vary depending on the type of component. For more information, see the documentation for <see href="https://docs.adyen.com/platforms/onboard-users/components">Onboarding</see> and <see href="https://docs.adyen.com/platforms/build-user-dashboards">Platform Experience</see> components.
/// </para>
/// <para>
/// ## Going live
/// To access the live endpoint, generate an API key in your live Customer Area if you have a <see href="https://docs.adyen.com/platforms/">platform</see> or <see href="https://docs.adyen.com/marketplaces/">marketplace setup</see>. If you have an Adyen Issuing integration, <see href="https://docs.adyen.com/issuing/manage-access/api-credentials-web-service/#generate-api-key">generate an API key</see> in your Balance Platform Customer Area. You can then use the API key to send requests to <c>https://authe-live.adyen.com/authe/api/v1</c>., The Legal Entity Management API enables you to manage legal entities that contain information required for verification.
/// </para>
/// <para>
/// ## Authentication
/// Each request to the Legal Entity Management API must be signed with an API key. Generate an API key in your Customer Area if you have a <see href="https://docs.adyen.com/platforms/manage-access/api-credentials-web-service/#generate-api-key">platform setup</see> or <see href="https://docs.adyen.com/marketplaces/manage-access/api-credentials-web-service/#generate-api-key">marketplace setup</see>.
/// </para>
/// <para>
///  If you have an Adyen Issuing integration, <see href="https://docs.adyen.com/issuing/manage-access/api-credentials-web-service/#generate-api-key">generate an API key</see> in your Balance Platform Customer Area.
/// </para>
/// <para>
/// To connect to the API, add an <c>X-API-Key</c> header with the API key as the value. For example:
/// </para>
/// <para>
/// <code>
/// curl
/// -H "X-API-Key: YOUR_API_KEY" \
/// -H "Content-Type: application/json" \
/// ...
/// </code>
/// ## Versioning
/// The Legal Entity Management API supports <see href="https://docs.adyen.com/development-resources/versioning">versioning</see> using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.
/// </para>
/// <para>
/// For example:
/// <code>
/// https://kyc-test.adyen.com/lem/v4/legalEntities
/// </code>
/// ## Rate limits
/// We enforce rate limits on Legal Entity Management API endpoints. When the number of requests you send exceeds a threshold within a time frame, additional requests are blocked until the time frame ends. Current limits:
/// </para>
/// <list type="bullet">
///   <item><description>Live environments: 700 requests per 5 seconds.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description>Test environments: 200 requests per 5 seconds.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description>Failed requests are subject to a limit of 5 failures per 10 seconds.</description></item>
/// </list>
/// <para>
/// ## Going live
/// When going live, generate an API key in your <see href="https://ca-live.adyen.com/ca/">live Customer Area</see> if you have an Adyen for Platforms integration or <see href="https://balanceplatform-live.adyen.com/balanceplatform/">live Balance Platform Customer Area</see> if you have an Adyen Issuing integration.You can then use the API key to send requests to <c>https://kyc-live.adyen.com/lem/v4</c>., This API is used for the classic integration. If you are just starting your implementation, refer to our <see href="https://docs.adyen.com/adyen-for-platforms-model">new integration guide</see> instead.
/// </para>
/// <para>
/// The Hosted onboarding API provides endpoints that you can use to generate links to Adyen-hosted pages, such as an <see href="https://docs.adyen.com/classic-platforms/hosted-onboarding-page">onboarding page</see> or a <see href="https://docs.adyen.com/classic-platforms/platforms-for-partners">PCI compliance questionnaire</see>. You can provide these links to your account holders so that they can complete their onboarding.
/// </para>
/// <para>
/// ## Authentication
/// Your Adyen contact will provide your API credential and an API key. To connect to the API, add an <c>X-API-Key</c> header with the API key as the value, for example:
/// </para>
/// <para>
///  ```
/// curl
/// -H "Content-Type: application/json" \
/// -H "X-API-Key: YOUR_API_KEY" \
/// ...
/// <code>
/// </para>
/// <para>
/// Alternatively, you can use the username and password to connect to the API using basic authentication. For example:
/// </para>
/// <para>
/// <code>
/// curl
/// -U "ws@MarketPlace.YOUR_PLATFORM_ACCOUNT":"YOUR_WS_PASSWORD" \
/// -H "Content-Type: application/json" \
/// ...
/// </code>
/// When going live, you need to generate new web service user credentials to access the <see href="https://docs.adyen.com/development-resources/live-endpoints">live endpoints</see>.
/// </para>
/// <para>
/// ## Versioning
/// The Hosted onboarding API supports <see href="https://docs.adyen.com/development-resources/versioning">versioning</see> using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.
/// </para>
/// <para>
/// For example:
/// <code>
/// https://cal-test.adyen.com/cal/services/Hop/v6/getOnboardingUrl
/// </code>
/// </para>
/// <para>
/// With these endpoints, you can:
/// - <b>Retrieve payment details</b>: Retrieve transaction information for specific payments.
/// - <b>Confirm payments</b>: Confirm payments with Strong Customer Authentication (SCA).
/// - <b>Cancel payments</b>: Cancel pending transactions.
/// </para>
/// <para>
/// ## Authentication
/// Each request made to the A2A Payments API must be signed with an API key. Generate an API key in your Customer Area.
/// </para>
/// <para>
/// To connect to the API, add an <c>X-API-Key</c> header with the API key as the value, for example:
/// </para>
/// <para>
///  ```
/// curl
/// -H "Content-Type: application/json" \
/// -H "X-API-Key: YOUR_API_KEY" \
/// ...
/// <code>
/// </para>
/// <para>
/// ## Roles and permissions
/// To use the A2A Payments API, your API credential must have the following roles:
/// - <b>Role for A2A Issuer payments - API</b>
/// </para>
/// <para>
/// Reach out to your Adyen contact to set up these roles.
/// ## Going live
/// When going live, generate an API key in your <see href="https://ca-live.adyen.com/ca">live Customer Area</see>. You can then use the API key to send requests to <c>https://balanceplatform-api-live.adyen.com/a2aissuer-api/v{version}/payments</c>., The Open Banking API provides secure endpoints to share financial data and services with third parties. This API offers quick and reliable user verification.
/// </para>
/// <para>
/// With these endpoints, you can:
/// </para>
/// <para>
/// - <b>Create a list of available account verification routes</b>: Create a list of Account Information Service Providers (AISPs) for third-party individual account verification. Successful connections generate a unique code used for requesting bank reports and verifying identity.
/// - <b>Verify bank account ownership</b>: Get the account verification report using the unique code from a successful open banking connection. This report provides identity verification and bank account details.
/// ## Authentication
/// Each request made to the Open Banking API must be signed with an API key. Generate an API key in your Customer Area.
/// </para>
/// <para>
/// To connect to the API, add an X-API-Keyheader with the API key as the value, for example:
/// </para>
/// <para>
///  ```
/// curl
/// -H "Content-Type: application/json"
/// -H "X-API-Key: YOUR_API_KEY"
/// ...
/// <code>
/// </para>
/// <para>
/// ## Roles and permissions
/// To use the Open Banking API, your API credential must have the following roles:
/// - <b>Role for OpenBanking account verification use case: EXTERNAL</b>
/// </para>
/// <para>
/// Reach out to your Adyen contact to set up these roles., You can use the <see href="https://docs.adyen.com/risk-management/disputes-api">Disputes API</see> to automate the dispute handling process so that you can respond to disputes and chargebacks as soon as they are initiated. The Disputes API lets you retrieve defense reasons, supply and delete defense documents, and accept or defend disputes.
/// </para>
/// <para>
/// ## Authentication
/// Each request to the Disputes API must be signed with an API key. For this, obtain an API Key from your Customer Area, as described in <see href="https://docs.adyen.com/development-resources/api-credentials#generate-api-key">How to get the API key</see>. Then set this key to the <c>X-API-Key</c> header value, for example:
/// </para>
/// <para>
/// <code>
/// curl
/// -H "Content-Type: application/json" \
/// -H "X-API-Key: Your_API_key" \
/// ...
/// </code>
/// Note that when going live, you need to generate new web service user credentials to access the <see href="https://docs.adyen.com/development-resources/live-endpoints">live endpoints</see>.
/// </para>
/// <para>
/// ## Versioning
/// Disputes API supports <see href="https://docs.adyen.com/development-resources/versioning">versioning</see> using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.
/// </para>
/// <para>
/// For example:
/// <code>
/// https://ca-test.adyen.com/ca/services/DisputeService/v30/defendDispute
/// </code>
/// </para>
/// <para>
/// ## Authentication
/// Your Adyen contact will provide your API credential and an API key. To connect to the API, add an <c>X-API-Key</c> header with the API key as the value, for example:
/// </para>
/// <para>
///  ```
/// curl
/// -H "Content-Type: application/json" \
/// -H "X-API-Key: YOUR_API_KEY" \
/// ...
/// <code>
/// </para>
/// <para>
/// Alternatively, you can use the username and password to connect to the API using basic authentication. For example:
/// </para>
/// <para>
/// <code>
/// curl
/// -H "Content-Type: application/json" \
/// -U "ws@BalancePlatform.YOUR_BALANCE_PLATFORM":"YOUR_WS_PASSWORD" \
/// ...
/// </code>
/// ## Roles and permissions
/// To use the Disputes API, you need an additional role for your API credential. Your Adyen contact will set up the roles and permissions for you.
/// ## Versioning
/// The Disputes API supports <see href="https://docs.adyen.com/development-resources/versioning">versioning</see> using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.
/// </para>
/// <para>
/// For example:
/// <code>
/// https://balanceplatform-api-test.adyen.com/btl/api/v{version}/disputes
/// </code>
/// ## Going live
/// When going live, your Adyen contact will provide your API credential for the live environment. You can then use the username and password to send requests to <c>https://balanceplatform-api-live.adyen.com/btl/api/v{version}</c>., The Adyen <see href="https://docs.adyen.com/point-of-sale/design-your-integration/terminal-api/">Terminal API</see> lets you make payments, issue refunds, collect shopper information, and perform other shopper-device interactions using a payment terminal supplied by Adyen. The Terminal API is also used for transactions in <see href="https://docs.adyen.com/point-of-sale/ipp-mobile/">Adyen Mobile solutions</see>.
/// </para>
/// <para>
/// ## API structure
/// The architecture of Terminal API is determined by the <see href="https://www.nexo-standards.org/standards/nexo-retailer-protocol">nexo Sale to POI Protocol Specifications</see>.
/// </para>
/// <para>
/// A Terminal API request is a JSON message consisting of a <c>SaleToPOIRequest</c> object with:
/// - <see href="https://docs.adyen.com/point-of-sale/design-your-integration/terminal-api/#request-message-header"><c>MessageHeader</c></see>: identifies the type of transaction, the terminal or Mobile SDK instance being used, and unique transaction identifiers.
/// - <b>Request body</b>: content depending on the type of transaction or operation, for example, a <c>PaymentRequest</c>.
/// </para>
/// <para>
/// A Terminal API response is a JSON message consisting of a <c>SaletoPOIResponse</c>with:
/// * <see href="https://docs.adyen.com/point-of-sale/design-your-integration/terminal-api/#response-message-header"><c>MessageHeader</c></see>: echoes the values provided in the request, except for <c>MessageType</c>, which is always <b>Response</b>.
/// * Response body: content depending on the type of transaction or operation, for example, a <c>PaymentResponse</c>.
/// </para>
/// <para>
/// ## Sending and receiving
/// In an integration with Ayden payment terminals, you can send and receive Terminal API messages in the following ways:
/// - <see href="https://docs.adyen.com/point-of-sale/design-your-integration/choose-your-architecture/local/">Local communications</see>: using your local network, your POS system sends the request directly to the IP address of the terminal, and receives the result synchronously.
/// - <see href="https://docs.adyen.com/point-of-sale/design-your-integration/choose-your-architecture/cloud/">Cloud communications</see>: using the internet to access the cloud, your POS system sends the request to an Adyen endpoint, and Adyen forwards the request to the terminal. Your POS system either keeps the connection open and receives the response synchronously, or closes the connection and receives the response asynchronously in an event notification.
/// </para>
/// <para>
/// ## Using local communications
/// To learn how to set up and protect local communications, refer to <see href="https://docs.adyen.com/point-of-sale/design-your-integration/choose-your-architecture/local/">Building a local integration</see>.
/// </para>
/// <para>
/// ## Endpoints for cloud communications
/// If your POS system is cloud-based, you POST your Terminal API requests to a <b>Cloud device API</b> endpoint, using path and query parameters to identify the device that you want to send the request to.
/// - If your POS system is designed to keep the connection open to wait for the response, use the endpoints ending in <c>/sync</c>.
/// - If your POS system is designed to close the connection so that it can initiate a new request, use the endpoints ending in <c>/async</c>.
/// </para>
/// <para>
/// ### Test endpoints
/// - <c>https://device-api-test.adyen.com/v1/merchants/{merchantAccount}/devices/{deviceId}/sync</c>
/// - <c>https://device-api-test.adyen.com/v1/merchants/{merchantAccount}/devices/{deviceId}/async</c>
/// </para>
/// <para>
/// ### Live endpoints
/// The live endpoints differ per region. In addition to using a regional endpoint, you must select the geographically closest data center in your live Customer Area.
/// </para>
/// <para>
/// <b>Australia</b>
/// - <c>https://device-api-live-au.adyen.com/v1/merchants/{merchantId}/devices/{deviceId}/sync</c>
/// - <c>https://device-api-live-au.adyen.com/v1/merchants/{merchantId}/devices/{deviceId}/async</c>
/// </para>
/// <para>
/// <b>East Asia</b>
/// - <c>https://device-api-live-apse.adyen.com/v1/merchants/{merchantId}/devices/{deviceId}/sync</c>
/// - <c>https://device-api-live-apse.adyen.com/v1/merchants/{merchantId}/devices/{deviceId}/async</c>
/// </para>
/// <para>
/// <b>Europe</b>
/// - <c>https://device-api-live.adyen.com/v1/merchants/{merchantId}/devices/{deviceId}/sync</c>
/// - <c>https://device-api-live.adyen.com/v1/merchants/{merchantId}/devices/{deviceId}/async</c>
/// </para>
/// <para>
/// <b>United States</b>
/// - <c>https://device-api-live-us.adyen.com/v1/merchants/{merchantId}/devices/{deviceId}/sync</c>
/// - <c>https://device-api-live-us.adyen.com/v1/merchants/{merchantId}/devices/{deviceId}/async</c>
/// </para>
/// <para>
///  ### Old endpoints
/// If you currently use endpoints with a base URL that includes <c>terminal-api</c>, we strongly recommend migrating to Cloud device API endpoints, for the following reasons:
/// - When using Cloud device API, the API logs in the Customer Area include the Terminal API requests and responses.
/// - Cloud device API endpoints offer technical advantages such as versioning and better routing.
/// - Future enhancements and features will be based on Cloud device API.
/// </para>
/// <para>
/// There will be no future development on the old endpoints, but we continue to support them.
/// </para>
/// <para>
/// <b>Old test endpoints</b>:
/// - <c>https://terminal-api-test.adyen.com/sync</c> and <c>https://terminal-api-test.adyen.com/async</c>
/// </para>
/// <para>
/// <b>Old live endpoints Australia</b>:
/// - <c>https://terminal-api-live-au.adyen.com/sync</c> and <c>https://terminal-api-live-au.adyen.com/async</c>
/// </para>
/// <para>
/// <b>Old live endpoints East Asia</b>:
/// - <c>https://terminal-api-live-apse.adyen.com/sync</c> and <c>https://terminal-api-live-apse.adyen.com/async</c>
/// </para>
/// <para>
/// <b>Old live endpoints Europe</b>:
/// - <c>https://terminal-api-live.adyen.com/sync</c> and <c>https://terminal-api-live.adyen.com/async</c>
/// </para>
/// <para>
/// <b>Old live endpoints United States</b>:
/// - <c>https://terminal-api-live-us.adyen.com/sync</c> and <c>https://terminal-api-live-us.adyen.com/async</c>
/// </para>
/// <para>
/// ## Authentication for cloud communications
/// Each request to a <b>Cloud device API</b> endpoint must be signed with an API key that has the <b>Cloud Device API role</b>. <see href="https://docs.adyen.com/development-resources/api-credentials#generate-api-key">Generate your API Key</see> in the Customer Area and set this key to the <c>X-API-Key</c> header value of the Cloud device API request.
/// </para>
/// <para>
/// When going live, generate a new API key in the live Customer Area.
/// </para>
/// <para>
/// ## Available Terminal API requests, The SoftPOS configuration API is used in the mutual authentication flow between an Adyen Android or iOS <see href="https://docs.adyen.com/point-of-sale/ipp-mobile/">Mobile SDK</see> and the Adyen payments platform.
/// The Mobile SDK for Android or iOS devices enables businesses to accept in-person payments using a commercial off-the-shelf (COTS) device like a phone.
/// For example, Tap to Pay transactions, or transactions on a mobile device in combination with a card reader.
/// </para>
/// <para>
/// ## Authentication
/// Each request to the POS Mobile API must be signed with an API key. <see href="https://docs.adyen.com/development-resources/api-credentials#generate-api-key">Generate your API key</see> in the Customer Area and then set this key to the <c>X-API-Key</c> header value.
/// You also need to have a <see href="https://docs.adyen.com/development-resources/client-side-authentication/">client key</see>. The client key is part of the setup but you will not need to use it in your integration later. Therefore, when you set up the client key, you do not need to specify allowed origins, and you do not need to store the key in your system.
/// To access the live endpoints, you need to generate a new API key and client key in your live Customer Area.
/// ## Versioning
/// </para>
/// <para>
/// The POS Mobile API handles versioning as part of the endpoint URL.
/// </para>
/// <para>
/// For example:
/// <code>
/// https://softposconfig-test.adyen.com/softposconfig/v{version}/auth/certificate
/// </code>
/// </para>
/// <para>
/// ## Going live
/// To access the live endpoints, you need an API key and client key from your live Customer Area, and switch to the live endpoint that is geographically closest to your location.
/// ### Australia:
/// https://softposconfig-live-au.adyen.com/softposconfig/v{version}/auth/certificate
/// ### Asia Pacific South East:
/// https://softposconfig-live-apse.adyen.com/softposconfig/v{version}/auth/certificate
/// ### Europe:
/// https://softposconfig-live.adyen.com/softposconfig/v{version}/auth/certificate
/// ### North East Asia:
/// https://softposconfig-live-nea.adyen.com/softposconfig/v{version}/auth/certificate
/// ### United States:
/// https://softposconfig-live-us.adyen.com/softposconfig/v3/auth/certificate
/// ## Methods, Board and manage the Adyen Payments App on your Android mobile devices.
/// ## Authentication
/// Each request to the Payments App API must be signed with an API key. <see href="https://docs.adyen.com/development-resources/api-credentials#generate-api-key">Generate your API key</see> in the Customer Area and then set this key to the <c>X-API-Key</c> header value.
/// </para>
/// <para>
/// ## Versioning
/// </para>
/// <para>
/// Payments App API handles versioning as part of the endpoint URL. For example, to send a request to this version of the <c>/merchants/{merchantId}/generatePaymentsAppBoardingToken</c> endpoint, use:
/// </para>
/// <code>
/// https://management-test.adyen.com/v1/merchants/{merchantId}/generatePaymentsAppBoardingToken
/// </code>
/// <para>
/// ## Going live
/// </para>
/// <para>
/// To access the live endpoints, you need an API key from your live Customer Area. Use this API key to make requests to:
/// </para>
/// <para>
/// <code>
/// https://management-live.adyen.com/v{version}
/// </code>
/// </para>
/// <para>
/// The POS Mobile API is used in the mutual authentication flow between an Adyen Android or iOS <see href="https://docs.adyen.com/point-of-sale/ipp-mobile/">POS Mobile SDK</see> and the Adyen payments platform.
/// The POS Mobile SDK for Android or iOS devices enables businesses to accept in-person payments using a commercial off-the-shelf (COTS) device like a phone. For example, Tap to Pay transactions, or transactions on a mobile device in combination with a card reader.
/// </para>
/// <para>
/// ## Authentication
/// Each request to the POS Mobile API must be signed with an API key. <see href="https://docs.adyen.com/development-resources/api-credentials#generate-api-key">Generate your API key</see> in the Customer Area and then set this key to the <c>X-API-Key</c> header value.
/// You also need to have a <see href="https://docs.adyen.com/development-resources/client-side-authentication/">client key</see>. The client key is part of the setup but you won't need to use it in your integration later. Therefore, you don't need to specify allowed origins, and you don't need to store the key in your system.
/// To access the live endpoints, you need to generate a new API key and client key in your live Customer Area.
/// ## Versioning
/// </para>
/// <para>
/// The POS Mobile API handles versioning as part of the endpoint URL.
/// </para>
/// <para>
/// For example:
/// <code>
/// https://checkout-test.adyen.com/checkout/possdk/v68/sessions
/// </code>
/// </para>
/// <para>
/// ## Going live
/// </para>
/// <para>
/// To access the live endpoints, you need an API key and client key from your live Customer Area.
/// </para>
/// <para>
/// The live endpoint URLs contain a prefix which is unique to your company account, for example:
/// <code>
/// https://{PREFIX}-checkout-live.adyenpayments.com/checkout/possdk/v68/sessions
/// </code>
/// </para>
/// <para>
/// For more information, refer to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management/assign-terminals-api/classic-assign-terminals-api/">Classic assign terminals</see>.
/// </para>
/// <para>
/// &gt;From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our <see href="https://docs.adyen.com/api-explorer/Management/latest/overview">Management API</see>.
/// </para>
/// <para>
/// ## Authentication
/// Each request to the Terminal Management API must be signed with an API key. For this, obtain an API Key from your Customer Area, as described in <see href="https://docs.adyen.com/development-resources/api-credentials#generate-api-key">How to get the API key</see>. Then set this key to the <c>X-API-Key</c> header value, for example:
/// </para>
/// <para>
/// <code>
/// curl
/// -H "Content-Type: application/json" \
/// -H "X-API-Key: Your_API_key" \
/// ...
/// </code>
/// Note that when going live, you need to generate new web service user credentials to access the <see href="https://docs.adyen.com/development-resources/live-endpoints">live endpoints</see>.
/// </para>
/// <para>
/// ## Roles and permissions
/// To use the POS Terminal Management API, you need the <b>POS Terminal Management API role</b> added to your API credential. Your Adyen contact will set up the roles for you.
/// ## Versioning
/// Terminal Management API supports <see href="https://docs.adyen.com/development-resources/versioning">versioning</see> using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.
/// </para>
/// <para>
/// For example:
/// <code>
/// https://postfmapi-test.adyen.com/postfmapi/terminal/v1/getTerminalsUnderAccount
/// </code>
/// When using versioned endpoints, Boolean response values are returned in string format: <c>"true"</c> or <c>"false"</c>.
/// If you omit the version from the endpoint URL, Boolean response values are returned like this: <c>true</c> or <c>false</c>.
/// ## Going live
/// To access the live endpoints, you need an API key from your live Customer Area.
/// Use this API key to make requests to:
/// </para>
/// <code>
/// https://postfmapi-live.adyen.com/postfmapi/terminal/v1
/// </code>
/// </summary>
public sealed class AdyenClient
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    public AdyenClient(HttpClient httpClient, AdyenClientOptions options)
    {
        _server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory = new HeadersFactory([
            new HeaderParam("User-Agent", "AdyenClient/72 CSharp"),
            new HeaderParam("X-APIMatic-Lang", "CSharp"),
            new HeaderParam("X-APIMatic-Package-Version", "72"),
            new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
            new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
            new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime),
        ]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry, options.TimeProvider);
        var httpLogger = new HttpLogger(options.Logging, "AdyenClient", options.TimeProvider);
        var responseContexts = new ResponseContextFactory(options.TimeProvider, options.StreamReadTimeout);
        _rawClient =
            new RawClient(
                httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks,
                responseContexts);
        _auth = new AuthSchemes(options);
    }

    public ApiCredentialsCompanyLevel ApiCredentialsCompanyLevel =>
        field ??= new ApiCredentialsCompanyLevel(_rawClient, _server, _auth);

    public ApiCredentialsMerchantLevel ApiCredentialsMerchantLevel =>
        field ??= new ApiCredentialsMerchantLevel(_rawClient, _server, _auth);

    public ApiKeyCompanyLevel ApiKeyCompanyLevel => field ??= new ApiKeyCompanyLevel(_rawClient, _server, _auth);

    public ApiKeyMerchantLevel ApiKeyMerchantLevel => field ??= new ApiKeyMerchantLevel(_rawClient, _server, _auth);

    public AccountCompanyLevel AccountCompanyLevel => field ??= new AccountCompanyLevel(_rawClient, _server, _auth);

    public AccountMerchantLevel AccountMerchantLevel => field ??= new AccountMerchantLevel(_rawClient, _server, _auth);

    public AccountStoreLevel AccountStoreLevel => field ??= new AccountStoreLevel(_rawClient, _server, _auth);

    public AccountVerification AccountVerification => field ??= new AccountVerification(_rawClient, _server);

    public AccountHolders AccountHolders => field ??= new AccountHolders(_rawClient, _server, _auth);

    public Accounts Accounts => field ??= new Accounts(_rawClient, _server, _auth);

    public AllowedOriginsCompanyLevel AllowedOriginsCompanyLevel =>
        field ??= new AllowedOriginsCompanyLevel(_rawClient, _server, _auth);

    public AllowedOriginsMerchantLevel AllowedOriginsMerchantLevel =>
        field ??= new AllowedOriginsMerchantLevel(_rawClient, _server, _auth);

    public AndroidFilesCompanyLevel AndroidFilesCompanyLevel =>
        field ??= new AndroidFilesCompanyLevel(_rawClient, _server, _auth);

    public AuthorizedCardUsers AuthorizedCardUsers => field ??= new AuthorizedCardUsers(_rawClient, _server);

    public BalanceAccounts BalanceAccounts => field ??= new BalanceAccounts(_rawClient, _server, _auth);

    public BalanceTransfers BalanceTransfers => field ??= new BalanceTransfers(_rawClient, _server);

    public Balances Balances => field ??= new Balances(_rawClient, _server);

    public BalancesOverview BalancesOverview => field ??= new BalancesOverview(_rawClient, _server);

    public BankAccountValidation BankAccountValidation =>
        field ??= new BankAccountValidation(_rawClient, _server, _auth);

    public BusinessLinesApi BusinessLinesApi => field ??= new BusinessLinesApi(_rawClient, _server, _auth);

    public Capital Capital => field ??= new Capital(_rawClient, _server, _auth);

    public CardOrders CardOrders => field ??= new CardOrders(_rawClient, _server, _auth);

    public CashOutApi CashOutApi => field ??= new CashOutApi(_rawClient, _server);

    public ClientKeyCompanyLevel ClientKeyCompanyLevel =>
        field ??= new ClientKeyCompanyLevel(_rawClient, _server, _auth);

    public ClientKeyMerchantLevel ClientKeyMerchantLevel =>
        field ??= new ClientKeyMerchantLevel(_rawClient, _server, _auth);

    public CustomPayoutSchedulesSweeps CustomPayoutSchedulesSweeps =>
        field ??= new CustomPayoutSchedulesSweeps(_rawClient, _server, _auth);

    public DirectDebitMandates DirectDebitMandates => field ??= new DirectDebitMandates(_rawClient, _server);

    public DisputeAttachments DisputeAttachments => field ??= new DisputeAttachments(_rawClient, _server);

    public Documents Documents => field ??= new Documents(_rawClient, _server, _auth);

    public DonationCampaigns DonationCampaigns => field ??= new DonationCampaigns(_rawClient, _server, _auth);

    public Donations Donations => field ??= new Donations(_rawClient, _server, _auth);

    public DynamicOffers DynamicOffers => field ??= new DynamicOffers(_rawClient, _server);

    public General General => field ??= new General(_rawClient, _server, _auth);

    public GrantAccounts GrantAccounts => field ??= new GrantAccounts(_rawClient, _server, _auth);

    public GrantOffersApi GrantOffersApi => field ??= new GrantOffersApi(_rawClient, _server, _auth);

    public GrantsApi GrantsApi => field ??= new GrantsApi(_rawClient, _server);

    public HostedOnboarding HostedOnboarding => field ??= new HostedOnboarding(_rawClient, _server, _auth);

    public HostedOnboardingPage HostedOnboardingPage => field ??= new HostedOnboardingPage(_rawClient, _server, _auth);

    public Initialization Initialization => field ??= new Initialization(_rawClient, _server, _auth);

    public InstantPayouts InstantPayouts => field ??= new InstantPayouts(_rawClient, _server, _auth);

    public LegalEntities LegalEntities => field ??= new LegalEntities(_rawClient, _server, _auth);

    public ManageScaDevices ManageScaDevices => field ??= new ManageScaDevices(_rawClient, _server, _auth);

    public ManageCardPin ManageCardPin => field ??= new ManageCardPin(_rawClient, _server, _auth);

    public ManagedPayoutSchedules ManagedPayoutSchedules => field ??= new ManagedPayoutSchedules(_rawClient, _server);

    public Modifications Modifications => field ??= new Modifications(_rawClient, _server, _auth);

    public MyApiCredential MyApiCredential => field ??= new MyApiCredential(_rawClient, _server, _auth);

    public NetworkTokens NetworkTokens => field ??= new NetworkTokens(_rawClient, _server, _auth);

    public Orders Orders => field ??= new Orders(_rawClient, _server, _auth);

    public PciComplianceQuestionnairePage PciComplianceQuestionnairePage =>
        field ??= new PciComplianceQuestionnairePage(_rawClient, _server, _auth);

    public PciQuestionnaires PciQuestionnaires => field ??= new PciQuestionnaires(_rawClient, _server, _auth);

    public PaymentInstrumentGroups PaymentInstrumentGroups =>
        field ??= new PaymentInstrumentGroups(_rawClient, _server, _auth);

    public PaymentInstruments PaymentInstruments => field ??= new PaymentInstruments(_rawClient, _server, _auth);

    public PaymentLinks PaymentLinks => field ??= new PaymentLinks(_rawClient, _server, _auth);

    public PaymentMethodsMerchantLevel PaymentMethodsMerchantLevel =>
        field ??= new PaymentMethodsMerchantLevel(_rawClient, _server, _auth);

    public Payments Payments => field ??= new Payments(_rawClient, _server, _auth);

    public PaymentsApp PaymentsApp => field ??= new PaymentsApp(_rawClient, _server);

    public PayoutSettingsMerchantLevel PayoutSettingsMerchantLevel =>
        field ??= new PayoutSettingsMerchantLevel(_rawClient, _server, _auth);

    public Platform Platform => field ??= new Platform(_rawClient, _server, _auth);

    public RaiseDisputes RaiseDisputes => field ??= new RaiseDisputes(_rawClient, _server);

    public Rates Rates => field ??= new Rates(_rawClient, _server);

    public RecurringApi RecurringApi => field ??= new RecurringApi(_rawClient, _server, _auth);

    public RecurringTopUps RecurringTopUps => field ??= new RecurringTopUps(_rawClient, _server);

    public Reviewing Reviewing => field ??= new Reviewing(_rawClient, _server, _auth);

    public ScaAssociationManagement ScaAssociationManagement =>
        field ??= new ScaAssociationManagement(_rawClient, _server);

    public ScaDeviceManagement ScaDeviceManagement => field ??= new ScaDeviceManagement(_rawClient, _server);

    public SessionAuthentication SessionAuthentication => field ??= new SessionAuthentication(_rawClient, _server);

    public SplitConfigurationMerchantLevel SplitConfigurationMerchantLevel =>
        field ??= new SplitConfigurationMerchantLevel(_rawClient, _server, _auth);

    public TaxEDeliveryConsent TaxEDeliveryConsent => field ??= new TaxEDeliveryConsent(_rawClient, _server, _auth);

    public TerminalActionsCompanyLevel TerminalActionsCompanyLevel =>
        field ??= new TerminalActionsCompanyLevel(_rawClient, _server, _auth);

    public TerminalActionsTerminalLevel TerminalActionsTerminalLevel =>
        field ??= new TerminalActionsTerminalLevel(_rawClient, _server, _auth);

    public TerminalOrdersCompanyLevel TerminalOrdersCompanyLevel =>
        field ??= new TerminalOrdersCompanyLevel(_rawClient, _server, _auth);

    public TerminalOrdersMerchantLevel TerminalOrdersMerchantLevel =>
        field ??= new TerminalOrdersMerchantLevel(_rawClient, _server, _auth);

    public TerminalSettingsCompanyLevel TerminalSettingsCompanyLevel =>
        field ??= new TerminalSettingsCompanyLevel(_rawClient, _server, _auth);

    public TerminalSettingsMerchantLevel TerminalSettingsMerchantLevel =>
        field ??= new TerminalSettingsMerchantLevel(_rawClient, _server, _auth);

    public TerminalSettingsStoreLevel TerminalSettingsStoreLevel =>
        field ??= new TerminalSettingsStoreLevel(_rawClient, _server, _auth);

    public TerminalSettingsTerminalLevel TerminalSettingsTerminalLevel =>
        field ??= new TerminalSettingsTerminalLevel(_rawClient, _server, _auth);

    public TerminalsTerminalLevel TerminalsTerminalLevel =>
        field ??= new TerminalsTerminalLevel(_rawClient, _server, _auth);

    public TermsOfService TermsOfService => field ??= new TermsOfService(_rawClient, _server, _auth);

    public TransactionRules TransactionRules => field ??= new TransactionRules(_rawClient, _server, _auth);

    public Transactions Transactions => field ??= new Transactions(_rawClient, _server, _auth);

    public TransferInstruments TransferInstruments => field ??= new TransferInstruments(_rawClient, _server, _auth);

    public TransferLimitsBalanceAccountLevel TransferLimitsBalanceAccountLevel =>
        field ??= new TransferLimitsBalanceAccountLevel(_rawClient, _server);

    public TransferLimitsBalancePlatformLevel TransferLimitsBalancePlatformLevel =>
        field ??= new TransferLimitsBalancePlatformLevel(_rawClient, _server);

    public TransferRoutes TransferRoutes => field ??= new TransferRoutes(_rawClient, _server, _auth);

    public Transfers Transfers => field ??= new Transfers(_rawClient, _server, _auth);

    public UsersCompanyLevel UsersCompanyLevel => field ??= new UsersCompanyLevel(_rawClient, _server, _auth);

    public UsersMerchantLevel UsersMerchantLevel => field ??= new UsersMerchantLevel(_rawClient, _server, _auth);

    public Utility Utility => field ??= new Utility(_rawClient, _server, _auth);

    public Verification Verification => field ??= new Verification(_rawClient, _server, _auth);

    public WebhooksCompanyLevel WebhooksCompanyLevel => field ??= new WebhooksCompanyLevel(_rawClient, _server, _auth);

    public WebhooksMerchantLevel WebhooksMerchantLevel =>
        field ??= new WebhooksMerchantLevel(_rawClient, _server, _auth);

    public IDealProfiles IDealProfiles => field ??= new IDealProfiles(_rawClient, _server);

    /// <summary>
    /// Abort Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Body of the Abort Request message.
    /// It conveys Information requested for identification of the message request carrying the transaction to abort. A message to display on the CustomerError Device could be sent by the Sale System (DisplayOutput).
    /// </remarks>
    public Task<object> AbortRequest(AbortRequestOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default24("/abort"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<object>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Admin Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Empty.
    /// Content of the Custom Admin Request message.
    /// </remarks>
    public Task<AdminResponse> AdminRequest(AdminRequestOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default24("/admin"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AdminResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// BalanceInquiry Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalanceInquiryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// It conveys Information related to the account for which a Balance Inquiry is requested.
    /// Content of the Balance Inquiry Request message.
    /// </remarks>
    public Task<BalanceInquiryResponse> BalanceInquiryRequest(BalanceInquiryRequestOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default24("/balanceinquiry"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BalanceInquiryResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CardAcquisition Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CardAcquisitionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// It conveys Information related to the payment and loyalty cards to read and analyse. This message pair is usually followed by a message pair (e.g. payment or loyalty) which refers to this Card Acquisition message pair.
    /// Content of the Card Acquisition Request message.
    /// </remarks>
    public Task<CardAcquisitionResponse> CardAcquisitionRequest(CardAcquisitionRequestOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default24("/cardacquisition"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CardAcquisitionResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CardReaderAPDU Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CardReaderApduResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// It contains the APDU request to send to the chip of the card, and a possible invitation message to display on the CashierInterface or the CustomerInterface.
    /// Content of the Card Reader APDU Request message.
    /// </remarks>
    public Task<CardReaderApduResponse> CardReaderApduRequest(CardReaderApduRequestOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default24("/cardreaderapdu"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CardReaderApduResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Diagnosis Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DiagnosisResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// It conveys Information related to the target POI for which the diagnosis is requested.
    /// Content of the Diagnosis Request message.
    /// </remarks>
    public Task<DiagnosisResponse> DiagnosisRequest(DiagnosisRequestOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default24("/diagnosis"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DiagnosisResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Display Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DisplayResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// It conveys the data to display and the way to process the display. It contains the complete content to display. It might contain an operation (the DisplayOutput element) per Display Device type.
    /// Content of the Display Request message.
    /// </remarks>
    public Task<DisplayResponse> DisplayRequest(DisplayRequestOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default24("/display"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DisplayResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// EnableService Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EnableServiceResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// It conveys the services that will be enabled for the POI Terminal without the request of the Sale System, and a possible invitation for the Customer to start the services.
    /// Content of the Enable Service Request message.
    /// </remarks>
    public Task<EnableServiceResponse> EnableServiceRequest(EnableServiceRequestOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default24("/enableservice"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<EnableServiceResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// GetTotals Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetTotalsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// It conveys information from the Sale System related to the scope and the format of the totals to be computed by the POI System.
    /// Content of the Get Totals Request message.
    /// </remarks>
    public Task<GetTotalsResponse> GetTotalsRequest(GetTotalsRequestOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default24("/gettotals"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GetTotalsResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Input Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InputResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Content of the <c>InputRequest</c> message. It conveys the data to display and how to process it. In addition to the display on the Input Device, it might contain an operation (the <c>DisplayOutput</c> element) per Display Device type.
    /// </remarks>
    public Task<InputResponse> InputRequest(InputRequestOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default24("/input"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<InputResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Login Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LoginResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// It conveys information related to the session (period between a Login and the following Logout) to process.
    /// Content of the <c>LoginRequest</c> message.
    /// </remarks>
    public Task<LoginResponse> LoginRequest(LoginRequestOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default24("/login"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<LoginResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Logout Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LogoutResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Empty.
    /// Content of the Logout Request message.
    /// </remarks>
    public Task<LogoutResponse> LogoutRequest(LogoutRequestOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default24("/logout"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<LogoutResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Payment Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentResponse4"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Request sent to terminal to initiate payment.
    /// It conveys Information related to the Payment transaction to process.
    /// Content of the <c>PaymentRequest</c> message.
    /// </remarks>
    public Task<PaymentResponse4> PaymentRequest(PaymentRequestOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default24("/payment"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaymentResponse4>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Print Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PrintResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Content of the Print Request message.
    /// It conveys the complete data to print and how to process the print.
    /// </remarks>
    public Task<PrintResponse> PrintRequest(PrintRequestOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default24("/print"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PrintResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Reconciliation Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ReconciliationResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Content of the Reconciliation Request message.
    /// It conveys Information related to the Reconciliation requested by the Sale System.
    /// </remarks>
    public Task<ReconciliationResponse> ReconciliationRequest(ReconciliationRequestOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default24("/reconciliation"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ReconciliationResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Reversal Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ReversalResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// It conveys Information related to the reversal of a previous payment or a loyalty transaction.
    /// Content of the Reversal Request message.
    /// </remarks>
    public Task<ReversalResponse> ReversalRequest(ReversalRequestOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default24("/reversal"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ReversalResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// StoredValue Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StoredValueResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// It conveys Information related to the Stored Value transaction to process.
    /// Content of the Stored Value Request message.
    /// </remarks>
    public Task<StoredValueResponse> StoredValueRequest(StoredValueRequestOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default24("/storedvalue"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<StoredValueResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// TransactionStatus Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionStatusResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Content of the TransactionStatus Request message.
    /// It conveys Information requested for status of the last or current Payment, Loyalty or Reversal transaction.
    /// </remarks>
    public Task<TransactionStatusResponse> TransactionStatusRequest(TransactionStatusRequestOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default24("/transactionstatus"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TransactionStatusResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}
