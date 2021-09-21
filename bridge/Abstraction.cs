using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    class Abstraction
    {
        protected IProduct product;

        public Abstraction(IProduct product)
        {
            this.product = product;
        }

        public virtual string Make()
        {
            return "Продукт " +  product.MadeSmth() + " выпущен";
        }
    }
}
