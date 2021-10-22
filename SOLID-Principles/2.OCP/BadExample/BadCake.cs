using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.OCP.BadExample
{
    public enum CakeType { AppleCake = 1, Cupcake = 2, CarrotCake = 3 }
    public class BadCake
    {
        public double GetTotalPrice(double amount, CakeType cakeType)
        {
            double totalPrice = 0;

            if (cakeType == CakeType.AppleCake)
            {
                totalPrice += amount * 5.48;
            }
            else if (cakeType == CakeType.Cupcake)
            {
                totalPrice += amount * 2.35;
            }
            else if (cakeType == CakeType.CarrotCake)
            {
                totalPrice += amount *4.85;
            }

            return totalPrice;
        }
    }
}
