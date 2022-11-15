using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursa4
{
    internal class remontedDevices : devicesList
    {
        private string solution;
        public string getSolution { get { return solution; } set { solution = value; } }

        private decimal price;
        public decimal getPrice { get { return price; } set { price = value; } }

        private bool guarantee;
        public bool getGuarantee { get { return guarantee; } set { guarantee = value; } }
    }
}
