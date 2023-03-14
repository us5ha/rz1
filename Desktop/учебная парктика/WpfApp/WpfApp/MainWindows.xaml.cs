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
using System.Windows.Shapes;

namespace WpfApp
{
    public class links
    {
        public Button name { get; set; }
        public Page link { get; set; }
    }
    public class zapisi
    {
        public string name { get; set; }
    }

    public partial class MainWindows : Window
    {
        public MainWindows()
        {
            InitializeComponent();
            Main.Navigate(new Pages.PageStart());
          
        }
    }
}
