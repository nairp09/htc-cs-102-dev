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

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2
    {
        public Window2()
        {
            InitializeComponent();
        }
         public double square;
        

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point p = Mouse.GetPosition(this);
            double h = this.Height;
            double w = this.Width;


            if (p.X < w/3 && p.Y < h / 3)
            {
                square = 1;
            } else if (w/3 < p.X && p.X < (2*w)/3 &&  p.Y < h / 3 )
            {
                square = 2;
            }
            else if ((2 * w) / 3 < p.X  && p.Y < h / 3)
            {
                square = 3;
            }
            else if (p.X < w / 3 && p.Y >h/3 && p.Y < (2*h) / 3)
            {
                square = 4;
            }
            else if (w/3 < p.X && p.X< (2*w)/3 && p.Y > h / 3 && p.Y < (2 * h) / 3)
            {
                square = 5;
            }
            else if ((2 * w) / 3 < p.X && p.Y > h / 3 && p.Y < (2 * h) / 3)
            {
                square = 6;
            }
            else if (p.X < w / 3 &&  p.Y > (2 * h) / 3)
            {
                square = 7;
            }
            else if (w / 3 < p.X && p.X < (2 * w) / 3 && p.Y > (2 * h) / 3)
            {
                square = 8;
            }
            else if ((2 * w) / 3 < p.X && p.Y > (2 * h) / 3)
            {
                square = 9;
            }

            if (square == 1)
            {
                Image3_png.Visibility = Visibility.Visible;
                Image25_png.Visibility = Visibility.Visible;
            } else if (square == 2)
            {
                
            }
            else if (square == 3)
            {

            }
            else if (square == 4)
            {
                Image2_png.Visibility = Visibility.Visible;
                Image24_png.Visibility = Visibility.Visible;
            }
            else if (square == 5)
            {

            }
            else if (square == 6)
            {

            }
            else if (square == 7)
            {

            }
            else if (square == 8)
            {

            }
            else if (square == 9)
            {

            }



        }

        
    }
}
