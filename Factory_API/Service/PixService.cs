using Factory_API.Service.Interfaces;

namespace Factory_API.Service
{
    public class PixService : IPaymentService
    {
        public PixService()
        {
            
        }

        public void Pay(string message)
        {
            Console.WriteLine($"Payment with Pix {message}.");
        }
    }
}
