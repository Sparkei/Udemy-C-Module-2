using System;

namespace FunctionWithAnonymousAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string> ConvertToUppercase = uppercasestring;
            string username ="MaRk OReIlLy";

            Console.WriteLine("Using class directly" +uppercasestring(username)) ;
            Console.WriteLine("Using function " + ConvertToUppercase(username));

            Func<string, string> anonomusMethod = delegate (string myname) { return myname.ToUpper(); };
            Console.WriteLine("Using anonom method " + anonomusMethod(username));

            Func<string, string> lambaExpression = text => text.ToUpper();
            Console.WriteLine("Using lambda method " + lambaExpression(username));
        }

        private static string uppercasestring(string inputstring)        {
            return inputstring.ToUpper();
        }
    }
}
