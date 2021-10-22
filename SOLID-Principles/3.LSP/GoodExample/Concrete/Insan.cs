using _3.LSP.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LSP.GoodExample.Concrete
{
    public class Insan : CanlilarinOzellikleri
    {
        public override string Beslenme() => "İnsanlar beslenirler.";


        public override string Hareket() => "İnsanlar hareket ederler.";
        public string Konusma() => "İnsanlar konuşurlar.";
        
    }
}
