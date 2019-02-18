﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Products
{
    //"Faktura zaliczkowa"
    public class AdvanceInvoice : IInvoice
    {
        public string Number { get; set; }
        public string TaxpayerFullName { get; set; }
        public string TaxpayerAddress { get; set; }
        public string Title => "Faktura zaliczkowa";

        public decimal AdvancedAmount { get; set; }
    }
}
