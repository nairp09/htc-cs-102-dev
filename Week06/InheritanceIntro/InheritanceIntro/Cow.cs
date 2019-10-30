using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class Cow : Animal
    {
        public Cow() { }


        public Cow(int height, string name)
        {
            this.Height = height;
            this.Name = name;
        }

        public void Moo()
        {
            MessageBox.Show("Moo");
        }

    }
}
