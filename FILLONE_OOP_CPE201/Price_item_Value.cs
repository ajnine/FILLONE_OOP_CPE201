using System;
using System.Collections.Generic;
using System.Text;

namespace FILLONE_OOP_CPE201
{
    internal class Price_item_Value
    {
        public String price, itemname, discount_amount;

        public void SetPriceItemValue(string item_name, string item_price)
        {
            this.itemname = item_name;
            this.price = item_price;
        }

        public String GetItemName ()
        {
            return itemname;
        }

        public String GetPrice()
        {
            return price;
        }

        public void SetPriceDsicountAmountValue(string discount_amt, string priceItem)
        {
            this.price = priceItem;
            this.discount_amount = discount_amt;
        }

        public String GetPriceItem()
        {
            return price;
        }

        public String GetDIscountAmount()
        {
            return discount_amount;
        }
    }
}
