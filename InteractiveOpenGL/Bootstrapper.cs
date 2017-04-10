using Prism.Mef;
using System.Windows;
using InteractiveOpenGL.Views;

namespace InteractiveOpenGL
{
	class Bootstrapper : MefBootstrapper
	{
		protected override DependencyObject CreateShell()
		{
			return new Shell();
		}

		protected override void InitializeShell()
		{
			Application.Current.MainWindow.Show();
		}
	}
}
