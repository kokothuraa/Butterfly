using Microsoft.AspNetCore.Mvc;

namespace Butterfly.Controllers
{
    
    [ApiController]    
    public class OperationController : ControllerBase
    {
        Modals.Operation Op = new Modals.Operation();

        [Route("api/Operation/Add/{firstNum}/{secondNum}")]
        [HttpGet]
        public  double Add(double firstNum, double secondNum)
        {
            return Op.Add(firstNum,secondNum);
        }
        [Route("api/Operation/Substract/{firstNum}/{secondNum}")]
        [HttpGet]
        public double Substract(double firstNum, double secondNum)
        {
            return Op.Substract(firstNum, secondNum);
        }

        [Route("api/Operation/Multiply/{firstNum}/{secondNum}")]
        [HttpGet]
        public double Multiply(double firstNum, double secondNum)
        {
            return Op.Multiply(firstNum, secondNum);
        }

        [Route("api/Operation/Divide/{firstNum}/{secondNum}")]
        [HttpGet]
        public double Divide(double firstNum, double secondNum)
        {
            return Op.Divide(firstNum, secondNum);
        }
    }
}
