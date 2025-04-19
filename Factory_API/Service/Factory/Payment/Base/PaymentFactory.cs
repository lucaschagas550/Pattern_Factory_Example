using Factory_API.Service.Interfaces;

namespace Factory_API.Service.Factory.Payment.Base
{
    public abstract class PaymentFactory
    {
        public abstract IPaymentService CreatePaymentService();

        public void Pay(string message)
        {
            var _paymentService = CreatePaymentService();
            _paymentService.Pay(message);
        }
    }
}
