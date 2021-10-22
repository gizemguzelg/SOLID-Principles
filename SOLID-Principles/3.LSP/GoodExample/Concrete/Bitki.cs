using _3.LSP.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LSP.GoodExample.Concrete
{
    public class Bitki : CanlilarinOzellikleri
    {
        public override string Beslenme()=>"Bitkiler beslenirler.";


        public override string Hareket() => "Bitkiler hareket ederler.";
        
    }
}
