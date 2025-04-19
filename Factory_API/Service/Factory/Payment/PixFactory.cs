using Factory_API.Service.Factory.Payment.Base;
using Factory_API.Service.Interfaces;

namespace Factory_API.Service.Factory.Payment
{
    public class PixFactory : PaymentFactory
    {
        public override IPaymentService CreatePaymentService()
        {
            return new PixService();
        }
    }
}
