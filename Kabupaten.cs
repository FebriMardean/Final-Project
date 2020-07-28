using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public abstract class Kabupaten
    {
        public string Nama { get; set; }
        public string KodeKab { get; set; }
        public abstract double Area();
    }
}
