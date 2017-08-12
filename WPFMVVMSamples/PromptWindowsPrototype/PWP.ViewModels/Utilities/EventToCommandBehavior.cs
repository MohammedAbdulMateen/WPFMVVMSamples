//-----------------------------------------------------------------------
// <copyright file="EventToCommandBehavior.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PWP.ViewModels.Utilities
{
    using System;
    using System.Reflection;
    using System.Windows;
    using System.Windows.Input;
    using System.Windows.Interactivity;

    /// <summary>
    /// Behavior that will connect an UI event to a view model Command,
    /// allowing the event arguments to be passed as the CommandParameter.
    /// </summary>
    public class EventToCommandBehavior : Behavior<FrameworkElement>
    {
        /// <summary>
        /// The event property
        /// </summary>
        public static readonly DependencyProperty EventProperty = DependencyProperty.Register("Event", typeof(string), typeof(EventToCommandBehavior), new PropertyMetadata(null, OnEventChanged));

        /// <summary>
        /// The command property
        /// </summary>
        public static readonly DependencyProperty CommandProperty = DependencyProperty.Register("Command", typeof(ICommand), typeof(EventToCommandBehavior), new PropertyMetadata(null));

        /// <summary>
        /// The pass arguments property
        /// </summary>
        public static readonly DependencyProperty PassArgumentsProperty = DependencyProperty.Register("PassArguments", typeof(bool), typeof(EventToCommandBehavior), new PropertyMetadata(false));

        /// <summary>
        /// The _handler
        /// </summary>
        private Delegate handler;

        /// <summary>
        /// The _old event
        /// </summary>
        private EventInfo oldEvent;

        /// <summary>
        /// Gets or sets the event.
        /// </summary>
        /// <value>
        /// The event.
        /// </value>
        public string Event
        {
            get
            {
                return (string)GetValue(EventProperty);
            }

            set
            {
                this.SetValue(EventProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the command.
        /// </summary>
        /// <value>
        /// The command.
        /// </value>
        public ICommand Command
        {
            get
            {
                return (ICommand)GetValue(CommandProperty);
            }

            set
            {
                this.SetValue(CommandProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [pass arguments]. PassArguments (default: false)
        /// </summary>
        /// <value>
        ///   <c>true</c> if [pass arguments]; otherwise, <c>false</c>.
        /// </value>
        public bool PassArguments
        {
            get
            {
                return (bool)GetValue(PassArgumentsProperty);
            }

            set
            {
                this.SetValue(PassArgumentsProperty, value);
            }
        }

        /// <summary>
        /// Called after the behavior is attached to an AssociatedObject.
        /// </summary>
        /// <remarks>
        /// Override this to hook up functionality to the AssociatedObject.
        /// </remarks>
        protected override void OnAttached()
        {
            this.AttachHandler(this.Event); // initial set
        }

        /// <summary>
        /// Called when [event changed].
        /// </summary>
        /// <param name="d">The d.</param>
        /// <param name="e">The <see cref="DependencyPropertyChangedEventArgs"/> instance containing the event data.</param>
        private static void OnEventChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var beh = (EventToCommandBehavior)d;

            if (beh.AssociatedObject != null)
            {
                // is not yet attached at initial load
                beh.AttachHandler((string)e.NewValue);
            }
        }

        /// <summary>
        /// Attaches the handler to the event
        /// </summary>
        /// <param name="eventName">Name of the event.</param>
        /// <exception cref="System.ArgumentException">throws ArgumentException</exception>
        private void AttachHandler(string eventName)
        {
            // detach old event
            if (this.oldEvent != null)
            {
                this.oldEvent.RemoveEventHandler(this.AssociatedObject, this.handler);
            }

            // attach new event
            if (!string.IsNullOrEmpty(eventName))
            {
                EventInfo ei = this.AssociatedObject.GetType().GetEvent(eventName);
                if (ei != null)
                {
                    MethodInfo mi = this.GetType().GetMethod("ExecuteCommand", BindingFlags.Instance | BindingFlags.NonPublic);
                    this.handler = Delegate.CreateDelegate(ei.EventHandlerType, this, mi);
                    ei.AddEventHandler(this.AssociatedObject, this.handler);
                    this.oldEvent = ei; // store to detach in case the Event property changes
                }
                else
                {
                    throw new ArgumentException(string.Format("The event '{0}' was not found on type '{1}'", eventName, this.AssociatedObject.GetType().Name));
                }
            }
        }

        /// <summary>
        /// Executes the Command
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ExecuteCommand(object sender, EventArgs e)
        {
            object parameter = this.PassArguments ? e : null;
            if (this.Command != null)
            {
                if (this.Command.CanExecute(parameter))
                {
                    this.Command.Execute(parameter);
                }
            }
        }
    }
}
