//-----------------------------------------------------------------------
// <copyright file="BaseWindowViewModel.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PWP.ViewModels.Core
{
    using StructureMap;

    /// <summary>
    /// class BaseWindowViewModel implements IWindowViewModel, inherits BaseNotification
    /// </summary>
    public class BaseWindowViewModel : BaseNotification, IWindowViewModel
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseWindowViewModel"/> class.
        /// </summary>
        /// <param name="window">The window.</param>
        /// <param name="container">The container.</param>
        public BaseWindowViewModel(IWindow window, IContainer container)
        {
            this.Window = window;
            this.Window.DataContext = this;
            this.Container = container;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the view.
        /// </summary>
        /// <value>
        /// The view.
        /// </value>
        public IView View { get; set; }

        /// <summary>
        /// Gets or sets the container.
        /// </summary>
        /// <value>
        /// The container.
        /// </value>
        public IContainer Container { get; set; }

        /// <summary>
        /// Gets or sets the window.
        /// </summary>
        /// <value>
        /// The window.
        /// </value>
        public IWindow Window { get; set; }

        #endregion

        #region Protected Helper Methods

        /// <summary>
        /// Gets the view.
        /// </summary>
        /// <typeparam name="T">The element type of BaseWindowViewModel</typeparam>
        /// <returns>An instance of IView type</returns>
        public IView GetView<T>() where T : IViewModel
        {
            return this.Container.GetInstance<T>().View;
        }

        /// <summary>
        /// Shows the view.
        /// </summary>
        /// <typeparam name="T">The element type of BaseWindowViewModel</typeparam>
        protected void ShowView<T>() where T : IViewModel
        {
            this.View = this.Container.GetInstance<T>().View;
        }

        #endregion
    }
}
