using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using SampleApplication.Models;

namespace SampleApplication.ViewModels
{
  /// <summary>
  /// The View model for the MainWindow.
  /// </summary>
  public class MainViewModel : ModelBase
  {
    private string statusMessage;

    /// <summary>
    /// Status message to display to the user.
    /// </summary>
    public string StatusMessage
    {
      get => this.statusMessage;
      set => this.SetProperty<string>(ref this.statusMessage, value);
    }

    /// <summary>
    /// Command to execute from the user interface.
    /// </summary>
    /// <param name="commandName">The name of the command to execute.</param>
    /// <param name="target">The object to act on.</param>
    internal void MenuCommand(string commandName, object target)
    {
      switch (commandName)
      {
        case "Clear":
          this.StatusMessage = string.Empty;
          break;
        case "ShowMsg":
          this.StatusMessage = "Hello from the Button.";
          break;
        default:
          this.StatusMessage = commandName;
          break;
      }
    }
  }
}
