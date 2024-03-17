// See https://aka.ms/new-console-template for more information
using FactoryDesignPattern.Factory;
using FactoryDesignPattern.Interface;

Console.WriteLine("Hello, World!");

//Using Factory Design Pattern
IPayment payment = PaymentFactory.Create(PaymentMethod.GooglePay);
payment.MakePayment(100);