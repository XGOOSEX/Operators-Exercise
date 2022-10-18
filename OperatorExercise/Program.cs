namespace OperatorExercise
{
    internal class Program
    {
        
        static void Main()
        {
            
            //int a = 17;

            //int b = 4;
            
            //int quotient = a / b ;

            //int remainder = a % b;

            //int product = a * b;

            //int sum = a + b;

            //Console.WriteLine($"17/4 is {quotient} remainder {remainder}");

            
            Console.WriteLine("What is the radius of the circle?");
            var radius = double.Parse(Console.ReadLine());

            var circle = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of the circle is {circle}");

        }
    }
}