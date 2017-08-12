//-----------------------------------------------------------------------
// <copyright file="IWindowViewModel.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PWP.ViewModels.Core
{
    /// <summary>
    /// interface IWindowViewModel
    /// </summary>
    public interface IWindowViewModel
    {
        /// <summary>
        /// Gets or sets the window.
        /// </summary>
        /// <value>
        /// The window.
        /// </value>
        IWindow Window { get; set; }
    }

    /// <summary>
    /// interface IWindow
    /// </summary>
    public interface IWindow
    {
        /// <summary>
        /// Gets or sets the data context.
        /// </summary>
        /// <value>
        /// The data context.
        /// </value>
        object DataContext { get; set; }
    }
}
