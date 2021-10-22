using _4.ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ISP.BadExample.Concrete
{
    class BPrinter : IPrinter
    {
        public string Photocopy() => "B yazıcısı fotokopi çekemez.";

        public string Printout() => "B yazıcısı çıktı alabilir.";

    }
}
