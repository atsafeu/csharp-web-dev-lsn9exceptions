using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            // Write your code here!
            if (y == 0.0)
            {
                throw new ArgumentOutOfRangeException("y", "You cannot divide by zero!");
            }
            else
            {
                return x / y;
            }
        }

        static int CheckFileExtension(string fileName)
        {
            // Write your code here!
            if (fileName == null || fileName == "")
            {
                throw new ArgumentNullException("fileName", "Student did not submit any work!");
            }
            else
            {
                if (fileName.Substring(fileName.Length - 3, 3) == ".cs")
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            double x = 12.3;
            double y = 0.0;

            try
            {
                Divide(x, y);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair<string, string> student in students)
            {
                try
                {
                    Console.WriteLine(student.Key);
                    CheckFileExtension(student.Value);
                }
                catch (ArgumentNullException n)
                {
                    Console.WriteLine(n.Message);
                }
            }
        }
    }
}
