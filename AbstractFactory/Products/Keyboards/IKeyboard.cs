﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Keyboards
{
    public interface IKeyboard
    {
        string SerialCode { get; set; }
        decimal Price { get; set; }
        void PrintSerialNumber();
    }
}
