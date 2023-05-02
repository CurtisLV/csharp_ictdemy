namespace Calculator
{
    internal class CalculatorLogic
    {
        double num1 = 0;
        double num2 = 0;

        public CalculatorLogic(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public double Sum()
        {
            return num1 + num2;
        }

        public double Difference()
        {
            return num1 - num2;
        }

        public double Product()
        {
            return (num1 * num2);
        }

        public double Quotien()
        {
            return num1 / num2;
        }
    }
}
