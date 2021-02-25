using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public abstract class GourmetShop
    {
        public int ItemCode  { get; set; }
        public String ItemName { get; set; }

        private Dictionary<int, double> ItemPrice = new Dictionary<int, double>();

        //public GourmetShop(int iCode,string iName)
        //{
        //    this.ItemCode = iCode;
        //    this.ItemName = iName;

        //}


    public abstract double PayPerPiece(int quantity);
        public abstract double PayPerWeight(int weight);

    }
}