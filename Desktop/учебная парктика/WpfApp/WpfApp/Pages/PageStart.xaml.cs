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

namespace WpfApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageStart.xaml
    /// </summary>
    public partial class PageStart : Page
    {
        public int cursor = 0;

        public List<links> links = new List<links>();
        public List<zapisi> zapisi = new List<zapisi>();
        
        public void next(Button knopka)
        {
            var btns = AbonentBtn;
            var linkThis = links.Where(x => x.name == knopka).FirstOrDefault();
            btns = linkThis.name;
            TextBlock.Text = (btns as Button).Content.ToString();
            client.Navigate(linkThis.link);
        }
        public PageStart()
        {
            InitializeComponent();
            PolzCmb.ItemsSource = App.db.admin.ToList();
            links = new List<links> {
             new links() { name = AbonentBtn, link = new Pages.ClientPage()},
             new links() { name = UprBtn, link= new Pages.UprPage()},
             new links() { name = ActBtn, link = new Pages.ActPage()},
             new links() { name = BilBtn, link=new Pages.BilPtn()},
             new links() { name = CrmBtn, link=new Pages.CRMPage(null)},
             new links() { name = PodBtn, link=new Pages.PodPages()},

            };
            string b = Convert.ToString(App.db.info_admin.ToList());
            zapisi = new List<zapisi>
            {
                new zapisi() {name=b},

            };

            events.ItemsSource = zapisi;
            events.SelectedItem = zapisi[cursor];
        }

        private void PolzCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btnup_Click(object sender, RoutedEventArgs e)
        {
            if (cursor != 0)
            {
                cursor--;
            }

            events.ScrollIntoView(zapisi[cursor]);
            events.SelectedItem = zapisi[cursor];
        }

        private void BtnDown_Click(object sender, RoutedEventArgs e)
        {
            if (cursor != zapisi.Count - 1)
            {
                cursor++;
            }
            events.ScrollIntoView(zapisi[cursor]);
            events.SelectedItem = zapisi[cursor];
        }

        private void VoprBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AbonentBtn_Click(object sender, RoutedEventArgs e)
        {
            next(sender as Button);
        }

        private void UprBtn_Click(object sender, RoutedEventArgs e)
        {
            next(sender as Button);
        }

        private void ActBtn_Click(object sender, RoutedEventArgs e)
        {
            next(sender as Button);
        }

        private void BilBtn_Click(object sender, RoutedEventArgs e)
        {
            next(sender as Button);
        }

        private void PodBtn_Click(object sender, RoutedEventArgs e)
        {
            next(sender as Button);
        }

        private void CrmBtn_Click(object sender, RoutedEventArgs e)
        {
            next(sender as Button);
        }

        private void ProfBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void events_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
