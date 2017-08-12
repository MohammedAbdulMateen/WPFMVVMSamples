//-----------------------------------------------------------------------
// <copyright file="Prompt.xaml.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PromptWindowsPrototype.Views.Prompts
{
    using System.Windows.Controls;
    using PWP.ViewModels.Views.Prompts;    

    /// <summary>
    /// Interaction logic for Prompt.xaml
    /// </summary>
    public partial class Prompt : UserControl, IPromptView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt"/> class.
        /// </summary>
        public Prompt()
        {
            this.InitializeComponent();
        }
    }
}
