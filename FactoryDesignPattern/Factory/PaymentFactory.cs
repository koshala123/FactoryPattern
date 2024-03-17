using FactoryDesignPattern.Interface;

namespace FactoryDesignPattern.Factory
{
    //Factory methods are normally static
    public class PaymentFactory
    {
        public static IPayment Create(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.GooglePay:
                    return new GooglePayPayment();
                case PaymentMethod.PayPal:
                    return new PayPalPayment();
                case PaymentMethod.CreditCard:
                    return new CreditCardPayment();
                default:
                    throw new NotSupportedException("Invalid payment method");
            }
        }
    }
}
