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

namespace WpfSortedCollections
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModels.SessionsViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            this.viewModel = (ViewModels.SessionsViewModel)this.DataContext;
        }

        private void buttonAddUrl_Click(object sender, RoutedEventArgs e) {
            // Should be changed to a Command
            viewModel.AddNewRelatedSession();
        }
    }
}
