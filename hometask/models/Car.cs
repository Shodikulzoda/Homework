using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask.models
{
    internal class Car
    {
        public string Model { get; set; }
        public string Marka { get; set; }
        public int Year { get; set; }

        public void Distructor(out string model, out string marka, out int year)
        {
            model = Model;
            marka = Marka;
            year = Year;
        }
    }
}
