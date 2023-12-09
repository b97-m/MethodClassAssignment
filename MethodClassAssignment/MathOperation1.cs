using System;

namespace MethodClassAssignment
{
    class MathOperation1
    {
        //A method that takes 2 integers as parameters
        //One of them is optional by providing a default value
        public int MathOperation(int i, int j = 1)
        {
            //Multiplication on integers and the result
            int result = i * j;
            return result;
        }
    }
}