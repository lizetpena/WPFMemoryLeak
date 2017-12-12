using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace WpfMemoryLeak
{
    /// <summary>
    /// Interaction logic for BindingSample.xaml
    /// </summary>
    public partial class BindingSample : Window
    {
        Dictionary<string, string> _books = new Dictionary<string, string>();

        public BindingSample()
        {
            InitializeComponent();
            Loaded += BindingSample_Loaded;
        }

        private void BindingSample_Loaded(object sender, RoutedEventArgs e)
        {
            var files = Directory.GetFiles(".\\books");
            foreach (var file in files)
            {
                string contents = File.ReadAllText(file);
                string filename = System.IO.Path.GetFileName(file);
                _books.Add(filename, contents);

                MyStackPanel.Children.Add(new TextBlock()
                {
                    Text = $"{filename} is {contents.Length} characters"
                });
            }
        }
    }
}
