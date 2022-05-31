namespace Butterfly.Modals
{
    public class Operation:Abstract.absOperation
    {
        public override double Add(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }
       
        public override double Substract(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }

        public override double Multiply(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }

        public override double Divide(double firstNum, double secondNum)
        {
            return firstNum / secondNum;
        }
    }
}
