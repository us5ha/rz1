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
using System.Xml.Linq;
using WpfApp.DataTable;

namespace WpfApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для CRMPage.xaml
    /// </summary>
    
    public partial class CRMPage : Page
    {
        private zayavka_CRM _currentGood = new zayavka_CRM();
        public CRMPage(zayavka_CRM selectedGood)
        {
            InitializeComponent();
            if (selectedGood != null)
            {
                List<zayavka_CRM> zayavka_CRMs = new List<zayavka_CRM>();
            }
            CmbUsluga.ItemsSource=App.db.uslugaCRM.ToList();
            CmbTypeProblem.ItemsSource=App.db.type_problem.ToList();
            CmbStatus.ItemsSource=App.db.status.ToList();
            CmbTypeUslugi.ItemsSource=App.db.type_uslugi.ToList();
            CmbVidUslugi.ItemsSource=App.db.vid_uslugi.ToList();
        }

        private void CmbUsluga_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbProblem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbUsluga_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbVidUslugi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbTypeUslugi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbTypeProblem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _currentGood.id_CRM = TBID.Text;
                _currentGood.opisanie_problem = TBOpis.Text;

                _currentGood.id_uslugaCRM = (CmbUsluga.SelectedItem as uslugaCRM).id_usligaCRM;
                _currentGood.id_vid_uslugi = (CmbVidUslugi.SelectedItem as vid_uslugi).id_vid_uslugi;
                _currentGood.id_status = (CmbStatus.SelectedItem as status).id_status;
                _currentGood.id_type_problem = (CmbTypeProblem.SelectedItem as type_problem).id_type_problem;
                _currentGood.id_type_uslugi = (CmbTypeUslugi.SelectedItem as type_uslugi).id_type_uslugi;

                App.db.zayavka_CRM.Add(_currentGood);
                App.db.SaveChanges();
                MessageBox.Show("save");
                NavigationService.Navigate(new Pages.ClientPage());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
