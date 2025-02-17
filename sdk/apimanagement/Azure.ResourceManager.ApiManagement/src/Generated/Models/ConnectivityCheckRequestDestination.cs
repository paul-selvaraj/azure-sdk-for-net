// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The connectivity check operation destination. </summary>
    public partial class ConnectivityCheckRequestDestination
    {
        /// <summary> Initializes a new instance of ConnectivityCheckRequestDestination. </summary>
        /// <param name="address"> Destination address. Can either be an IP address or a FQDN. </param>
        /// <param name="port"> Destination port. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="address"/> is null. </exception>
        public ConnectivityCheckRequestDestination(string address, long port)
        {
            if (address == null)
            {
                throw new ArgumentNullException(nameof(address));
            }

            Address = address;
            Port = port;
        }

        /// <summary> Destination address. Can either be an IP address or a FQDN. </summary>
        public string Address { get; }
        /// <summary> Destination port. </summary>
        public long Port { get; }
    }
}
