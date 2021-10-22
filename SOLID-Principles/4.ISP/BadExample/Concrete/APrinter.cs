using _4.ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ISP.BadExample.Concrete
{
    class APrinter : IPrinter
    {
       public string Photocopy() => "A yazıcısı fotokopi çekebilir";

        public string Printout() => "A yazıcısı çıktı alabilir.";

    }
}
