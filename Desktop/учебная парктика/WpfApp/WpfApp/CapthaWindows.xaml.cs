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
using WpfApp.DataTable;

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для CapthaWindows.xaml
    /// </summary>
    public partial class CapthaWindows : Window
    {
        string _correctCaptcha { get; set; }
        public bool _isCorrect { get; set; } = false;
        public CapthaWindows()
        {
            InitializeComponent();
            string abc = "1234567890";//символы которые участвуют в капче
            string captcha = "";
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                captcha = captcha + abc[rnd.Next(0, abc.Length)];
            }
            _correctCaptcha = captcha;

            CaptchaImage.Background = new DrawingBrush(Captha.DrawMyText(captcha));
        }

        private void CheckCaptcha_Click(object sender, RoutedEventArgs e)
        {
            if (_correctCaptcha != CaptchaTb.Text)
            {
                this.DialogResult = false;
                MessageBox.Show("Капча введена неверно");
                return;
            }
            MessageBox.Show("Начинайте работу!");
            this.DialogResult = true;
        }
    }
}
