using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Flyweights
{
    public class FlyWeightFactory
    {
        public FlyWeightFactory() 
        {
        
        }


        public void GetFlyweight(string type)
        {
            switch (type)
            {
                case ("bottomWeight"):
                    
                break;

                case ("pyramid"):

                    break;

                case ("topple"):

                    break;

                default:
                    throw new ArgumentOutOfRangeException("Invalid Strategy Type");
            }
        }
    }
}
