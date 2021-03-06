﻿// Copyright 2007-2016 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.RabbitMqTransport
{
    using System;
    using System.Threading.Tasks;
    using GreenPipes;
    using RabbitMQ.Client;
    using Topology;


    /// <summary>
    /// A RabbitMQ connection
    /// </summary>
    public interface ConnectionContext :
        PipeContext
    {
        /// <summary>
        /// The RabbitMQ Connection
        /// </summary>
        IConnection Connection { get; }

        /// <summary>
        /// The connection description, useful to debug output
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The Host Address for this connection
        /// </summary>
        Uri HostAddress { get; }

        IRabbitMqHostTopology Topology { get; }
        
        /// <summary>
        /// The host settings for the connection
        /// </summary>
        RabbitMqHostSettings HostSettings { get; }

        /// <summary>
        /// Create a model on the connection
        /// </summary>
        /// <returns></returns>
        Task<IModel> CreateModel();
    }
}