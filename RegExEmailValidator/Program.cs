// See https://aka.ms/new-console-template for more information
using System;
namespace RegExEmailValidator
{
    public class Program
    {
        static void Main(string[] args)
        {
            int ch = 0, caseVal=0;
            Patterns patterns = new Patterns();
            do
            {
                Console.Write("======= VALIDATION MENU =======");
                Console.Write("\n   1.First Name \n   2.Last Name \n   3.Email Validation");
                Console.Write("\nEnter your Choice: ");
                caseVal = Convert.ToInt32(Console.ReadLine());
                switch (caseVal)
                {
                    case 1:
                        Console.Write("Enter  First Name: ");
                        string firstName = Console.ReadLine();
                        if (patterns.firstNameValidator(firstName) == true)
                        {
                            Console.WriteLine("First Name is valid");
                        }
                        else
                        {
                            Console.WriteLine("First Name is Not valid");
                        }
                    break;
                    case 2:
                        Console.Write("Enter  Last Name: ");
                        string lastName = Console.ReadLine();
                        if (patterns.firstNameValidator(lastName) == true)
                        {
                            Console.WriteLine("Last Name is valid");
                        }
                        else
                        {
                            Console.WriteLine("Last Name is Not valid");
                        }
                    break;
                    case 3:
                        Console.Write("Enter email: ");
                        string email = Console.ReadLine();
                        if (patterns.emailValidator(email) == true)
                        {
                            Console.WriteLine("Email is valid");
                        }
                        else
                        {
                            Console.WriteLine("Email is Not valid");
                        }
                    break;

                    default:
                        Console.WriteLine("Enter Number in Given Range");
                    break;
                }
                Console.WriteLine("Do you want to Continue ? \n Press 1 for YES \n Press 2 for NO");
                ch = Convert.ToInt32(Console.ReadLine());
            } while (ch != 2);

        }
    }
}