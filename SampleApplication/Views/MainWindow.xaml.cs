using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SampleApplication.ViewModels;

namespace SampleApplication.Views
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml.
  /// </summary>
  public partial class MainWindow : Window
  {
    private readonly MainViewModel viewModel;

    /// <summary>
    /// Initializes a new instance of the <see cref="MainWindow"/> class.
    /// </summary>
    /// <param name="viewModel">View model for this view. Created by Ninject.</param>
    public MainWindow(MainViewModel viewModel)
    {
      this.InitializeComponent();
      this.viewModel = viewModel;
      this.DataContext = this.viewModel;
    }

    private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;

    private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
    {
      switch (e.Parameter.ToString())
      {
        default:
          this.viewModel.MenuCommand(e.Parameter.ToString(), this.StatusText);
          break;
      }
    }
  }
}
