//-----------------------------------------------------------------------
// <copyright file="MainWindowViewModel.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PWP.ViewModels.Windows.MainWindow
{
    using PWP.ViewModels.Core;
    using StructureMap;

    /// <summary>
    /// class MainWindowViewModel implements IMainWindowViewModel, inherits BaseWindowViewModel
    /// </summary>
    public class MainWindowViewModel : BaseWindowViewModel, IMainWindowViewModel
    {
        #region Contructor

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        /// <param name="container">The container.</param>
        public MainWindowViewModel(IMainWindow view, IContainer container)
            : base(view, container)
        {
        }

        #endregion
    }
}
