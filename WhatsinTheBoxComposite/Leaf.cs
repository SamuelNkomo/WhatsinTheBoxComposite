using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WhatsinTheBoxComposite
{
    //inherits from Items to be able to use properties
    //overrides the inherted calculate method

    public class Leaf : Items, IComponent
    {
        public Leaf(String name, int price, int qua) :
            base(name, price, qua)
        { }  

        public int CalculateTotalPrice()
        {
            Console.WriteLine(name + "with the price" + (price * quantity));
            return (price * quantity);
        }
    }
}
