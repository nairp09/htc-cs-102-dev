using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIntro
{
    public interface Ispeaker
    {

        string Name { get; }
        int Height { get; }
        void Speak();
        void SayName();






    }
}
