using Factory_API.Service.Interfaces;

namespace Factory_API.Service
{
    public class CreditCardService : IPaymentService
    {
        public CreditCardService()
        {
            
        }

        public void Pay(string message)
        {
            Console.WriteLine($"Payment with Credit Card {message}.");
        }
    }
}
