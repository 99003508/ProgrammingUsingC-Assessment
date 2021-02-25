using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
   
    public class GourmetCoffeeShop : GourmetShop, ITaxCompute
    {

        GourmetCoffeeShop(int iCode,string iName ,Dictionary<int, double> discCoffe)
        {

        }


        public double TotalBillValue { get; set; }
        public double PayPerPrice(int quantity)
        {

            return 0;
        }
        public double PayPerWeight(int weight)
        {
            return 0;
        }
       public double TaxOnTotalBill()
        {
            return 0;
        }
    }
}
