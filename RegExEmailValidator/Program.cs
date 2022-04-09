// See https://aka.ms/new-console-template for more information
using System;
namespace RegExEmailValidator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Patterns patterns = new Patterns();
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            if(patterns.firstNameValidator(firstName) == true)
            {
                Console.WriteLine("First Name is valid");
            }
            else
            {
                Console.WriteLine("First Name Not is valid");
            }
        }
    }
}