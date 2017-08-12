//-----------------------------------------------------------------------
// <copyright file="App.xaml.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PromptWindowsPrototype
{
    using System.Windows;
    using PromptWindowsPrototype.Infrastructure;
    using PromptWindowsPrototype.Windows;
    using PWP.ViewModels.Windows.MainWindow;
    using StructureMap;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        public App()
        {
            Bootstrapper.Initialize();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Application.Startup" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.StartupEventArgs" /> that contains the event data.</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            IMainWindowViewModel window = ObjectFactory.GetInstance<IMainWindowViewModel>();
            this.MainWindow = (MainWindow)window.Window;
            MainWindow.ShowDialog();
            base.OnStartup(e);
        }
    }
}
