// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using MgmtScopeResource.Models;

namespace MgmtScopeResource
{
    /// <summary> A class to add extension methods to Tenant. </summary>
    internal partial class TenantExtensionClient : ArmResource
    {
        private ClientDiagnostics _deploymentExtendedDeploymentsClientDiagnostics;
        private DeploymentsRestOperations _deploymentExtendedDeploymentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantExtensionClient"/> class for mocking. </summary>
        protected TenantExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DeploymentExtendedDeploymentsClientDiagnostics => _deploymentExtendedDeploymentsClientDiagnostics ??= new ClientDiagnostics("MgmtScopeResource", DeploymentExtended.ResourceType.Namespace, DiagnosticOptions);
        private DeploymentsRestOperations DeploymentExtendedDeploymentsRestClient => _deploymentExtendedDeploymentsRestClient ??= new DeploymentsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(DeploymentExtended.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DeploymentExtendeds in the DeploymentExtended. </summary>
        /// <returns> An object representing collection of DeploymentExtendeds and their operations over a DeploymentExtended. </returns>
        public virtual DeploymentExtendedCollection GetDeploymentExtendeds()
        {
            return new DeploymentExtendedCollection(Client, Id);
        }

        /// <summary> Gets a collection of ResourceLinks in the ResourceLink. </summary>
        /// <param name="scope"> The fully qualified ID of the scope for getting the resource links. For example, to list resource links at and under a resource group, set the scope to /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup. </param>
        /// <returns> An object representing collection of ResourceLinks and their operations over a ResourceLink. </returns>
        public virtual ResourceLinkCollection GetResourceLinks(string scope)
        {
            return new ResourceLinkCollection(Client, Id, scope);
        }

        /// <summary>
        /// Calculate the hash of the given template.
        /// Request Path: /providers/Microsoft.Resources/calculateTemplateHash
        /// Operation Id: Deployments_CalculateTemplateHash
        /// </summary>
        /// <param name="template"> The template provided to calculate hash. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TemplateHashResult>> CalculateTemplateHashDeploymentAsync(object template, CancellationToken cancellationToken = default)
        {
            using var scope0 = DeploymentExtendedDeploymentsClientDiagnostics.CreateScope("TenantExtensionClient.CalculateTemplateHashDeployment");
            scope0.Start();
            try
            {
                var response = await DeploymentExtendedDeploymentsRestClient.CalculateTemplateHashAsync(template, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Calculate the hash of the given template.
        /// Request Path: /providers/Microsoft.Resources/calculateTemplateHash
        /// Operation Id: Deployments_CalculateTemplateHash
        /// </summary>
        /// <param name="template"> The template provided to calculate hash. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TemplateHashResult> CalculateTemplateHashDeployment(object template, CancellationToken cancellationToken = default)
        {
            using var scope0 = DeploymentExtendedDeploymentsClientDiagnostics.CreateScope("TenantExtensionClient.CalculateTemplateHashDeployment");
            scope0.Start();
            try
            {
                var response = DeploymentExtendedDeploymentsRestClient.CalculateTemplateHash(template, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }
    }
}
