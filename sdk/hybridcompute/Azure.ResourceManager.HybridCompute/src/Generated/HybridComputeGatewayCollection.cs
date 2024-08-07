// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HybridCompute
{
    /// <summary>
    /// A class representing a collection of <see cref="HybridComputeGatewayResource"/> and their operations.
    /// Each <see cref="HybridComputeGatewayResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="HybridComputeGatewayCollection"/> instance call the GetHybridComputeGateways method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class HybridComputeGatewayCollection : ArmCollection, IEnumerable<HybridComputeGatewayResource>, IAsyncEnumerable<HybridComputeGatewayResource>
    {
        private readonly ClientDiagnostics _hybridComputeGatewayGatewaysClientDiagnostics;
        private readonly GatewaysRestOperations _hybridComputeGatewayGatewaysRestClient;

        /// <summary> Initializes a new instance of the <see cref="HybridComputeGatewayCollection"/> class for mocking. </summary>
        protected HybridComputeGatewayCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HybridComputeGatewayCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HybridComputeGatewayCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hybridComputeGatewayGatewaysClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridCompute", HybridComputeGatewayResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HybridComputeGatewayResource.ResourceType, out string hybridComputeGatewayGatewaysApiVersion);
            _hybridComputeGatewayGatewaysRestClient = new GatewaysRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hybridComputeGatewayGatewaysApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update a gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Gateways_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-20-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="gatewayName"> The name of the Gateway. </param>
        /// <param name="data"> Parameters supplied to the Create gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HybridComputeGatewayResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string gatewayName, HybridComputeGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridComputeGatewayGatewaysClientDiagnostics.CreateScope("HybridComputeGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hybridComputeGatewayGatewaysRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HybridComputeArmOperation<HybridComputeGatewayResource>(new HybridComputeGatewayOperationSource(Client), _hybridComputeGatewayGatewaysClientDiagnostics, Pipeline, _hybridComputeGatewayGatewaysRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to create or update a gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Gateways_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-20-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="gatewayName"> The name of the Gateway. </param>
        /// <param name="data"> Parameters supplied to the Create gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HybridComputeGatewayResource> CreateOrUpdate(WaitUntil waitUntil, string gatewayName, HybridComputeGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridComputeGatewayGatewaysClientDiagnostics.CreateScope("HybridComputeGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hybridComputeGatewayGatewaysRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, data, cancellationToken);
                var operation = new HybridComputeArmOperation<HybridComputeGatewayResource>(new HybridComputeGatewayOperationSource(Client), _hybridComputeGatewayGatewaysClientDiagnostics, Pipeline, _hybridComputeGatewayGatewaysRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about the view of a gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Gateways_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-20-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gatewayName"> The name of the Gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual async Task<Response<HybridComputeGatewayResource>> GetAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _hybridComputeGatewayGatewaysClientDiagnostics.CreateScope("HybridComputeGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = await _hybridComputeGatewayGatewaysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridComputeGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about the view of a gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Gateways_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-20-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gatewayName"> The name of the Gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<HybridComputeGatewayResource> Get(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _hybridComputeGatewayGatewaysClientDiagnostics.CreateScope("HybridComputeGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = _hybridComputeGatewayGatewaysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridComputeGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get all gateways of a non-Azure machine
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/gateways</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Gateways_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-20-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridComputeGatewayResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HybridComputeGatewayResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridComputeGatewayGatewaysRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hybridComputeGatewayGatewaysRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HybridComputeGatewayResource(Client, HybridComputeGatewayData.DeserializeHybridComputeGatewayData(e)), _hybridComputeGatewayGatewaysClientDiagnostics, Pipeline, "HybridComputeGatewayCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// The operation to get all gateways of a non-Azure machine
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/gateways</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Gateways_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-20-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridComputeGatewayResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HybridComputeGatewayResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridComputeGatewayGatewaysRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hybridComputeGatewayGatewaysRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HybridComputeGatewayResource(Client, HybridComputeGatewayData.DeserializeHybridComputeGatewayData(e)), _hybridComputeGatewayGatewaysClientDiagnostics, Pipeline, "HybridComputeGatewayCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Gateways_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-20-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gatewayName"> The name of the Gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _hybridComputeGatewayGatewaysClientDiagnostics.CreateScope("HybridComputeGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hybridComputeGatewayGatewaysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Gateways_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-20-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gatewayName"> The name of the Gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<bool> Exists(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _hybridComputeGatewayGatewaysClientDiagnostics.CreateScope("HybridComputeGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = _hybridComputeGatewayGatewaysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Gateways_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-20-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gatewayName"> The name of the Gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual async Task<NullableResponse<HybridComputeGatewayResource>> GetIfExistsAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _hybridComputeGatewayGatewaysClientDiagnostics.CreateScope("HybridComputeGatewayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _hybridComputeGatewayGatewaysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<HybridComputeGatewayResource>(response.GetRawResponse());
                return Response.FromValue(new HybridComputeGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Gateways_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-20-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gatewayName"> The name of the Gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual NullableResponse<HybridComputeGatewayResource> GetIfExists(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _hybridComputeGatewayGatewaysClientDiagnostics.CreateScope("HybridComputeGatewayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _hybridComputeGatewayGatewaysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<HybridComputeGatewayResource>(response.GetRawResponse());
                return Response.FromValue(new HybridComputeGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HybridComputeGatewayResource> IEnumerable<HybridComputeGatewayResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HybridComputeGatewayResource> IAsyncEnumerable<HybridComputeGatewayResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
