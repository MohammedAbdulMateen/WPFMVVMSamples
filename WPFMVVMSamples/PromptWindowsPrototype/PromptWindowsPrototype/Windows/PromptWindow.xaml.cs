//-----------------------------------------------------------------------
// <copyright file="PromptWindow.xaml.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PromptWindowsPrototype.Windows
{
    using FirstFloor.ModernUI.Windows.Controls;
    using PWP.ViewModels.Windows.PromptWindow;

    /// <summary>
    /// Interaction logic for PromptWindow.xaml
    /// </summary>
    public partial class PromptWindow : ModernWindow, IPromptWindow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PromptWindow"/> class.
        /// </summary>
        public PromptWindow()
        {
            this.InitializeComponent();
        }
    }
}
