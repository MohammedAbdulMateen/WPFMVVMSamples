//-----------------------------------------------------------------------
// <copyright file="Bootstrapper.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PromptWindowsPrototype.Infrastructure
{
    using PromptWindowsPrototype.Views.PromptOrigins;
    using PromptWindowsPrototype.Views.Prompts;
    using PromptWindowsPrototype.Views.PWPMain;
    using PromptWindowsPrototype.Windows;
    using PWP.ViewModels.Views.PromptOrigins;
    using PWP.ViewModels.Views.Prompts;
    using PWP.ViewModels.Views.PWPMain;
    using PWP.ViewModels.Windows.MainWindow;
    using PWP.ViewModels.Windows.PromptWindow;
    using StructureMap;

    /// <summary>
    /// class Bootstrapper
    /// </summary>
    public static class Bootstrapper
    {
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public static void Initialize()
        {
            ObjectFactory.Initialize(OnInitialize);
        }

        /// <summary>
        /// Called when [initialize].
        /// </summary>
        /// <param name="x">The x.</param>
        private static void OnInitialize(IInitializationExpression x)
        {
            ////MainWindow
            x.For<IMainWindow>().Singleton().Use<MainWindow>();
            x.For<IMainWindowViewModel>().Singleton().Use<MainWindowViewModel>();

            ////PWPMain
            x.For<IPWPMainView>().Singleton().Use<PWPMain>();
            x.For<IPWPMainViewModel>().Singleton().Use<PWPMainViewModel>();

            ////PromptOrigin
            x.For<IPromptOriginView>().Use<PromptOrigin>();
            x.For<IPromptOriginViewModel>().Use<PromptOriginViewModel>();

            ////PromptWindow
            x.For<IPromptWindow>().Use<PromptWindow>();
            x.For<IPromptWindowViewModel>().Use<PromptWindowViewModel>();

            ////Prompt
            x.For<IPromptView>().Use<Prompt>();
            x.For<IPromptViewModel>().Use<PromptViewModel>();
        }
    }
}
