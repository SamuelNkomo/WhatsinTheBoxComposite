using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsinTheBoxComposite
{   //Add and remove methods. Not in the abstract
    //class because Leal class will not be using them
    //Only composite class will use the methods
    public interface IComponent
    {
        //void DisplayPrice();
        int CalculateTotalPrice();
    }
}
