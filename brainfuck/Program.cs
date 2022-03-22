using System.Collections.Specialized;
using System.Net.Mime;

namespace brainfuck
{
    internal static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);  
            
            // Tests();

            while (true) Console.WriteLine(new Brainfuck(Console.ReadLine() ?? string.Empty).ResultList);
        }

        public static void Tests()
        {
            var brainfuck = new Brainfuck("+++[>++++[>+++[>+++++<-]<-]<-]++.>++.>++.>.");
            var brainfuck2 = new Brainfuck("+++++>+++<<+++<<<+++");
            var brainfuck3 = new Brainfuck("+++++[>+++<-]");
            
            Console.WriteLine();
            Console.WriteLine(brainfuck.ResultList);
            Console.WriteLine(brainfuck2.ResultList);
            Console.WriteLine(brainfuck3.ResultList);
        }
    }
}