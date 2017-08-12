//-----------------------------------------------------------------------
// <copyright file="BaseViewModel.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PWP.ViewModels.Core
{
    using StructureMap;

    /// <summary>
    /// class BaseViewModel implements IViewModel, inherits BaseNotification
    /// </summary>
    public class BaseViewModel : BaseNotification, IViewModel
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseViewModel"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        /// <param name="container">The container.</param>
        public BaseViewModel(IView view, IContainer container)
        {
            this.View = view;
            this.View.DataContext = this;
            this.Container = container;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseViewModel"/> class.
        /// </summary>
        /// <param name="container">The container.</param>
        public BaseViewModel(IContainer container)
        {
            this.Container = container;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the container.
        /// </summary>
        /// <value>
        /// The container.
        /// </value>
        public IContainer Container { get; set; }

        /// <summary>
        /// Gets or sets the view.
        /// </summary>
        /// <value>
        /// The view.
        /// </value>
        public IView View { get; set; }

        /// <summary>
        /// Gets the view.
        /// </summary>
        /// <typeparam name="T">The element type of BaseViewModel</typeparam>
        /// <returns>An instance of IView type</returns>
        protected IView GetView<T>() where T : IViewModel
        {
            return this.Container.GetInstance<T>().View;
        }

        #endregion
    }
}
