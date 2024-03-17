using FactoryDesignPattern.Interface;

namespace FactoryDesignPattern.PaymentMethods
{
    public class PayPalPayment : IPayment
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"Payment made using PayPal. Amount is ${amount}");
        }
    }
}
