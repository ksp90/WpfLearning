using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace _03_ApplicationEventLifeCycle
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            DebugUtilityLog.Log();
            base.OnStartup(e);
        }
        protected override void OnActivated(EventArgs e)
        {
            DebugUtilityLog.Log();
            base.OnActivated(e);
        }
        protected override void OnDeactivated(EventArgs e)
        {
            DebugUtilityLog.Log();
            base.OnDeactivated(e);
        }
        protected override void OnExit(ExitEventArgs e)
        {
            DebugUtilityLog.Log();
            base.OnExit(e);
        }
        protected override void OnFragmentNavigation(FragmentNavigationEventArgs e)
        {
            DebugUtilityLog.Log();
            base.OnFragmentNavigation(e);
        }
        protected override void OnLoadCompleted(NavigationEventArgs e)
        {
            DebugUtilityLog.Log();
            base.OnLoadCompleted(e);
        }
        protected override void OnNavigated(NavigationEventArgs e)
        {
            DebugUtilityLog.Log();
            base.OnNavigated(e);
        }
        protected override void OnNavigating(NavigatingCancelEventArgs e)
        {
            DebugUtilityLog.Log();
            base.OnNavigating(e);
        }
        protected override void OnNavigationFailed(NavigationFailedEventArgs e)
        {
            DebugUtilityLog.Log();
            base.OnNavigationFailed(e);
        }
        protected override void OnNavigationProgress(NavigationProgressEventArgs e)
        {
            DebugUtilityLog.Log();
            base.OnNavigationProgress(e);
        }
        protected override void OnNavigationStopped(NavigationEventArgs e)
        {
            DebugUtilityLog.Log();
            base.OnNavigationStopped(e);
        }
        protected override void OnSessionEnding(SessionEndingCancelEventArgs e)
        {
            DebugUtilityLog.Log();
            base.OnSessionEnding(e);
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            DebugUtilityLog.Log();
            MessageBox.Show("Exception received: " + e.Exception.ToString(), "Exception Handled at Application");
            e.Handled = true;
        }
    }
}
