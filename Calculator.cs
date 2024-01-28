namespace VirtualDars.Demo.Calc
{
    public class Calculator
    {
        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Calculator dasturi");

                double firstNumber = ParseNumber();
                string operation = ValidateOperation();
                double secondNumber = ParseNumber();

                double result = Calculate(firstNumber, operation, secondNumber);
                Console.WriteLine(result);
            }
        }

        private double Calculate(double firstNumber, string operation, double secondNumber)
        {
            double result = operation switch
            {
                "+" => firstNumber + secondNumber,
                "-" => firstNumber - secondNumber,
                "*" => firstNumber * secondNumber,
                "/" => firstNumber / secondNumber,
                "^" => Math.Pow(firstNumber, secondNumber),
                "#" => Math.Sqrt(firstNumber)
            };

            Console.WriteLine($"Natija: {firstNumber} {operation} {secondNumber} = {result}");
            return result;
        }

        private double ParseNumber()
        {
            bool parsingResult = false;
            double result = 0;
            while (!parsingResult)
            {
                Console.WriteLine("Son kiriting:");
                string firstNumberString = Console.ReadLine();
                parsingResult = double.TryParse(firstNumberString, out result);
            }
            return result;
        }

        private string ValidateOperation()
        {
            string operation = string.Empty;
            while (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != "^" && operation != "#")
            {
                Console.WriteLine("Amalni kiriting (+ - * / ^ #):");
                operation = Console.ReadLine();
            }
            return operation;
        }
    }
}
