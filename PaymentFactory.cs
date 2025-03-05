using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_pattern
{
    public class PaymentFactory
    {
        public static IPayment create(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.CreditCard:
                    return new CreditCard();

                case PaymentMethod.PhonePay:
                    return new PhonePay();

                case PaymentMethod.GooglePay:
                    return new GooglePay();

                default:
                    throw new NotSupportedException(
                        $"{paymentMethod} is not currently Supported as a Payment Method"
                        );

            }
        }
    }
}
