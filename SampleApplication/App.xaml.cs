using System.Windows;
using Ninject;
using SampleApplication.Infrastructure;
using SampleApplication.Views;

namespace SampleApplication
{
  /// <summary>
  /// Interaction logic for App.xaml.
  /// </summary>
  public partial class App : Application
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="App"/> class.
    /// </summary>
    public App()
    {
      this.ConfigureContainer();
      this.ComposeObjects();
    }

    /// <summary>
    /// Main application Ninject Container.
    /// </summary>
    public IKernel NinjectContainer { get; } = new StandardKernel(new NinjectModules());

    /// <summary>
    /// Configure the Ninject container here.
    /// </summary>
    public void ConfigureContainer()
    {
    }

    /// <summary>
    /// Create the initial objects here.
    /// </summary>
    public void ComposeObjects()
    {
      Application.Current.MainWindow = this.NinjectContainer.Get<MainWindow>();
      Application.Current.MainWindow.Show();
    }
  }
}
