// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace CompoundInterest.User
{
    public class CompoundInterest
    {
        public static void Main(String[] args)
        {
            float principal = 20000; 
            double rate = 5.0;
            short time = 3; 

            Console.WriteLine("Compound Interest Calculator");

         
            Console.WriteLine($"Principal amount: {principal}");
            Console.WriteLine($"Annual interest rate: {rate}%");
            Console.WriteLine($"Time (in years): {time}");

           
            double amount = CalculateCompoundInterest(principal, rate, time);

          
            Console.WriteLine($"\nAmount after {time} years: {amount}");

            Console.WriteLine("\nThank you for using the Compound Interest Calculator!");
        }

     
        static double CalculateCompoundInterest(float principal, double rate, short time)
        {
            double amount = principal * Math.Pow((1 + rate / 100), time);
            return amount;
        }
    }
    }




