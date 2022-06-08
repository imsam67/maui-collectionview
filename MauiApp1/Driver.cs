using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class Driver
    {
        public string Name { get; set; }

        public Vehicle Car { get; set; } = new Vehicle();
    }
}