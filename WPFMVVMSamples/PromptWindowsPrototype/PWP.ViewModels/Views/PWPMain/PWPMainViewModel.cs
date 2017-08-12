//-----------------------------------------------------------------------
// <copyright file="PWPMainViewModel.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PWP.ViewModels.Views.PWPMain
{
    using System.Collections.ObjectModel;
    using System.Windows.Controls;
    using System.Windows.Media;
    using FirstFloor.ModernUI.Windows.Controls;
    using PWP.ViewModels.Core;
    using PWP.ViewModels.Utilities;
    using PWP.ViewModels.Views.PromptOrigins;
    using StructureMap;

    /// <summary>
    /// class PWPMainViewModel implements IPWPMainViewModel, inherits BaseViewModel
    /// </summary>
    public class PWPMainViewModel : BaseViewModel, IPWPMainViewModel
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PWPMainViewModel"/> class.
        /// </summary>
        /// <param name="container">The container.</param>
        public PWPMainViewModel(IContainer container)
            : base(container)
        {
            this.PWPMainDataContext = this;
            this.PWPMainRootGridLoaded = new DelegateCommand<object>(this.OnPWPMainRootGridLoaded);
            this.PromptOriginCollection = new ObservableCollection<ContentControl>();
            this.PromptWindowsCollection = new ObservableCollection<ModernWindow>();
            this.PromptsCollection = new ObservableCollection<UserControl>();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the PWP main data context.
        /// </summary>
        /// <value>
        /// The PWP main data context.
        /// </value>
        public object PWPMainDataContext { get; set; }

        /// <summary>
        /// Gets or sets the PWP main root grid.
        /// </summary>
        /// <value>
        /// The PWP main root grid.
        /// </value>
        public Grid PWPMainRootGrid { get; set; }

        /// <summary>
        /// Gets or sets the prompt origin collection.
        /// </summary>
        /// <value>
        /// The prompt origin collection.
        /// </value>
        public ObservableCollection<ContentControl> PromptOriginCollection { get; set; }

        /// <summary>
        /// Gets or sets the prompt windows collection.
        /// </summary>
        /// <value>
        /// The prompt windows collection.
        /// </value>
        public ObservableCollection<ModernWindow> PromptWindowsCollection { get; set; }

        /// <summary>
        /// Gets or sets the prompts collection.
        /// </summary>
        /// <value>
        /// The prompts collection.
        /// </value>
        public ObservableCollection<UserControl> PromptsCollection { get; set; }

        #endregion

        #region Public Delegates

        /// <summary>
        /// Gets or sets the PWP main root grid loaded.
        /// </summary>
        /// <value>
        /// The PWP main root grid loaded.
        /// </value>
        public DelegateCommand<object> PWPMainRootGridLoaded { get; set; }

        #endregion

        #region Private Methods

        /// <summary>
        /// Called when [PWP main root grid loaded].
        /// </summary>
        /// <param name="obj">The object.</param>
        private void OnPWPMainRootGridLoaded(object obj)
        {
            if (obj != null && this.PWPMainRootGrid == null)
            {
                this.PWPMainRootGrid = obj as Grid;
                int controlCount = 1;
                const int MaxControlCount = 2;
                for (int i = 0; i < 1; i++)
                {
                    this.PWPMainRootGrid.RowDefinitions.Add(new RowDefinition());
                }

                for (int i = 0; i < 2; i++)
                {
                    ////this.PWPMainRootGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
                    this.PWPMainRootGrid.ColumnDefinitions.Add(new ColumnDefinition());
                }

                for (; controlCount <= MaxControlCount; controlCount++)
                {
                    ContentControl contentControl = new ContentControl { Content = GetView<IPromptOriginViewModel>(), Tag = controlCount };
                    IPromptOriginViewModel promptOriginViewModel = (IPromptOriginViewModel)((IView)contentControl.Content).DataContext;
                    promptOriginViewModel.PromptOriginsEntity.PromptOriginsText = string.Concat("Control ", controlCount);
                    promptOriginViewModel.PromptOriginsEntity.PromptOriginsIdentity = controlCount;
                    if (controlCount % 2 == 0)
                    {
                        promptOriginViewModel.PromptOriginsEntity.PromptOriginsBrush = Brushes.SkyBlue;
                    }
                    else
                    {
                        promptOriginViewModel.PromptOriginsEntity.PromptOriginsBrush = Brushes.SteelBlue;
                    }

                    Grid.SetRow(contentControl, 0);
                    Grid.SetColumn(contentControl, controlCount - 1);
                    this.PWPMainRootGrid.Children.Add(contentControl);
                    this.PromptOriginCollection.Add(contentControl);
                    promptOriginViewModel.ShowPrompt();
                }
            }
        }

        #endregion
    }
}
