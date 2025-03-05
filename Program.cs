// See https://aka.ms/new-console-template for more information
using Factory_Design_pattern;

//IPayment payment = PaymentFactory.create(PaymentMethod.CreditCard);
IPayment payment = PaymentFactory.create(0);

payment.pay(0);
