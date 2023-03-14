using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace WpfApp.DataTable
{
    internal class Captha
    {
        [Obsolete]
        public static Drawing DrawMyText(string captcha)
        {
            //функция генерации капчи
            Random rnd = new Random();
            DrawingGroup drawingGroup = new DrawingGroup();
            using (DrawingContext drawingContext = drawingGroup.Open())
            {
                FormattedText formattedText = new FormattedText(
                    captcha,
                    CultureInfo.GetCultureInfo("en-us"),//язык
                    FlowDirection.LeftToRight,
                    new Typeface("Times New Roman Bold"),//шрифт
                    18,
                    System.Windows.Media.Brushes.Black
                    );

                Geometry textGeometry = formattedText.BuildGeometry(new System.Windows.Point(20, 0));
                drawingContext.DrawGeometry(System.Windows.Media.Brushes.Black, new System.Windows.Media.Pen(System.Windows.Media.Brushes.Black, 1.5), textGeometry);
                drawingContext.DrawLine(new System.Windows.Media.Pen(System.Windows.Media.Brushes.White, 4), new System.Windows.Point(rnd.Next(0, (int)formattedText.Width), rnd.Next(0, (int)formattedText.Height)), new System.Windows.Point(rnd.Next(0, (int)formattedText.Width), rnd.Next(0, (int)formattedText.Height)));
                drawingContext.DrawLine(new System.Windows.Media.Pen(System.Windows.Media.Brushes.White, 4), new System.Windows.Point(rnd.Next(0, (int)formattedText.Width), rnd.Next(0, (int)formattedText.Height)), new System.Windows.Point(rnd.Next(0, (int)formattedText.Width), rnd.Next(0, (int)formattedText.Height)));
                drawingContext.DrawLine(new System.Windows.Media.Pen(System.Windows.Media.Brushes.White, 4), new System.Windows.Point(rnd.Next(0, (int)formattedText.Width), rnd.Next(0, (int)formattedText.Height)), new System.Windows.Point(rnd.Next(0, (int)formattedText.Width), rnd.Next(0, (int)formattedText.Height)));

                for (int i = 0; i < 10; i++)
                {
                    drawingContext.DrawEllipse(System.Windows.Media.Brushes.Black, new System.Windows.Media.Pen(System.Windows.Media.Brushes.White, 4), new System.Windows.Point(rnd.Next(0, (int)formattedText.Width + 50), rnd.Next(0, (int)formattedText.Height)), 0.0001, 0.0001);
                }

                return drawingGroup;
            }
        }
    }
}
