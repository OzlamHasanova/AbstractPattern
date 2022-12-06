using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPattern
{
    public class CircleFactory:AbstractFactory
    {
       
        public override IShape GetShape(string shapename)
        {
            if (shapename == "Circle")
            {
                return new Circle();
            }
            return null;
        }
    }
}
