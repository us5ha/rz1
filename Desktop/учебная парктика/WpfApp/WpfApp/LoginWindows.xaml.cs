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
using WpfApp.DataTable;

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        } 

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CapthaWindows capthaWindows = new CapthaWindows();
                bool isCorrect = (bool)capthaWindows.ShowDialog();
                if (isCorrect)
                {
                    admin admin = App.db.admin.FirstOrDefault(u => u.id_admin == TBNumber.Text && TBPassword.Password == "1111");
                    if (admin != null)
                    {
                        Class1.IsAuth = true;
                        Class1.admin = admin;
                        if (admin.id_dolgj == 1)
                        {
                            MainWindows mainWindows = new MainWindows();
                            mainWindows.Show();
                            this.Close();
                        }
                        else if (admin.id_dolgj == 2)
                        {
                            MainWindows mainWindows = new MainWindows();
                            mainWindows.Show();
                            this.Close();
                        }
                        else if (admin.id_dolgj == 3)
                        {
                            MainWindows mainWindows = new MainWindows();
                            mainWindows.Show();
                            this.Close();
                        }
                        else if (admin.id_dolgj == 4)
                        {
                            MainWindows mainWindows = new MainWindows();
                            mainWindows.Show();
                            this.Close();
                        }
                        else if (admin.id_dolgj == 5)
                        {
                            MainWindows mainWindows = new MainWindows();
                            mainWindows.Show();
                            this.Close();
                        }
                        else if (admin.id_dolgj == 6)
                        {
                            MainWindows mainWindows = new MainWindows();
                            mainWindows.Show();
                            this.Close();
                        }
                        else if (admin.id_dolgj == 7)
                        {
                            MainWindows mainWindows = new MainWindows();
                            mainWindows.Show();
                            this.Close();
                        }
                        else
                        {
                            MainWindows mainWindows = new MainWindows();
                            mainWindows.Show();
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); 
            }
        }
    }
}
