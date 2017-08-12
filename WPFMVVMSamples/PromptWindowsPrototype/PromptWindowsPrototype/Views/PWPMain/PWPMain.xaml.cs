//-----------------------------------------------------------------------
// <copyright file="PWPMain.xaml.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PromptWindowsPrototype.Views.PWPMain
{
    using System.Windows.Controls;
    using PWP.ViewModels.Views.PWPMain;
    using StructureMap;

    /// <summary>
    /// Interaction logic for PWPMain.xaml
    /// </summary>
    public partial class PWPMain : UserControl, IPWPMainView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PWPMain"/> class.
        /// </summary>
        public PWPMain()
        {
            this.InitializeComponent();
            var pwpMainViewModel = ObjectFactory.GetInstance<IPWPMainViewModel>();
            this.DataContext = pwpMainViewModel.PWPMainDataContext;
        }
    }
}
