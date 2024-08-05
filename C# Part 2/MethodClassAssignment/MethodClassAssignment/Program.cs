using System;


namespace MethodClassAssignment
{
    class Program
    {
        static void Main()
        {
            // craeting an instance of MathOperations
            MathOperations mathOps = new MathOperations();


            // Calls PerformOperation method with parameters
            mathOps.PerformOperation(15, 99);

            //Calls PerformOperation method with named parameters.
            mathOps.PerformOperation(num1: 45, num2: 30);

            //Keeps the console open to review the output
            Console.WriteLine("Press any key to exit....");
            Console.ReadKey();
        }
    }
}
