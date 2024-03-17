using FactoryDesignPattern.Interface;

namespace FactoryDesignPattern.PaymentMethods
{
    public class CreditCardPayment : IPayment
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"Payment made using CreditCard. Amount is ${amount}");
        }
    }
}
