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
    /// Interaction logic for DataMonitor.xaml
    /// </summary>
    public partial class DataMonitor : Window
    {

        private UInt64[] _memToLeak = new UInt64[1024*1024];
        private List<ulong> _dataLeak = new List<ulong>();

        public DataMonitor()
        {
            
            InitializeComponent();
        }

        

        public void SetDataSource(ObservableCollection<object> DataSource)
        {
                
            DataSource.CollectionChanged += DataSource_CollectionChanged;
        }

        private void DataSource_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            _dataLeak.AddRange(_memToLeak.ToList<ulong>());

            var collection =   (ObservableCollection<object>)sender;
            txtDataCount.Text = $"Collection has {collection.Count} items";
            txtDataCount.Visibility = Visibility.Visible;
        }
    }
}
