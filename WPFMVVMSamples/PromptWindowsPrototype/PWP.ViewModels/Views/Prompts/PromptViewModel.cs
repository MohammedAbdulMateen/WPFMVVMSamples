//-----------------------------------------------------------------------
// <copyright file="PromptViewModel.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PWP.ViewModels.Views.Prompts
{
    using System;
    using System.Linq;
    using System.Windows;
    using System.Windows.Controls;
    using PWP.Models.Views.Prompts;
    using PWP.ViewModels.Core;
    using PWP.ViewModels.Utilities;
    using PWP.ViewModels.Views.PromptOrigins;
    using PWP.ViewModels.Views.PWPMain;
    using StructureMap;

    /// <summary>
    /// class PromptViewModel implements IPromptViewModel, inherits BaseViewModel
    /// </summary>
    public class PromptViewModel : BaseViewModel, IPromptViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PromptViewModel" /> class.
        /// </summary>
        /// <param name="view">The view.</param>
        /// <param name="container">The container.</param>
        public PromptViewModel(IPromptView view, IContainer container)
            : base(view, container)
        {
            this.PromptEntity = new PromptModel();
            this.SendPromptResponse = new DelegateCommand<object>(this.OnSendPromptResponse);
            this.PWPMainViewModel = container.GetInstance<IPWPMainViewModel>();
        }

        #region Public Properties

        /// <summary>
        /// Gets or sets the prompt data context.
        /// </summary>
        /// <value>
        /// The prompt data context.
        /// </value>
        public object PromptDataContext { get; set; }

        /// <summary>
        /// Gets or sets the prompt entity.
        /// </summary>
        /// <value>
        /// The prompt entity.
        /// </value>
        public PromptModel PromptEntity { get; set; }

        #endregion

        #region Public Delegates

        /// <summary>
        /// Gets or sets the send prompt response.
        /// </summary>
        /// <value>
        /// The send prompt response.
        /// </value>
        public DelegateCommand<object> SendPromptResponse { get; set; }

        #endregion

        #region Private Properties

        /// <summary>
        /// Gets or sets the PWP main view model.
        /// </summary>
        /// <value>
        /// The PWP main view model.
        /// </value>
        private IPWPMainViewModel PWPMainViewModel { get; set; }

        /// <summary>
        /// Gets or sets the prompt origin view model.
        /// </summary>
        /// <value>
        /// The prompt origin view model.
        /// </value>
        private IPromptOriginViewModel PromptOriginViewModel { get; set; }

        #endregion

        #region Private Methods

        /// <summary>
        /// Called when [send prompt response].
        /// </summary>
        /// <param name="obj">The object.</param>
        private void OnSendPromptResponse(object obj)
        {
            if (this.PWPMainViewModel.PromptOriginCollection.Any(x => Convert.ToInt16(x.Tag) == this.PromptEntity.Identity))
            {
                ContentControl contentControl = (ContentControl)this.PWPMainViewModel.PromptOriginCollection.FirstOrDefault(x => Convert.ToInt16(x.Tag) == this.PromptEntity.Identity);
                this.PromptOriginViewModel = (IPromptOriginViewModel)((IView)contentControl.Content).DataContext;
                this.PWPMainViewModel.PromptWindowsCollection.Remove(this.PromptOriginViewModel.PromptWindow);
                if (this.PWPMainViewModel.PromptsCollection.Any(x => Convert.ToInt16(x.Tag) == this.PromptEntity.Identity))
                {
                    this.PWPMainViewModel.PromptsCollection.Remove((UserControl)this.PWPMainViewModel.PromptsCollection.FirstOrDefault(x => Convert.ToInt16(x.Tag) == this.PromptEntity.Identity));
                }

                this.PromptOriginViewModel.PromptWindow.Close();
                this.PromptOriginViewModel.PromptOriginsEntity.PromptOriginsResponse = this.PromptEntity.PromptResponse;
                Application.Current.MainWindow.Focus();
            }
        }

        #endregion
    }
}
