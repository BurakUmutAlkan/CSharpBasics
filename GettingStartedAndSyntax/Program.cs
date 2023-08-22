using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedAndSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * What is C# ?
             * -------------------------------------------------------------------------------------------
             * 
             * C# is a programming language used in development of software production.
             * With C#, the following types of software can be developed:
             * 
             * 1. Mobile Applications
             * 2. Desktop Applications
             * 3. Web Applications
             * 4. Web Services
             * 5. Web Sites
             * 6. Games
             * 7. VR
             * 8. Database Applications
             */

            /*
             * First Lines of Coding
             * -------------------------------------------------------------------------------------------
             * 
             * No matter what is the programming language you are learning, every beginner has to write
             * their first few lines of code and it is usually starts with making a program that prints
             * out the sentence "Hello World!". Before printing out a sentence, you need to know a line of
             * command that prints out first.
             * 
             * Console.WriteLine()
             * -------------------------------------------------------------------------------------------
             * 
             * Console.WriteLine() command is a command that targets the console itself and prints out 
             * the text written inside the paranthezes surrounded by "". But even if you execute this code
             * by itself, you will not be able to see the output, since the application is designed to
             * close after executing the code. So you need to make the program standby somehow. 
             * That's where Console.ReadKey() comes in.
             * 
             * Console.ReadKey()
             * -------------------------------------------------------------------------------------------
             * 
             * Console.ReadKey() is a command that tells the console to wait for a key input from user to
             * proceed to the next line of code.
             */

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
