//-----------------------------------------------------------------------
// <copyright file="IPromptWindowViewModel.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PWP.ViewModels.Windows.PromptWindow
{
    using System;
    using PWP.ViewModels.Core;

    /// <summary>
    /// interface IPromptWindowViewModel
    /// </summary>
    public interface IPromptWindowViewModel : IWindowViewModel
    {
        /// <summary>
        /// Gets or sets the content of the prompt window.
        /// </summary>
        /// <value>
        /// The content of the prompt window.
        /// </value>
        IView PromptWindowContent { get; set; }
    }
}
