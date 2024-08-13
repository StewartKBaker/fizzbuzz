namespace fizzbuzzwhiteboard;

class Program
{
    static void Main(string[] args)
    {
        static string FizzBuzz(int x)
        {
            var fizzbuzz = "";
            if (x % 3 == 0)
            {
                fizzbuzz += "fizz";
            }

            if (x % 5 == 0)
            {
                fizzbuzz += "buzz";
            }

            return fizzbuzz;
        }
        
        Console.WriteLine(1);
        Console.WriteLine(FizzBuzz(3));
        Console.WriteLine(FizzBuzz(5));
        Console.WriteLine(FizzBuzz(15));
    }
}