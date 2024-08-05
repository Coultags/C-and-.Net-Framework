using System;


namespace MethodClassAssignment
{
    public class MathOperations
    {
        public void PerformOperation(int num1, int num2)
        {

            //Performing a math operation involving addition
            int result = num1 + 20;


            //Display results.
            Console.WriteLine($"The result of the operation is: {result}");
            Console.WriteLine($"The second number is: {num2}");
        }
    }
}