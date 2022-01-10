using System;
using System.Collections.Generic;
using System.Text;

namespace CoreysKnickKnacks
{
    public class StoreItem
    {
        private Product _product;
        private int _quantity;

        public StoreItem(Product product, int quantity)
        {
            _product = product;
            _quantity = quantity;
        }

        public Product GetProduct()
        {
            return _product;

        }

        public void Product(Product product)
        {
            _product = product;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }
    }
}