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
using WpfApplication3;

namespace WpfApplication3 
{

    class x
    {
        bool clicked = false;

        public bool Lastclicked()
        {
            clicked = (clicked == true) ? false : true;
            return clicked;
        }
        public void Show(Image imgX,Image imgO)
        {
            imgX.Visibility = Visibility.Visible;
            imgO.Visibility = Visibility.Hidden;
        }



    }

    class o
    {
        bool clicked = false;

        public bool Lastclicked()
        {
            clicked = (clicked == true) ? false : true;
            return clicked;
        }
        public void Show(Image imgO, Image imgX)
        {
            imgO.Visibility = Visibility.Visible;
            imgX.Visibility = Visibility.Hidden;
        }



    }


    public partial class Window2
    {
        public Window2()
        {
            InitializeComponent();
        }
        public int square;
        x imagex = new x ();
        o imageo = new o ();

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point p = Mouse.GetPosition(this);
            double h = this.Height;
            double w = this.Width;
            Image[] imageXs = new Image[10];
            Image[] imageOs = new Image[10];
            imageXs[1] = Image3_png;
            imageOs[1] = Image25_png;
            imageXs[2] = Image10_png;
            imageOs[2] = Image22_png;
            imageXs[3] = Image15_png;
            imageOs[3] = Image28_png;
            imageXs[4] = Image2_png;
            imageOs[4] = Image24_png;
            imageXs[5] = Image8_png;
            imageOs[5] = Image21_png;
            imageXs[6] = Image14_png;
            imageOs[6] = Image27_png;
            imageXs[7] = Image12_png;
            imageOs[7] = Image23_png;
            imageXs[8] = Image9_png;
            imageOs[8] = Image20_png;
            imageXs[9] = Image13_png;
            imageOs[9] = Image26_png;


            if (p.X < w / 3 && p.Y < h / 3)
            {
                square = 1;
            }
            else if (w / 3 < p.X && p.X < (2 * w) / 3 && p.Y < h / 3)
            {
                square = 2;
            }
            else if ((2 * w) / 3 < p.X && p.Y < h / 3)
            {
                square = 3;
            }
            else if (p.X < w / 3 && p.Y > h / 3 && p.Y < (2 * h) / 3)
            {
                square = 4;
            }
            else if (w / 3 < p.X && p.X < (2 * w) / 3 && p.Y > h / 3 && p.Y < (2 * h) / 3)
            {
                square = 5;
            }
            else if ((2 * w) / 3 < p.X && p.Y > h / 3 && p.Y < (2 * h) / 3)
            {
                square = 6;
            }
            else if (p.X < w / 3 && p.Y > (2 * h) / 3)
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

            

            
                if (imagex.Lastclicked())
                {
                    imageo.Show(imageOs[square], imageXs[square]);
                }
                else
                {
                    imagex.Show(imageXs[square], imageOs[square]);
                }
            
            //if (square == 1)
            //{
            //    //    Image3_png.Visibility = Visibility.Visible; //x
            //    //   Image25_png.Visibility = Visibility.Visible; //o
            //}
            //else if (square == 2)
            //{
            //    Image22_png.Visibility = Visibility.Visible;
            //    Image10_png.Visibility = Visibility.Visible;
            //}
            //else if (square == 3)
            //{
            //    Image28_png.Visibility = Visibility.Visible;
            //    Image15_png.Visibility = Visibility.Visible;
            //}
            //else if (square == 4)
            //{
            //    Image2_png.Visibility = Visibility.Visible;
            //    Image24_png.Visibility = Visibility.Visible;
            //}
            //else if (square == 5)
            //{
            //    Image8_png.Visibility = Visibility.Visible;
            //    Image21_png.Visibility = Visibility.Visible;
            //}
            //else if (square == 6)
            //{
            //    Image14_png.Visibility = Visibility.Visible;
            //    Image27_png.Visibility = Visibility.Visible;
            //}
            //else if (square == 7)
            //{
            //    Image23_png.Visibility = Visibility.Visible;
            //    Image12_png.Visibility = Visibility.Visible;
            //}
            //else if (square == 8)
            //{
            //    Image9_png.Visibility = Visibility.Visible;
            //    Image20_png.Visibility = Visibility.Visible;
            //}
            //else if (square == 9)
            //{
            //    Image13_png.Visibility = Visibility.Visible;
            //    Image26_png.Visibility = Visibility.Visible;
            //}



        }


    }
}


