using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPattern
{
    public class RoundFactory : AbstractFactory
    {
        public override IShape GetShape(string shapename)
        {
            if(shapename == "Round")
            {
                return new Round();
            }
            return null;
        }
    }
}
