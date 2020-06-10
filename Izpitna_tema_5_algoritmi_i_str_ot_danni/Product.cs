using System;
using System.Collections.Generic;
using System.Text;

namespace Izpitna_tema_5_algoritmi_i_str_ot_danni
{
    class Product
    {
        private string name;
        private Product next_product;

        public Product(string name)
        {
            this.name = name;
        }
        public Product Next_product
        {
            get;
            set;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
