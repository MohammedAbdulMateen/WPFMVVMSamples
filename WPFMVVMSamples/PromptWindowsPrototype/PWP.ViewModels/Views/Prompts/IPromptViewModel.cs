//-----------------------------------------------------------------------
// <copyright file="IPromptViewModel.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PWP.ViewModels.Views.Prompts
{
    using PWP.Models.Views.Prompts;
    using PWP.ViewModels.Core;

    /// <summary>
    /// interface IPromptViewModel
    /// </summary>
    public interface IPromptViewModel : IViewModel
    {
        /// <summary>
        /// Gets or sets the prompt data context.
        /// </summary>
        /// <value>
        /// The prompt data context.
        /// </value>
        object PromptDataContext { get; set; }

        /// <summary>
        /// Gets or sets the prompt entity.
        /// </summary>
        /// <value>
        /// The prompt entity.
        /// </value>
        PromptModel PromptEntity { get; set; }
    }

    /// <summary>
    /// interface IPromptView
    /// </summary>
    public interface IPromptView : IView
    {
    }
}
