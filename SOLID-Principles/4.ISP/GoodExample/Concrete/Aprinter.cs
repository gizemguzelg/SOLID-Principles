using _4.ISP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ISP.GoodExample.Concrete
{
    public class Aprinter : IPhotocopy, IPrintout
    {
        public string Photocopy() => "A yazıcısı fotokopi çekebilir.";

        public string Printout() => "A yazıcısı çıktı alabilir.";

    }
}
