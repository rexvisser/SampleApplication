using Ninject.Extensions.Factory;
using Ninject.Modules;
using SampleApplication.ViewModels;
using SampleApplication.Views;

namespace SampleApplication.Infrastructure
{
  /// <summary>
  /// Module for Ninject to define types.
  /// </summary>
  public class NinjectModules : NinjectModule
  {
    /// <summary>
    /// Define bindings.
    /// </summary>
    public override void Load()
    {
      this.Bind<IViewFactory>().ToFactory();

      this.Bind<MainViewModel>().ToSelf().InSingletonScope();
    }
  }
}
