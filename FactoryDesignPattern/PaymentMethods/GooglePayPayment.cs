using FactoryDesignPattern.Interface;

namespace FactoryDesignPattern.PaymentMethods
{
    public class GooglePayPayment : IPayment
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"Payment made using GooglePay. Amount is ${amount}");
        }
    }
}
