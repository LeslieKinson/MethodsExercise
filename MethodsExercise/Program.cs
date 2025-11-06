namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            string name = Console.ReadLine();
            
            Console.WriteLine($"hello {name}");
            
            Console.WriteLine("Whatis your favorite color?");
            string color = Console.ReadLine();
            
            Console.WriteLine($"{color} is a fabulous choice!");
            
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            
            Console.WriteLine($"{animal} is super cool!");
            
            Console.WriteLine("what is your favorite band?");
            string band = Console.ReadLine();
            
            Console.WriteLine($"Your name is {name}, your favorite color is {color}, your favorite animal is {animal}, and your favorite band is {band}. I like your choices! Let's be friends? ");

            //math section
            
            Console.WriteLine("Lets do some math!");
            
            Console.WriteLine("enter your favotire number:");
            int a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("enter the second favorite number:");
            int b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("enter the number you hate the most:");
            int c = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"now we are going to do some calculations with {a} and {b}");
            
            int difference = Subtract(a, b);
            Console.WriteLine($"The difference of a and b is {difference}");
            
            int product = Multiply(a, b);
            Console.WriteLine($"The product of a and b is {product}");
            
            double quotient = Divide(a, b);
            Console.WriteLine($"The quotient of a and b is {quotient}");
            Console.WriteLine($"Don't you love math with {a} and {b}?");
            
            Console.WriteLine($"Now we are going to add {a} plus {b} plus {c}");
            
            int sum2 = Add(a, b, c);
            Console.WriteLine($"The sum of a and b and c is {sum2}");
        }

        public static int Add(int a, int b, int c)
        {
           return a + b + c;
           
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide (double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("You're silly! Don't you know  you cannot divide by zero");
            }
            return a / b;
        }


    }
}
