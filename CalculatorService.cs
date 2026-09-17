using System;

namespace CalculatorApp
{
    internal class CalculatorService
    {
        public double Calculate(double firstNumber, double secondNumber, string operation)
        {
            switch (operation)
            {
                case "+": return firstNumber + secondNumber;
                case "-": return firstNumber - secondNumber;
                case "*": return firstNumber * secondNumber;
                case "/":
                    if (secondNumber == 0) throw new DivideByZeroException("Bagi nol!");
                    return firstNumber / secondNumber;
                case "mod": return firstNumber % secondNumber;
                case "y^x": return Math.Pow(firstNumber, secondNumber);
                case "y√x": return Math.Pow(firstNumber, 1.0 / secondNumber);
                case "log_y x": return Math.Log(firstNumber, secondNumber);
                default: return secondNumber;
            }
        }

        public string FormatHistory(double num1, string op, double num2, double result)
        {
            return $"{num1} {op} {num2} = {result}";
        }

        public double GetPi() => Math.PI;
        public double GetE() => Math.E;

        public double CalculateFactorial(int n)
        {
            if (n < 0) throw new Exception("Angka harus positif!");
            double fact = 1;
            for (int i = 1; i <= n; i++) fact *= i;
            return fact;
        }

        public string Backspace(string currentText)
        {
            if (string.IsNullOrEmpty(currentText) || currentText == "0") return "0";
            string updated = currentText.Substring(0, currentText.Length - 1);
            return string.IsNullOrEmpty(updated) ? "0" : updated;
        }
    }
}