using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPattern
{
    public class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("It is a circle");
        }
    }
}
