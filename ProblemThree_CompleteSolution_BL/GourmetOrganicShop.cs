using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetOrganicShop : GourmetShop, ITaxCompute
    {
       
        public double TotalBillValue { get; set; }
        public void GourmetOrganicShop(int iCode, string iName, Dictionary<int,string> discOrganic) 
        {
            this.ItemCode = iCode;
            this.ItemName = iName;

            
        }
        public double TaxOnTotalBill()
        {
            return 0;
        }
    }
}
