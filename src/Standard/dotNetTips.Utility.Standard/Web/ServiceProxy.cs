// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 04-02-2018
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="ServiceProxy.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace dotNetTips.Utility.Standard.Web
{
    /// <summary>
    /// Class ServiceProxy.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="System.IDisposable" />
    public abstract class ServiceProxy<T>
        where T : ICommunicationObject, IDisposable
    {
        /// <summary>
        /// The channel
        /// </summary>
        private T _channel;

        /// <summary>
        /// The channel factory
        /// </summary>
        private IChannelFactory<T> _channelFactory;

        /// <summary>
        /// The lock
        /// </summary>
        private readonly object _lock = new object();

        /// <summary>
        /// The service endpoint
        /// </summary>
        private readonly string _serviceEndpoint;
        /// <summary>
        /// The disposed
        /// </summary>
        protected bool disposed;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProxy{T}" /> class.
        /// </summary>
        /// <param name="serviceEndpoint">The service endpoint.</param>
        protected ServiceProxy(string serviceEndpoint)
        {
            this._serviceEndpoint = serviceEndpoint;
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        private void Initialize()
        {
            lock(this._lock)
            {
                if(this.Channel != null)
                {
                    return;
                }

                this._channelFactory = new ChannelFactory<T>(this._serviceEndpoint);
                this.Channel = this._channelFactory.CreateChannel(new EndpointAddress(this._serviceEndpoint));
            }
        }

        /// <summary>
        /// Closes the channel.
        /// </summary>
        protected void CloseChannel()
        {
            if(this.Channel != null)
            {
                ((ICommunicationObject)this.Channel).Close();
            }
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            // Do nothing if the object has already been disposed of.
            if(this.disposed)
            {
                return;
            }

            if (disposing)
            {
                lock(this._lock)
                {
                    // Release disposable objects used by this instance here.
                    if(this.Channel != null)
                    {
                        this.Channel.Dispose();
                    }
                }
            }

            // Release unmanaged resources here. Don't access reference type fields.

            // Remember that the object has been disposed of.
            this.disposed = true;
        }

        /// <summary>
        /// Gets the channel.
        /// </summary>
        /// <value>The channel.</value>
        protected T Channel
        {
            get
            {
                this.Initialize();
                return this._channel;
            }
            private set => this._channel = value;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public virtual void Dispose()
        {
            this.Dispose(true);

            // Unregister object for finalization.
            GC.SuppressFinalize(this);
        }
    }
}
