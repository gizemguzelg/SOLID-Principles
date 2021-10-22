using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LSP.BadExample
{
   public class Bitki : CanlilarinOzellikleri
    {
        public override string Beslenme()=>"Bitkiler beslenebilirler.";

        public override string Hareket() => "Bitiler hareket edebilirler.";

        public override string Konusma() => "Bitkiler konuşamazlar";
        
    }
}
