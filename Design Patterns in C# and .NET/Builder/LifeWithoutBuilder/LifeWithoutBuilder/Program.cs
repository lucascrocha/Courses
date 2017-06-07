using System;
using System.Text;

namespace LifeWithoutBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var hello = "hello";
            var sb = new StringBuilder();
            sb.Append(hello);
            Console.WriteLine(sb);

            var words = new[] { "hello", "world"};
            sb.Clear();
            foreach (var word in words)
            {
                sb.Append(word);
            }

            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}