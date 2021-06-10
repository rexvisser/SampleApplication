using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.ViewModels
{
  /// <summary>
  /// Extension methods.
  /// </summary>
  public static class ViewModelExtensions
  {
    /// <summary>
    /// Add the entities from the list to the ObservableCollection.
    /// </summary>
    /// <param name="oc">The destination.</param>
    /// <param name="list">The source items.</param>
    public static void AddRange(this ObservableCollection<object> oc, List<object> list)
    {
      foreach (object item in list)
      {
        oc.Add(item);
      }
    }
  }
}
