using _5.DIP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DIP.GoodExample.Concrete
{
   public class Market
    {

        private IVegetable _vegetable;

        public Market(IVegetable vegetable)=> this._vegetable = vegetable;


        public string GenerateMarketInstruction() => $"{_vegetable.GetVegetableInstruction()}";
    }
}
