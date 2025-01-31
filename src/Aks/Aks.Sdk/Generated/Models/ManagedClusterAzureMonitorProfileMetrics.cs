// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Metrics profile for the Azure Monitor managed service for Prometheus
    /// addon. Collect out-of-the-box Kubernetes infrastructure metrics to send
    /// to an Azure Monitor Workspace and configure additional scraping for
    /// custom targets. See aka.ms/AzureManagedPrometheus for an overview.
    /// </summary>
    public partial class ManagedClusterAzureMonitorProfileMetrics
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterAzureMonitorProfileMetrics class.
        /// </summary>
        public ManagedClusterAzureMonitorProfileMetrics()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterAzureMonitorProfileMetrics class.
        /// </summary>
        /// <param name="enabled">Whether to enable or disable the Azure
        /// Managed Prometheus addon for Prometheus monitoring. See
        /// aka.ms/AzureManagedPrometheus-aks-enable for details on enabling
        /// and disabling.</param>
        public ManagedClusterAzureMonitorProfileMetrics(bool enabled, ManagedClusterAzureMonitorProfileKubeStateMetrics kubeStateMetrics = default(ManagedClusterAzureMonitorProfileKubeStateMetrics))
        {
            Enabled = enabled;
            KubeStateMetrics = kubeStateMetrics;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether to enable or disable the Azure Managed
        /// Prometheus addon for Prometheus monitoring. See
        /// aka.ms/AzureManagedPrometheus-aks-enable for details on enabling
        /// and disabling.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kubeStateMetrics")]
        public ManagedClusterAzureMonitorProfileKubeStateMetrics KubeStateMetrics { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
