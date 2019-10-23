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

        public string Title { get; set; }
        public int ReleaseYear{ get; set; }
        public string Director { get; set; }
        public string Length { get; set; }
        public string Genre { get; set; }
        public double RottenTomatoesScore { get; set; }


        public Movie(string title, int releaseyear, string director, string length, string genre, double rottentomatoesscore)
        {
            Title = title;
            ReleaseYear = releaseyear;
            Director = director;
            Length = length;
            Genre = genre;
            RottenTomatoesScore = rottentomatoesscore;

        }




        public void ShowDetails()
        {
            MessageBox.Show(Title + " was released in : " + ReleaseYear + " ,the director was " + Director + ",it is " + Length + " hours long, and it is in the category of " + Genre  );
        }
        


    }
}
