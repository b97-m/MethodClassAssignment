using System;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathOperation operation = new MathOperation();

            // Call the method by passing in two numbers 
            operation.PerformOperation(5, 10);

            // Call the method by specifying the parameters by name
            operation.PerformOperation(firstNumber: 8, secondNumber: 20);
        }
    }
}
