using Factory_API.Model.Enum;
using Factory_API.Service.Factory.Payment;
using Factory_API.Service.Factory.Payment.Base;
using Microsoft.AspNetCore.Mvc;

namespace Factory_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly ILogger<PaymentController> _logger;

        public PaymentController(ILogger<PaymentController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public IActionResult Index([FromQuery] EPaymentTypes ePaymentTypes)
        {
            PaymentFactory paymentFactory;

            switch (ePaymentTypes)
            {
                case EPaymentTypes.CREDIT_CARD:
                    paymentFactory = new CreditCardFactory();
                    break;
                case EPaymentTypes.DEBIT_CARD:
                    paymentFactory = new DebitCardFactory();
                    break;
                case EPaymentTypes.PIX:
                    paymentFactory = new PixFactory();
                    break;
                default:
                    throw new NotSupportedException("Payment type not supported");
            }

            paymentFactory.Pay("R$ 2250.00");
            return Ok();
        }
    }
}
