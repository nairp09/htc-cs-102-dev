using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplication1
{
    public class Movie
    {

        public string Title;
        public int ReleaseYear;
        public string Director;
        public string Length;
        public string Genre;


        public Movie(string title, int releaseyear, string director, string length, string genre)
        {
            Title = title;
            ReleaseYear = releaseyear;
            Director = director;
            Length = length;
            Genre = genre;

        }




        public void ShowDetails()
        {
            MessageBox.Show(Title + " was released in : " + ReleaseYear + " ,the director was " + Director + ",it is " + Length + " hours long, and it is in the category of " + Genre  );
        }
        


    }
}
