using Factory_API.Service.Interfaces;

namespace Factory_API.Service
{
    public class DebitCardService : IPaymentService
    {
        public DebitCardService()
        {
            
        }

        public void Pay(string message)
        {
            Console.WriteLine($"Payment with Debit Card {message}.");
        }
    }
}
