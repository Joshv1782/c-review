using System;

namespace C__Review
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assigned an int!
            int x = 25;
            Console.WriteLine("Hello World!"+x);

            if ( x < 30 ) {
            Console.WriteLine( "X is less than thrity!" );
            } else if ( x == 30 ) {
                Console.WriteLine( "x is thirty!" );
            } else { 
                Console.WriteLine( "x is greater than thirty" );
            }

             int a = 2;
             switch ( a ) {
                case 1 :
                    Console.WriteLine( "Value is 1!" );
                    break;
                case 2 :
                    Console.WriteLine ( "Value is 2!" );
                    break;
                case 3 :
                    Console.WriteLine( "Value is 3!" );
                    break;
                // Pay attention to opening and closing with curly brackets
                default:
                    Console.WriteLine( "uh oh, it is another value" );
                    break;
                // git add -A and git commit -m "..." cycle. Repeat OFTEN 

            }
        }
    }
}