using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_screencast_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ConsoleApp");
            Console.WriteLine("Enter password");
            var password=Console.ReadLine();
            if (password=="123456")
            {
                Console.WriteLine("password accepted");

            }
            Console.ReadLine();
        }
    }
}
