// See https://aka.ms/new-console-template for more information
using System;
namespace RegExEmailValidator
{
    public class Program
    {
        static void Main(string[] args)
        {
            int ch = 0, caseVal = 0;
            Patterns patterns = new Patterns();
            do
            {
                Console.Write("======= VALIDATION MENU =======");
                Console.Write("\n   1.First Name \n   2.Last Name \n   3.Email Validation \n   4.MobileNumber Validator\n");
                Console.Write("   5.Password Validator");
                Console.Write("\nEnter your Choice: ");
                caseVal = Convert.ToInt32(Console.ReadLine());
                switch (caseVal)
                {
                    case 1:
                        Console.Write("Enter  First Name: ");
                        string firstName = Console.ReadLine();
                        if (patterns.firstNameValidator(firstName) == true)     //checking whether entered string is in correct format
                        {
                            Console.WriteLine("First Name is valid");       //if string is valid then this bolck will be executed
                        }
                        else
                        {
                            Console.WriteLine("First Name is Not valid");   //if string is invalid then this bolck will be executed
                        }
                        break;
                    case 2:
                        Console.Write("Enter  Last Name: ");
                        string lastName = Console.ReadLine();
                        if (patterns.firstNameValidator(lastName) == true)      //checking whether entered string is in correct format
                        {
                            Console.WriteLine("Last Name is valid");       //if string is valid then this bolck will be executed
                        }
                        else
                        {
                            Console.WriteLine("Last Name is Not valid");   //if string is invalid then this bolck will be executed
                        }
                        break;
                    case 3:
                        Console.Write("Enter email: ");
                        string email = Console.ReadLine();
                        if (patterns.emailValidator(email) == true)      //checking whether entered email is in correct format
                        {
                            Console.WriteLine("Email is valid");        //if email is valid then this bolck will be executed
                        }
                        else
                        {
                            Console.WriteLine("Email is Not valid");    //if email is invalid then this bolck will be executed
                        }
                        break;
                    case 4:
                        Console.Write("Enter Mobile Number: ");
                        string mobNumber = Console.ReadLine();
                        if (patterns.mobileNumberValidator(mobNumber) == true)      //checking whether entered number is in correct format
                        {
                            Console.WriteLine("Mobile Number is valid");       //if number is valid then this bolck will be executed
                        }
                        else
                        {
                            Console.WriteLine("Mobile Number is Not valid");    //if number is invalid then this bolck will be executed
                        }
                        break;
                        case 5:
                        Console.Write("Enter Password: ");
                        string pass = Console.ReadLine();
                        if (patterns.paswordValidator(pass) == true)      //checking whether entered password is in correct format
                        {
                            Console.WriteLine("Password is valid");       //if password is valid then this bolck will be executed
                        }
                        else
                        {
                            Console.WriteLine("Password is Not valid");    //if password is invalid then this bolck will be executed
                        }
                        break;

                    default:
                        Console.WriteLine("Enter Number in Given Range");       // if wrong choice is given then this block will be executed
                        break;
                }
                Console.WriteLine("Do you want to Continue ? \n Press 1 for YES \n Press 2 for NO");
                ch = Convert.ToInt32(Console.ReadLine());
            } while (ch != 2);

        }
    }
}