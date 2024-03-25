using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsinTheBoxComposite
{
    public abstract class Items
    {
        protected String name;
        protected int price;
        protected int quantity;

        public Items(String name, int price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
