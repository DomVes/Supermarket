using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class VariablePriceProduct : Product
    {
        
        public string Measurement { get; set; }
        public decimal Quantity { get; set; }
        public override decimal ValueToPay()
        {
            return Price;
        }

        public override string ToString()        
        {
            decimal asist = Quantity * ValueToPay();
            decimal total = asist * Tax;
            return $"{Id} - {Description}" +
                $"\n\tMeasurement..:    {Measurement}" +
                $"\n\tPrice........:    ${Price:N2}" +
                $"\n\tQuantity.....:    {Quantity*1000:N2}gr" +
                $"\n\tTax..........:    {Tax*100:N2}%" +
                $"\n\tValue to Pay.:    ${asist+total:N2}";
                
        }



    }
}
