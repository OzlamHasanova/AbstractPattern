using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPattern
{
    public class FactoryProducer
    {
        public AbstractFactory GetFactory(string factoryname)
        {
            if (factoryname == "Circlefactory")
            {
                return new CircleFactory();
            }else if(factoryname == "Roundfactory")
            {
                return new RoundFactory();
            }
            return null;
        }
    }
}
