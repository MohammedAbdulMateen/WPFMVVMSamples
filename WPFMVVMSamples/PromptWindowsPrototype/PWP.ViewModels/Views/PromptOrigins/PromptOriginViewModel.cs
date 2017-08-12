//-----------------------------------------------------------------------
// <copyright file="PromptOriginViewModel.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PWP.ViewModels.Views.PromptOrigins
{
    using System;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using FirstFloor.ModernUI.Windows.Controls;
    using PWP.Models.Views.PromptOrigins;
    using PWP.ViewModels.Core;
    using PWP.ViewModels.Views.Prompts;
    using PWP.ViewModels.Views.PWPMain;
    using PWP.ViewModels.Windows.PromptWindow;
    using StructureMap;

    /// <summary>
    /// class PromptOriginViewModel implements IPromptOriginViewModel, inherits BaseViewModel
    /// </summary>
    public class PromptOriginViewModel : BaseViewModel, IPromptOriginViewModel
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOriginViewModel"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        /// <param name="container">The container.</param>
        public PromptOriginViewModel(IPromptOriginView view, IContainer container)
            : base(view, container)
        {
            this.PromptOriginsEntity = new PromptOriginsModel();
            this.PWPMainViewModel = container.GetInstance<IPWPMainViewModel>();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the prompt origins entity.
        /// </summary>
        /// <value>
        /// The prompt origins entity.
        /// </value>
        public PromptOriginsModel PromptOriginsEntity { get; set; }

        /// <summary>
        /// Gets or sets the prompt window.
        /// </summary>
        /// <value>
        /// The prompt window.
        /// </value>
        public ModernWindow PromptWindow { get; set; }

        #endregion

        #region Private Properties

        /// <summary>
        /// Gets or sets the PWP main view model.
        /// </summary>
        /// <value>
        /// The PWP main view model.
        /// </value>
        private IPWPMainViewModel PWPMainViewModel { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Shows the prompt.
        /// </summary>
        /// <returns>
        /// An instance of Task
        /// </returns>
        public async Task ShowPrompt()
        {
            await Task.Delay(this.PromptOriginsEntity.PromptOriginsIdentity * 1000);
            this.PromptWindow = ObjectFactory.GetInstance<IPromptWindowViewModel>().Window as ModernWindow;
            this.PromptWindow.Title = string.Concat("Control ", this.PromptOriginsEntity.PromptOriginsIdentity);
            this.PromptWindow.Tag = this.PromptOriginsEntity.PromptOriginsIdentity;
            this.PromptWindow.Owner = Application.Current.MainWindow;

            // Store Window object in PromptWindowsCollection
            this.PWPMainViewModel.PromptWindowsCollection.Add(this.PromptWindow);
            this.PromptWindow.Show(); // inorder to retrieve the ModernFrame the ModernWindow is to be shown first

            ModernFrame frameContent = (ModernFrame)this.PromptWindow.Template.FindName("ContentFrame", this.PromptWindow);
            UserControl userControl = new UserControl { Content = GetView<IPromptViewModel>(), Tag = this.PromptOriginsEntity.PromptOriginsIdentity };
            frameContent.Content = userControl;
            this.PWPMainViewModel.PromptsCollection.Add(userControl);

            IPromptViewModel promptViewModel = (IPromptViewModel)((IView)userControl.Content).DataContext;
            promptViewModel.PromptEntity.Identity = this.PromptOriginsEntity.PromptOriginsIdentity;
        }

        #endregion
    }
}
