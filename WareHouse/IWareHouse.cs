﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse1
{
    public interface IWareHouse
    {
         bool AddProduct(Product product);
         bool MoveProduct(int count, Product product, IWareHouse warehouse);
         Product SearchBySKU(int Sku);
         decimal TotalCost();
         Worker ResponsibileWorker(string workStation);
    }
}