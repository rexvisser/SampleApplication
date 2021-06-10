using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SampleApplication.Models
{
  /// <summary>
  /// Common things for all Models.
  /// </summary>
  public class ModelBase : INotifyPropertyChanged
  {
    /// <summary>
    /// Used to indicate that a property has changed and the UI should update.
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// Used to signal the UI that a property value has changed.
    /// </summary>
    /// <param name="propertyName">The name of the property that changed.</param>
    public void OnPropertyChanged(string propertyName)
    {
      this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    /// <summary>
    /// Checks if a property already matches a desired value. Sets the property and
    /// notifies listeners only when necessary.
    /// </summary>
    /// <typeparam name="T">Type of the property.</typeparam>
    /// <param name="storage">Reference to a property with both getter and setter.</param>
    /// <param name="value">Desired value for the property.</param>
    /// <param name="propertyName">Name of the property used to notify listeners. This
    /// value is optional and can be provided automatically when invoked from compilers that
    /// support CallerMemberName.</param>
    /// <returns>True if the value was changed, false if the existing value matched the
    /// desired value.</returns>
    /// <remarks>Taken from Prism.</remarks>
    protected virtual bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
    {
      if (EqualityComparer<T>.Default.Equals(storage, value))
      {
        return false;
      }

      storage = value;
      this.OnPropertyChanged(propertyName);
      return true;
    }
  }
}
