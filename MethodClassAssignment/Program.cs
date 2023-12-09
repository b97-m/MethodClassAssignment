using System;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate MathOperation1 clss
            MathOperation1 mathOp = new MathOperation1();

            //Ask the user to provide the first number
            Console.WriteLine("Please enter an integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //Ask the user to provide a second number or press enter
            Console.WriteLine("Please enter a second integer, or press enter: ");
            try
            {
                //Call a method with 2 parameters if both parameters are provided
                int num2 = Convert.ToInt32(Console.ReadLine());
                int results = mathOp.MathOperation(num1, num2);
                Console.WriteLine(num1 + " x " + num2 + " = " + results);
            }
            catch
            {
                //Call a method with one parameter if only one is provied by the user
                int results = mathOp.MathOperation(num1);
                Console.WriteLine(num1 + " x Default 1 = " + results);
            }
            Console.ReadLine();           
         
        }
    }
}