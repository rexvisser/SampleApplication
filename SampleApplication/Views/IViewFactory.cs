using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Views
{
  /// <summary>
  /// Factories for Ninject to user when making views.
  /// </summary>
  public interface IViewFactory
  {
    /// <summary>
    /// Create a MainWindow using Ninject.
    /// </summary>
    /// <returns>MainWindow.</returns>
    MainWindow CreateMainWindow();
  }
}
