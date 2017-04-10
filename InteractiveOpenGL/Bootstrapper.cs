using System.Windows;
using InteractiveOpenGL.Views;
using Microsoft.Practices.ServiceLocation;
using Prism.Autofac;

namespace InteractiveOpenGL
{
	class Bootstrapper : AutofacBootstrapper
	{
		protected override DependencyObject CreateShell()
		{
			return ServiceLocator.Current.GetInstance<Shell>();
		}

		protected override void InitializeShell()
		{
			Application.Current.MainWindow.Show();
		}
	}
}
