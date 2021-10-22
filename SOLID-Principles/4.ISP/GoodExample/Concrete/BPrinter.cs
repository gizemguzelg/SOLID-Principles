using _4.ISP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ISP.GoodExample.Concrete
{
    class BPrinter : IPrintout
    {
        public string Printout() => "B yazıcısı çıktı alabilir.";

    }
}
