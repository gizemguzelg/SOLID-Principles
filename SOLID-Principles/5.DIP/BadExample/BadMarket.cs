using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DIP.BadExample
{
   public class BadMarket
    {
        BadPatato badPatato = new BadPatato();
        BadVegetable badVegetable = new BadVegetable();

        public string GetMarket() => $"{badPatato.GetPatatoInstruction()} - {badVegetable.GetVegetableInstruction()}";
    }
}
