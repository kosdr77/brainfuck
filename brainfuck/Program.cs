namespace brainfuck
{
    internal static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);  
            
            // TESTS
            
            var brainfuck = new Brainfuck("+++[>++++[>+++[>+++++<-]<-]<-]++.>++.>++.>.");
            var brainfuck2 = new Brainfuck("+++++>+++<<+++<<<+++");
            var brainfuck3 = new Brainfuck("+++++[>+++<-]");
            
            Console.WriteLine();
            Console.WriteLine(brainfuck.ResultList);
            Console.WriteLine(brainfuck2.ResultList);
            Console.WriteLine(brainfuck3.ResultList);

            Console.ReadKey();
        }
    }
}