using System;
using System.Collections.Generic;
using System.Text;

namespace CoreysKnickKnacks
{
    public class ShoppingCartItem
    {
        private Product _product;
        private int _quantity;

        public ShoppingCartItem(Product product, int quantity)
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
        public decimal GetTotal()
        {
            var productPrice = _product.GetPrice();
            var quantity = GetQuantity();
            productPrice = quantity * productPrice;
            return productPrice;
        }
    }
}

