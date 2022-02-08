using System; 

namespace MyNewApp
{
    class Program_CodeBlocks
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn"; 
            string reversedValue = Reverse(value);
            Console.WriteLine($"Secret message {reversedValue}");
        }

        static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters); 
        }
    }
}