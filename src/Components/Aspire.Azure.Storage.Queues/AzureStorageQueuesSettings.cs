// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Azure.Core;

namespace Aspire.Azure.Storage.Queues;

/// <summary>
/// Provides the client configuration settings for connecting to Azure Storage Queues.
/// </summary>
public sealed class AzureStorageQueuesSettings
{
    /// <summary>
    /// A <see cref="Uri"/> referencing the queue service.
    /// This is likely to be similar to "https://{account_name}.queue.core.windows.net".
    /// </summary>
    /// <remarks>Must not contain shared access signature.</remarks>
    public Uri? ServiceUri { get; set; }

    /// <summary>
    /// Gets or sets the credential used to authenticate to the Queues Storage.
    /// </summary>
    public TokenCredential? Credential { get; set; }

    /// <summary>
    /// <para>Gets or sets a boolean value that indicates whether the Queues Storage health check is enabled or not.</para>
    /// <para>Enabled by default.</para>
    /// </summary>
    public bool HealthChecks { get; set; } = true;

    /// <summary>
    /// <para>Gets or sets a boolean value that indicates whether the OpenTelemetry tracing is enabled or not.</para>
    /// <para>Disabled by default.</para>
    /// </summary>
    /// <remarks>
    /// ActivitySource support in Azure SDK is experimental, the shape of Activities may change in the future without notice.
    /// It can be enabled by setting "Azure.Experimental.EnableActivitySource" <see cref="AppContext"/> switch to true.
    /// Or by setting "AZURE_EXPERIMENTAL_ENABLE_ACTIVITY_SOURCE" environment variable to "true".
    /// </remarks>
    public bool Tracing { get; set; }
}