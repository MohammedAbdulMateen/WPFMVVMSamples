//-----------------------------------------------------------------------
// <copyright file="IPWPMainViewModel.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PWP.ViewModels.Views.PWPMain
{
    using System.Collections.ObjectModel;
    using System.Windows.Controls;
    using FirstFloor.ModernUI.Windows.Controls;
    using PWP.ViewModels.Core;    

    /// <summary>
    /// interface IPWPMainViewModel
    /// </summary>
    public interface IPWPMainViewModel : IViewModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the PWP main data context.
        /// </summary>
        /// <value>
        /// The PWP main data context.
        /// </value>
        object PWPMainDataContext { get; set; }

        /// <summary>
        /// Gets or sets the prompt origin collection.
        /// </summary>
        /// <value>
        /// The prompt origin collection.
        /// </value>
        ObservableCollection<ContentControl> PromptOriginCollection { get; set; }

        /// <summary>
        /// Gets or sets the prompt windows collection.
        /// </summary>
        /// <value>
        /// The prompt windows collection.
        /// </value>
        ObservableCollection<ModernWindow> PromptWindowsCollection { get; set; }

        /// <summary>
        /// Gets or sets the prompts collection.
        /// </summary>
        /// <value>
        /// The prompts collection.
        /// </value>
        ObservableCollection<UserControl> PromptsCollection { get; set; }

        #endregion
    }

    /// <summary>
    /// interface IPWPMainView
    /// </summary>
    public interface IPWPMainView : IView
    {
    }
}
