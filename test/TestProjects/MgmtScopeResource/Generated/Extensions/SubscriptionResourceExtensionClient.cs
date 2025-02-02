// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace MgmtScopeResource
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _resourceLinkClientDiagnostics;
        private ResourceLinksRestOperations _resourceLinkRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ResourceLinkClientDiagnostics => _resourceLinkClientDiagnostics ??= new ClientDiagnostics("MgmtScopeResource", ResourceLinkResource.ResourceType.Namespace, Diagnostics);
        private ResourceLinksRestOperations ResourceLinkRestClient => _resourceLinkRestClient ??= new ResourceLinksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ResourceLinkResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DeploymentExtendedResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of DeploymentExtendedResources and their operations over a DeploymentExtendedResource. </returns>
        public virtual DeploymentExtendedCollection GetDeploymentExtendeds()
        {
            return GetCachedClient(Client => new DeploymentExtendedCollection(Client, Id));
        }

        /// <summary>
        /// Gets all the linked resources for the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Resources/links
        /// Operation Id: ResourceLinks_ListAtSubscription
        /// </summary>
        /// <param name="filter"> The filter to apply on the list resource links operation. The supported filter for list resource links is targetId. For example, $filter=targetId eq {value}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceLinkResource> GetResourceLinksAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceLinkResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ResourceLinkClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetResourceLinks");
                scope.Start();
                try
                {
                    var response = await ResourceLinkRestClient.ListAtSubscriptionAsync(Id.SubscriptionId, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceLinkResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceLinkResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ResourceLinkClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetResourceLinks");
                scope.Start();
                try
                {
                    var response = await ResourceLinkRestClient.ListAtSubscriptionNextPageAsync(nextLink, Id.SubscriptionId, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceLinkResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets all the linked resources for the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Resources/links
        /// Operation Id: ResourceLinks_ListAtSubscription
        /// </summary>
        /// <param name="filter"> The filter to apply on the list resource links operation. The supported filter for list resource links is targetId. For example, $filter=targetId eq {value}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceLinkResource> GetResourceLinks(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<ResourceLinkResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ResourceLinkClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetResourceLinks");
                scope.Start();
                try
                {
                    var response = ResourceLinkRestClient.ListAtSubscription(Id.SubscriptionId, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceLinkResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourceLinkResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ResourceLinkClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetResourceLinks");
                scope.Start();
                try
                {
                    var response = ResourceLinkRestClient.ListAtSubscriptionNextPage(nextLink, Id.SubscriptionId, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceLinkResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
