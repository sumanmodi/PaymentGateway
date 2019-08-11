using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PaymentGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(string transactionId)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string cardNumber, string expiryMonthYear, double paymentAmount, string currencyCode, string CVVCode )
        {

        }

        
    }
}
