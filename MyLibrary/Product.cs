﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public  class Product(int id, string name, decimal unitPrice, int unitsInStock) 
    {
        //Propiedades 

       
        public int Id { get; }

        
        public string Name { get; }
        public decimal UnitPrice;{  get; }

        public int UnitsInStock; {  get;  }

       
        //Constructor

        public Product (int id, string name, decimal unitPrice, int unitsInStock)
        {
            Id = id;
            Name = name;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;

        }

    }
}

