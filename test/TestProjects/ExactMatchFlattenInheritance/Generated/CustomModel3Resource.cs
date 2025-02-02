// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace ExactMatchFlattenInheritance
{
    /// <summary>
    /// A Class representing a CustomModel3 along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="CustomModel3Resource" />
    /// from an instance of <see cref="ArmClient" /> using the GetCustomModel3Resource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetCustomModel3 method.
    /// </summary>
    public partial class CustomModel3Resource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CustomModel3Resource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel3s/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _customModel3ClientDiagnostics;
        private readonly CustomModel3SRestOperations _customModel3RestClient;
        private readonly CustomModel3Data _data;

        /// <summary> Initializes a new instance of the <see cref="CustomModel3Resource"/> class for mocking. </summary>
        protected CustomModel3Resource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CustomModel3Resource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CustomModel3Resource(ArmClient client, CustomModel3Data data) : this(client, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CustomModel3Resource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CustomModel3Resource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _customModel3ClientDiagnostics = new ClientDiagnostics("ExactMatchFlattenInheritance", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string customModel3ApiVersion);
            _customModel3RestClient = new CustomModel3SRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, customModel3ApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/customModel3s";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CustomModel3Data Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get an CustomModel3.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel3s/{name}
        /// Operation Id: CustomModel3s_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CustomModel3Resource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _customModel3ClientDiagnostics.CreateScope("CustomModel3Resource.Get");
            scope.Start();
            try
            {
                var response = await _customModel3RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomModel3Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an CustomModel3.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel3s/{name}
        /// Operation Id: CustomModel3s_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CustomModel3Resource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _customModel3ClientDiagnostics.CreateScope("CustomModel3Resource.Get");
            scope.Start();
            try
            {
                var response = _customModel3RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomModel3Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
