using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfMemoryLeak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<object> _data = new ObservableCollection<object>();

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if ((theItems.Items==null)||(theItems.Items.Count == 0))
            {
                theItems.ItemsSource = _data;
            }
            
            
        }

        private void bttnAddItem_Click(object sender, RoutedEventArgs e)
        {
            _data.Add(new Customer { Name = "Lizet", City = "Chicago" });
        }

        private void bttnRemoveItem_Click(object sender, RoutedEventArgs e)
        {
            if (_data.Count > 0)
            {
                _data.RemoveAt(0);
            }
        }

        private void bttnShowMonitor_Click(object sender, RoutedEventArgs e)
        {
            DataMonitor dm = new DataMonitor();
            dm.SetDataSource(_data);
            dm.Show();
        }

        private void bttnBindingPage_Click(object sender, RoutedEventArgs e)
        {
            BindingSample window = new BindingSample();
            window.ShowDialog();
        }
    }
}
