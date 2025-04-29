using System;

namespace C_Sharp_OOPS
{

    public class Exception_Handlig
    {
        public static void Logical_ExceptionHandling()
        {
            Console.Write("Enter the Number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            if(num2 == 0)
            {
                Console.WriteLine("Number 2 can not be Zero");
            }
            else
            {
                Console.WriteLine("Result : "+num1/num2);
            }
        }

        public static void Try_Catch()
        {

            

            try
            {
                Console.Write("Enter the Number 1: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the Number 2: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch(Exception e)
            {
                Console.WriteLine("Some Error Occure");
                Console.WriteLine("Mesaage : " + e.Message);
                Console.WriteLine("Source : " + e.Source);
                Console.WriteLine("HelpLink : " +e.HelpLink);
                Console.WriteLine("StackTrace : "+e.StackTrace);
            }
        }
        static void Main(string[] args)
        {
            //Logical_ExceptionHandling();
            Try_Catch();
            Console.ReadKey();
        }
    }
}