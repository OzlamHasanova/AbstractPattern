using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPattern
{
    public class Round : IShape
    {
        public void draw()
        {
            Console.WriteLine("it is round");
        }
    }
}
