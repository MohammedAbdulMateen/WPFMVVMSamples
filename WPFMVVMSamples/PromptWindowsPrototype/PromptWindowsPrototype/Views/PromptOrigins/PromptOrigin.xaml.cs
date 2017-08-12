//-----------------------------------------------------------------------
// <copyright file="PromptOrigin.xaml.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PromptWindowsPrototype.Views.PromptOrigins
{
    using System.Windows.Controls;
    using PWP.ViewModels.Views.PromptOrigins;

    /// <summary>
    /// Interaction logic for PromptOrigin.xaml
    /// </summary>
    public partial class PromptOrigin : UserControl, IPromptOriginView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOrigin"/> class.
        /// </summary>
        public PromptOrigin()
        {
            this.InitializeComponent();
        }
    }
}
