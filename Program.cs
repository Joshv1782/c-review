using System;

namespace C__Review
{
    class Program
    {
        static void Main(string[] args)
        {

            // For methos to execute we must call it by name.
            // MyMethod();

            int[] myarray = new int [5] { 3, 4, 5, 6, 7 };
            myarray[0] = 2; // Update value by index.  //ARRAYS START AT ZERO!
            Console.WriteLine( myarray[0] ); // Output a value by index
            
            //  Lets try for a loop!
            for ( int i = 0; i < 5; i++ ) {
                Console.WriteLine( "Array Index:"+i+" | Array Value:"+myarray [i] );
        }

        int n = 0;
        while ( n < 5 ) {
            Console.WriteLine( "Array Index:"+n+" | Array Value:"+myarray[n] );
            //  n = n +2;
            n += 2; // Don't forget to iterate or this might be endless!
        }

        // Let's try a forereach! // They stop themselves at the end of the collection.
        foreach ( int e in myarray ) {
            Console.WriteLine( "Current Foreach Value is:"+e );
        }

        Console.WriteLine( "please enter your name:");
        string myname = Console.ReadLine(); // Store their input, or it will be lost forever!
        Console.WriteLine( "Thank you, "+myname+"!" );

        static void MyMethod()
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
}