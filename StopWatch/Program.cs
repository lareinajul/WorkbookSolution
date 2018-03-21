using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    //Fields
    private static string _stopWatch;
    private static string _command;

    //Properties
    /*Nothing here as we don't want to share data with any other classes. Also, this is the class with the static void Main() Method and only the compiler instantiates/creates an object from this class. */

    //Constructor
    static Program()
    {
        ///  _stopWatch = new StopWatch();
    }

    //Methods
    public static void Main()
    {
        bool started = false;
        bool stopped = false;
        bool reset = false;

        Console.Clear();
        Console.WriteLine("StopWatch v1.0");

        while (_command != "exit")
        {
            //anything in here we're going to do until the user types exit
            Console.WriteLine("Please type in start, stop, or exit");
            Console.ReadLine().ToLower();

            if (_command == "start")
            {
                //we're going to start the stop watch.
                Console.WriteLine("The stopwatch has started");
            }


            if (_command == "stop")
            {
                if (stopwatch is stop)

                {
                    Console.WriteLine("Stopwatch hasn't started yet, PLEASE type start.");
                    //tell user that the watch hasn't started and they should type start.

                }
                else if (the stopwatch has started)

               {

                    //then stop the watch and output time.
                }

            }


        }





    }
}
