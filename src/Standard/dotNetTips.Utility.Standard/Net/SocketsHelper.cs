// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-22-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-22-2020
// ***********************************************************************
// <copyright file="SocketsHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Net;
using System.Net.Sockets;
using dotNetTips.Utility.Standard.Common;

namespace dotNetTips.Utility.Standard.Net
{
    /// <summary>
    /// Helper methods for Sockets.
    /// </summary>
    [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
    public static class SocketsHelper
    {
        /// <summary>
        /// Creates the and start TCP listener on anonymous port. Binds to an OS-assigned port.
        /// </summary>
        /// <returns>System.ValueTuple&lt;TcpListener, System.Int32&gt;.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static (TcpListener listener, int port) CreateAndStartTcpListenerOnAnonymousPort()
        {
            var listener = new TcpListener(IPAddress.IPv6Any, 0);
            listener.Server.DualMode = true;

            listener.Start();
            var port = ((IPEndPoint)listener.LocalEndpoint).Port;

            return (listener, port);
        }
    }
}
