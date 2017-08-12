//-----------------------------------------------------------------------
// <copyright file="IPromptOriginViewModel.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PWP.ViewModels.Views.PromptOrigins
{
    using System.Threading.Tasks;
    using FirstFloor.ModernUI.Windows.Controls;
    using PWP.Models.Views.PromptOrigins;
    using PWP.ViewModels.Core;

    /// <summary>
    /// interface IPromptOriginViewModel
    /// </summary>
    public interface IPromptOriginViewModel : IViewModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the prompt origins entity.
        /// </summary>
        /// <value>
        /// The prompt origins entity.
        /// </value>
        PromptOriginsModel PromptOriginsEntity { get; set; }

        /// <summary>
        /// Gets or sets the prompt window.
        /// </summary>
        /// <value>
        /// The prompt window.
        /// </value>
        ModernWindow PromptWindow { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Shows the prompt.
        /// </summary>
        /// <returns>An instance of Task</returns>
        Task ShowPrompt();

        #endregion
    }

    /// <summary>
    /// interface IPromptOriginView
    /// </summary>
    public interface IPromptOriginView : IView
    {
    }
}
