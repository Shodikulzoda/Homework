using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    internal interface ISayhello
    {
        void Say();

        public void SayHello()
        {
            Console.WriteLine("Salom Dunyo");
        }
    }

}
