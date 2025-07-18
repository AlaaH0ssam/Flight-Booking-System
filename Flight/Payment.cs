using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight
{
    internal class Payment
    {
        public enum PaymentMethod
        {
            cash,
            Instapay,
            Visa,
        }
        public int PaymentID { get; set; }
        public decimal PaymentAmount { get; set; }
        public PaymentMethod Paymentmethod { get; set; }
        public bool PaymentStatus { get; set; }

        public Payment(int id , decimal amount , PaymentMethod method , bool status ) {
            PaymentAmount = amount;
            Paymentmethod = method;
            PaymentStatus = status;
            PaymentID = id;
        }
    }
}
