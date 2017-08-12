//-----------------------------------------------------------------------
// <copyright file="IViewModel.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PWP.ViewModels.Core
{
    /// <summary>
    /// interface IViewModel
    /// </summary>
    public interface IViewModel
    {
        /// <summary>
        /// Gets or sets the view.
        /// </summary>
        /// <value>
        /// The view.
        /// </value>
        IView View { get; set; }
    }

    /// <summary>
    /// interface IView
    /// </summary>
    public interface IView
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
