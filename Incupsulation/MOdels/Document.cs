using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incupsulation.MOdels
{
    internal abstract class Document
    {
        public abstract void Print();
        public void Save()
        {
            Console.WriteLine($"Documnet saved ");
        }
    }
}
