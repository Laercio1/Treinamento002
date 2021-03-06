using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Treinamento2
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            :base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name
                + " (usado) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (data de fabricação: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
