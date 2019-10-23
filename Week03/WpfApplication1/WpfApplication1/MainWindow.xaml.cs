using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      ObservableCollection<Movie> Movies = new ObservableCollection<Movie>();
        public MainWindow()
        {
            InitializeComponent();
            lvMovies.ItemsSource = Movies;
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie movie in Movies)
            {
                movie.ShowDetails();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string title = titleInput.Text;
            int  releaseYear = Convert.ToInt32(releaseYearInput.Text);
            string director = directorInput.Text;
            string genre = genreInput.Text;
            string length = lengthInput.Text;
            double rottentomatoesscore = Convert.ToDouble(rottenInput.Text);


            Movie movie = new Movie(title, releaseYear, director,length,genre, rottentomatoesscore);
            Movies.Add(movie);
            MessageBox.Show("Movie was added!");
        }

        private void lvMovies_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            Movie selectedMovie = lvMovies.SelectedItem as Movie;
           
            foreach (Movie item in Movies)
            {
                if (Movies.Count == 0)
                {
                    selectedMovie.ShowDetails();


                } else if (Title == item.Title)
                {
                    MessageBox.Show("This movie was already added");

                }

            }
                
                
                 
                
            
                       
        }
    }
}
