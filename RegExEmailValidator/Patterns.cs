using System;
using System.Text.RegularExpressions;

namespace RegExEmailValidator
{
    public class Patterns
    {
        public static string name_validator = "^[A-Z][a-z]{2,}$";   // pattern of string to validate first name
        public static string email_Validator ="^[0-9a-zA-Z]+[./+_-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9-]+[.][a-zA-Z]{2,}([.][a-zA-Z]{2,}){0,1}$"; // pattern for email validation
        public bool firstNameValidator(string firstName)    // method for validating name
        {
            return Regex.IsMatch(firstName,name_validator);     // true or false value will be returned 
        }

        public bool lastNameValidator(string lastName)    // method for validating last name
        {
            return Regex.IsMatch(lastName,name_validator);     // true or false value will be returned 
        }

        public bool emailValidator(string email)    // method for validating email
        {
            return Regex.IsMatch(email,email_Validator);     // true or false value will be returned 
        }       
    }
}