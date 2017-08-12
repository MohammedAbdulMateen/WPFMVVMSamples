//-----------------------------------------------------------------------
// <copyright file="PromptWindowViewModel.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PWP.ViewModels.Windows.PromptWindow
{
    using FirstFloor.ModernUI.Windows.Controls;
    using PWP.ViewModels.Core;
    using PWP.ViewModels.Utilities;
    using StructureMap;

    /// <summary>
    /// class PromptWindowViewModel implements IPromptWindowViewModel, inherits BaseWindowViewModel
    /// </summary>
    public class PromptWindowViewModel : BaseWindowViewModel, IPromptWindowViewModel
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptWindowViewModel"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        /// <param name="container">The container.</param>
        public PromptWindowViewModel(IPromptWindow view, IContainer container)
            : base(view, container)
        {
            this.PromptWindowLoaded = new DelegateCommand<object>(this.OnPromptWindowLoaded);
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the content of the prompt window.
        /// </summary>
        /// <value>
        /// The content of the prompt window.
        /// </value>
        public IView PromptWindowContent { get; set; }

        #endregion

        #region Public Delegates

        /// <summary>
        /// Gets or sets the prompt window loaded.
        /// </summary>
        /// <value>
        /// The prompt window loaded.
        /// </value>
        public DelegateCommand<object> PromptWindowLoaded { get; set; }

        #endregion

        #region Private Properties

        /// <summary>
        /// Gets or sets the prompt window object.
        /// </summary>
        /// <value>
        /// The prompt window object.
        /// </value>
        private ModernWindow PromptWindowObject { get; set; }

        #endregion

        /////// <summary>
        /////// The gw l_ style
        /////// </summary>
        ////private const int GWL_STYLE = -16;

        /////// <summary>
        /////// The w s_ sys menu
        /////// </summary>
        ////private const int WS_SYSMENU = 0x80000;

        /////// <summary>
        /////// Gets the window long.
        /////// </summary>
        /////// <param name="hWnd">The h WND.</param>
        /////// <param name="nIndex">Index of the n.</param>
        /////// <returns>A 32-bit signed integer</returns>
        ////[DllImport("user32.dll", SetLastError = true)]
        ////private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        /////// <summary>
        /////// Sets the window long.
        /////// </summary>
        /////// <param name="hWnd">The h WND.</param>
        /////// <param name="nIndex">Index of the n.</param>
        /////// <param name="dwNewLong">The dw new long.</param>
        /////// <returns>A 32-bit signed integer</returns>
        ////[DllImport("user32.dll")]
        ////private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        #region Private Methods

        /// <summary>
        /// Called when [prompt window loaded].
        /// </summary>
        /// <param name="obj">The object.</param>
        private void OnPromptWindowLoaded(object obj)
        {
            if (obj != null)
            {
                ////if (PromptWindowObject == null)
                ////{
                ////    PromptWindowObject = obj as ModernWindow;
                ////    var hwnd = new WindowInteropHelper(PromptWindowObject).Handle;
                ////    SetWindowLong(hwnd, GWL_STYLE, GetWindowLong(hwnd, GWL_STYLE) & ~WS_SYSMENU);
                ////}
            }
        }

        #endregion
    }
}
