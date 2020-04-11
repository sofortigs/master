using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public class Buyer
    {
        public int _cash;
        public List<Products> _productsList = new List<Products>();
        public Buyer(List<Products> productList, int cash)
        {
            this._productsList = productList;
            this._cash = cash;
        }
    }
}
