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

namespace sillv0r.WpfObjectDatabindingExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class ViewModel
        {
            public ViewModel()
            {
                this.Ingredients = new List<string>();
                this.Ingredients.AddRange(new string[] {"Eggs", "Bread", "Celery" });
            }
            public List<string> Ingredients { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new ViewModel();
        }
    }
}
