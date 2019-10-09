// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-09-2018
//
// Last Modified By : David McCarter
// Last Modified On : 07-30-2019
// ***********************************************************************
// <copyright file="SystemEvents.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class SystemEvents.
    /// </summary>
    /// TODO Edit XML Comment Template for SystemEvents
    public static partial class SystemEvents
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemEvents" /> class.
        /// </summary>
        /// TODO Edit XML Comment Template for #ctor
        static SystemEvents()
        {
            NetworkChange.NetworkAddressChanged += new NetworkAddressChangedEventHandler(NetworkAddressChangedCallback);
            NetworkChange.NetworkAvailabilityChanged += NetworkChange_NetworkAvailabilityChanged;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;
            AppDomain.CurrentDomain.FirstChanceException += CurrentDomain_FirstChanceException;
        }

        /// <summary>
        /// Handles the FirstChanceException event of the CurrentDomain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs" /> instance containing the event data.</param>
        /// TODO Edit XML Comment Template for CurrentDomain_FirstChanceException
        private static void CurrentDomain_FirstChanceException(object sender, System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs e)
        {
            
        }

        /// <summary>
        /// Handles the ProcessExit event of the CurrentDomain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        /// TODO Edit XML Comment Template for CurrentDomain_ProcessExit
        private static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// Handles the UnhandledException event of the CurrentDomain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="UnhandledExceptionEventArgs" /> instance containing the event data.</param>
        /// TODO Edit XML Comment Template for CurrentDomain_UnhandledException
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var eventArgs = new SystemChangedEventArgs { SystemEventType = SystemEventType.UnhandledException };

            var eventInfo = new UnhandledExceptionEventInformation { IsTerminating = e.IsTerminating, Exception = e.ExceptionObject as LoggableException };

            eventArgs.EventInformation = new UnhandledExceptionEventInformation[] { eventInfo };

            OnSystemChanged(eventArgs);
        }

        /// <summary>
        /// Handles the NetworkAvailabilityChanged event of the NetworkChange control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="NetworkAvailabilityEventArgs" /> instance containing the event data.</param>
        /// TODO Edit XML Comment Template for NetworkChange_NetworkAvailabilityChanged
        private static void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            var eventInfo = new List<NetworkAvailabilityChangedEventInformation>(1)
            {
                new NetworkAvailabilityChangedEventInformation { NetworkAvailable = e.IsAvailable }
            };

            Trace.Write($"Network availble: {e.IsAvailable}");

            var eventArgs = new SystemChangedEventArgs { SystemEventType = SystemEventType.NetworkAvailabilityChanged, EventInformation = eventInfo };

            OnSystemChanged(eventArgs);
        }

        /// <summary>
        /// Networks the address changed callback.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        /// TODO Edit XML Comment Template for NetworkAddressChangedCallback
        private static void NetworkAddressChangedCallback(object sender, EventArgs e)
        {
            var adapters = NetworkInterface.GetAllNetworkInterfaces();

            var eventInfo = new List<NetworkAddressChangedEventInformation>(adapters.Count());

            eventInfo.AddRange(adapters.Select(adapter => new NetworkAddressChangedEventInformation
            {
                Id = adapter.Id,
                Name = adapter.Name,
                OperationalStatus = adapter.OperationalStatus
            }));

            eventInfo.TrimExcess();

            var eventArgs = new SystemChangedEventArgs
            {
                SystemEventType = SystemEventType.NetworkAddressChanged,
                EventInformation = eventInfo
            };

            OnSystemChanged(eventArgs);
        }

        /// <summary>
        /// Occurs when [system changed].
        /// </summary>
        /// TODO Edit XML Comment Template for SystemChanged
        public static event EventHandler<SystemChangedEventArgs> SystemChanged;

        /// <summary>
        /// Handles the <see cref="E:SystemChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="SystemChangedEventArgs" /> instance containing the event data.</param>
        /// TODO Edit XML Comment Template for OnSystemChanged
        private static void OnSystemChanged(SystemChangedEventArgs e) => SystemChanged?.Invoke(AppDomain.CurrentDomain, e);

    }
}