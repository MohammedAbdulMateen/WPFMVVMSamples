//-----------------------------------------------------------------------
// <copyright file="EventTriggerHandler.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PWP.ViewModels.Utilities
{
    using System;
    using System.Windows;

    /// <summary>
    /// EventTriggerHandler to handle propagating of event to parent elements
    /// </summary>
    public class EventTriggerHandler : System.Windows.Interactivity.EventTrigger
    {
        /// <summary>
        /// Overrides the OnEvent base implementation
        /// </summary>
        /// <param name="eventArgs">The Interactive event args</param>
        /// <remarks>
        /// Override this to provide more granular control over when actions associated with this trigger will be invoked.
        /// </remarks>
        protected override void OnEvent(EventArgs eventArgs)
        {
            var routedEventArgs = eventArgs as RoutedEventArgs;
            if (routedEventArgs != null && routedEventArgs.RoutedEvent != null)
            {
                routedEventArgs.Handled = true;
            }

            base.OnEvent(eventArgs);
        }
    }
}
