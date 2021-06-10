using System.Windows.Input;

namespace SampleApplication.Infrastructure
{
  /// <summary>
  /// Custom commands for this application.
  /// </summary>
  public static class Commands
  {
    /// <summary>
    /// Command for use in the MainWindow.
    /// </summary>
    public static readonly RoutedCommand MainCommand = new RoutedCommand();
  }
}
